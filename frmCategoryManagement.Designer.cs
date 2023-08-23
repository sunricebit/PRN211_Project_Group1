namespace FurnitureWinApp
{
    partial class frmCategoryManagement
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
            label4 = new Label();
            txtCategoryId = new TextBox();
            label2 = new Label();
            btnLoad = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource2 = new BindingSource(components);
            categoryBindingSource = new BindingSource(components);
            grActions = new GroupBox();
            comboBox1 = new ComboBox();
            categoryBindingSource1 = new BindingSource(components);
            rbName = new RadioButton();
            rbId = new RadioButton();
            grSearch = new GroupBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            grActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            grSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(481, 45);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(22, 23);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "⇧";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 45;
            label4.Text = "Category name";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(211, 16);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(195, 23);
            txtCategoryId.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 43;
            label2.Text = "Category ID (Update/Delete only)";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(524, 49);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(22, 23);
            btnLoad.TabIndex = 42;
            btnLoad.Text = "↻";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(452, 23);
            txtSearch.TabIndex = 41;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(22, 20);
            btnSearch.TabIndex = 40;
            btnSearch.Text = "🔎";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(450, 45);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(22, 23);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "-";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(422, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(22, 23);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn });
            dataGridView.DataSource = categoryBindingSource2;
            dataGridView.Location = new Point(12, 153);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(531, 250);
            dataGridView.TabIndex = 37;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource2
            // 
            categoryBindingSource2.DataSource = typeof(PRN211_Project_Group1.DataAccess.Category);
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(PRN211_Project_Group1.DataAccess.Category);
            // 
            // grActions
            // 
            grActions.Controls.Add(txtCategoryId);
            grActions.Controls.Add(comboBox1);
            grActions.Controls.Add(btnUpdate);
            grActions.Controls.Add(label4);
            grActions.Controls.Add(label2);
            grActions.Controls.Add(btnAdd);
            grActions.Controls.Add(btnDelete);
            grActions.Location = new Point(12, 4);
            grActions.Name = "grActions";
            grActions.Size = new Size(509, 76);
            grActions.TabIndex = 48;
            grActions.TabStop = false;
            grActions.Text = "Actions";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = categoryBindingSource1;
            comboBox1.DisplayMember = "Id";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(211, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 48;
            comboBox1.ValueMember = "Id";
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(PRN211_Project_Group1.DataAccess.Category);
            // 
            // rbName
            // 
            rbName.AutoSize = true;
            rbName.Checked = true;
            rbName.Location = new Point(6, 47);
            rbName.Name = "rbName";
            rbName.Size = new Size(57, 19);
            rbName.TabIndex = 49;
            rbName.TabStop = true;
            rbName.Text = "Name";
            rbName.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            rbId.AutoSize = true;
            rbId.Location = new Point(78, 47);
            rbId.Name = "rbId";
            rbId.Size = new Size(35, 19);
            rbId.TabIndex = 50;
            rbId.Text = "Id";
            rbId.UseVisualStyleBackColor = true;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(txtSearch);
            grSearch.Controls.Add(rbId);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(rbName);
            grSearch.Location = new Point(13, 78);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(508, 69);
            grSearch.TabIndex = 52;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(223, 408);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 53;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // frmCategoryManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 441);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView);
            Controls.Add(grActions);
            Controls.Add(grSearch);
            Name = "frmCategoryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += frmCategoryManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            grActions.ResumeLayout(false);
            grActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdate;
        private Label label4;
        private TextBox txtCategoryId;
        private Label label2;
        private Button btnLoad;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
        private GroupBox grActions;
        private ComboBox comboBox1;
        private BindingSource categoryBindingSource1;
        private RadioButton rbName;
        private RadioButton rbId;
        private GroupBox grSearch;
        private BindingSource categoryBindingSource2;
        private Button btnClose;
    }
}