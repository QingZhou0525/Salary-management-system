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
    public partial class 历史考勤 : Form
    {
        public 历史考勤()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(string.Empty))
                MessageBox.Show("请选择要查询的员工编号！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                string time = dateTimePicker1.Value.ToString("yyyyMM");
                string id = comboBox1.Text.ToString();
                string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                SqlConnection conn = new SqlConnection(connString);
                string sqlstr = string.Format("select * from 考勤表 where 员工编号='{0}' and 时间='{1}' ", id, time);
                SqlCommand cmd = new SqlCommand(sqlstr, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label11.Text = dr.GetString(2).ToString();
                    label12.Text = dr.GetInt32(3).ToString() + "次";
                    label13.Text = dr.GetInt32(5).ToString() + "次";
                    label14.Text = dr.GetDouble(7).ToString() + "小时";
                    label16.Text = dr.GetDouble(4).ToString() + "元";
                    label17.Text = dr.GetDouble(6).ToString() + "元";
                    label18.Text = dr.GetDouble(8).ToString() + "元";
                    label15.Text = dr.GetDouble(9).ToString() + "元";
                }
            }
        }

        private void 历史考勤_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“gongziDataSet22.员工信息表”中。您可以根据需要移动或删除它。
            this.员工信息表TableAdapter.Fill(this.gongziDataSet22.员工信息表);
            // TODO: 这行代码将数据加载到表“gongziDataSet19.考勤表”中。您可以根据需要移动或删除它。
            this.考勤表TableAdapter1.Fill(this.gongziDataSet19.考勤表);
            // TODO: 这行代码将数据加载到表“gongziDataSet18.考勤表”中。您可以根据需要移动或删除它。
            this.考勤表TableAdapter.Fill(this.gongziDataSet18.考勤表);
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Text = null;
            string time = dateTimePicker1.Value.ToString("yyyyMM");
            string id = comboBox1.Text.ToString();
            string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection conn = new SqlConnection(connString);
            string sqlstr = string.Format("select * from 考勤表 where 员工编号='{0}' and 时间='{1}' ", id, time);
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label11.Text = dr.GetString(2).ToString();
               
            }
            label12.Text = null;
            label13.Text = null;
            label14.Text = null;
            label16.Text = null;
            label17.Text = null;
            label18.Text = null;
            label15.Text = null;
        }

    }
}
