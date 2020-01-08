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
    public partial class ModifyAdministrator : Form
    {
        public ModifyAdministrator()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_NO.Text == "")
                MessageBox.Show("请填写管理员账号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    string selecStr = "select * from 管理员信息表 where mAcct = '" + textBox_NO.Text + "'";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecStr, conn);
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        conn.Close();
                        string selecStr1 = "update 管理员信息表 set mName = '" + textBox_Name.Text + "' where mAcct = '" + textBox_NO.Text + "' ";
                        string selecStr2 = "update 管理员信息表 set mPassword = '" + textBox_PW.Text + "' where mAcct = '" + textBox_NO.Text + "' ";
                        string selecStr3 = "update 管理员信息表 set mtel = '" + textBox_TEL.Text + "' where mAcct = '" + textBox_NO.Text + "' ";
                        conn.Open();
                        if (textBox_Name.Text != "")
                        {
                            SqlCommand cmd1 = new SqlCommand(selecStr1, conn);
                            cmd1.ExecuteNonQuery(); 
                        }
                        if (textBox_PW.Text != "")
                        {
                            SqlCommand cmd2 = new SqlCommand(selecStr2, conn);
                            cmd2.ExecuteNonQuery();
                        }
                        if (textBox_TEL.Text != "")
                        {
                            SqlCommand cmd3 = new SqlCommand(selecStr3, conn);
                            cmd3.ExecuteNonQuery();
                        }
                        MessageBox.Show("修改成功!", "提示");
                        textBox_Name.Text = textBox_PW.Text = textBox_TEL.Text = textBox_NO.Text = "";
                        return;
                    }
                    else
                        MessageBox.Show("修改失败，请检查账号是否正确后重新尝试!", "提示");

                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
