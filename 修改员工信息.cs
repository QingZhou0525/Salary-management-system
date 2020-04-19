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
    public partial class 修改员工信息 : Form
    {
        public 修改员工信息()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“gongziDataSet17.员工信息表”中。您可以根据需要移动或删除它。
            this.员工信息表TableAdapter3.Fill(this.gongziDataSet17.员工信息表);
            // TODO: 这行代码将数据加载到表“gongziDataSet15.员工信息表”中。您可以根据需要移动或删除它。
            this.员工信息表TableAdapter2.Fill(this.gongziDataSet15.员工信息表);
            // TODO: 这行代码将数据加载到表“gongziDataSet14.员工信息表”中。您可以根据需要移动或删除它。
            this.员工信息表TableAdapter1.Fill(this.gongziDataSet14.员工信息表);
            // TODO: 这行代码将数据加载到表“gongziDataSet7.员工信息表”中。您可以根据需要移动或删除它。
            this.员工信息表TableAdapter.Fill(this.gongziDataSet7.员工信息表);

        }
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("gongzi");

        private void ShowImformation()
        {
            string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            string sql = "select 员工姓名 as 员工姓名,出生日期 as 出生日期,员工编号 as 员工编号,身份证号 as 身份证号,电话 as 电话,性别 as 性别,家庭地址 as 家庭地址,部门 as 部门,职位 as 职位,入职时间 as 入职时间 from 员工信息表";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            da.SelectCommand = comm;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(ds, "员工信息表");
            this.dgvYuangong.DataSource = ds.Tables["员工信息表"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection("server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false");
            scon.Open();
            SqlCommand scmd;

            try
            {
                for (int i = 0; i < dgvYuangong.Rows.Count; i++)
                {
                    string id = dgvYuangong.Rows[i].Cells["员工编号DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string name = dgvYuangong.Rows[i].Cells["员工姓名DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string sfzh = dgvYuangong.Rows[i].Cells["身份证号DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string tel = dgvYuangong.Rows[i].Cells["电话DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string gender = dgvYuangong.Rows[i].Cells["性别DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string address = dgvYuangong.Rows[i].Cells["家庭地址DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string department = dgvYuangong.Rows[i].Cells["部门DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string position = dgvYuangong.Rows[i].Cells["职位DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    string scmdStr = "update 员工信息表 set 员工姓名='" + name + "',身份证号='" + sfzh + "',电话='" + tel + "',性别='" + gender + "', 家庭地址 ='" + address + "',部门 ='" + department + "',职位='" + position + "' where 员工编号='" + id + "'";
                    scmd = new SqlCommand(scmdStr, scon);
                    scmd.ExecuteNonQuery();

                }
                MessageBox.Show("修改成功！", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                scon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否取消修改？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void dgvYuangong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgvYuangong.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    if (MessageBox.Show("是否删除此员工信息？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string id = dgvYuangong.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                        SqlConnection conn = new SqlConnection(connString);
                        conn.Open();
                        //从员工信息表中删除
                        string sql = String.Format("delete from 员工信息表 where 员工编号='{0}'", id);
                        SqlCommand comm = new SqlCommand(sql, conn);
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        //从考勤表中删除
                        string ConnString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                        SqlConnection Conn = new SqlConnection(ConnString);
                        string SQL = String.Format("delete from 考勤表 where 员工编号='{0}'", id);
                        SqlCommand COMM = new SqlCommand(SQL, Conn);
                        SqlDataAdapter DA = new SqlDataAdapter(SQL, Conn);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);
                        //从工资表中删除
                        string COnnString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                        SqlConnection COnn = new SqlConnection(COnnString);
                        string SQl = String.Format("delete from 考勤表 where 员工编号='{0}'", id);
                        SqlCommand COmm = new SqlCommand(SQl, COnn);
                        SqlDataAdapter Da = new SqlDataAdapter(SQl, COnn);
                        DataSet Ds = new DataSet();
                        Da.Fill(Ds);
                        //更新dgvYuangong表
                        string Sql = "select 员工姓名 as 员工姓名,出生日期 as 出生日期,员工编号 as 员工编号,身份证号 as 身份证号,电话 as 电话,性别 as 性别,家庭地址 as 家庭地址,部门 as 部门,职位 as 职位 from 员工信息表";
                        SqlCommand Comm = new SqlCommand(Sql, conn);
                        da.SelectCommand = Comm;
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        da.Fill(ds, "员工信息表");
                        this.dgvYuangong.DataSource = ds.Tables["员工信息表"];

                    }                   
                }
            }
        }

        private void 员工信息表BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}