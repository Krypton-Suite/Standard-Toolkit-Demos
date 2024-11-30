
namespace KryptonUACButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kchkShowUACShield = new Krypton.Toolkit.KryptonCheckBox();
            this.kbtnTest = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kchkShowUACShield);
            this.kryptonPanel1.Controls.Add(this.kbtnTest);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(457, 44);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kchkShowUACShield
            // 
            this.kchkShowUACShield.Location = new System.Drawing.Point(285, 16);
            this.kchkShowUACShield.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kchkShowUACShield.Name = "kchkShowUACShield";
            this.kchkShowUACShield.Size = new System.Drawing.Size(142, 24);
            this.kchkShowUACShield.TabIndex = 1;
            this.kchkShowUACShield.Values.Text = "&Show UAC Shield";
            this.kchkShowUACShield.CheckedChanged += new System.EventHandler(this.kchkShowUACShield_CheckedChanged);
            // 
            // kbtnTest
            // 
            this.kbtnTest.Location = new System.Drawing.Point(17, 10);
            this.kbtnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kbtnTest.Name = "kbtnTest";
            this.kbtnTest.Size = new System.Drawing.Size(259, 31);
            this.kbtnTest.TabIndex = 0;
            this.kbtnTest.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnTest.Values.Text = "Some Text";
            this.kbtnTest.Click += new System.EventHandler(this.kbtnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 44);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton UAC Demo";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCheckBox kchkShowUACShield;
        private Krypton.Toolkit.KryptonButton kbtnTest;
    }
}

