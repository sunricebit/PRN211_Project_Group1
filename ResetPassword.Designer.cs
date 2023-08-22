namespace NES_Store
{
    partial class ResetPassword
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
            label1 = new Label();
            txtMail = new TextBox();
            btnCheck = new Button();
            gbPass = new GroupBox();
            lbconfirm = new Label();
            btnSave = new Button();
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnBack = new Button();
            lbcheck = new Label();
            gbPass.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Input email:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(98, 12);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(218, 23);
            txtMail.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(338, 12);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // gbPass
            // 
            gbPass.BackColor = Color.Transparent;
            gbPass.Controls.Add(lbconfirm);
            gbPass.Controls.Add(btnSave);
            gbPass.Controls.Add(txtConfirmPass);
            gbPass.Controls.Add(txtNewPass);
            gbPass.Controls.Add(label3);
            gbPass.Controls.Add(label2);
            gbPass.Location = new Point(12, 70);
            gbPass.Name = "gbPass";
            gbPass.Size = new Size(400, 140);
            gbPass.TabIndex = 3;
            gbPass.TabStop = false;
            gbPass.Text = "New password";
            // 
            // lbconfirm
            // 
            lbconfirm.AutoSize = true;
            lbconfirm.Location = new Point(24, 108);
            lbconfirm.Name = "lbconfirm";
            lbconfirm.Size = new Size(0, 15);
            lbconfirm.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(294, 104);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(194, 60);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(175, 23);
            txtConfirmPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(194, 26);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(175, 23);
            txtNewPass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 63);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 1;
            label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 29);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 0;
            label2.Text = "New Password:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(148, 230);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(128, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back to login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbcheck
            // 
            lbcheck.AutoSize = true;
            lbcheck.Location = new Point(13, 43);
            lbcheck.Name = "lbcheck";
            lbcheck.Size = new Size(239, 15);
            lbcheck.TabIndex = 5;
            lbcheck.Text = "Please enter your email for validation check.";
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(424, 265);
            Controls.Add(lbcheck);
            Controls.Add(btnBack);
            Controls.Add(gbPass);
            Controls.Add(btnCheck);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPassword";
            Load += ResetPassword_Load;
            gbPass.ResumeLayout(false);
            gbPass.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private Button btnCheck;
        private GroupBox gbPass;
        private Button btnSave;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private Label label3;
        private Label label2;
        private Button btnBack;
        private Label lbcheck;
        private Label lbconfirm;
    }
}