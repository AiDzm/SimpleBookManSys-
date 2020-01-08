namespace 图书馆管理系统
{
    partial class StuForm
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
            this.btnLook = new System.Windows.Forms.Button();
            this.btnbrro = new System.Windows.Forms.Button();
            this.btnretu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.Color.Transparent;
            this.btnLook.FlatAppearance.BorderSize = 0;
            this.btnLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLook.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLook.ForeColor = System.Drawing.Color.Black;
            this.btnLook.Location = new System.Drawing.Point(11, 243);
            this.btnLook.Margin = new System.Windows.Forms.Padding(2);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(339, 115);
            this.btnLook.TabIndex = 0;
            this.btnLook.Text = "查阅图书";
            this.btnLook.UseVisualStyleBackColor = false;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnbrro
            // 
            this.btnbrro.BackColor = System.Drawing.Color.Transparent;
            this.btnbrro.FlatAppearance.BorderSize = 0;
            this.btnbrro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrro.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbrro.ForeColor = System.Drawing.Color.Black;
            this.btnbrro.Location = new System.Drawing.Point(11, 362);
            this.btnbrro.Margin = new System.Windows.Forms.Padding(2);
            this.btnbrro.Name = "btnbrro";
            this.btnbrro.Size = new System.Drawing.Size(339, 115);
            this.btnbrro.TabIndex = 1;
            this.btnbrro.Text = "借阅图书";
            this.btnbrro.UseVisualStyleBackColor = false;
            this.btnbrro.Click += new System.EventHandler(this.btnbrro_Click);
            // 
            // btnretu
            // 
            this.btnretu.BackColor = System.Drawing.Color.Transparent;
            this.btnretu.FlatAppearance.BorderSize = 0;
            this.btnretu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretu.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnretu.ForeColor = System.Drawing.Color.Black;
            this.btnretu.Location = new System.Drawing.Point(17, 481);
            this.btnretu.Margin = new System.Windows.Forms.Padding(2);
            this.btnretu.Name = "btnretu";
            this.btnretu.Size = new System.Drawing.Size(339, 115);
            this.btnretu.TabIndex = 2;
            this.btnretu.Text = "归还图书";
            this.btnretu.UseVisualStyleBackColor = false;
            this.btnretu.Click += new System.EventHandler(this.btnretu_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(11, 124);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(339, 115);
            this.button4.TabIndex = 3;
            this.button4.Text = "修改个人信息";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labTime
            // 
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.ForeColor = System.Drawing.Color.Black;
            this.labTime.Location = new System.Drawing.Point(11, 80);
            this.labTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(246, 42);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "TimeShow";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxName.Font = new System.Drawing.Font("楷体", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(118, 11);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(216, 40);
            this.textBoxName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "账号:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(11, 719);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 115);
            this.button1.TabIndex = 8;
            this.button1.Text = "返回登录界面";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Location = new System.Drawing.Point(411, 139);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1082, 555);
            this.panel.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(11, 600);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 115);
            this.button2.TabIndex = 2;
            this.button2.Text = "查看借阅记录";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1502, 940);
            this.Controls.Add(this.btnretu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnbrro);
            this.Controls.Add(this.btnLook);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StuForm";
            this.Text = "学生使用界面";
            this.Load += new System.EventHandler(this.StuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnbrro;
        private System.Windows.Forms.Button btnretu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button2;
    }
}