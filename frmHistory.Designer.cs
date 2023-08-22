namespace Project
{
    partial class frmHistory
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
            dgvHistory = new DataGridView();
            btnClose = new Button();
            historyBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quatityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, transactionDateDataGridViewTextBoxColumn, quatityDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn });
            dgvHistory.DataSource = historyBindingSource;
            dgvHistory.Location = new Point(12, 12);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowTemplate.Height = 25;
            dgvHistory.Size = new Size(743, 246);
            dgvHistory.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(336, 264);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // historyBindingSource
            // 
            historyBindingSource.DataSource = typeof(PRN211_Project_Group1.DataAccess.History);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            // 
            // quatityDataGridViewTextBoxColumn
            // 
            quatityDataGridViewTextBoxColumn.DataPropertyName = "Quatity";
            quatityDataGridViewTextBoxColumn.HeaderText = "Quatity";
            quatityDataGridViewTextBoxColumn.Name = "quatityDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "Note";
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 306);
            Controls.Add(btnClose);
            Controls.Add(dgvHistory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHistory";
            Text = "Transaction History";
            Load += frmHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)historyBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistory;
        private Button btnClose;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quatityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private BindingSource historyBindingSource;
    }
}