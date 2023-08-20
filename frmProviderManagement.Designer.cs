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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grFilter = new System.Windows.Forms.GroupBox();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.lbSearchCity = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lbSearchCountry = new System.Windows.Forms.Label();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.radioByName = new System.Windows.Forms.RadioButton();
            this.radioByID = new System.Windows.Forms.RadioButton();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.txtProviderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.grFilter.SuspendLayout();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(457, 124);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(310, 124);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 22);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(159, 124);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 22);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // grFilter
            // 
            this.grFilter.Controls.Add(this.cboAddress);
            this.grFilter.Controls.Add(this.lbSearchCity);
            this.grFilter.Controls.Add(this.cboCountry);
            this.grFilter.Controls.Add(this.lbSearchCountry);
            this.grFilter.Location = new System.Drawing.Point(414, 164);
            this.grFilter.Name = "grFilter";
            this.grFilter.Size = new System.Drawing.Size(260, 84);
            this.grFilter.TabIndex = 39;
            this.grFilter.TabStop = false;
            this.grFilter.Text = "Filter";
            // 
            // cboAddress
            // 
            this.cboAddress.Location = new System.Drawing.Point(77, 55);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(165, 23);
            this.cboAddress.TabIndex = 20;
            // 
            // lbSearchCity
            // 
            this.lbSearchCity.AutoSize = true;
            this.lbSearchCity.Location = new System.Drawing.Point(19, 56);
            this.lbSearchCity.Name = "lbSearchCity";
            this.lbSearchCity.Size = new System.Drawing.Size(49, 15);
            this.lbSearchCity.TabIndex = 19;
            this.lbSearchCity.Text = "Address";
            // 
            // cboCountry
            // 
            this.cboCountry.Location = new System.Drawing.Point(77, 20);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(165, 23);
            this.cboCountry.TabIndex = 0;
            // 
            // lbSearchCountry
            // 
            this.lbSearchCountry.AutoSize = true;
            this.lbSearchCountry.Location = new System.Drawing.Point(19, 22);
            this.lbSearchCountry.Name = "lbSearchCountry";
            this.lbSearchCountry.Size = new System.Drawing.Size(41, 15);
            this.lbSearchCountry.TabIndex = 18;
            this.lbSearchCountry.Text = "Phone";
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.radioByName);
            this.grSearch.Controls.Add(this.radioByID);
            this.grSearch.Controls.Add(this.txtSearchValue);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.lbSearch);
            this.grSearch.Location = new System.Drawing.Point(52, 164);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(302, 89);
            this.grSearch.TabIndex = 38;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search";
            // 
            // radioByName
            // 
            this.radioByName.AutoSize = true;
            this.radioByName.Checked = true;
            this.radioByName.Location = new System.Drawing.Point(210, 53);
            this.radioByName.Name = "radioByName";
            this.radioByName.Size = new System.Drawing.Size(83, 19);
            this.radioByName.TabIndex = 23;
            this.radioByName.TabStop = true;
            this.radioByName.Text = "By Address";
            this.radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            this.radioByID.AutoSize = true;
            this.radioByID.Location = new System.Drawing.Point(210, 23);
            this.radioByID.Name = "radioByID";
            this.radioByID.Size = new System.Drawing.Size(73, 19);
            this.radioByID.TabIndex = 22;
            this.radioByID.TabStop = true;
            this.radioByID.Text = "By Name";
            this.radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(72, 21);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(118, 23);
            this.txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(72, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(24, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(42, 15);
            this.lbSearch.TabIndex = 16;
            this.lbSearch.Text = "Search";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(476, 72);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 23);
            this.txtAddress.TabIndex = 37;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(476, 19);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 23);
            this.txtPhone.TabIndex = 36;
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(158, 75);
            this.txtProviderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(206, 23);
            this.txtProviderName.TabIndex = 35;
            // 
            // txtProviderID
            // 
            this.txtProviderID.Location = new System.Drawing.Point(159, 19);
            this.txtProviderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProviderID.Name = "txtProviderID";
            this.txtProviderID.Size = new System.Drawing.Size(206, 23);
            this.txtProviderID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(406, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(406, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Provider Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Provider ID:";
            // 
            // dgvProvider
            // 
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Location = new System.Drawing.Point(37, 280);
            this.dgvProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.RowHeadersWidth = 51;
            this.dgvProvider.RowTemplate.Height = 29;
            this.dgvProvider.Size = new System.Drawing.Size(664, 165);
            this.dgvProvider.TabIndex = 29;
            // 
            // frmProviderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 464);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grFilter);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtProviderName);
            this.Controls.Add(this.txtProviderID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProvider);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProviderManagement";
            this.Text = "Provider Management";
            this.grFilter.ResumeLayout(false);
            this.grFilter.PerformLayout();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grFilter;
        private ComboBox cboAddress;
        private Label lbSearchCity;
        private ComboBox cboCountry;
        private Label lbSearchCountry;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtProviderName;
        private TextBox txtProviderID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvProvider;
    }
}