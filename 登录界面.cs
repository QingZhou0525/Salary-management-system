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
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "员工" && comboBox1.Text != "管理员")
            {
                MessageBox.Show("请选择员工类型！");
            }
            else
            {
                if (comboBox1.Text == "员工")
                {
                    bool success = false;
                    string name = txtID.Text;
                    string password = txtKEY.Text;
                    name = name.Trim();
                    password = password.Trim();

                    String connsql = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = connsql;
                            string sqlstr = string.Format("select 登录密码 from 员工登录表 where 员工编号 ='{0}'", name);
                            SqlCommand cmd = new SqlCommand(sqlstr, conn);
                            conn.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                {
                                    string psd = dr[0].ToString();
                                    if (password.Equals(psd.TrimEnd()))
                                    {
                                        success = true;
                                    }
                                }
                                if (success)
                                {
                                    Data.id = name;
                                    //用户登录界面 fm2 = new 用户登录界面();
                                    this.Hide();
                                    //fm2.ShowDialog();
                                    Application.ExitThread();
                                }
                                else
                                    MessageBox.Show("员工编号或密码错误，请重试！");
                            }
                            else
                            {
                                MessageBox.Show("员工类型选择错误，请重试！");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误信息：" + ex.Message, "出现错误");
                    }
                }
                else if (comboBox1.Text == "管理员")
                {
                    bool suc = false;
                    string Name = txtID.Text;
                    string Pwd = txtKEY.Text;
                    Name = Name.Trim();
                    Pwd = Pwd.Trim();

                    String connsql = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {
                            conn.ConnectionString = connsql;
                            string Sqlstr = string.Format("select 登录密码 from 管理员登录表 where 员工编号 ='{0}'", Name);
                            SqlCommand cmd = new SqlCommand(Sqlstr, conn);
                            conn.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                {
                                    string psd = dr[0].ToString();
                                    if (Pwd.Equals(psd.TrimEnd()))
                                    {
                                        suc = true;
                                    }
                                }
                                if (suc)
                                {
                                    管理员登录界面 fm3 = new 管理员登录界面();
                                    this.Hide();
                                    fm3.ShowDialog();
                                    Application.ExitThread();
                                }
                                else
                                    MessageBox.Show("员工编号或密码错误，请重试！！");
                            }
                            else
                            {
                                MessageBox.Show("员工类型选择错误，请重试！");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误信息：" + ex.Message, "出现错误");
                    }
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 登录界面_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}