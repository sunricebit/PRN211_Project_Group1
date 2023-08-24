namespace FurnitureWinApp
{
    partial class frmProductManagement
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
            btnImport = new Button();
            btnUpdate = new Button();
            txtPrice = new TextBox();
            Price = new Label();
            txtProductName = new TextBox();
            label4 = new Label();
            txtInStock = new TextBox();
            label3 = new Label();
            txtCategoryId = new TextBox();
            label2 = new Label();
            btnLoad = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnExport = new Button();
            grFilter = new GroupBox();
            numCatFilter = new NumericUpDown();
            lbSearchCountry = new Label();
            productBindingSource = new BindingSource(components);
            rbByName = new RadioButton();
            txtSearch = new TextBox();
            rbByCatID = new RadioButton();
            rbByProviderID = new RadioButton();
            btnSearch = new Button();
            dataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            grSearch = new GroupBox();
            rbByID = new RadioButton();
            cboProductID = new ComboBox();
            grActions = new GroupBox();
            label5 = new Label();
            txtProviderID = new TextBox();
            btnClose = new Button();
            grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCatFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grSearch.SuspendLayout();
            grActions.SuspendLayout();
            SuspendLayout();
            // 
            // btnImport
            // 
            btnImport.Location = new Point(527, 138);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(84, 30);
            btnImport.TabIndex = 36;
            btnImport.Text = "Import data";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(696, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(26, 23);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "⇧";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(107, 46);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 34;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Location = new Point(66, 46);
            Price.Name = "Price";
            Price.Size = new Size(33, 15);
            Price.TabIndex = 33;
            Price.Text = "Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(107, 15);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(13, 14);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 31;
            label4.Text = "Product name";
            // 
            // txtInStock
            // 
            txtInStock.Location = new Point(300, 46);
            txtInStock.Name = "txtInStock";
            txtInStock.Size = new Size(100, 23);
            txtInStock.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(257, 46);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 29;
            label3.Text = "In stock";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(300, 15);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(100, 23);
            txtCategoryId.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(234, 16);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 27;
            label2.Text = "Category ID ";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(708, 138);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(36, 30);
            btnLoad.TabIndex = 26;
            btnLoad.Text = "↻";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(423, 49);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 22;
            label1.Text = "Product ID (Update/Delete only)";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(664, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(26, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "-";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(632, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(26, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(618, 138);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(84, 30);
            btnExport.TabIndex = 38;
            btnExport.Text = "Export data";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(numCatFilter);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new Point(518, 79);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(226, 53);
            grFilter.TabIndex = 41;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // numCatFilter
            // 
            numCatFilter.Location = new Point(80, 18);
            numCatFilter.Name = "numCatFilter";
            numCatFilter.Size = new Size(136, 23);
            numCatFilter.TabIndex = 19;
            numCatFilter.ValueChanged += numCatFilter_ValueChanged;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new Point(19, 22);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new Size(55, 15);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Category";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(PRN211_Project_Group1.DataAccess.Product);
            // 
            // rbByName
            // 
            rbByName.AutoSize = true;
            rbByName.Checked = true;
            rbByName.Location = new Point(326, 22);
            rbByName.Name = "rbByName";
            rbByName.Size = new Size(73, 19);
            rbByName.TabIndex = 23;
            rbByName.TabStop = true;
            rbByName.Text = "By Name";
            rbByName.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(38, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(275, 23);
            txtSearch.TabIndex = 17;
            // 
            // rbByCatID
            // 
            rbByCatID.AutoSize = true;
            rbByCatID.Location = new Point(326, 47);
            rbByCatID.Name = "rbByCatID";
            rbByCatID.Size = new Size(70, 19);
            rbByCatID.TabIndex = 24;
            rbByCatID.Text = "By CatID";
            rbByCatID.UseVisualStyleBackColor = true;
            // 
            // rbByProviderID
            // 
            rbByProviderID.AutoSize = true;
            rbByProviderID.Location = new Point(397, 47);
            rbByProviderID.Name = "rbByProviderID";
            rbByProviderID.Size = new Size(96, 19);
            rbByProviderID.TabIndex = 26;
            rbByProviderID.Text = "By ProviderID";
            rbByProviderID.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(10, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(22, 23);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "🔎";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, providerIdDataGridViewTextBoxColumn });
            dataGridView.DataSource = productBindingSource;
            dataGridView.Location = new Point(13, 174);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(731, 284);
            dataGridView.TabIndex = 19;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providerIdDataGridViewTextBoxColumn
            // 
            providerIdDataGridViewTextBoxColumn.DataPropertyName = "ProviderId";
            providerIdDataGridViewTextBoxColumn.HeaderText = "ProviderId";
            providerIdDataGridViewTextBoxColumn.Name = "providerIdDataGridViewTextBoxColumn";
            providerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(rbByProviderID);
            grSearch.Controls.Add(rbByID);
            grSearch.Controls.Add(rbByCatID);
            grSearch.Controls.Add(rbByName);
            grSearch.Controls.Add(txtSearch);
            grSearch.Controls.Add(btnSearch);
            grSearch.Location = new Point(13, 79);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(499, 83);
            grSearch.TabIndex = 40;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // rbByID
            // 
            rbByID.AutoSize = true;
            rbByID.Location = new Point(397, 22);
            rbByID.Name = "rbByID";
            rbByID.Size = new Size(52, 19);
            rbByID.TabIndex = 25;
            rbByID.Text = "By ID";
            rbByID.UseVisualStyleBackColor = true;
            // 
            // cboProductID
            // 
            cboProductID.DataSource = productBindingSource;
            cboProductID.DisplayMember = "Id";
            cboProductID.Location = new Point(625, 45);
            cboProductID.Name = "cboProductID";
            cboProductID.Size = new Size(101, 23);
            cboProductID.TabIndex = 42;
            cboProductID.ValueMember = "Id";
            // 
            // grActions
            // 
            grActions.Controls.Add(label5);
            grActions.Controls.Add(txtProviderID);
            grActions.Controls.Add(cboProductID);
            grActions.Controls.Add(btnAdd);
            grActions.Controls.Add(btnDelete);
            grActions.Controls.Add(txtPrice);
            grActions.Controls.Add(txtProductName);
            grActions.Controls.Add(btnUpdate);
            grActions.Controls.Add(label1);
            grActions.Controls.Add(txtCategoryId);
            grActions.Controls.Add(txtInStock);
            grActions.Location = new Point(12, -2);
            grActions.Name = "grActions";
            grActions.Size = new Size(732, 78);
            grActions.TabIndex = 43;
            grActions.TabStop = false;
            grActions.Text = "Actions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(423, 17);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 44;
            label5.Text = "Provider ID";
            // 
            // txtProviderID
            // 
            txtProviderID.Location = new Point(515, 16);
            txtProviderID.Name = "txtProviderID";
            txtProviderID.Size = new Size(100, 23);
            txtProviderID.TabIndex = 43;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(330, 467);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 44;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 500);
            Controls.Add(btnClose);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(Price);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView);
            Controls.Add(grActions);
            Name = "frmProductManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += frmProductManagement_Load;
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCatFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grActions.ResumeLayout(false);
            grActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnImport;
        private Button btnUpdate;
        private TextBox txtPrice;
        private Label Price;
        private TextBox txtProductName;
        private Label label4;
        private TextBox txtInStock;
        private Label label3;
        private TextBox txtCategoryId;
        private Label label2;
        private Button btnLoad;
        private Label label1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnExport;
        private GroupBox grFilter;
        private Label lbSearchCountry;
        private RadioButton rbByProviderID;
        private RadioButton rbByCatID;
        private RadioButton rbByName;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView;
        private GroupBox grSearch;
        private BindingSource productBindingSource;
        private ComboBox cboProductID;
        private GroupBox grActions;
        private Button btnClose;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn historiesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private RadioButton rbByID;
        private Label label5;
        private TextBox txtProviderID;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerIdDataGridViewTextBoxColumn;
        private NumericUpDown numCatFilter;
    }
}