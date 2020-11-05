using Krypton.Toolkit;
using KryptonExplorer.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;

namespace KryptonExplorer
{
    public class ThemeFileLocator : KryptonForm
    {
        #region Design Code
        private KryptonButton kbtnOk;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnBrowsePath;
        private KryptonTextBox ktxtPath;
        private KryptonLabel kryptonLabel1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnBrowsePath = new Krypton.Toolkit.KryptonButton();
            this.ktxtPath = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 69);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(620, 41);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnOk
            // 
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(518, 9);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 25);
            this.kbtnOk.TabIndex = 0;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnBrowsePath);
            this.kryptonPanel2.Controls.Add(this.ktxtPath);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(620, 66);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kbtnBrowsePath
            // 
            this.kbtnBrowsePath.Location = new System.Drawing.Point(575, 24);
            this.kbtnBrowsePath.Name = "kbtnBrowsePath";
            this.kbtnBrowsePath.Size = new System.Drawing.Size(33, 25);
            this.kbtnBrowsePath.TabIndex = 3;
            this.kbtnBrowsePath.Values.Text = ".&..";
            this.kbtnBrowsePath.Click += new System.EventHandler(this.kbtnBrowsePath_Click);
            // 
            // ktxtPath
            // 
            this.ktxtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ktxtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ktxtPath.Location = new System.Drawing.Point(149, 23);
            this.ktxtPath.Name = "ktxtPath";
            this.ktxtPath.Size = new System.Drawing.Size(420, 23);
            this.ktxtPath.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(131, 20);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Theme Directory Path:";
            // 
            // ThemeFileLocator
            // 
            this.ClientSize = new System.Drawing.Size(620, 110);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemeFileLocator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse for Theme Files";
            this.Load += new System.EventHandler(this.ThemeFileLocator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        public ThemeFileLocator()
        {
            InitializeComponent();
        }

        private void ThemeFileLocator_Load(object sender, EventArgs e)
        {

        }

        private void kbtnBrowsePath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog ofd = new CommonOpenFileDialog();

            ofd.Title = "Browse for theme files:";

            ofd.IsFolderPicker = true;

            if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtPath.Text = Path.GetFullPath(ofd.FileName);
            }
            
            TopMost = true;
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            Settings mySettings = new Settings();

            if (string.IsNullOrEmpty(ktxtPath.Text))
            {
                mySettings.ThemeFileLocation = string.Empty;
            }
            else
            {
                mySettings.ThemeFileLocation = ktxtPath.Text;
            }

            mySettings.Save();

            Hide();
        }
    }
}