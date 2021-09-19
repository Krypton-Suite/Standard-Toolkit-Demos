
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
            this.kbtnBrowse = new Krypton.Toolkit.KryptonButton();
            this.ktxtProcessPath = new Krypton.Toolkit.KryptonTextBox();
            this.kbtnRun = new Krypton.Toolkit.KryptonButton();
            this.kchkShowShield = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.ktxtProcessPath);
            this.kryptonPanel1.Controls.Add(this.kbtnRun);
            this.kryptonPanel1.Controls.Add(this.kchkShowShield);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(461, 98);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Location = new System.Drawing.Point(422, 25);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Size = new System.Drawing.Size(27, 25);
            this.kbtnBrowse.TabIndex = 7;
            this.kbtnBrowse.Values.Text = ".&..";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // ktxtProcessPath
            // 
            this.ktxtProcessPath.Location = new System.Drawing.Point(120, 25);
            this.ktxtProcessPath.Name = "ktxtProcessPath";
            this.ktxtProcessPath.Size = new System.Drawing.Size(296, 23);
            this.ktxtProcessPath.TabIndex = 6;
            // 
            // kbtnRun
            // 
            this.kbtnRun.Location = new System.Drawing.Point(145, 58);
            this.kbtnRun.Name = "kbtnRun";
            this.kbtnRun.Size = new System.Drawing.Size(90, 25);
            this.kbtnRun.TabIndex = 5;
            this.kbtnRun.Values.Text = "&Run";
            this.kbtnRun.Click += new System.EventHandler(this.kbtnRun_Click);
            // 
            // kchkShowShield
            // 
            this.kchkShowShield.Location = new System.Drawing.Point(241, 58);
            this.kchkShowShield.Name = "kchkShowShield";
            this.kchkShowShield.Size = new System.Drawing.Size(90, 20);
            this.kchkShowShield.TabIndex = 4;
            this.kchkShowShield.Values.Text = "&Show Shield";
            this.kchkShowShield.CheckedChanged += new System.EventHandler(this.kchkShowShield_CheckedChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 25);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(100, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Process to Run:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 98);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton UAC Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCheckBox kchkShowShield;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox ktxtProcessPath;
        private Krypton.Toolkit.KryptonButton kbtnRun;
        private Krypton.Toolkit.KryptonButton kbtnBrowse;
    }
}

