namespace Lab1.TehnologiiWeb
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.genRandomValBTN = new System.Windows.Forms.Button();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sorteaza = new System.Windows.Forms.Button();
            this.sortMethodComboBox = new System.Windows.Forms.ComboBox();
            this.integerNumberRadio = new System.Windows.Forms.RadioButton();
            this.realNumberRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 0;
            // 
            // genRandomValBTN
            // 
            this.genRandomValBTN.Location = new System.Drawing.Point(292, 71);
            this.genRandomValBTN.Name = "genRandomValBTN";
            this.genRandomValBTN.Size = new System.Drawing.Size(164, 23);
            this.genRandomValBTN.TabIndex = 1;
            this.genRandomValBTN.Text = "Genereaza valori aleatorii";
            this.genRandomValBTN.UseVisualStyleBackColor = true;
            this.genRandomValBTN.Click += new System.EventHandler(this.genRandomValBTN_Click);
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "Crescator",
            "Descrescator"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(151, 12);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortOrderComboBox.TabIndex = 2;
            this.sortOrderComboBox.Text = "crescator";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // Sorteaza
            // 
            this.Sorteaza.AccessibleDescription = "Sorteaza";
            this.Sorteaza.AccessibleName = "Sorteaza";
            this.Sorteaza.Location = new System.Drawing.Point(12, 359);
            this.Sorteaza.Name = "Sorteaza";
            this.Sorteaza.Size = new System.Drawing.Size(156, 23);
            this.Sorteaza.TabIndex = 4;
            this.Sorteaza.Text = "Sorteaza";
            this.Sorteaza.UseVisualStyleBackColor = true;
            this.Sorteaza.Click += new System.EventHandler(this.Sorteaza_Click);
            // 
            // sortMethodComboBox
            // 
            this.sortMethodComboBox.FormattingEnabled = true;
            this.sortMethodComboBox.Items.AddRange(new object[] {
            "Bubble",
            "Insertion",
            "Quick"});
            this.sortMethodComboBox.Location = new System.Drawing.Point(12, 12);
            this.sortMethodComboBox.Name = "sortMethodComboBox";
            this.sortMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortMethodComboBox.TabIndex = 5;
            this.sortMethodComboBox.Text = "Bubble";
            // 
            // integerNumberRadio
            // 
            this.integerNumberRadio.AutoSize = true;
            this.integerNumberRadio.Checked = true;
            this.integerNumberRadio.Location = new System.Drawing.Point(12, 48);
            this.integerNumberRadio.Name = "integerNumberRadio";
            this.integerNumberRadio.Size = new System.Drawing.Size(52, 17);
            this.integerNumberRadio.TabIndex = 6;
            this.integerNumberRadio.TabStop = true;
            this.integerNumberRadio.Text = "Intreg";
            this.integerNumberRadio.UseVisualStyleBackColor = true;
            // 
            // realNumberRadio
            // 
            this.realNumberRadio.AutoSize = true;
            this.realNumberRadio.Location = new System.Drawing.Point(104, 48);
            this.realNumberRadio.Name = "realNumberRadio";
            this.realNumberRadio.Size = new System.Drawing.Size(47, 17);
            this.realNumberRadio.TabIndex = 7;
            this.realNumberRadio.Text = "Real";
            this.realNumberRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.realNumberRadio);
            this.Controls.Add(this.integerNumberRadio);
            this.Controls.Add(this.sortMethodComboBox);
            this.Controls.Add(this.Sorteaza);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sortOrderComboBox);
            this.Controls.Add(this.genRandomValBTN);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button genRandomValBTN;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sorteaza;
        private System.Windows.Forms.ComboBox sortMethodComboBox;
        private System.Windows.Forms.RadioButton integerNumberRadio;
        private System.Windows.Forms.RadioButton realNumberRadio;
    }
}

