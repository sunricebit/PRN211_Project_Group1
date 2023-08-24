namespace PRN211_Project_Group1
{
    partial class Main
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
            labelname = new Label();
            btnProducts = new Button();
            btnCategories = new Button();
            btnProvider = new Button();
            btnHistory = new Button();
            btnAdmin = new Button();
            groupBox1 = new GroupBox();
            btnLogout = new Button();
            grOther = new GroupBox();
            groupBox1.SuspendLayout();
            grOther.SuspendLayout();
            SuspendLayout();
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(64, 32);
            labelname.Name = "labelname";
            labelname.Size = new Size(38, 15);
            labelname.TabIndex = 0;
            labelname.Text = "label1";
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(16, 22);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(121, 37);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(16, 73);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(121, 37);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Manage Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProvider
            // 
            btnProvider.Location = new Point(148, 22);
            btnProvider.Name = "btnProvider";
            btnProvider.Size = new Size(121, 37);
            btnProvider.TabIndex = 3;
            btnProvider.Text = "Manage Provider";
            btnProvider.UseVisualStyleBackColor = true;
            btnProvider.Click += btnProvider_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(148, 73);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(121, 37);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "View History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(32, 22);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(121, 38);
            btnAdmin.TabIndex = 6;
            btnAdmin.Text = "Manage Accounts";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdmin);
            groupBox1.Location = new Point(111, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 79);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin only";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(165, 287);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // grOther
            // 
            grOther.Controls.Add(btnProvider);
            grOther.Controls.Add(btnCategories);
            grOther.Controls.Add(btnHistory);
            grOther.Controls.Add(btnProducts);
            grOther.Location = new Point(64, 61);
            grOther.Name = "grOther";
            grOther.Size = new Size(298, 122);
            grOther.TabIndex = 9;
            grOther.TabStop = false;
            grOther.Text = "Manager/Member Only";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 322);
            Controls.Add(btnLogout);
            Controls.Add(labelname);
            Controls.Add(groupBox1);
            Controls.Add(grOther);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            groupBox1.ResumeLayout(false);
            grOther.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelname;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnProvider;
        private Button btnHistory;
        private Button btnAdmin;
        private GroupBox groupBox1;
        private Button btnLogout;
        private GroupBox grOther;
    }
}