namespace 图书馆管理系统
{
    partial class LAstu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn后退 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 224);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 41);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 41);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(315, 41);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "新密码：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码：";
            // 
            // btn查看
            // 
            this.btn查看.BackColor = System.Drawing.Color.White;
            this.btn查看.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn查看.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn查看.ForeColor = System.Drawing.Color.Black;
            this.btn查看.Location = new System.Drawing.Point(583, 33);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(196, 61);
            this.btn查看.TabIndex = 7;
            this.btn查看.Text = "查看";
            this.btn查看.UseVisualStyleBackColor = false;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn修改
            // 
            this.btn修改.BackColor = System.Drawing.Color.White;
            this.btn修改.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn修改.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn修改.ForeColor = System.Drawing.Color.Black;
            this.btn修改.Location = new System.Drawing.Point(785, 100);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(196, 68);
            this.btn修改.TabIndex = 8;
            this.btn修改.Text = "修改";
            this.btn修改.UseVisualStyleBackColor = false;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 265);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果显示:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn后退);
            this.groupBox2.Controls.Add(this.btn删除);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btn修改);
            this.groupBox2.Controls.Add(this.btn查看);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(32, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 181);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作：";
            // 
            // btn后退
            // 
            this.btn后退.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn后退.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn后退.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn后退.ForeColor = System.Drawing.Color.Black;
            this.btn后退.Location = new System.Drawing.Point(785, 33);
            this.btn后退.Name = "btn后退";
            this.btn后退.Size = new System.Drawing.Size(196, 61);
            this.btn后退.TabIndex = 11;
            this.btn后退.Text = "后退";
            this.btn后退.UseVisualStyleBackColor = false;
            this.btn后退.Click += new System.EventHandler(this.btn后退_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackColor = System.Drawing.Color.White;
            this.btn删除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn删除.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn删除.ForeColor = System.Drawing.Color.Black;
            this.btn删除.Location = new System.Drawing.Point(583, 100);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(196, 68);
            this.btn删除.TabIndex = 10;
            this.btn删除.Text = "删除账户";
            this.btn删除.UseVisualStyleBackColor = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // LAstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1066, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "LAstu";
            this.Text = "查删改学生用户及其借阅情况";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn后退;
    }
}