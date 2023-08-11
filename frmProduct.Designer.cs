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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(329, 351);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 25;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(187, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(42, 351);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 23;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 27);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(42, 264);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 18;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(42, 191);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 17;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(42, 113);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 16;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(42, 41);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 15;
            label1.Text = "Product ID:";
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 452);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProduct";
            Text = "frmProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}