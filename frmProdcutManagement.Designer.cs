namespace Project
{
    partial class frmProdcutManagement
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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            grFilter = new GroupBox();
            cboSearchCity = new ComboBox();
            lbSearchCity = new Label();
            cboCountry = new ComboBox();
            lbSearchCountry = new Label();
            grSearch = new GroupBox();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            lbSearch = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 396);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(759, 220);
            dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(463, 123);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 7;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(454, 52);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(47, 127);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 5;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(47, 49);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "Product ID:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(547, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 27);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(547, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 12;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboSearchCity);
            grFilter.Controls.Add(lbSearchCity);
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new Point(463, 248);
            grFilter.Margin = new Padding(3, 4, 3, 4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new Padding(3, 4, 3, 4);
            grFilter.Size = new Size(297, 112);
            grFilter.TabIndex = 25;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // cboSearchCity
            // 
            cboSearchCity.Location = new Point(88, 73);
            cboSearchCity.Margin = new Padding(3, 4, 3, 4);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new Size(188, 28);
            cboSearchCity.TabIndex = 20;
            // 
            // lbSearchCity
            // 
            lbSearchCity.AutoSize = true;
            lbSearchCity.Location = new Point(31, 76);
            lbSearchCity.Name = "lbSearchCity";
            lbSearchCity.Size = new Size(41, 20);
            lbSearchCity.TabIndex = 19;
            lbSearchCity.Text = "Price";
            // 
            // cboCountry
            // 
            cboCountry.Location = new Point(88, 27);
            cboCountry.Margin = new Padding(3, 4, 3, 4);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(188, 28);
            cboCountry.TabIndex = 0;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new Point(22, 29);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new Size(65, 20);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Quantity";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new Point(72, 241);
            grSearch.Margin = new Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new Padding(3, 4, 3, 4);
            grSearch.Size = new Size(330, 119);
            grSearch.TabIndex = 24;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(240, 70);
            radioByName.Margin = new Padding(3, 4, 3, 4);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(90, 24);
            radioByName.TabIndex = 23;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new Point(240, 30);
            radioByID.Margin = new Padding(3, 4, 3, 4);
            radioByID.Name = "radioByID";
            radioByID.Size = new Size(65, 24);
            radioByID.TabIndex = 22;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(82, 28);
            txtSearchValue.Margin = new Padding(3, 4, 3, 4);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(134, 27);
            txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(82, 69);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(27, 29);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(516, 188);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 28;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(358, 188);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 27;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(208, 188);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 26;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmProdcutManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 637);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmProdcutManagement";
            Text = "frmProdcutManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox grFilter;
        private ComboBox cboSearchCity;
        private Label lbSearchCity;
        private ComboBox cboCountry;
        private Label lbSearchCountry;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}