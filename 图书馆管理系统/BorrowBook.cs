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
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }
        public BorrowBook(string txt)
            : this()
        {
            textBox2.Text = txt;
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bnumber 已借书号,sAcct 学生账号,borrowtime 借出时间 from 借阅信息表 where sAcct = '" + textBox2.Text + "' and returntime is null";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "test");
                dataGridView1.DataSource = myDataSet.Tables["test"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void btn确认_Click(object sender, EventArgs e)
        {
            try
            {
            conn.Open();
            string Strs = "select * from 学生个人信息表  where sBro = 3 and sAcct = '" + textBox2.Text + "'";
            SqlCommand cmds = new SqlCommand(Strs, conn);

            SqlDataReader drs = cmds.ExecuteReader();
                if (drs.Read())
                {
                    MessageBox.Show("【借阅失败】,借书最大上限是3本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string Str0 = "select * from 图书信息表  where bamount = 0 and bnumber = '" + textBox1.Text + "'";
                    SqlCommand cmd0 = new SqlCommand(Str0, conn);

                    SqlDataReader dr1 = cmd0.ExecuteReader();
                    if (dr1.Read())
                    {
                        MessageBox.Show("【借阅失败】,该书剩余数量为零！", "**提示**", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string Str1 = "insert into 借阅信息表(bnumber,sAcct,borrowtime) values('" + textBox1.Text + "','" + textBox2.Text + "',getdate())";
                        SqlCommand cmd = new SqlCommand(Str1, conn);
                        int stu = cmd.ExecuteNonQuery(); 

                        if (stu > 0)
                        {
                            string Str2 = "update 图书信息表 set bamount -= 1 where bnumber = '" + textBox1.Text + "'"; 
                            SqlCommand cmd1 = new SqlCommand(Str2, conn);
                            string Str3 = "update 学生个人信息表 set sBro += 1 where sAcct = '" + textBox2.Text + "'"; 
                            SqlCommand cmd2 = new SqlCommand(Str3, conn);
                            if (cmd1.ExecuteNonQuery() > 0 && cmd2.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("恭喜【借阅成功】!", "提示");
                            }
                        }
                    }
                }
            
            }
            catch (SqlException ex) 
            {     
                MessageBox.Show(ex.ToString()); 

            }
            finally 
            { 
                conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string cmdStr1 = "select bnumber 已借书号,sAcct 学生账号,borrowtime 借出时间 from 借阅信息表 where sAcct = '" + textBox2.Text + "' and returntime is null";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "test");
                dataGridView1.DataSource = myDataSet.Tables["test"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
    }
}
