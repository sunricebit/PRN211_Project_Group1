namespace Project
{
    partial class frmProduct
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
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtProductName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            txtNote = new RichTextBox();
            label5 = new Label();
            txtProviderID = new TextBox();
            label1 = new Label();
            txtCategoryId = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(135, 186);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(206, 23);
            txtPrice.TabIndex = 22;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(135, 65);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(206, 23);
            txtQuantity.TabIndex = 21;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(135, 25);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(206, 23);
            txtProductName.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(37, 188);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 18;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(37, 67);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 17;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(37, 28);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 16;
            label2.Text = "Product Name:";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(259, 325);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 24;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(135, 325);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 23;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(135, 224);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(206, 67);
            txtNote.TabIndex = 25;
            txtNote.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(37, 227);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 26;
            label5.Text = "Note";
            // 
            // txtProviderID
            // 
            txtProviderID.Location = new Point(135, 105);
            txtProviderID.Name = "txtProviderID";
            txtProviderID.Size = new Size(206, 23);
            txtProviderID.TabIndex = 45;
            // 
            // txtProviderID
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(37, 108);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 46;
            label1.Text = "Provider ID:";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(135, 145);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(206, 23);
            txtCategoryId.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(37, 148);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 49;
            label6.Text = "Category ID:";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 364);
            Controls.Add(label6);
            Controls.Add(txtCategoryId);
            Controls.Add(label1);
            Controls.Add(txtProviderID);
            Controls.Add(label5);
            Controls.Add(txtNote);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += frmProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtProductName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private Button btnSave;
        private RichTextBox txtNote;
        private Label label5;
        private TextBox txtProviderID;
        private Label label1;
        private TextBox txtCategoryId;
        private Label label6;
    }
}