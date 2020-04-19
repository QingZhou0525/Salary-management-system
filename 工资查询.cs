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
    public partial class 工资查询 : Form
    {
        public 工资查询()
        {
            InitializeComponent();
        }

        private void 本月工资管理_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“gongziDataSet24.工资表”中。您可以根据需要移动或删除它。
            this.工资表TableAdapter1.Fill(this.gongziDataSet24.工资表);
            // TODO: 这行代码将数据加载到表“gongziDataSet13.员工信息表”中。您可以根据需要移动或删除它。
            this.员工信息表TableAdapter.Fill(this.gongziDataSet13.员工信息表);
            // TODO: 这行代码将数据加载到表“gongziDataSet12.工资表”中。您可以根据需要移动或删除它。
            this.工资表TableAdapter.Fill(this.gongziDataSet12.工资表);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString("yyyyMM");
            string id = comboBox1.Text.ToString();
            string connString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sqlstr = string.Format("select * from 工资表  where 员工编号='{0}' and 时间='{1}' ", id, time);
            SqlDataAdapter da=new SqlDataAdapter(sqlstr,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter.FillBy(this.gongziDataSet12.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 倒序ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter1.倒序(this.gongziDataSet24.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 降序ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter1.降序(this.gongziDataSet24.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 升序ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter1.升序(this.gongziDataSet24.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 升序排列ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter1.升序排列(this.gongziDataSet24.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 降序排列ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter1.降序排列(this.gongziDataSet24.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 时间升序排列ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter1.时间升序排列(this.gongziDataSet24.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 时间降序排列ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资表TableAdapter1.时间降序排列(this.gongziDataSet24.工资表);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
