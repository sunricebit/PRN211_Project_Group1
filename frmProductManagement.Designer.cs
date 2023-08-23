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
            this.components = new System.ComponentModel.Container();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.numCatFilter = new System.Windows.Forms.NumericUpDown();
            this.lbSearchCountry = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbByCatID = new System.Windows.Forms.RadioButton();
            this.rbByProviderID = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.rbByID = new System.Windows.Forms.RadioButton();
            this.cboProductID = new System.Windows.Forms.ComboBox();
            this.grActions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProviderID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCatFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grSearch.SuspendLayout();
            this.grActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(602, 184);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(96, 40);
            this.btnImport.TabIndex = 36;
            this.btnImport.Text = "Import data";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(795, 21);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(30, 31);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "⇧";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(122, 61);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 27);
            this.txtPrice.TabIndex = 34;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Location = new System.Drawing.Point(75, 61);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(41, 20);
            this.Price.TabIndex = 33;
            this.Price.Text = "Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(122, 20);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(114, 27);
            this.txtProductName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Product name";
            // 
            // txtInStock
            // 
            this.txtInStock.Location = new System.Drawing.Point(343, 61);
            this.txtInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(114, 27);
            this.txtInStock.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(336, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "In stock";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(343, 20);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(114, 27);
            this.txtCategoryId.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(267, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Category ID ";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(809, 184);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(41, 40);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "↻";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(483, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product ID (Update/Delete only)";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(759, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 31);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(722, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 31);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(706, 184);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 40);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "Export data";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.numCatFilter);
            this.grFilter.Controls.Add(this.lbSearchCountry);
            this.grFilter.Location = new System.Drawing.Point(592, 105);
            this.grFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grFilter.Name = "grFilter";
            this.grFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grFilter.Size = new System.Drawing.Size(258, 71);
            this.grFilter.TabIndex = 41;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter";
            // 
            // numCatFilter
            // 
            this.numCatFilter.Location = new System.Drawing.Point(91, 24);
            this.numCatFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCatFilter.Name = "numCatFilter";
            this.numCatFilter.Size = new System.Drawing.Size(155, 27);
            this.numCatFilter.TabIndex = 19;
            // 
            // lbSearchCountry
            // 
            this.lbSearchCountry.AutoSize = true;
            this.lbSearchCountry.Location = new System.Drawing.Point(25, 39);
            this.lbSearchCountry.Name = "lbSearchCountry";
            this.lbSearchCountry.Size = new System.Drawing.Size(69, 20);
            this.lbSearchCountry.TabIndex = 18;
            this.lbSearchCountry.Text = "Category";
            // 
            // rbByName
            // 
            this.rbByName.AutoSize = true;
            this.rbByName.Checked = true;
            this.rbByName.Location = new System.Drawing.Point(373, 29);
            this.rbByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(90, 24);
            this.rbByName.TabIndex = 23;
            this.rbByName.TabStop = true;
            this.rbByName.Text = "By Name";
            this.rbByName.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(43, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(314, 27);
            this.txtSearch.TabIndex = 17;
            // 
            // rbByCatID
            // 
            this.rbByCatID.AutoSize = true;
            this.rbByCatID.Location = new System.Drawing.Point(373, 63);
            this.rbByCatID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbByCatID.Name = "rbByCatID";
            this.rbByCatID.Size = new System.Drawing.Size(87, 24);
            this.rbByCatID.TabIndex = 24;
            this.rbByCatID.Text = "By CatID";
            this.rbByCatID.UseVisualStyleBackColor = true;
            // 
            // rbByProviderID
            // 
            this.rbByProviderID.AutoSize = true;
            this.rbByProviderID.Location = new System.Drawing.Point(454, 63);
            this.rbByProviderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbByProviderID.Name = "rbByProviderID";
            this.rbByProviderID.Size = new System.Drawing.Size(120, 24);
            this.rbByProviderID.TabIndex = 26;
            this.rbByProviderID.Text = "By ProviderID";
            this.rbByProviderID.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 31);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "🔎";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.productBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 232);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(835, 379);
            this.dataGridView.TabIndex = 19;
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.rbByProviderID);
            this.grSearch.Controls.Add(this.rbByID);
            this.grSearch.Controls.Add(this.rbByCatID);
            this.grSearch.Controls.Add(this.rbByName);
            this.grSearch.Controls.Add(this.txtSearch);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Location = new System.Drawing.Point(15, 105);
            this.grSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSearch.Name = "grSearch";
            this.grSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSearch.Size = new System.Drawing.Size(570, 111);
            this.grSearch.TabIndex = 40;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // rbByID
            // 
            this.rbByID.AutoSize = true;
            this.rbByID.Location = new System.Drawing.Point(454, 29);
            this.rbByID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbByID.Name = "rbByID";
            this.rbByID.Size = new System.Drawing.Size(65, 24);
            this.rbByID.TabIndex = 25;
            this.rbByID.Text = "By ID";
            this.rbByID.UseVisualStyleBackColor = true;
            // 
            // cboProductID
            // 
            this.cboProductID.DataSource = this.productBindingSource;
            this.cboProductID.DisplayMember = "Id";
            this.cboProductID.Location = new System.Drawing.Point(714, 60);
            this.cboProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProductID.Name = "cboProductID";
            this.cboProductID.Size = new System.Drawing.Size(115, 28);
            this.cboProductID.TabIndex = 42;
            this.cboProductID.ValueMember = "Id";
            // 
            // grActions
            // 
            this.grActions.Controls.Add(this.label5);
            this.grActions.Controls.Add(this.txtProviderID);
            this.grActions.Controls.Add(this.cboProductID);
            this.grActions.Controls.Add(this.btnAdd);
            this.grActions.Controls.Add(this.btnDelete);
            this.grActions.Controls.Add(this.txtPrice);
            this.grActions.Controls.Add(this.txtProductName);
            this.grActions.Controls.Add(this.btnUpdate);
            this.grActions.Controls.Add(this.label1);
            this.grActions.Controls.Add(this.txtCategoryId);
            this.grActions.Controls.Add(this.txtInStock);
            this.grActions.Location = new System.Drawing.Point(14, -3);
            this.grActions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grActions.Name = "grActions";
            this.grActions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grActions.Size = new System.Drawing.Size(837, 104);
            this.grActions.TabIndex = 43;
            this.grActions.TabStop = false;
            this.grActions.Text = "Actions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(483, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Provider ID";
            // 
            // txtProviderID
            // 
            this.txtProviderID.Location = new System.Drawing.Point(589, 21);
            this.txtProviderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProviderID.Name = "txtProviderID";
            this.txtProviderID.Size = new System.Drawing.Size(114, 27);
            this.txtProviderID.TabIndex = 43;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(377, 623);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 667);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.grActions);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCatFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.grActions.ResumeLayout(false);
            this.grActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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