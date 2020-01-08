using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace 图书馆管理系统
{
    public partial class NewBook : Form
    {
        public NewBook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");
        private void btn上架_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""  || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text ==  "")
                MessageBox.Show("请您添写所有的必填项!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string selecString1 = "insert into 图书信息表 values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "','" + textBox6.Text  + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox11.Text + "','"+textBox10.Text+"')";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    //执行sql语句，返回受影响行数
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("图书成功上架!","提示");
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox9.Text = textBox11.Text = "";
                }
                catch (SqlException ex) 
                { 
                    MessageBox.Show("图书架上失败，请修改书号后重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                finally 
                { 
                    conn.Close(); 
                }
            }
        }

        private void btn下架_Click(object sender, EventArgs e)
        {
            string selecString1 = "delete from 图书信息表 where bnumber = '" + textBox8.Text + "' ";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selecString1, conn);
                    int stu = cmd.ExecuteNonQuery();
                    if (stu > 0) 
                        MessageBox.Show("图书成功下架!", "提示");
                    else
                        MessageBox.Show("图书下架失败，请检查书号后重新尝试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
                finally { conn.Close(); }
        }

        private void btn后退_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            try
            {
                String connString = "Data Source=.;Initial Catalog=MyBookSys;Integrated Security=True";
                SqlDataAdapter da = new SqlDataAdapter("select bnumber 书号,bName 书名, bwriter 作者, bamount 数量,btype 类型,blanguage 语言,bpublisher 出版商,bsummary 摘要,bplace 存放位置 from 图书信息表", connString);
                DataSet ds = new DataSet();
                da.Fill(ds, "图书信息表");
                DataTable dt = ds.Tables["图书信息表"];
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_isbn_Click(object sender, EventArgs e)
        {

            string str = "https://www.googleapis.com/books/v1/volumes?q=ISBN"+textBox_ISBN.Text;

            string getJson = HttpUitls.Get(str);

            Root rt = JsonConvert.DeserializeObject<Root>(getJson);
            textBox1.Text = rt.items[0].volumeInfo.title;
            textBox3.Text = rt.items[0].volumeInfo.authors[0];
            textBox5.Text = rt.items[0].volumeInfo.categories[0];
            textBox7.Text = rt.items[0].volumeInfo.description;
            textBox9.Text = rt.items[0].volumeInfo.publisher;
            textBox10.Text = rt.items[0].volumeInfo.publishedDate;
            textBox11.Text = rt.items[0].volumeInfo.language;
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            try
            {
                String connString = "Data Source=.;Initial Catalog=MyBookSys;Integrated Security=True";
                SqlDataAdapter da = new SqlDataAdapter("select bnumber 书号,bName 书名, bwriter 作者, bamount 数量,btype 类型,blanguage 语言,bpublisher 出版商,bsummary 摘要,bplace 存放位置 from 图书信息表", connString);
                DataSet ds = new DataSet();
                da.Fill(ds, "图书信息表");
                DataTable dt = ds.Tables["图书信息表"];
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
