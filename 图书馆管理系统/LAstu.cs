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
    public partial class LAstu : Form
    {
        public LAstu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void btn查看_Click(object sender, EventArgs e)
        {
            string str = "select b.sAcct 用户账号,sPassword 密码,a.bnumber 所借书号,bName 所借书名,borrowtime 借书日期,returntime 还书日期,YuanXi 院系,JiBie 级别,ZhuanYe 专业班级,stel 电话 from 借阅信息表 a right join 图书信息表 c on a.bnumber = c.bnumber right join 学生个人信息表 b on a.sAcct = b.sAcct  where b.sAcct = '" + textBox1.Text+"'";
            try
            { 
             conn.Open();
             SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(str, conn);
             DataSet myDataSet = new DataSet();
             mySqlDataAdapter.Fill(myDataSet, "0");
             dataGridView1.DataSource = myDataSet.Tables["0"];
             if (dataGridView1.RowCount == 1) 
                 MessageBox.Show("查无此人，请重新输入！", "提示");
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel);
            if (DialogResult != DialogResult.Cancel) 
            {
                conn.Open();
                string str1 = "select * from 借阅信息表 where sAcct = '" + textBox1.Text + "' and returntime is null";
                SqlCommand cmd1 = new SqlCommand(str1, conn);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    MessageBox.Show("该学生用户有书未归还，请联系本人归还后重新进行此操作！", "提示");
                    conn.Close();
                    return;
                }
                else
                {
                    string str2 = "delete from 学生个人信息表  where sAcct = '" + textBox1.Text + "'";
                    try
                    {
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand(str2, conn);
                        if (cmd2.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("删除学生用户成功!", "提示");
                        }
                        else
                            MessageBox.Show("【删除失败】该用户不存在!", "提示");
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("【错误】有未填入框", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox2.Text != textBox3.Text)
                MessageBox.Show("确认密码与新密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str1 = "update 学生个人信息表 set sPassword = '" + textBox2.Text + "' where sAcct = '" + textBox1.Text + "'";
                try
                {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(str1, conn);
                if (cmd1.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("修改成功!", "提示");
                    textBox2.Text = textBox3.Text = "";
                }
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
            }
        }

        private void btn后退_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
