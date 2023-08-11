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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(522, 165);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 42;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(354, 165);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 41;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(182, 165);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 40;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboSearchCity);
            grFilter.Controls.Add(lbSearchCity);
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new Point(473, 218);
            grFilter.Margin = new Padding(3, 4, 3, 4);
            grFilter.Name = "grFilter";
            grFilter.Padding = new Padding(3, 4, 3, 4);
            grFilter.Size = new Size(297, 112);
            grFilter.TabIndex = 39;
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
            lbSearchCity.Location = new Point(22, 75);
            lbSearchCity.Name = "lbSearchCity";
            lbSearchCity.Size = new Size(62, 20);
            lbSearchCity.TabIndex = 19;
            lbSearchCity.Text = "Address";
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
            lbSearchCountry.Location = new Point(22, 30);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new Size(50, 20);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Phone";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new Point(60, 218);
            grSearch.Margin = new Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new Padding(3, 4, 3, 4);
            grSearch.Size = new Size(330, 119);
            grSearch.TabIndex = 38;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(240, 71);
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
            radioByID.Location = new Point(240, 31);
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
            lbSearch.Location = new Point(27, 30);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(544, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 27);
            textBox4.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(544, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 27);
            textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 27);
            textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(464, 103);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 33;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(464, 28);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 32;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(60, 103);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 31;
            label2.Text = "Provider Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(60, 25);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 30;
            label1.Text = "Provider ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(759, 220);
            dataGridView1.TabIndex = 29;
            // 
            // frmProviderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 619);
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
            Name = "frmProviderManagement";
            Text = "frmProviderManagement";
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}