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
    public partial class StuForm : Form
    {
        public StuForm()
        {
            InitializeComponent();
        }
        public StuForm(string txt)
            : this()
        {
            textBoxName.Text = txt;
        }

        private void StuForm_Load(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("f");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            lookInformation look = new lookInformation( textBoxName.Text );
            look.TopLevel = false;
            panel.Controls.Add(look);
            look.Show();
            look.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            CheckBook CB = new CheckBook();
            CB.TopLevel = false;
            panel.Controls.Add(CB);
            CB.Show();
            CB.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnbrro_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            BorrowBook borbook = new BorrowBook(textBoxName.Text);
            borbook.TopLevel = false;
            panel.Controls.Add(borbook);
            borbook.Show();
            borbook.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnretu_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            ReturnBook rebook = new ReturnBook(textBoxName.Text);
            rebook.TopLevel = false;
            panel.Controls.Add(rebook);
            rebook.Show();
            rebook.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterForm eb = new EnterForm();
            this.Hide();
            eb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel.Controls.Clear();
            BR_log br = new BR_log(textBoxName.Text);
            br.TopLevel = false;
            panel.Controls.Add(br);
            br.Show();
            br.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
