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
            this.components = new System.ComponentModel.Container();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbUserName = new System.Windows.Forms.RadioButton();
            this.rbFullname = new System.Windows.Forms.RadioButton();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Account = new System.Windows.Forms.GroupBox();
            this.cboSelectRole = new System.Windows.Forms.ComboBox();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            this.Account.SuspendLayout();
            this.grFilter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(799, 67);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(25, 31);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "⇧";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 71);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(114, 27);
            this.txtPassword.TabIndex = 53;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Location = new System.Drawing.Point(15, 76);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(70, 20);
            this.Price.TabIndex = 52;
            this.Price.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(102, 28);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(114, 27);
            this.txtUsername.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Username";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(318, 71);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 27);
            this.txtPhone.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(246, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Phone";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(318, 28);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(165, 27);
            this.txtFullname.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(246, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Fullname";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(864, 28);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(25, 31);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "↻";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(596, 27);
            this.txtSearch.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 128);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 31);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "🔎";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(767, 67);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 31);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(735, 67);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 31);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AutoGenerateColumns = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvAccount.DataSource = this.accountBindingSource;
            this.dgvAccount.Location = new System.Drawing.Point(14, 227);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 25;
            this.dgvAccount.Size = new System.Drawing.Size(882, 339);
            this.dgvAccount.TabIndex = 38;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(PRN211_Project_Group1.DataAccess.Account);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(541, 23);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 27);
            this.txtEmail.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(493, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(513, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(735, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "ID";
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Checked = true;
            this.rbID.Location = new System.Drawing.Point(25, 168);
            this.rbID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(43, 24);
            this.rbID.TabIndex = 63;
            this.rbID.TabStop = true;
            this.rbID.Text = "Id";
            this.rbID.UseVisualStyleBackColor = true;
            // 
            // rbUserName
            // 
            this.rbUserName.AutoSize = true;
            this.rbUserName.Location = new System.Drawing.Point(94, 168);
            this.rbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUserName.Name = "rbUserName";
            this.rbUserName.Size = new System.Drawing.Size(96, 24);
            this.rbUserName.TabIndex = 64;
            this.rbUserName.Text = "Username";
            this.rbUserName.UseVisualStyleBackColor = true;
            // 
            // rbFullname
            // 
            this.rbFullname.AutoSize = true;
            this.rbFullname.Location = new System.Drawing.Point(207, 168);
            this.rbFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFullname.Name = "rbFullname";
            this.rbFullname.Size = new System.Drawing.Size(93, 24);
            this.rbFullname.TabIndex = 65;
            this.rbFullname.Text = "FullName";
            this.rbFullname.UseVisualStyleBackColor = true;
            // 
            // cboId
            // 
            this.cboId.DataSource = this.accountBindingSource;
            this.cboId.DisplayMember = "Id";
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(767, 24);
            this.cboId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(57, 28);
            this.cboId.TabIndex = 66;
            this.cboId.ValueMember = "Id";
            this.cboId.SelectedIndexChanged += new System.EventHandler(this.cboId_SelectedIndexChanged);
            // 
            // cboRole
            // 
            this.cboRole.DataSource = this.accountBindingSource1;
            this.cboRole.DisplayMember = "Role";
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(39, 29);
            this.cboRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(138, 28);
            this.cboRole.TabIndex = 67;
            this.cboRole.ValueMember = "Role";
            this.cboRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataSource = typeof(PRN211_Project_Group1.DataAccess.Account);
            // 
            // Account
            // 
            this.Account.Controls.Add(this.cboSelectRole);
            this.Account.Controls.Add(this.cboId);
            this.Account.Controls.Add(this.label1);
            this.Account.Controls.Add(this.txtEmail);
            this.Account.Controls.Add(this.label6);
            this.Account.Controls.Add(this.btnAdd);
            this.Account.Controls.Add(this.btnUpdate);
            this.Account.Controls.Add(this.btnDelete);
            this.Account.Location = new System.Drawing.Point(14, 4);
            this.Account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Account.Name = "Account";
            this.Account.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Account.Size = new System.Drawing.Size(843, 107);
            this.Account.TabIndex = 68;
            this.Account.TabStop = false;
            this.Account.Text = "Account";
            // 
            // cboSelectRole
            // 
            this.cboSelectRole.DataSource = this.accountBindingSource1;
            this.cboSelectRole.DisplayMember = "Role";
            this.cboSelectRole.FormattingEnabled = true;
            this.cboSelectRole.Location = new System.Drawing.Point(541, 67);
            this.cboSelectRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSelectRole.Name = "cboSelectRole";
            this.cboSelectRole.Size = new System.Drawing.Size(165, 28);
            this.cboSelectRole.TabIndex = 68;
            this.cboSelectRole.ValueMember = "Role";
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.cboRole);
            this.grFilter.Location = new System.Drawing.Point(680, 111);
            this.grFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grFilter.Name = "grFilter";
            this.grFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grFilter.Size = new System.Drawing.Size(209, 108);
            this.grFilter.TabIndex = 69;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter by role";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Location = new System.Drawing.Point(15, 109);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(651, 109);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(408, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 636);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rbFullname);
            this.Controls.Add(this.rbUserName);
            this.Controls.Add(this.rbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.Account);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            this.Account.ResumeLayout(false);
            this.Account.PerformLayout();
            this.grFilter.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnReset;
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
        private GroupBox Account;
        private GroupBox grFilter;
        private GroupBox groupBox3;
        private BindingSource accountBindingSource1;
        private Button btnClose;
        private ComboBox cboSelectRole;
    }
}