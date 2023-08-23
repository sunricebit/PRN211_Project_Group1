namespace FurnitureWinApp
{
    partial class frmAccountManagement
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
            components = new System.ComponentModel.Container();
            btnUpdate = new Button();
            txtPassword = new TextBox();
            Price = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtFullname = new TextBox();
            label2 = new Label();
            btnLoad = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvAccount = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountBindingSource = new BindingSource(components);
            txtEmail = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            rbID = new RadioButton();
            rbUserName = new RadioButton();
            rbFullname = new RadioButton();
            cboId = new ComboBox();
            cboRole = new ComboBox();
            accountBindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            cboSelectRole = new ComboBox();
            grFilter = new GroupBox();
            groupBox3 = new GroupBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            grFilter.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(699, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(22, 23);
            btnUpdate.TabIndex = 54;
            btnUpdate.Text = "⇧";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 53);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 53;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Location = new Point(13, 57);
            Price.Name = "Price";
            Price.Size = new Size(57, 15);
            Price.TabIndex = 52;
            Price.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(89, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(13, 24);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 50;
            label4.Text = "Username";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(278, 53);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(145, 23);
            txtPhone.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(215, 56);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 48;
            label3.Text = "Phone";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(278, 21);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(145, 23);
            txtFullname.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(215, 24);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 46;
            label2.Text = "Fullname";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(756, 21);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(22, 23);
            btnLoad.TabIndex = 45;
            btnLoad.Text = "↻";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(31, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(522, 23);
            txtSearch.TabIndex = 44;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(16, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(22, 23);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "🔎";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(671, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(22, 23);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "-";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(643, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(22, 23);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AllowUserToDeleteRows = false;
            dgvAccount.AutoGenerateColumns = false;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            dgvAccount.DataSource = accountBindingSource;
            dgvAccount.Location = new Point(12, 170);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 25;
            dgvAccount.Size = new Size(772, 254);
            dgvAccount.TabIndex = 38;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(PRN211_Project_Group1.DataAccess.Account);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(473, 17);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 23);
            txtEmail.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(431, 21);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 57;
            label1.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(449, 57);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 59;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(643, 21);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 61;
            label6.Text = "ID";
            // 
            // rbID
            // 
            rbID.AutoSize = true;
            rbID.Checked = true;
            rbID.Location = new Point(22, 126);
            rbID.Name = "rbID";
            rbID.Size = new Size(35, 19);
            rbID.TabIndex = 63;
            rbID.TabStop = true;
            rbID.Text = "Id";
            rbID.UseVisualStyleBackColor = true;
            // 
            // rbUserName
            // 
            rbUserName.AutoSize = true;
            rbUserName.Location = new Point(82, 126);
            rbUserName.Name = "rbUserName";
            rbUserName.Size = new Size(78, 19);
            rbUserName.TabIndex = 64;
            rbUserName.Text = "Username";
            rbUserName.UseVisualStyleBackColor = true;
            // 
            // rbFullname
            // 
            rbFullname.AutoSize = true;
            rbFullname.Location = new Point(181, 126);
            rbFullname.Name = "rbFullname";
            rbFullname.Size = new Size(76, 19);
            rbFullname.TabIndex = 65;
            rbFullname.Text = "FullName";
            rbFullname.UseVisualStyleBackColor = true;
            // 
            // cboId
            // 
            cboId.DataSource = accountBindingSource;
            cboId.DisplayMember = "Id";
            cboId.FormattingEnabled = true;
            cboId.Location = new Point(671, 18);
            cboId.Name = "cboId";
            cboId.Size = new Size(50, 23);
            cboId.TabIndex = 66;
            cboId.ValueMember = "Id";
            // 
            // cboRole
            // 
            cboRole.DataSource = accountBindingSource1;
            cboRole.DisplayMember = "Role";
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(34, 22);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(121, 23);
            cboRole.TabIndex = 67;
            cboRole.ValueMember = "Role";
            cboRole.SelectedIndexChanged += cboRole_SelectedIndexChanged;
            // 
            // accountBindingSource1
            // 
            accountBindingSource1.DataSource = typeof(PRN211_Project_Group1.DataAccess.Account);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSelectRole);
            groupBox1.Controls.Add(cboId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 80);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cboSelectRole
            // 
            cboSelectRole.DataSource = accountBindingSource1;
            cboSelectRole.DisplayMember = "Role";
            cboSelectRole.FormattingEnabled = true;
            cboSelectRole.Location = new Point(473, 50);
            cboSelectRole.Name = "cboSelectRole";
            cboSelectRole.Size = new Size(145, 23);
            cboSelectRole.TabIndex = 68;
            cboSelectRole.ValueMember = "Role";
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboRole);
            grFilter.Location = new Point(595, 83);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(183, 81);
            grFilter.TabIndex = 69;
            grFilter.TabStop = false;
            grFilter.Text = "Filter by role";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Location = new Point(13, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(570, 82);
            groupBox3.TabIndex = 69;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(357, 444);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 70;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(357, 444);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 70;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmAccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 477);
            Controls.Add(btnClose);
            Controls.Add(rbFullname);
            Controls.Add(rbUserName);
            Controls.Add(rbID);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(Price);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtFullname);
            Controls.Add(label2);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(dgvAccount);
            Controls.Add(groupBox3);
            Controls.Add(grFilter);
            Controls.Add(groupBox1);
            Name = "frmAccountManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Management";
            Load += frmAccountManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grFilter.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private TextBox txtPassword;
        private Label Price;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtFullname;
        private Label label2;
        private Button btnLoad;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvAccount;
        private TextBox txtEmail;
        private Label label1;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private BindingSource accountBindingSource;
        private RadioButton rbID;
        private RadioButton rbUserName;
        private RadioButton rbFullname;
        private ComboBox cboId;
        private ComboBox cboRole;
        private GroupBox groupBox1;
        private GroupBox grFilter;
        private GroupBox groupBox3;
        private BindingSource accountBindingSource1;
        private Button btnClose;
        private ComboBox cboSelectRole;
    }
}