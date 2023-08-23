namespace Project
{
    partial class frmProviderManagement
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grSearch = new GroupBox();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            lbSearch = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtProviderName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvProvider = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerBindingSource = new BindingSource(components);
            grActions = new GroupBox();
            comboBox1 = new ComboBox();
            btnLoad = new Button();
            btnClose = new Button();
            cboSort = new ComboBox();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).BeginInit();
            grActions.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Control;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(433, 124);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(320, 124);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(202, 124);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new Point(202, 170);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(313, 89);
            grSearch.TabIndex = 38;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(210, 53);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(73, 19);
            radioByName.TabIndex = 23;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new Point(210, 23);
            radioByID.Name = "radioByID";
            radioByID.Size = new Size(51, 19);
            radioByID.TabIndex = 22;
            radioByID.TabStop = true;
            radioByID.Text = "By Id";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(72, 21);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(118, 23);
            txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(72, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(24, 22);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(476, 72);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 23);
            txtAddress.TabIndex = 37;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(454, 21);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(206, 23);
            txtPhone.TabIndex = 36;
            // 
            // txtProviderName
            // 
            txtProviderName.Location = new Point(158, 75);
            txtProviderName.Margin = new Padding(3, 2, 3, 2);
            txtProviderName.Name = "txtProviderName";
            txtProviderName.Size = new Size(206, 23);
            txtProviderName.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(406, 77);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 33;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(384, 24);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 32;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(52, 77);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 31;
            label2.Text = "Provider Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 30;
            label1.Text = "Provider ID:";
            // 
            // dgvProvider
            // 
            dgvProvider.AllowUserToAddRows = false;
            dgvProvider.AllowUserToDeleteRows = false;
            dgvProvider.AutoGenerateColumns = false;
            dgvProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvider.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, providerNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dgvProvider.DataSource = providerBindingSource;
            dgvProvider.Location = new Point(22, 280);
            dgvProvider.Margin = new Padding(3, 2, 3, 2);
            dgvProvider.Name = "dgvProvider";
            dgvProvider.ReadOnly = true;
            dgvProvider.RowHeadersWidth = 51;
            dgvProvider.RowTemplate.Height = 29;
            dgvProvider.Size = new Size(679, 165);
            dgvProvider.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerNameDataGridViewTextBoxColumn
            // 
            providerNameDataGridViewTextBoxColumn.DataPropertyName = "ProviderName";
            providerNameDataGridViewTextBoxColumn.HeaderText = "ProviderName";
            providerNameDataGridViewTextBoxColumn.Name = "providerNameDataGridViewTextBoxColumn";
            providerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerBindingSource
            // 
            providerBindingSource.DataSource = typeof(PRN211_Project_Group1.DataAccess.Provider);
            // 
            // grActions
            // 
            grActions.Controls.Add(comboBox1);
            grActions.Controls.Add(label1);
            grActions.Controls.Add(label3);
            grActions.Controls.Add(txtPhone);
            grActions.Location = new Point(22, 3);
            grActions.Name = "grActions";
            grActions.Size = new Size(679, 161);
            grActions.TabIndex = 43;
            grActions.TabStop = false;
            grActions.Text = "Actions";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = providerBindingSource;
            comboBox1.DisplayMember = "Id";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 37;
            comboBox1.ValueMember = "Id";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(571, 222);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 45;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(320, 466);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 46;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "All", "A-Z", "Z-A" });
            cboSort.Location = new Point(549, 184);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(121, 23);
            cboSort.TabIndex = 48;
            cboSort.Text = "Sort Name...";
            // 
            // frmProviderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 499);
            Controls.Add(cboSort);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grSearch);
            Controls.Add(txtAddress);
            Controls.Add(txtProviderName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dgvProvider);
            Controls.Add(grActions);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProviderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Provider Management";
            Load += frmProviderManagement_Load;
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).EndInit();
            grActions.ResumeLayout(false);
            grActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtProviderName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvProvider;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private BindingSource providerBindingSource;
        private GroupBox grActions;
        private Button btnLoad;
        private Button btnClose;
        private ComboBox comboBox1;
        private ComboBox cboSort;
    }
}