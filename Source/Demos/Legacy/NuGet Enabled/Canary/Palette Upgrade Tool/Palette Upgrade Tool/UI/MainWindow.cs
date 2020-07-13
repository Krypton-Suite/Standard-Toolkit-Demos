using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaletteUpgradeTool.UI
{
    public class MainWindow : KryptonForm
    {
        private KryptonPanel kpnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KryptonLabel kryptonLabel1;
        private KryptonLabel kryptonLabel2;
        private KryptonRichTextBox kryptonRichTextBox1;
        private KryptonButton kbtnClose;
        private KryptonLabel klblInformation;
        private KryptonRichTextBox krtbOutputFile;
        private KryptonLabel kryptonLabel3;
        private KryptonButton kbtnExport;
        private KryptonButton kbtnUpgrade;
        private KryptonButton kryptonButton1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kpnlTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.krtbOutputFile = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblInformation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnUpgrade = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlTop)).BeginInit();
            this.kpnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlTop
            // 
            this.kpnlTop.Controls.Add(this.pictureBox1);
            this.kpnlTop.Controls.Add(this.kryptonLabel1);
            this.kpnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlTop.Location = new System.Drawing.Point(0, 0);
            this.kpnlTop.Name = "kpnlTop";
            this.kpnlTop.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlCustom1;
            this.kpnlTop.Size = new System.Drawing.Size(777, 91);
            this.kpnlTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::PaletteUpgradeTool.Properties.Resources.Square_Design_64_x_64_New_Green;
            this.pictureBox1.Location = new System.Drawing.Point(667, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 51);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(177, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Palette Upgrade Tool";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnExport);
            this.kryptonPanel1.Controls.Add(this.kbtnUpgrade);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.klblInformation);
            this.kryptonPanel1.Controls.Add(this.krtbOutputFile);
            this.kryptonPanel1.Controls.Add(this.kryptonRichTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 91);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(777, 332);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(80, 24);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel2.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Input File";
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnClose.Location = new System.Drawing.Point(675, 295);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 25);
            this.kbtnClose.TabIndex = 4;
            this.kbtnClose.Values.Text = "&Close";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(12, 46);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(654, 93);
            this.kryptonRichTextBox1.TabIndex = 5;
            this.kryptonRichTextBox1.Text = "kryptonRichTextBox1";
            // 
            // krtbOutputFile
            // 
            this.krtbOutputFile.Location = new System.Drawing.Point(12, 175);
            this.krtbOutputFile.Name = "krtbOutputFile";
            this.krtbOutputFile.ReadOnly = true;
            this.krtbOutputFile.Size = new System.Drawing.Size(654, 93);
            this.krtbOutputFile.TabIndex = 7;
            this.krtbOutputFile.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 145);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(93, 24);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel3.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Output File";
            // 
            // klblInformation
            // 
            this.klblInformation.Location = new System.Drawing.Point(12, 295);
            this.klblInformation.Name = "klblInformation";
            this.klblInformation.Size = new System.Drawing.Size(195, 24);
            this.klblInformation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblInformation.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.klblInformation.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.klblInformation.TabIndex = 8;
            this.klblInformation.Values.Text = "This will be informative...";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(675, 73);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Values.Text = "&Load File...";
            // 
            // kbtnUpgrade
            // 
            this.kbtnUpgrade.Enabled = false;
            this.kbtnUpgrade.Location = new System.Drawing.Point(675, 188);
            this.kbtnUpgrade.Name = "kbtnUpgrade";
            this.kbtnUpgrade.Size = new System.Drawing.Size(90, 25);
            this.kbtnUpgrade.TabIndex = 10;
            this.kbtnUpgrade.Values.Text = "&Upgrade";
            // 
            // kbtnExport
            // 
            this.kbtnExport.Enabled = false;
            this.kbtnExport.Location = new System.Drawing.Point(675, 229);
            this.kbtnExport.Name = "kbtnExport";
            this.kbtnExport.Size = new System.Drawing.Size(90, 25);
            this.kbtnExport.TabIndex = 11;
            this.kbtnExport.Values.Text = "E&xport";
            // 
            // MainWindow
            // 
            this.CancelButton = this.kbtnClose;
            this.ClientSize = new System.Drawing.Size(777, 423);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kpnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlTop)).EndInit();
            this.kpnlTop.ResumeLayout(false);
            this.kpnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}