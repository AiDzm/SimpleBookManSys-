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
    public partial class DeleteAdministrator : Form
    {
        public DeleteAdministrator()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_DEL.Text == "")
                MessageBox.Show("请填写管理员账号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("此操作不可逆，确定删除？", "提示", MessageBoxButtons.OKCancel);
                if (DialogResult != DialogResult.Cancel)
                {
                    string selecStr1 = "delete from 管理员信息表 where mAcct = '" + textBox_DEL.Text + "'";
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(selecStr1, conn);
                        int stu = cmd.ExecuteNonQuery();
                        if (stu > 0)
                        {
                            MessageBox.Show("删除操作成功!", "提示");
                            textBox_DEL.Text = "";
                            return;
                        }

                        else
                            MessageBox.Show("删除失败，该管理员不存在!", "提示");

                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
        }
    }
}
