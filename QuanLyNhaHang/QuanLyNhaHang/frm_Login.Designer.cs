namespace QuanLyNhaHang
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.group_Login = new System.Windows.Forms.GroupBox();
            this.txt_LoginUser = new System.Windows.Forms.TextBox();
            this.txt_LoginPass = new System.Windows.Forms.TextBox();
            this.link_LoginChangePass = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LoginCancel = new System.Windows.Forms.Button();
            this.btn_LoginReset = new System.Windows.Forms.Button();
            this.btn_LoginLogin = new System.Windows.Forms.Button();
            this.lb_LoginTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.group_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_LoginCancel);
            this.panel1.Controls.Add(this.btn_LoginReset);
            this.panel1.Controls.Add(this.btn_LoginLogin);
            this.panel1.Controls.Add(this.lb_LoginTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 380);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.group_Login);
            this.panel2.Location = new System.Drawing.Point(3, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 168);
            this.panel2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 154);
            this.label5.TabIndex = 18;
            // 
            // group_Login
            // 
            this.group_Login.Controls.Add(this.txt_LoginUser);
            this.group_Login.Controls.Add(this.txt_LoginPass);
            this.group_Login.Controls.Add(this.link_LoginChangePass);
            this.group_Login.Controls.Add(this.label4);
            this.group_Login.Controls.Add(this.label3);
            this.group_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_Login.ForeColor = System.Drawing.Color.DodgerBlue;
            this.group_Login.Location = new System.Drawing.Point(163, 9);
            this.group_Login.Name = "group_Login";
            this.group_Login.Size = new System.Drawing.Size(380, 156);
            this.group_Login.TabIndex = 0;
            this.group_Login.TabStop = false;
            this.group_Login.Text = "Thông tin đăng nhập";
            // 
            // txt_LoginUser
            // 
            this.txt_LoginUser.Location = new System.Drawing.Point(143, 30);
            this.txt_LoginUser.Multiline = true;
            this.txt_LoginUser.Name = "txt_LoginUser";
            this.txt_LoginUser.Size = new System.Drawing.Size(216, 25);
            this.txt_LoginUser.TabIndex = 1;
            this.txt_LoginUser.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txt_LoginUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Login_KeyPress);
            this.txt_LoginUser.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // txt_LoginPass
            // 
            this.txt_LoginPass.Location = new System.Drawing.Point(143, 70);
            this.txt_LoginPass.Multiline = true;
            this.txt_LoginPass.Name = "txt_LoginPass";
            this.txt_LoginPass.PasswordChar = '♔';
            this.txt_LoginPass.Size = new System.Drawing.Size(216, 25);
            this.txt_LoginPass.TabIndex = 2;
            this.txt_LoginPass.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txt_LoginPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Login_KeyPress);
            this.txt_LoginPass.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // link_LoginChangePass
            // 
            this.link_LoginChangePass.AutoSize = true;
            this.link_LoginChangePass.Location = new System.Drawing.Point(293, 115);
            this.link_LoginChangePass.Name = "link_LoginChangePass";
            this.link_LoginChangePass.Size = new System.Drawing.Size(85, 16);
            this.link_LoginChangePass.TabIndex = 6;
            this.link_LoginChangePass.TabStop = true;
            this.link_LoginChangePass.Text = "Đổi mật khẩu";
            this.link_LoginChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LoginChangePass_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(41, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(41, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Name: ";
            // 
            // btn_LoginCancel
            // 
            this.btn_LoginCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_LoginCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginCancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoginCancel.Image")));
            this.btn_LoginCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoginCancel.Location = new System.Drawing.Point(421, 314);
            this.btn_LoginCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoginCancel.Name = "btn_LoginCancel";
            this.btn_LoginCancel.Size = new System.Drawing.Size(95, 44);
            this.btn_LoginCancel.TabIndex = 5;
            this.btn_LoginCancel.Text = "Hủy bỏ";
            this.btn_LoginCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LoginCancel.UseVisualStyleBackColor = false;
            this.btn_LoginCancel.Click += new System.EventHandler(this.btn_LoginCancel_Click);
            // 
            // btn_LoginReset
            // 
            this.btn_LoginReset.AutoSize = true;
            this.btn_LoginReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_LoginReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginReset.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoginReset.Image")));
            this.btn_LoginReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoginReset.Location = new System.Drawing.Point(238, 314);
            this.btn_LoginReset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoginReset.Name = "btn_LoginReset";
            this.btn_LoginReset.Size = new System.Drawing.Size(101, 44);
            this.btn_LoginReset.TabIndex = 4;
            this.btn_LoginReset.Text = "Nhập lại";
            this.btn_LoginReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LoginReset.UseVisualStyleBackColor = false;
            this.btn_LoginReset.Click += new System.EventHandler(this.btn_LoginReset_Click);
            // 
            // btn_LoginLogin
            // 
            this.btn_LoginLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_LoginLogin.CausesValidation = false;
            this.btn_LoginLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginLogin.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoginLogin.Image")));
            this.btn_LoginLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LoginLogin.Location = new System.Drawing.Point(37, 314);
            this.btn_LoginLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoginLogin.Name = "btn_LoginLogin";
            this.btn_LoginLogin.Size = new System.Drawing.Size(123, 44);
            this.btn_LoginLogin.TabIndex = 3;
            this.btn_LoginLogin.Text = "Đăng Nhập";
            this.btn_LoginLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LoginLogin.UseVisualStyleBackColor = false;
            this.btn_LoginLogin.Click += new System.EventHandler(this.btn_LoginLogin_Click);
            // 
            // lb_LoginTime
            // 
            this.lb_LoginTime.AutoSize = true;
            this.lb_LoginTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoginTime.Location = new System.Drawing.Point(422, 73);
            this.lb_LoginTime.Name = "lb_LoginTime";
            this.lb_LoginTime.Size = new System.Drawing.Size(123, 16);
            this.lb_LoginTime.TabIndex = 2;
            this.lb_LoginTime.Text = "Ngày giờ hiện hành";
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(376, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHUCSDOO BBQ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(560, 381);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.Shown += new System.EventHandler(this.frm_Login_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.group_Login.ResumeLayout(false);
            this.group_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_LoginTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox group_Login;
        private System.Windows.Forms.TextBox txt_LoginUser;
        private System.Windows.Forms.TextBox txt_LoginPass;
        private System.Windows.Forms.LinkLabel link_LoginChangePass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_LoginCancel;
        private System.Windows.Forms.Button btn_LoginReset;
        private System.Windows.Forms.Button btn_LoginLogin;
    }
}