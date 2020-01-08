using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 图书馆管理系统
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            string selecString1 = "select * from 管理员信息表 where mAcct='" + UseText.Text + "' and mPassword='" + PasswordText.Text + "'";
            string selecString2 = "select * from 学生个人信息表 where sAcct ='" + UseText.Text + "' and sPassword='" + PasswordText.Text + "'";

            SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
            try
            { 
             conn.Open();
             if (rBnadmin.Checked)
             {
                if (UseText.Text != "" && PasswordText.Text != "")
                {

                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        ziAdminForm ziadmin = new ziAdminForm();
                        ziadmin.Show();
                        ziadmin.WindowState = FormWindowState.Maximized;
                        UseText.Text = PasswordText.Text = "";
                    }
                    else if (UseText.Text == "SuperAdmin" && int.Parse(PasswordText.Text) == 123456)
                    {
                        AdminForm admin = new AdminForm();
                        admin.Show();
                        admin.WindowState = FormWindowState.Maximized;
                        UseText.Text = PasswordText.Text = "";
                        }
                    else
                        MessageBox.Show("用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("请输入用户名和密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (rBnstu.Checked)
             {
                if (UseText.Text != "" && PasswordText.Text != "")
                {
                    SqlCommand cmd = new SqlCommand(selecString2, conn);
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    if (dr2.Read())
                    {
                        StuForm stu = new StuForm(UseText.Text);
                        stu.Show();
                        stu.WindowState = FormWindowState.Maximized;
                        UseText.Text = PasswordText.Text = "";
                        }
                    else
                        MessageBox.Show("用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("请输入用户名和密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
                 MessageBox.Show("请选择登录身份！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void rBnstu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
