
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
            this.kchkElevateProcess = new Krypton.Toolkit.KryptonCheckBox();
            this.kbtnRun = new Krypton.Toolkit.KryptonButton();
            this.kbtnBrowse = new Krypton.Toolkit.KryptonButton();
            this.ktxtProcessPath = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kchkElevateProcess);
            this.kryptonPanel1.Controls.Add(this.kbtnRun);
            this.kryptonPanel1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel1.Controls.Add(this.ktxtProcessPath);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(461, 98);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kchkElevateProcess
            // 
            this.kchkElevateProcess.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.kchkElevateProcess.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kchkElevateProcess.Location = new System.Drawing.Point(241, 58);
            this.kchkElevateProcess.Name = "kchkElevateProcess";
            this.kchkElevateProcess.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kchkElevateProcess.Size = new System.Drawing.Size(107, 20);
            this.kchkElevateProcess.TabIndex = 4;
            this.kchkElevateProcess.Values.Text = "&Elevate Process";
            this.kchkElevateProcess.CheckedChanged += new System.EventHandler(this.kchkElevateProcess_CheckedChanged);
            // 
            // kbtnRun
            // 
            this.kbtnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kbtnRun.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kbtnRun.Location = new System.Drawing.Point(120, 54);
            this.kbtnRun.Name = "kbtnRun";
            this.kbtnRun.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kbtnRun.Size = new System.Drawing.Size(114, 25);
            this.kbtnRun.TabIndex = 3;
            this.kbtnRun.Values.Text = "&Run";
            this.kbtnRun.Click += new System.EventHandler(this.kbtnRun_Click);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kbtnBrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kbtnBrowse.Location = new System.Drawing.Point(419, 24);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kbtnBrowse.Size = new System.Drawing.Size(27, 25);
            this.kbtnBrowse.TabIndex = 2;
            this.kbtnBrowse.Values.Text = "...";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // ktxtProcessPath
            // 
            this.ktxtProcessPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktxtProcessPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktxtProcessPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ktxtProcessPath.Location = new System.Drawing.Point(120, 24);
            this.ktxtProcessPath.Name = "ktxtProcessPath";
            this.ktxtProcessPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktxtProcessPath.Size = new System.Drawing.Size(293, 23);
            this.ktxtProcessPath.TabIndex = 1;
            this.ktxtProcessPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ktxtProcessPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ktxtProcessPath_KeyDown);
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
        private Krypton.Toolkit.KryptonCheckBox kchkElevateProcess;
        private Krypton.Toolkit.KryptonButton kbtnRun;
        private Krypton.Toolkit.KryptonButton kbtnBrowse;
        private Krypton.Toolkit.KryptonTextBox ktxtProcessPath;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

