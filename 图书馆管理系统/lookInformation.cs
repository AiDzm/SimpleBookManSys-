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
    public partial class lookInformation : Form
    {
        public lookInformation()
        {
            InitializeComponent();
        }

        public lookInformation(string txt)
            : this()
        {
            textBoxAcct.Text = txt;
        }


        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void lookInformation_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select sAcct 账号,sName 用户名,sPassword 密码,YuanXi 院系,JiBie 级别,ZhuanYe 专业,stel 电话,sBro 已借书籍数量,fine 罚款金额_元 from 学生个人信息表 where sAcct = '" + textBoxAcct.Text + "'";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "学生个人信息表");
                dataGridView1.DataSource = myDataSet.Tables["学生个人信息表"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {//修改密码
                if (textBox2.Text != "" && textBox3.Text == "")
                {
                    MessageBox.Show("请再次输入更改后的密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (textBox2.Text == "" && textBox3.Text != "")
                {
                    MessageBox.Show("请按次序输入新密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = textBox3.Text = "";
                    return;
                }
                else if(textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("两次新密码输入不一致！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = textBox3.Text = "";
                    return;
                }

                else
                {
                    try
                    {
                        string selecString1 = "select * from 学生个人信息表 where sAcct ='" + textBoxAcct.Text + "' and sPassword='" + textBox2.Text + "'";
                        string selecString2 = "select * from 学生个人信息表 where sAcct ='" + textBoxAcct.Text + "' and sPassword='" + textBox1.Text + "'";
                        conn.Open();
                        SqlCommand cmd1 = new SqlCommand(selecString1, conn);
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        if(dr1.Read())
                        {
                            MessageBox.Show("新输入密码与原密码相同，请重新输入新密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Text = textBox3.Text = "";
                            return;
                        }
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd2 = new SqlCommand(selecString2, conn);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.Read())
                        {
                            conn.Close();
                            conn.Open();
                            string selecStr1 = "update 学生个人信息表 set sPassword = '" + textBox2.Text + "'  where sAcct = '" + textBoxAcct.Text + "' ";
                            SqlCommand cmd3 = new SqlCommand(selecStr1, conn);
                            cmd3.ExecuteReader();
                            MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = textBox2.Text = textBox3.Text = "";
                            conn.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("原密码输入错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = textBox2.Text = textBox3.Text = "";
                            conn.Close();
                            return;
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
            else
            {
                MessageBox.Show("请输入原密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                if (comboBox1.Text != "")
                {
                    string selecStr2 = "update 学生个人信息表 set YuanXi = '" + comboBox1.Text + "'  where sAcct = '" + textBoxAcct.Text + "' ";
                    SqlCommand cmd2 = new SqlCommand(selecStr2, conn);
                    cmd2.ExecuteNonQuery();
                }
                if (textBox5.Text != "")
                {
                    string selecStr3 = "update 学生个人信息表 set JiBie = '" + textBox5.Text + "'  where sAcct = '" + textBoxAcct.Text + "' ";
                    SqlCommand cmd3 = new SqlCommand(selecStr3, conn);
                    cmd3.ExecuteNonQuery();
                }
                if (textBox6.Text != "")
                {
                    string selecStr4 = "update 学生个人信息表 set ZhuanYe = '" + textBox6.Text + "'  where sAcct = '" + textBoxAcct.Text + "' ";
                    SqlCommand cmd4 = new SqlCommand(selecStr4, conn);
                    cmd4.ExecuteNonQuery();
                }
                if (textBox7.Text != "")
                {
                    string selecStr5 = "update 学生个人信息表 set stel = '" + textBox7.Text + "'  where sAcct = '" + textBoxAcct.Text + "' ";
                    SqlCommand cmd5 = new SqlCommand(selecStr5, conn);
                    cmd5.ExecuteNonQuery();
                }
                MessageBox.Show("修改成功!", "提示");
                comboBox1.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
                conn.Close();
                return;
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
    }
}
