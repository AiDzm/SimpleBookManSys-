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
    public partial class RegisterAdministrator : Form
    {
        public RegisterAdministrator()
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
                string selecString1 = "insert into 管理员信息表 values('" + textBox_NO.Text + "','" + textBox_PW.Text + "','" + textBox_Name.Text + "','" + textBox_TEL.Text+"')";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    int stu = cmd.ExecuteNonQuery();
                    if (stu > 0) MessageBox.Show("注册管理员成功!", "恭喜");
                    textBox_NO.Text = textBox_PW.Text = textBox_TEL.Text = textBox_Name.Text = "";
                    return;
                }
                catch
                {
                    MessageBox.Show("该管理员已存在!", "提示");
                    textBox_NO.Text = textBox_PW.Text = textBox_TEL.Text = textBox_Name.Text = "";
                    return;
                }
                finally { conn.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterAdministrator_Load(object sender, EventArgs e)
        {

        }
    }
}
