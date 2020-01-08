using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书馆管理系统
{
    public partial class ziAdminForm : Form
    {
        public ziAdminForm()
        {
            InitializeComponent();
        }

        private void btn注册_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            NewStuForm stu = new NewStuForm();
            stu.TopLevel = false;
            panel.Controls.Add(stu);
            stu.Show();
            stu.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnLookbook_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            CheckBook CB = new CheckBook();
            CB.TopLevel = false;
            panel.Controls.Add(CB);
            CB.Show();
            CB.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn上下架_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            NewBook ab = new NewBook();
            ab.TopLevel = false;
            panel.Controls.Add(ab);
            ab.Show();
            ab.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn查删改_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            LAstu la = new LAstu();
            la.TopLevel = false;
            panel.Controls.Add(la);
            la.Show();
            la.FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ziAdminForm_Load(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("f");
        }
    }
}
