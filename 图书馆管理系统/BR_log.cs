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
    public partial class BR_log : Form
    {
        public BR_log(string txt)
        {
            InitializeComponent();
            textBox.Text = txt;
        }

        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");

        private void BR_log_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string flag = "select bnumber 已借书号,sAcct 学生账号,borrowtime 借出时间,returntime 还书时间,durtime 借阅时长_天 from 借阅信息表 where sAcct = '" + textBox.Text + "'";
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
