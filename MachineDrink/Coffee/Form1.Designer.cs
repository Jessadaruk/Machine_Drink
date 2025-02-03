namespace Coffee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBlackCoffee = new Button();
            btnMocca = new Button();
            btnLatta = new Button();
            btnChocolate = new Button();
            btnIncreaseStock = new Button();
            lblBlackCoffeeStock = new Label();
            lblMoccaStock = new Label();
            lblLattaStock = new Label();
            lblChocolateStock = new Label();
            numBlackCoffee = new NumericUpDown();
            numMocca = new NumericUpDown();
            numLatta = new NumericUpDown();
            numChocolate = new NumericUpDown();
            txtWater = new TextBox();
            txtCoffee = new TextBox();
            txtChocolate = new TextBox();
            txtMilk = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numBlackCoffee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMocca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLatta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChocolate).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBlackCoffee
            // 
            btnBlackCoffee.Location = new Point(110, 56);
            btnBlackCoffee.Name = "btnBlackCoffee";
            btnBlackCoffee.Size = new Size(71, 32);
            btnBlackCoffee.TabIndex = 0;
            btnBlackCoffee.Text = "กาแฟดำ";
            btnBlackCoffee.UseVisualStyleBackColor = true;
            btnBlackCoffee.Click += button1_Click;
            // 
            // btnMocca
            // 
            btnMocca.Location = new Point(110, 105);
            btnMocca.Name = "btnMocca";
            btnMocca.Size = new Size(71, 32);
            btnMocca.TabIndex = 1;
            btnMocca.Text = "มอคค่า";
            btnMocca.UseVisualStyleBackColor = true;
            btnMocca.Click += btnMocca_Click;
            // 
            // btnLatta
            // 
            btnLatta.Location = new Point(110, 164);
            btnLatta.Name = "btnLatta";
            btnLatta.Size = new Size(71, 32);
            btnLatta.TabIndex = 2;
            btnLatta.Text = "ลาเต้";
            btnLatta.UseVisualStyleBackColor = true;
            btnLatta.Click += btnLatta_Click;
            // 
            // btnChocolate
            // 
            btnChocolate.Location = new Point(110, 219);
            btnChocolate.Name = "btnChocolate";
            btnChocolate.Size = new Size(71, 32);
            btnChocolate.TabIndex = 3;
            btnChocolate.Text = "ช็อคโกแลต";
            btnChocolate.UseVisualStyleBackColor = true;
            btnChocolate.Click += btnChocolate_Click;
            // 
            // btnIncreaseStock
            // 
            btnIncreaseStock.Location = new Point(205, 320);
            btnIncreaseStock.Name = "btnIncreaseStock";
            btnIncreaseStock.Size = new Size(71, 32);
            btnIncreaseStock.TabIndex = 4;
            btnIncreaseStock.Text = "เพิ่มสต๊อค";
            btnIncreaseStock.UseVisualStyleBackColor = true;
            btnIncreaseStock.Click += btnIncreaseStock_Click;
            // 
            // lblBlackCoffeeStock
            // 
            lblBlackCoffeeStock.AutoSize = true;
            lblBlackCoffeeStock.Location = new Point(223, 65);
            lblBlackCoffeeStock.Name = "lblBlackCoffeeStock";
            lblBlackCoffeeStock.Size = new Size(41, 15);
            lblBlackCoffeeStock.TabIndex = 5;
            lblBlackCoffeeStock.Text = "จำนวณ";
            lblBlackCoffeeStock.Click += label1_Click_1;
            // 
            // lblMoccaStock
            // 
            lblMoccaStock.AutoSize = true;
            lblMoccaStock.Location = new Point(223, 115);
            lblMoccaStock.Name = "lblMoccaStock";
            lblMoccaStock.Size = new Size(41, 15);
            lblMoccaStock.TabIndex = 6;
            lblMoccaStock.Text = "จำนวณ";
            // 
            // lblLattaStock
            // 
            lblLattaStock.AutoSize = true;
            lblLattaStock.Location = new Point(223, 173);
            lblLattaStock.Name = "lblLattaStock";
            lblLattaStock.Size = new Size(41, 15);
            lblLattaStock.TabIndex = 7;
            lblLattaStock.Text = "จำนวณ";
            // 
            // lblChocolateStock
            // 
            lblChocolateStock.AutoSize = true;
            lblChocolateStock.Location = new Point(223, 228);
            lblChocolateStock.Name = "lblChocolateStock";
            lblChocolateStock.Size = new Size(41, 15);
            lblChocolateStock.TabIndex = 8;
            lblChocolateStock.Text = "จำนวณ";
            lblChocolateStock.Click += lblChocolateStock_Click;
            // 
            // numBlackCoffee
            // 
            numBlackCoffee.Location = new Point(38, 57);
            numBlackCoffee.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numBlackCoffee.Name = "numBlackCoffee";
            numBlackCoffee.Size = new Size(39, 23);
            numBlackCoffee.TabIndex = 9;
            numBlackCoffee.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numBlackCoffee.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numMocca
            // 
            numMocca.Location = new Point(38, 105);
            numMocca.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numMocca.Name = "numMocca";
            numMocca.Size = new Size(39, 23);
            numMocca.TabIndex = 10;
            numMocca.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numMocca.ValueChanged += numMocca_ValueChanged;
            // 
            // numLatta
            // 
            numLatta.Location = new Point(38, 164);
            numLatta.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numLatta.Name = "numLatta";
            numLatta.Size = new Size(39, 23);
            numLatta.TabIndex = 11;
            numLatta.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numLatta.ValueChanged += numLatta_ValueChanged;
            // 
            // numChocolate
            // 
            numChocolate.Location = new Point(38, 220);
            numChocolate.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numChocolate.Name = "numChocolate";
            numChocolate.Size = new Size(39, 23);
            numChocolate.TabIndex = 12;
            numChocolate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtWater
            // 
            txtWater.Location = new Point(80, 29);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(100, 23);
            txtWater.TabIndex = 13;
            // 
            // txtCoffee
            // 
            txtCoffee.Location = new Point(80, 71);
            txtCoffee.Name = "txtCoffee";
            txtCoffee.Size = new Size(100, 23);
            txtCoffee.TabIndex = 14;
            txtCoffee.TextChanged += txtCoffee_TextChanged;
            // 
            // txtChocolate
            // 
            txtChocolate.Location = new Point(80, 127);
            txtChocolate.Name = "txtChocolate";
            txtChocolate.Size = new Size(100, 23);
            txtChocolate.TabIndex = 15;
            txtChocolate.TextChanged += txtChocolate_TextChanged;
            // 
            // txtMilk
            // 
            txtMilk.Location = new Point(80, 189);
            txtMilk.Name = "txtMilk";
            txtMilk.Size = new Size(100, 23);
            txtMilk.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Khaki;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtWater);
            groupBox1.Controls.Add(txtCoffee);
            groupBox1.Controls.Add(txtMilk);
            groupBox1.Controls.Add(txtChocolate);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(445, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 228);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "วัตถุดิบ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 192);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 22;
            label4.Text = "นม";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 21;
            label3.Text = "ผงช็อคโกแล็ต";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 20;
            label2.Text = "ผงกาแฟ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 19;
            label1.Text = "น้ำ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 384);
            Controls.Add(groupBox1);
            Controls.Add(numChocolate);
            Controls.Add(numLatta);
            Controls.Add(numMocca);
            Controls.Add(numBlackCoffee);
            Controls.Add(lblChocolateStock);
            Controls.Add(lblLattaStock);
            Controls.Add(lblMoccaStock);
            Controls.Add(lblBlackCoffeeStock);
            Controls.Add(btnIncreaseStock);
            Controls.Add(btnChocolate);
            Controls.Add(btnLatta);
            Controls.Add(btnMocca);
            Controls.Add(btnBlackCoffee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numBlackCoffee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMocca).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLatta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChocolate).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBlackCoffee;
        private Button btnMocca;
        private Button btnLatta;
        private Button btnChocolate;
        private Button btnIncreaseStock;
        private Label lblBlackCoffeeStock;
        private Label lblMoccaStock;
        private Label lblLattaStock;
        private Label lblChocolateStock;
        private NumericUpDown numBlackCoffee;
        private NumericUpDown numMocca;
        private NumericUpDown numLatta;
        private NumericUpDown numChocolate;
        private TextBox txtWater;
        private TextBox txtCoffee;
        private TextBox txtChocolate;
        private TextBox txtMilk;
        private Label lblResult;
        private GroupBox groupBox1;
        private Label textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
