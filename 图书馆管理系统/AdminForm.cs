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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("server=(local);database=MyBookSys;Integrated Security=SSPI");


        private void AdminInformation_Load(object sender, EventArgs e)
        {

        }


        private void button进入二级_Click(object sender, EventArgs e)
        {
            ziAdminForm ziadmin = new ziAdminForm();
            ziadmin.Show();
            ziadmin.WindowState = FormWindowState.Maximized;
            //this.Hide();
        }

        private void button注册管理_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            RegisterAdministrator RA = new RegisterAdministrator();
            RA.TopLevel = false;
            panel.Controls.Add(RA);
            RA.Show();
            RA.FormBorderStyle = FormBorderStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            ModifyAdministrator MA = new ModifyAdministrator();
            MA.TopLevel = false;
            panel.Controls.Add(MA);
            MA.Show();
            MA.FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            DeleteAdministrator DA = new DeleteAdministrator();
            DA.TopLevel = false;
            panel.Controls.Add(DA);
            DA.Show();
            DA.FormBorderStyle = FormBorderStyle.None;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                String connString = "Data Source=.;Initial Catalog=MyBookSys;Integrated Security=True";
                SqlDataAdapter da = new SqlDataAdapter("select mAcct 管理员账号, mPassword 管理员密码,mName 姓名,mtel 联系方式 from 管理员信息表", connString);
                DataSet ds = new DataSet();
                da.Fill(ds, "管理员信息表");
                DataTable dt = ds.Tables["管理员信息表"];
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            try
            {
                String connString = "Data Source=.;Initial Catalog=MyBookSys;Integrated Security=True";
                SqlDataAdapter da = new SqlDataAdapter("select mAcct 管理员账号, mPassword 管理员密码,mName 姓名,mtel 联系方式 from 管理员信息表", connString);
                DataSet ds = new DataSet();
                da.Fill(ds, "管理员信息表");
                DataTable dt = ds.Tables["管理员信息表"];
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }

        }
    }
}
