namespace QuanLyNhaHang
{
    partial class frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Change_ConfirmPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Change_NewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Change_OldPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Change_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Change_ChangePass = new System.Windows.Forms.Button();
            this.btn_Change_Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 80);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(13, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 64);
            this.label6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHANGE PASSWORD";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.txt_Change_ConfirmPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Change_NewPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Change_OldPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Change_User);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 207);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txt_Change_ConfirmPass
            // 
            this.txt_Change_ConfirmPass.Location = new System.Drawing.Point(195, 160);
            this.txt_Change_ConfirmPass.Multiline = true;
            this.txt_Change_ConfirmPass.Name = "txt_Change_ConfirmPass";
            this.txt_Change_ConfirmPass.Size = new System.Drawing.Size(288, 25);
            this.txt_Change_ConfirmPass.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Confirm new password:";
            // 
            // txt_Change_NewPass
            // 
            this.txt_Change_NewPass.Location = new System.Drawing.Point(195, 118);
            this.txt_Change_NewPass.Multiline = true;
            this.txt_Change_NewPass.Name = "txt_Change_NewPass";
            this.txt_Change_NewPass.Size = new System.Drawing.Size(288, 25);
            this.txt_Change_NewPass.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "New password:";
            // 
            // txt_Change_OldPass
            // 
            this.txt_Change_OldPass.Location = new System.Drawing.Point(195, 75);
            this.txt_Change_OldPass.Multiline = true;
            this.txt_Change_OldPass.Name = "txt_Change_OldPass";
            this.txt_Change_OldPass.Size = new System.Drawing.Size(288, 25);
            this.txt_Change_OldPass.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Old password:";
            // 
            // txt_Change_User
            // 
            this.txt_Change_User.Location = new System.Drawing.Point(195, 32);
            this.txt_Change_User.Multiline = true;
            this.txt_Change_User.Name = "txt_Change_User";
            this.txt_Change_User.Size = new System.Drawing.Size(288, 25);
            this.txt_Change_User.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Your user:";
            // 
            // btn_Change_ChangePass
            // 
            this.btn_Change_ChangePass.BackColor = System.Drawing.Color.Bisque;
            this.btn_Change_ChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btn_Change_ChangePass.Image")));
            this.btn_Change_ChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Change_ChangePass.Location = new System.Drawing.Point(390, 322);
            this.btn_Change_ChangePass.Name = "btn_Change_ChangePass";
            this.btn_Change_ChangePass.Size = new System.Drawing.Size(123, 45);
            this.btn_Change_ChangePass.TabIndex = 20;
            this.btn_Change_ChangePass.Text = "Đổi mật khẩu";
            this.btn_Change_ChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Change_ChangePass.UseVisualStyleBackColor = false;
            this.btn_Change_ChangePass.Click += new System.EventHandler(this.btn_Change_ChangePass_Click);
            // 
            // btn_Change_Reset
            // 
            this.btn_Change_Reset.BackColor = System.Drawing.Color.Bisque;
            this.btn_Change_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Change_Reset.Image")));
            this.btn_Change_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Change_Reset.Location = new System.Drawing.Point(268, 322);
            this.btn_Change_Reset.Name = "btn_Change_Reset";
            this.btn_Change_Reset.Size = new System.Drawing.Size(105, 45);
            this.btn_Change_Reset.TabIndex = 21;
            this.btn_Change_Reset.Text = "Nhập lại";
            this.btn_Change_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Change_Reset.UseVisualStyleBackColor = false;
            this.btn_Change_Reset.Click += new System.EventHandler(this.btn_Change_Reset_Click);
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.btn_Change_Reset);
            this.Controls.Add(this.btn_Change_ChangePass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChangePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.frm_ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Change_ConfirmPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Change_NewPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Change_OldPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Change_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Change_ChangePass;
        private System.Windows.Forms.Button btn_Change_Reset;
    }
}