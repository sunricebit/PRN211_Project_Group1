namespace FurnitureWinApp
{
    partial class frmAccount
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
            btnClose = new Button();
            btnSave = new Button();
            label5 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            Price = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtFullname = new TextBox();
            label2 = new Label();
            cboRole = new ComboBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(171, 217);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 34;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(69, 217);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 33;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(47, 171);
            label5.Name = "label5";
            label5.Size = new Size(34, 16);
            label5.TabIndex = 71;
            label5.Text = "Role";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 23);
            txtEmail.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 142);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 69;
            label1.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 53);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 68;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Price.Location = new Point(47, 55);
            Price.Name = "Price";
            Price.Size = new Size(65, 16);
            Price.TabIndex = 67;
            Price.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 24);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 23);
            txtUsername.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(47, 26);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 65;
            label4.Text = "Username";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(136, 111);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(145, 23);
            txtPhone.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 113);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 63;
            label3.Text = "Phone";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(136, 82);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(145, 23);
            txtFullname.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 84);
            label2.Name = "label2";
            label2.Size = new Size(64, 16);
            label2.TabIndex = 61;
            label2.Text = "Fullname";
            // 
            // cboRole
            // 
            cboRole.DisplayMember = "Role";
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Admin", "Manager", "Member" });
            cboRole.Location = new Point(136, 169);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(145, 23);
            cboRole.TabIndex = 72;
            cboRole.ValueMember = "Role";
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 261);
            Controls.Add(cboRole);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(Price);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtFullname);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "frmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            Load += frmAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private Label label5;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtPassword;
        private Label Price;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtFullname;
        private Label label2;
        private ComboBox cboRole;
    }
}