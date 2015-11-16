namespace Mail
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fill_btn = new System.Windows.Forms.Button();
            this.pass_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.to_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.from_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subj_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cont_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fill2_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.rst_btn = new System.Windows.Forms.Button();
            this.fill3_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.fill_btn);
            this.panel1.Controls.Add(this.pass_txtbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.user_txtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 143);
            this.panel1.TabIndex = 0;
            // 
            // fill_btn
            // 
            this.fill_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill_btn.ForeColor = System.Drawing.Color.White;
            this.fill_btn.Location = new System.Drawing.Point(464, 97);
            this.fill_btn.Name = "fill_btn";
            this.fill_btn.Size = new System.Drawing.Size(225, 27);
            this.fill_btn.TabIndex = 4;
            this.fill_btn.Text = "Fill";
            this.fill_btn.UseVisualStyleBackColor = false;
            this.fill_btn.Click += new System.EventHandler(this.fill_btn_Click);
            // 
            // pass_txtbox
            // 
            this.pass_txtbox.Location = new System.Drawing.Point(464, 64);
            this.pass_txtbox.Name = "pass_txtbox";
            this.pass_txtbox.PasswordChar = '*';
            this.pass_txtbox.Size = new System.Drawing.Size(225, 27);
            this.pass_txtbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // user_txtbox
            // 
            this.user_txtbox.Location = new System.Drawing.Point(464, 31);
            this.user_txtbox.Name = "user_txtbox";
            this.user_txtbox.Size = new System.Drawing.Size(225, 27);
            this.user_txtbox.TabIndex = 1;
            this.user_txtbox.Text = "example@gmail.com";
            this.user_txtbox.TextChanged += new System.EventHandler(this.user_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // to_txtbox
            // 
            this.to_txtbox.Location = new System.Drawing.Point(106, 140);
            this.to_txtbox.Name = "to_txtbox";
            this.to_txtbox.Size = new System.Drawing.Size(341, 27);
            this.to_txtbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "To:";
            // 
            // from_txtbox
            // 
            this.from_txtbox.Enabled = false;
            this.from_txtbox.Location = new System.Drawing.Point(106, 173);
            this.from_txtbox.Name = "from_txtbox";
            this.from_txtbox.Size = new System.Drawing.Size(341, 27);
            this.from_txtbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "From:";
            // 
            // subj_txtbox
            // 
            this.subj_txtbox.Location = new System.Drawing.Point(106, 206);
            this.subj_txtbox.Name = "subj_txtbox";
            this.subj_txtbox.Size = new System.Drawing.Size(577, 27);
            this.subj_txtbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subject:";
            // 
            // cont_txtbox
            // 
            this.cont_txtbox.Location = new System.Drawing.Point(106, 239);
            this.cont_txtbox.Multiline = true;
            this.cont_txtbox.Name = "cont_txtbox";
            this.cont_txtbox.Size = new System.Drawing.Size(577, 177);
            this.cont_txtbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Content:";
            // 
            // fill2_btn
            // 
            this.fill2_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fill2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill2_btn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill2_btn.ForeColor = System.Drawing.Color.White;
            this.fill2_btn.Location = new System.Drawing.Point(454, 140);
            this.fill2_btn.Name = "fill2_btn";
            this.fill2_btn.Size = new System.Drawing.Size(112, 27);
            this.fill2_btn.TabIndex = 5;
            this.fill2_btn.Text = "ikenamik";
            this.fill2_btn.UseVisualStyleBackColor = false;
            this.fill2_btn.Click += new System.EventHandler(this.fill2_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.send_btn.ForeColor = System.Drawing.Color.White;
            this.send_btn.Location = new System.Drawing.Point(506, 422);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(177, 47);
            this.send_btn.TabIndex = 5;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // rst_btn
            // 
            this.rst_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rst_btn.ForeColor = System.Drawing.Color.White;
            this.rst_btn.Location = new System.Drawing.Point(323, 422);
            this.rst_btn.Name = "rst_btn";
            this.rst_btn.Size = new System.Drawing.Size(177, 47);
            this.rst_btn.TabIndex = 10;
            this.rst_btn.Text = "Reset";
            this.rst_btn.UseVisualStyleBackColor = false;
            this.rst_btn.Click += new System.EventHandler(this.rst_btn_Click);
            // 
            // fill3_btn
            // 
            this.fill3_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fill3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill3_btn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill3_btn.ForeColor = System.Drawing.Color.White;
            this.fill3_btn.Location = new System.Drawing.Point(576, 140);
            this.fill3_btn.Name = "fill3_btn";
            this.fill3_btn.Size = new System.Drawing.Size(107, 27);
            this.fill3_btn.TabIndex = 11;
            this.fill3_btn.Text = "zhengy1";
            this.fill3_btn.UseVisualStyleBackColor = false;
            this.fill3_btn.Click += new System.EventHandler(this.fill3_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mail.Properties.Resources.google;
            this.pictureBox1.Location = new System.Drawing.Point(12, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "CS336 - Networks I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Karoline Ikenami";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Yiwei Zheng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "Southern Oregon University";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fill3_btn);
            this.Controls.Add(this.rst_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.fill2_btn);
            this.Controls.Add(this.cont_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subj_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.from_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.to_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Simple Mail - Gmail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fill_btn;
        private System.Windows.Forms.TextBox pass_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox to_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox from_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subj_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cont_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button fill2_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button rst_btn;
        private System.Windows.Forms.Button fill3_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

