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
    public partial class CheckBook : Form
    {
        public CheckBook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");


        private void button_Check_Click(object sender, EventArgs e)
        {
            if (radioButton_Name.Checked)
            {
                if (textBox_Name.Text == "")
                    MessageBox.Show("请填写图书名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        conn.Open();
                        string cmdStr1 = "select bnumber 书号,bName 书名, bwriter 作者, bamount 现有数量,btype 类型,blanguage 语言,bpublisher 出版商,bpubdate 出版日期,bsummary 摘要,bplace 存放位置 from 图书信息表 where bName like '%" + textBox_Name.Text + "%'";
                        SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                        DataSet myDataSet = new DataSet();
                        mySqlDataAdapter.Fill(myDataSet, "图书信息表");
                        dataGridView1.DataSource = myDataSet.Tables["图书信息表"];
                        textBox_Name.Text = "";
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
            else if (radioButton_Number.Checked)
            {
                if (textBox_Number.Text == "")
                    MessageBox.Show("请填写图书编号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        conn.Open();
                        string cmdStr1 = "select bnumber 书号,bName 书名, bwriter 作者, bamount 现有数量,btype 类型,blanguage 语言,bpublisher 出版商,bpubdate 出版日期,bsummary 摘要,bplace 存放位置 from 图书信息表 where bnumber = '" + textBox_Number.Text + "'";
                        SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                        DataSet myDataSet = new DataSet();
                        mySqlDataAdapter.Fill(myDataSet, "图书信息表");
                        dataGridView1.DataSource = myDataSet.Tables["图书信息表"];
                        textBox_Number.Text = "";
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
            else if (radioButton_Type.Checked)
            {
                if (comboBox1.Text == "")
                    MessageBox.Show("请选择一种图书类型!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        conn.Open();
                        string cmdStr1 = "select bnumber 书号,bName 书名, bwriter 作者, bamount 现有数量,btype 类型,blanguage 语言,bpublisher 出版商,bpubdate 出版日期,bsummary 摘要,bplace 存放位置 from 图书信息表 where btype = '" + comboBox1.Text + "'";
                        SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                        DataSet myDataSet = new DataSet();
                        mySqlDataAdapter.Fill(myDataSet, "图书信息表");
                        dataGridView1.DataSource = myDataSet.Tables["图书信息表"];
                        comboBox1.Text = "";
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
            else if (radioButton_Writer.Checked)
            {
                if(textBox_Writer.Text == "")
                    MessageBox.Show("请填写作者姓名!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        conn.Open();
                        string cmdStr1 = "select bnumber 书号,bName 书名, bwriter 作者, bamount 现有数量,btype 类型,blanguage 语言,bpublisher 出版商,bpubdate 出版日期,bsummary 摘要,bplace 存放位置 from 图书信息表 where bwriter like '%" + textBox_Writer.Text + "%'";
                        SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdStr1, conn);
                        DataSet myDataSet = new DataSet();
                        mySqlDataAdapter.Fill(myDataSet, "图书信息表");
                        dataGridView1.DataSource = myDataSet.Tables["图书信息表"];
                        textBox_Writer.Text = "";
                    }
                    catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                    finally { conn.Close(); }
                }
            }
            else
            {
                MessageBox.Show("请选择一种查询方式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBook_Load(object sender, EventArgs e)
        {
            try
            {
                String connString = "Data Source=.;Initial Catalog=MyBookSys;Integrated Security=True";
                SqlDataAdapter da = new SqlDataAdapter("select * from 图书信息表", connString);
                DataSet ds = new DataSet();
                da.Fill(ds, "图书信息表");
                DataTable dt = ds.Tables["图书信息表"];
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
