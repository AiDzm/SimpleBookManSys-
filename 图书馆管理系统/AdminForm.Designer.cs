namespace 图书馆管理系统
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.button进入二级 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myBookSysDataSet = new 图书馆管理系统.MyBookSysDataSet();
            this.myBookSysDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBookSysDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBookSysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBookSysDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBookSysDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button进入二级
            // 
            this.button进入二级.BackColor = System.Drawing.Color.Transparent;
            this.button进入二级.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button进入二级.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button进入二级.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button进入二级.Location = new System.Drawing.Point(12, 501);
            this.button进入二级.Margin = new System.Windows.Forms.Padding(2);
            this.button进入二级.Name = "button进入二级";
            this.button进入二级.Size = new System.Drawing.Size(323, 69);
            this.button进入二级.TabIndex = 1;
            this.button进入二级.Text = "进入二级管理界面";
            this.button进入二级.UseVisualStyleBackColor = false;
            this.button进入二级.Click += new System.EventHandler(this.button进入二级_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "当前身份：超级管理员";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("幼圆", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 214);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "增删改管理员";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(12, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "修改管理员";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(12, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除管理员";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "注册管理员";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "902397dda144ad3467f491dbdca20cf431ad8526.jpg");
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(996, 79);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(650, 508);
            this.panel.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(12, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(321, 93);
            this.button3.TabIndex = 10;
            this.button3.Text = "退出超管界面";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(340, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(650, 755);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // myBookSysDataSet
            // 
            this.myBookSysDataSet.DataSetName = "MyBookSysDataSet";
            this.myBookSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myBookSysDataSetBindingSource
            // 
            this.myBookSysDataSetBindingSource.DataSource = this.myBookSysDataSet;
            this.myBookSysDataSetBindingSource.Position = 0;
            // 
            // myBookSysDataSetBindingSource1
            // 
            this.myBookSysDataSetBindingSource1.DataSource = this.myBookSysDataSet;
            this.myBookSysDataSetBindingSource1.Position = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(11, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(322, 70);
            this.button5.TabIndex = 12;
            this.button5.Text = "刷新";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(559, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 35);
            this.label3.TabIndex = 13;
            this.label3.Text = "管理员列表";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 638);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button进入二级);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "超级管理员操作界面";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBookSysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBookSysDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBookSysDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button进入二级;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource myBookSysDataSetBindingSource;
        private MyBookSysDataSet myBookSysDataSet;
        private System.Windows.Forms.BindingSource myBookSysDataSetBindingSource1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
    }
}