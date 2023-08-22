namespace PRN211_Project_Group1
{
    partial class frmLogin
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
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Button();
            btnLogin = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(222, 250);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "forgot password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(127, 159);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 22);
            label3.Name = "label3";
            label3.Size = new Size(502, 35);
            label3.TabIndex = 15;
            label3.Text = "Furniture Storage Management";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(299, 205);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "EXIT";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(167, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 107);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 12;
            label1.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(232, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(205, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(232, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 23);
            txtEmail.TabIndex = 10;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 322);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
        private Button btnClose;
        private Button btnLogin;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}