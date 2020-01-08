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
    public partial class ReturnBook : Form
    {
        public ReturnBook(string txt)
        {
            InitializeComponent();
            textBox2.Text = txt;
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string flag = "select bnumber 已借书号,sAcct 学生账号,borrowtime 借出时间,returntime 还书时间 from 借阅信息表 where sAcct = '" + textBox2.Text + "' and returntime is null";
                string cmdStr1 = "select bnumber 已借书号,sAcct 学生账号,borrowtime 借出时间 from 借阅信息表 where sAcct = '" + textBox2.Text + " '";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(flag, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "test");
                dataGridView1.DataSource = myDataSet.Tables["test"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
        private void btn归还_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string selecString1 = "select * from 借阅信息表  where bnumber = '" + textBox1.Text + " ' and sAcct = '" + textBox2.Text + " ' and returntime is null";
                SqlCommand cmd1 = new SqlCommand(selecString1, conn);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    conn.Close();
                    conn.Open();
                    string selecString2 = "update 图书信息表 set bamount += 1 where bnumber = '" + textBox1.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(selecString2, conn);
                    string selecString3 = "update 学生个人信息表 set sBro -= 1 where sAcct = '" + textBox2.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(selecString3, conn);
                    string Str4 = "update 借阅信息表 set returntime = getdate() where bnumber = '" + textBox1.Text + "' and sAcct = '"+ textBox2.Text + "'";
                    SqlCommand cmd4 = new SqlCommand(Str4, conn);


                    //string fine = "update 学生个人信息表 set fine +=  (select durtime from 借阅信息表*  where bnumber = '" + textBox1.Text + "' and sAcct = '" + textBox2.Text + "' and durtime > 30) * 0.1'";

                    //SqlCommand cmdf = new SqlCommand(fine, conn);
                    //cmdf.ExecuteReader();

                    if (cmd2.ExecuteNonQuery() > 0 && cmd3.ExecuteNonQuery() > 0 && cmd4.ExecuteNonQuery() > 0)
                    { 
                        MessageBox.Show("归还成功!", "提示");
                        conn.Close();
                        conn.Open();
                        string Strdur = "update 借阅信息表 set durtime = datediff(day,borrowtime,returntime) where bnumber = '" + textBox1.Text + "' and sAcct = '" + textBox2.Text + "'";
                        SqlCommand cmddur = new SqlCommand(Strdur, conn);
                        cmddur.ExecuteReader();
                        conn.Close();


                        string da = "select durtime from 借阅信息表 where bnumber = '" + textBox1.Text + "' and sAcct = '" + textBox2.Text + "' and durtime > 30";
                        string ds = "update 学生个人信息表 set fine = (select durtime from 借阅信息表 where bnumber = '" + textBox1.Text + "' and sAcct = '" + textBox2.Text + "' and durtime > 30)*0.1 where  sAcct = '" + textBox2.Text + "'";
                        conn.Open();
                        SqlCommand comup = new SqlCommand(ds, conn);
                        comup.ExecuteReader();
                        conn.Close();

                    }
                        
                }
                else MessageBox.Show("归还失败,确认书籍是否已还或检查书号后重新尝试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string flag = "select bnumber 已借书号,sAcct 学生账号,borrowtime 借出时间,returntime 还书时间 from 借阅信息表 where sAcct = '" + textBox2.Text + "' and returntime is null";
                string cmdStr1 = "select bnumber 已借书号,sAcct 学生账号,borrowtime 借出时间 from 借阅信息表 where sAcct = '" + textBox2.Text + " '";
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(flag, conn);
                DataSet myDataSet = new DataSet();
                mySqlDataAdapter.Fill(myDataSet, "test");
                dataGridView1.DataSource = myDataSet.Tables["test"];
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            finally { conn.Close(); }
        }
    }
}
