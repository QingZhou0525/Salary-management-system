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
    public partial class 标准工资管理 : Form
    {
        public 标准工资管理()
        {
            InitializeComponent();
            

        }

        private void 标准工资管理_Load(object sender, EventArgs e)
        {
            string pos = "员工";
            string CONNString = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection CONN = new SqlConnection(CONNString);
            string sqlstr = string.Format("select * from 标准工资表 where 职位='{0}'", pos);
            SqlCommand cmd = new SqlCommand(sqlstr, CONN);
            CONN.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetDouble(1).ToString();
            }
            
            string pos1 = "部门副经理";
            string CONNString1 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection CONN1 = new SqlConnection(CONNString1);
            string sqlstr1 = string.Format("select * from 标准工资表 where 职位='{0}'", pos1);
            SqlCommand cmd1 = new SqlCommand(sqlstr1, CONN1);
            CONN1.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                textBox2.Text = dr1.GetDouble(1).ToString();
            }
            string pos2 = "部门经理";
            string CONNString2 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection CONN2 = new SqlConnection(CONNString2);
            string sqlstr2 = string.Format("select * from 标准工资表 where 职位='{0}'", pos2);
            SqlCommand cmd2 = new SqlCommand(sqlstr2, CONN2);
            CONN2.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                textBox3.Text = dr2.GetDouble(1).ToString();
            }
            string pos3 = "副总经理";
            string CONNString3 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection CONN3 = new SqlConnection(CONNString3);
            string sqlstr3 = string.Format("select * from 标准工资表 where 职位='{0}'", pos3);
            SqlCommand cmd3 = new SqlCommand(sqlstr3, CONN3);
            CONN3.Open();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                textBox4.Text = dr3.GetDouble(1).ToString();
            }
            string pos4 = "总经理";
            string CONNString4 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection CONN4 = new SqlConnection(CONNString4);
            string sqlstr4 = string.Format("select * from 标准工资表 where 职位='{0}'", pos4);
            SqlCommand cmd4 = new SqlCommand(sqlstr4, CONN4);
            CONN4.Open();
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                textBox5.Text = dr4.GetDouble(1).ToString();
            }
            string pos5 = "董事长";
            string CONNString5 = "server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false";
            SqlConnection CONN5 = new SqlConnection(CONNString5);
            string sqlstr5 = string.Format("select * from 标准工资表 where 职位='{0}'", pos5);
            SqlCommand cmd5 = new SqlCommand(sqlstr5, CONN5);
            CONN5.Open();
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                textBox6.Text = dr5.GetDouble(1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(string.Empty))
                MessageBox.Show("请输入员工标准工资！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                if (textBox2.Text.Equals(string.Empty))
                    MessageBox.Show("请输入部门副经理标准工资！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else
                {
                    if (textBox3.Text.Equals(string.Empty))
                        MessageBox.Show("请输入部门经理标准工资！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    else
                    {
                        if (textBox4.Text.Equals(string.Empty))
                            MessageBox.Show("请输入副总经理标准工资！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        else
                        {
                            if (textBox5.Text.Equals(string.Empty))
                                MessageBox.Show("请输入总经理标准工资！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            else
                            {
                                if (textBox6.Text.Equals(string.Empty))
                                    MessageBox.Show("请输入董事长标准工资！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                else
                                {


                                    SqlConnection scon = new SqlConnection("server=47.101.133.16;database=gongzi;uid='CaoXiaoYong';pwd='Cxy1998525';integrated security=false");
                                    scon.Open();
                                    SqlCommand scmd;
                                    SqlCommand scmd1;
                                    SqlCommand scmd2;
                                    SqlCommand scmd3;
                                    SqlCommand scmd4;
                                    SqlCommand scmd5;
                                    SqlCommand scmd6;
                                    SqlCommand scmd7;
                                    SqlCommand scmd8;
                                    SqlCommand scmd9;
                                    SqlCommand scmd10;
                                    SqlCommand scmd11;
                                    try
                                    {
                                        string time = DateTime.Now.ToString("yyyyMM");
                                        double gz = Convert.ToDouble(textBox1.Text);
                                        string pos = "员工";
                                        string scmdStr = "update 标准工资表 set 标准工资='" + gz + "'where 职位='" + pos + "';";
                                        scmd = new SqlCommand(scmdStr, scon);
                                        scmd.ExecuteNonQuery();
                                        string SCMDStr = "update 工资表 set 月基本工资='" + gz + "'where 时间='" + time + "'and 职位='" + pos + "';";
                                        scmd1 = new SqlCommand(SCMDStr, scon);
                                        scmd1.ExecuteNonQuery();

                                        double gz1 = Convert.ToDouble(textBox2.Text);
                                        string pos1 = "部门副经理";
                                        string scmdStr1 = "update 标准工资表 set 标准工资='" + gz1 + "'where 职位='" + pos1 + "';";
                                        scmd2 = new SqlCommand(scmdStr1, scon);
                                        scmd2.ExecuteNonQuery();
                                        string SCMDStr1 = "update 工资表 set 月基本工资='" + gz1 + "'where 时间='" + time + "'and 职位='" + pos1 + "';";
                                        scmd3 = new SqlCommand(SCMDStr1, scon);
                                        scmd3.ExecuteNonQuery();

                                        double gz2 = Convert.ToDouble(textBox3.Text);
                                        string pos2 = "部门经理";
                                        string scmdStr2 = "update 标准工资表 set 标准工资='" + gz2 + "'where 职位='" + pos2 + "';";
                                        scmd4 = new SqlCommand(scmdStr2, scon);
                                        scmd4.ExecuteNonQuery();
                                        string SCMDStr2 = "update 工资表 set 月基本工资='" + gz2 + "'where 时间='" + time + "'and 职位='" + pos2 + "';";
                                        scmd5 = new SqlCommand(SCMDStr2, scon);
                                        scmd5.ExecuteNonQuery();

                                        double gz3 = Convert.ToDouble(textBox4.Text);
                                        string pos3 = "副总经理";
                                        string scmdStr3 = "update 标准工资表 set 标准工资='" + gz3 + "'where 职位='" + pos3 + "';";
                                        scmd6 = new SqlCommand(scmdStr3, scon);
                                        scmd6.ExecuteNonQuery();
                                        string SCMDStr3 = "update 工资表 set 月基本工资='" + gz3 + "'where 时间='" + time + "'and 职位='" + pos3 + "';";
                                        scmd7 = new SqlCommand(SCMDStr3, scon);
                                        scmd7.ExecuteNonQuery();

                                        double gz4 = Convert.ToDouble(textBox5.Text);
                                        string pos4 = "副总经理";
                                        string scmdStr4 = "update 标准工资表 set 标准工资='" + gz4 + "'where 职位='" + pos4 + "';";
                                        scmd8 = new SqlCommand(scmdStr4, scon);
                                        scmd8.ExecuteNonQuery();
                                        string SCMDStr4 = "update 工资表 set 月基本工资='" + gz4 + "'where 时间='" + time + "'and 职位='" + pos4 + "';";
                                        scmd9 = new SqlCommand(SCMDStr4, scon);
                                        scmd9.ExecuteNonQuery();

                                        double gz5 = Convert.ToDouble(textBox6.Text);
                                        string pos5 = "副总经理";
                                        string scmdStr5 = "update 标准工资表 set 标准工资='" + gz5 + "'where 职位='" + pos5 + "';";
                                        scmd10 = new SqlCommand(scmdStr5, scon);
                                        scmd10.ExecuteNonQuery();
                                        string SCMDStr5 = "update 工资表 set 月基本工资='" + gz5 + "'where 时间='" + time + "'and 职位='" + pos5 + "';";
                                        scmd11 = new SqlCommand(SCMDStr5, scon);
                                        scmd11.ExecuteNonQuery();
                                        MessageBox.Show("修改成功！", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                        scon.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否取消修改？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
