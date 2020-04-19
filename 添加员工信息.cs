using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 工资管理系统
{
    public partial class 添加员工信息 : Form
    {
        public 添加员工信息()
        {
            InitializeComponent();
        }
        private void 添加员工信息_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; 
        }

        bool ischinese(string s)
        {
            bool i = true;
            foreach (char a in s)
            {
                if (a>127)
                {
                    i = false;
                }
            }
            return i;
        }
        
        bool isbianhao(string s)
        {
            bool i = true;
            foreach (char a in s)
            {
                if (a <= 127)
                {
                    i = false;
                }
            }
            return i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals(string.Empty))
                    MessageBox.Show("请输入员工姓名！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                {
                    if (textBox2.Text.Equals(string.Empty))
                        MessageBox.Show("请输入员工编号！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    else
                    {
                        if (textBox3.Text.Equals(string.Empty))
                            MessageBox.Show("请输入身份证号！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        else
                        {
                            if (textBox4.Text.Equals(string.Empty))
                                MessageBox.Show("请输入电话号码！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            else
                            {
                                if (textBox5.Text.Equals(string.Empty))
                                    MessageBox.Show("请输入家庭住址！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                else
                                {
                                    if (comboBox1.Text.Equals(string.Empty))
                                        MessageBox.Show("请选择部门！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    else
                                    {
                                        if (comboBox2.Text.Equals(string.Empty))
                                            MessageBox.Show("请选择职位！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                        else
                                        {
                                            if (ischinese(textBox1.Text))
                                                MessageBox.Show("请输入正确的姓名！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                            else
                                            {

                                                if (isbianhao(textBox2.Text))
                                                    MessageBox.Show("员工编号中不可包含中文！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                                else
                                                {
                                                    if (ischinese(textBox5.Text))
                                                        MessageBox.Show("请输入正确的家庭地址！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                                    else
                                                    {



                                                        string Name = textBox1.Text;
                                                        string ID = textBox2.Text;
                                                        string sfzh = textBox3.Text;
                                                        string birth = dateTimePicker1.Value.ToString("yyyyMMdd");
                                                        string tel = textBox4.Text;
                                                        string gender = string.Empty;
                                                        if (radioButton1.Checked)
                                                        {
                                                            gender = "男";
                                                        }
                                                        else
                                                        {
                                                            gender = "女";
                                                        }
                                                        string address = textBox5.Text;
                                                        string department = comboBox1.Text;
                                                        string position = comboBox2.Text;
                                                        string Time = DateTime.Now.ToString("yyyyMMdd");
                                                        //添加到员工信息表
                                                        string sql = String.Format("INSERT INTO 员工信息表(员工姓名,员工编号,出生日期,身份证号,电话,性别,家庭地址,部门,职位,入职时间)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", Name, ID, birth, sfzh, tel, gender, address, department, position, Time);
                                                        string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                        using (SqlConnection conn = new SqlConnection(connString))
                                                        {
                                                            conn.Open();
                                                            SqlCommand comm = new SqlCommand(sql, conn);
                                                            int count = comm.ExecuteNonQuery();
                                                            if (count > 0)
                                                            {
                                                                MessageBox.Show("添加员工信息成功", "添加成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("添加员工信息失败", "添加失败！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            }
                                                        }
                                                        ///添加到考勤表
                                                        string time = DateTime.Now.ToString("yyyyMM");
                                                        int cdcs = 0;
                                                        int cdfj = 0;
                                                        int qjkgcs = 0;
                                                        int qjkgfj = 0;
                                                        int jbxs = 0;
                                                        int jbjj = 0;
                                                        int zj = 0;
                                                        string Sql = String.Format("INSERT INTO 考勤表(时间,员工编号,员工姓名,迟到次数,迟到罚金,请假旷工次数,请假旷工罚金,加班小时,加班奖金,总计)VALUES('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8},{9})", time, ID, Name, cdcs, cdfj, qjkgcs, qjkgfj, jbxs, jbjj, zj);
                                                        string ConnString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                        using (SqlConnection Conn = new SqlConnection(ConnString))
                                                        {
                                                            Conn.Open();
                                                            SqlCommand Comm = new SqlCommand(Sql, Conn);
                                                            int Count = Comm.ExecuteNonQuery();
                                                        }
                                                        //添加到工资表
                                                        double yjjgz = 0;
                                                        if (comboBox2.Text == "员工")
                                                        {
                                                            string pos = comboBox2.Text.ToString();
                                                            string CONNString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                            SqlConnection CONN = new SqlConnection(CONNString);
                                                            string sqlstr = string.Format("select * from 标准工资表 where 职位='{0}'", pos);
                                                            SqlCommand cmd = new SqlCommand(sqlstr, CONN);
                                                            CONN.Open();
                                                            SqlDataReader dr = cmd.ExecuteReader();
                                                            while (dr.Read())
                                                            {
                                                                yjjgz = dr.GetDouble(1);
                                                            }
                                                        }
                                                        if (comboBox2.Text == "部门副经理")
                                                        {
                                                            string pos1 = comboBox2.Text.ToString();
                                                            string CONNString1 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                            SqlConnection CONN1 = new SqlConnection(CONNString1);
                                                            string sqlstr1 = string.Format("select * from 标准工资表 where 职位='{0}'", pos1);
                                                            SqlCommand cmd1 = new SqlCommand(sqlstr1, CONN1);
                                                            CONN1.Open();
                                                            SqlDataReader dr1 = cmd1.ExecuteReader();
                                                            while (dr1.Read())
                                                            {
                                                                yjjgz = dr1.GetDouble(1);
                                                            }
                                                        }
                                                        if (comboBox2.Text == "部门经理")
                                                        {
                                                            string pos2 = comboBox2.Text.ToString();
                                                            string CONNString2 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                            SqlConnection CONN2 = new SqlConnection(CONNString2);
                                                            string sqlstr2 = string.Format("select * from 标准工资表 where 职位='{0}'", pos2);
                                                            SqlCommand cmd2 = new SqlCommand(sqlstr2, CONN2);
                                                            CONN2.Open();
                                                            SqlDataReader dr2 = cmd2.ExecuteReader();
                                                            while (dr2.Read())
                                                            {
                                                                yjjgz = dr2.GetDouble(1);
                                                            }
                                                        }
                                                        if (comboBox2.Text == "副总经理")
                                                        {
                                                            string pos3 = comboBox2.Text.ToString();
                                                            string CONNString3 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                            SqlConnection CONN3 = new SqlConnection(CONNString3);
                                                            string sqlstr3 = string.Format("select * from 标准工资表 where 职位='{0}'", pos3);
                                                            SqlCommand cmd3 = new SqlCommand(sqlstr3, CONN3);
                                                            CONN3.Open();
                                                            SqlDataReader dr3 = cmd3.ExecuteReader();
                                                            while (dr3.Read())
                                                            {
                                                                yjjgz = dr3.GetDouble(1);
                                                            }
                                                        }
                                                        if (comboBox2.Text == "总经理")
                                                        {
                                                            string pos4 = comboBox2.Text.ToString();
                                                            string CONNString4 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                            SqlConnection CONN4 = new SqlConnection(CONNString4);
                                                            string sqlstr4 = string.Format("select * from 标准工资表 where 职位='{0}'", pos4);
                                                            SqlCommand cmd4 = new SqlCommand(sqlstr4, CONN4);
                                                            CONN4.Open();
                                                            SqlDataReader dr4 = cmd4.ExecuteReader();
                                                            while (dr4.Read())
                                                            {
                                                                yjjgz = dr4.GetDouble(1);
                                                            }
                                                        }
                                                        if (comboBox2.Text == "董事长")
                                                        {
                                                            string pos5 = comboBox2.Text.ToString();
                                                            string CONNString5 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                            SqlConnection CONN5 = new SqlConnection(CONNString5);
                                                            string sqlstr5 = string.Format("select * from 标准工资表 where 职位='{0}'", pos5);
                                                            SqlCommand cmd5 = new SqlCommand(sqlstr5, CONN5);
                                                            CONN5.Open();
                                                            SqlDataReader dr5 = cmd5.ExecuteReader();
                                                            while (dr5.Read())
                                                            {
                                                                yjjgz = dr5.GetDouble(1);
                                                            }
                                                        }
                                                        double ygzzj = yjjgz + zj;
                                                        string POS = comboBox2.Text.ToString();
                                                        string SQL = String.Format("INSERT INTO 工资表(时间,员工编号,员工姓名,月基本工资,月奖惩工资,月工资总结,职位)VALUES('{0}','{1}','{2}',{3},{4},{5},'{6}')", time, ID, Name, yjjgz, zj, ygzzj, POS);
                                                        string COnnString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                        using (SqlConnection COnn = new SqlConnection(COnnString))
                                                        {
                                                            COnn.Open();
                                                            SqlCommand COmm = new SqlCommand(SQL, COnn);
                                                            int COunt = COmm.ExecuteNonQuery();
                                                        }

                                                    }
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("此员工信息已存在，请重试！", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否取消添加？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
        }

    }
}
