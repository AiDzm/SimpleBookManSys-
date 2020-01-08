namespace 图书馆管理系统
{
    partial class CheckBook
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
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_Writer = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Check = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.radioButton_Number = new System.Windows.Forms.RadioButton();
            this.radioButton_Name = new System.Windows.Forms.RadioButton();
            this.radioButton_Writer = new System.Windows.Forms.RadioButton();
            this.radioButton_Type = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Number
            // 
            this.textBox_Number.Font = new System.Drawing.Font("宋体", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Number.Location = new System.Drawing.Point(413, 12);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(217, 39);
            this.textBox_Number.TabIndex = 0;
            // 
            // textBox_Writer
            // 
            this.textBox_Writer.Font = new System.Drawing.Font("宋体", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Writer.Location = new System.Drawing.Point(819, 12);
            this.textBox_Writer.Name = "textBox_Writer";
            this.textBox_Writer.Size = new System.Drawing.Size(217, 39);
            this.textBox_Writer.TabIndex = 5;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("宋体", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Name.Location = new System.Drawing.Point(413, 76);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(217, 39);
            this.textBox_Name.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "武侠",
            "英语",
            "C++",
            "C#",
            "C",
            "Pyshon",
            "Java",
            "数学",
            "物理",
            "化学",
            "儿童",
            "教辅",
            "言情",
            "神话",
            "古典",
            "数据库"});
            this.comboBox1.Location = new System.Drawing.Point(819, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 36);
            this.comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "选择查询方式";
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.Transparent;
            this.button_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Check.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Check.Location = new System.Drawing.Point(18, 64);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(102, 70);
            this.button_Check.TabIndex = 13;
            this.button_Check.Text = "查询";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("楷体", 26.25F);
            this.button_Cancel.Location = new System.Drawing.Point(135, 64);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(102, 70);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // radioButton_Number
            // 
            this.radioButton_Number.AutoSize = true;
            this.radioButton_Number.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Number.Font = new System.Drawing.Font("楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Number.Location = new System.Drawing.Point(264, 13);
            this.radioButton_Number.Name = "radioButton_Number";
            this.radioButton_Number.Size = new System.Drawing.Size(142, 31);
            this.radioButton_Number.TabIndex = 15;
            this.radioButton_Number.TabStop = true;
            this.radioButton_Number.Text = "图书编号";
            this.radioButton_Number.UseVisualStyleBackColor = false;
            // 
            // radioButton_Name
            // 
            this.radioButton_Name.AutoSize = true;
            this.radioButton_Name.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Name.Font = new System.Drawing.Font("楷体", 20.25F);
            this.radioButton_Name.Location = new System.Drawing.Point(264, 77);
            this.radioButton_Name.Name = "radioButton_Name";
            this.radioButton_Name.Size = new System.Drawing.Size(142, 31);
            this.radioButton_Name.TabIndex = 16;
            this.radioButton_Name.TabStop = true;
            this.radioButton_Name.Text = "图书名称";
            this.radioButton_Name.UseVisualStyleBackColor = false;
            // 
            // radioButton_Writer
            // 
            this.radioButton_Writer.AutoSize = true;
            this.radioButton_Writer.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Writer.Font = new System.Drawing.Font("楷体", 20.25F);
            this.radioButton_Writer.Location = new System.Drawing.Point(670, 13);
            this.radioButton_Writer.Name = "radioButton_Writer";
            this.radioButton_Writer.Size = new System.Drawing.Size(142, 31);
            this.radioButton_Writer.TabIndex = 17;
            this.radioButton_Writer.TabStop = true;
            this.radioButton_Writer.Text = "图书作者";
            this.radioButton_Writer.UseVisualStyleBackColor = false;
            // 
            // radioButton_Type
            // 
            this.radioButton_Type.AutoSize = true;
            this.radioButton_Type.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Type.Font = new System.Drawing.Font("楷体", 20.25F);
            this.radioButton_Type.Location = new System.Drawing.Point(670, 77);
            this.radioButton_Type.Name = "radioButton_Type";
            this.radioButton_Type.Size = new System.Drawing.Size(142, 31);
            this.radioButton_Type.TabIndex = 18;
            this.radioButton_Type.TabStop = true;
            this.radioButton_Type.Text = "图书类型";
            this.radioButton_Type.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 355);
            this.dataGridView1.TabIndex = 19;
            // 
            // CheckBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1066, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton_Type);
            this.Controls.Add(this.radioButton_Writer);
            this.Controls.Add(this.radioButton_Name);
            this.Controls.Add(this.radioButton_Number);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Writer);
            this.Controls.Add(this.textBox_Number);
            this.Name = "CheckBook";
            this.Text = "CheckBook";
            this.Load += new System.EventHandler(this.CheckBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_Writer;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.RadioButton radioButton_Number;
        private System.Windows.Forms.RadioButton radioButton_Name;
        private System.Windows.Forms.RadioButton radioButton_Writer;
        private System.Windows.Forms.RadioButton radioButton_Type;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}