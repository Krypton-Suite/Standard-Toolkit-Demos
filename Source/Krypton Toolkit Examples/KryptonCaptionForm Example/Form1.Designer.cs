namespace KryptonCaptionFormExample
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
            Krypton.Toolkit.KryptonFormCaptionItem kryptonFormCaptionItem1 = new Krypton.Toolkit.KryptonFormCaptionItem();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.Location = new System.Drawing.Point(8, 8);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(75, 22);
            this.kryptonComboBox1.TabIndex = 1;
            this.kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(16, 16);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox1.TabIndex = 2;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox2.TabIndex = 4;
            this.kryptonTextBox2.Text = "kryptonTextBox2";
            this.kryptonTextBox2.TextChanged += new System.EventHandler(this.kryptonTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            kryptonFormCaptionItem1.Control = this.kryptonTextBox2;
            this.CaptionItems.AddRange(new Krypton.Toolkit.KryptonFormCaptionItem[] {
            kryptonFormCaptionItem1});
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonTextBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KryptonButton kryptonButton1;
        private KryptonComboBox kryptonComboBox1;
        private KryptonTextBox kryptonTextBox1;
        private KryptonTextBox kryptonTextBox2;
    }
}