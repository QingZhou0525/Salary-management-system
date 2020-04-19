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
    public partial class 工资计算 : Form
    {
        public 工资计算()
        {
            InitializeComponent();
        }

        private void 工资计算_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“gongziDataSet21.员工信息表”中。您可以根据需要移动或删除它。
            this.员工信息表TableAdapter.Fill(this.gongziDataSet21.员工信息表);
            // TODO: 这行代码将数据加载到表“gongziDataSet20.工资表”中。您可以根据需要移动或删除它。
            this.工资表TableAdapter.Fill(this.gongziDataSet20.工资表);
            label24.Text = DateTime.Now.ToString("yyyy") + "年" + DateTime.Now.ToString("MM") + "月";
            comboBox1.SelectedIndex = -1;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(string.Empty))
                            {
                                MessageBox.Show("请选择员工编号！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            else
                            {
                                if (textBox1.Text.Equals(string.Empty))
                                    MessageBox.Show("请输入迟到次数！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                else
                                {
                                    if (textBox1.Text.Equals(string.Empty))
                                    {
                                        MessageBox.Show("请输入请假旷工次数！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                    else
                                    {
                                        if (textBox1.Text.Equals(string.Empty))
                                        {
                                            MessageBox.Show("请输入加班小时！", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                        }
                                        else
                                        {
            int cdcs;
            int qjkgcs;
            double jbxs = Convert.ToDouble(textBox3.Text);
            string s = textBox3.Text.ToString();
            bool bb;
            string[] sArray = s.Split('.');
            bb = s.Contains(".");
            if (int.TryParse(textBox1.Text, out cdcs) && int.TryParse(textBox2.Text, out qjkgcs))
            {

                if (cdcs < 0 || qjkgcs < 0 || jbxs < 0)
                    MessageBox.Show("迟到次数、请假旷工次数和请假时间应为大于0！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                {

                    if (cdcs + qjkgcs > 30)
                        MessageBox.Show("迟到次数和请假旷工次数之和应小于30！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    else
                    {
                        if (!(!bb || Convert.ToInt32(sArray[1]) == 5 || Convert.ToInt32(sArray[1]) == 0))
                            MessageBox.Show("请输入正确的加班小时！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        else
                        {

                            if (comboBox1.Text.Equals(string.Empty))
                            {
                                MessageBox.Show("请选择员工编号！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                            else
                            {
                                if (textBox1.Text.Equals(string.Empty))
                                    MessageBox.Show("请输入迟到次数！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                else
                                {
                                    if (textBox1.Text.Equals(string.Empty))
                                    {
                                        MessageBox.Show("请输入请假旷工次数！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    }
                                    else
                                    {
                                        if (textBox1.Text.Equals(string.Empty))
                                        {
                                            MessageBox.Show("请输入加班小时！", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                        }
                                        else
                                        {


                                            string id = comboBox1.Text.ToString();


                                            label3.Text = (cdcs * 25).ToString() + "元";
                                            label6.Text = (qjkgcs * 50).ToString() + "元";
                                            label9.Text = (jbxs * 10).ToString() + "元";
                                            double yjbgz = 0;
                                            string pos = "";
                                            string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                            SqlConnection conn = new SqlConnection(connString);
                                            string sqlstr = string.Format("select * from 员工信息表 where 员工编号='{0}' ", id);
                                            SqlCommand cmd = new SqlCommand(sqlstr, conn);
                                            conn.Open();
                                            SqlDataReader dr = cmd.ExecuteReader();
                                            while (dr.Read())
                                            {
                                                pos = dr.GetString(8);
                                                string CONNString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                                SqlConnection CONN = new SqlConnection(CONNString);
                                                string SQL = string.Format("select * from 标准工资表 where 职位='{0}' ", pos);
                                                SqlCommand CMD = new SqlCommand(SQL, CONN);
                                                CONN.Open();
                                                SqlDataReader DR = CMD.ExecuteReader();
                                                while (DR.Read())
                                                {
                                                    yjbgz = DR.GetDouble(1);
                                                    label12.Text = DR.GetDouble(1).ToString();
                                                }
                                            }
                                            label22.Text = ((jbxs * 10) - (cdcs * 25) - (qjkgcs * 50)).ToString() + "元";
                                            label14.Text = (yjbgz + (jbxs * 10) - (cdcs * 25) - (qjkgcs * 50)).ToString() + "元";
                                            //添加到考勤表
                                            string COnnString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                            SqlConnection COnn = new SqlConnection(COnnString);
                                            COnn.Open();
                                            SqlCommand scmd;
                                            string time = DateTime.Now.ToString("yyyyMM");
                                            string name = label17.Text.ToString();
                                            int cdfj = cdcs * 25;
                                            int qjkgfj = qjkgcs * 50;
                                            double jbjj = jbxs * 10;
                                            double zj = jbjj - cdfj - qjkgfj;
                                            double zjgz = yjbgz + zj;
                                            try
                                            {
                                                string sql = string.Format("insert into 考勤表 values('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8},{9})", time, id, name, cdcs, cdfj, qjkgcs, qjkgfj, jbxs, jbjj, zj);
                                                scmd = new SqlCommand(sql, COnn);
                                                scmd.ExecuteNonQuery();

                                           }
                                            catch (Exception ex)
                                            {
                                                //MessageBox.Show("请输入正确的迟到次数、请假旷工次数！");
                                            }
                                            //添加到工资表
                                            string ConnString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                                            SqlConnection Conn = new SqlConnection(ConnString);
                                            Conn.Open();
                                            SqlCommand Scmd;
                                            try
                                            {
                                                string Sql = string.Format("insert into 工资表 values('{0}','{1}','{2}',{3},{4},{5},'{6}')", time, id, name, yjbgz, zj, zjgz, pos);
                                                Scmd = new SqlCommand(Sql, Conn);
                                                Scmd.ExecuteNonQuery();
                                            }
                                            catch (Exception ex)
                                            {
                                                //MessageBox.Show(ex.ToString());

                                                label3.Text = null;
                                                label6.Text = null;
                                                label9.Text = null;
                                                label12.Text = null;
                                                label22.Text = null;
                                                label14.Text = null;
                                                MessageBox.Show("该员工本月工资已计算，请勿重复输入！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入正确格式的迟到次数、请假旷工次数！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
                                        }
                                    }
                                }
                            }
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = comboBox1.Text.ToString();
            string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection conn = new SqlConnection(connString);
            string sqlstr = string.Format("select * from 员工信息表 where 员工编号='{0}' ", id);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label17.Text = dr.GetString(0).ToString();
            }
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

        }
    }
}
