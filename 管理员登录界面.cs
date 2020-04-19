using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 工资管理系统
{
    public partial class 管理员登录界面 : Form
    {
        public 管理员登录界面()
        {
            InitializeComponent();
        }

        private void 安全退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            登录界面 fm1 = new 登录界面();
            this.Hide();
            fm1.ShowDialog();
            Application.ExitThread();
        }

        private void 添加员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            添加员工信息 fm5 = new 添加员工信息();
            fm5.Show();
        }

        private void 修改员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改员工信息 fm6 = new 修改员工信息();
            fm6.MdiParent = this;
            fm6.Show();

        }


        private void 本月考勤情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            本月考勤 fm8 = new 本月考勤();
            fm8.MdiParent = this;
            fm8.Show();
        }

        private void 历史考勤情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            历史考勤 fm9 = new 历史考勤();
            fm9.MdiParent = this;
            fm9.Show();
        }

        private void 减少员工工资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            工资查询 fm10 = new 工资查询();
            fm10.MdiParent = this;
            fm10.Show();
        }

        private void 标准工资管理ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            标准工资管理 fm11 = new 标准工资管理();
            fm11.Show();
        }

        private void 工资计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            工资计算 fm12 = new 工资计算();
            fm12.MdiParent = this;
            fm12.Show();
        }

        private void 打印员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            打印员工信息预览 fm13 = new 打印员工信息预览();
            fm13.Show();
        }

        private void 打印工资条ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            打印工资条预览 fm14 = new 打印工资条预览();
            fm14.Show();
        }

        private void 员工信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
