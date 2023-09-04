
namespace KryptonScrollbarExamples
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonProgressBar2 = new Krypton.Toolkit.KryptonProgressBar();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            this.kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            this.progressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            this.pbVertical = new Krypton.Toolkit.KryptonProgressBar();
            this.pbHorizontal = new Krypton.Toolkit.KryptonProgressBar();
            this.knudHorizontal = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.kryptonProgressBarToolStripItem1 = new Krypton.Toolkit.KryptonProgressBarToolStripItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonProgressBar2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonThemeComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonProgressBar1);
            this.kryptonPanel1.Controls.Add(this.progressBar1);
            this.kryptonPanel1.Controls.Add(this.pbVertical);
            this.kryptonPanel1.Controls.Add(this.pbHorizontal);
            this.kryptonPanel1.Controls.Add(this.knudHorizontal);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(404, 319);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonProgressBar2
            // 
            this.kryptonProgressBar2.CornerRoundingRadius = 10F;
            this.kryptonProgressBar2.Enabled = false;
            this.kryptonProgressBar2.Location = new System.Drawing.Point(39, 203);
            this.kryptonProgressBar2.Name = "kryptonProgressBar2";
            this.kryptonProgressBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonProgressBar2.Size = new System.Drawing.Size(353, 23);
            this.kryptonProgressBar2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonProgressBar2.StateCommon.Border.Rounding = 10F;
            this.kryptonProgressBar2.TabIndex = 12;
            this.kryptonProgressBar2.Text = "Disabled";
            this.kryptonProgressBar2.Value = 56;
            this.kryptonProgressBar2.Values.Text = "Disabled";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.CornerRoundingRadius = 10F;
            this.kryptonButton1.Location = new System.Drawing.Point(39, 255);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(353, 20);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.TabIndex = 11;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonThemeComboBox1
            // 
            this.kryptonThemeComboBox1.DisplayMember = "Key";
            this.kryptonThemeComboBox1.DropDownWidth = 321;
            this.kryptonThemeComboBox1.IntegralHeight = false;
            this.kryptonThemeComboBox1.Location = new System.Drawing.Point(161, 3);
            this.kryptonThemeComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            this.kryptonThemeComboBox1.Size = new System.Drawing.Size(241, 21);
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonThemeComboBox1.TabIndex = 10;
            this.kryptonThemeComboBox1.ValueMember = "Value";
            // 
            // kryptonProgressBar1
            // 
            this.kryptonProgressBar1.Location = new System.Drawing.Point(10, 10);
            this.kryptonProgressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonProgressBar1.Name = "kryptonProgressBar1";
            this.kryptonProgressBar1.Orientation = Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonProgressBar1.Size = new System.Drawing.Size(24, 266);
            this.kryptonProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.kryptonProgressBar1.TabIndex = 9;
            this.kryptonProgressBar1.Values.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.CornerRoundingRadius = 10F;
            this.progressBar1.Location = new System.Drawing.Point(39, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(353, 23);
            this.progressBar1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.progressBar1.StateCommon.Border.Rounding = 10F;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 56;
            this.progressBar1.Values.Text = "";
            // 
            // pbVertical
            // 
            this.pbVertical.Location = new System.Drawing.Point(39, 130);
            this.pbVertical.Name = "pbVertical";
            this.pbVertical.Size = new System.Drawing.Size(353, 23);
            this.pbVertical.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pbVertical.TabIndex = 7;
            this.pbVertical.Value = 56;
            this.pbVertical.Values.Text = "";
            // 
            // pbHorizontal
            // 
            this.pbHorizontal.Location = new System.Drawing.Point(39, 79);
            this.pbHorizontal.Name = "pbHorizontal";
            this.pbHorizontal.Size = new System.Drawing.Size(353, 45);
            this.pbHorizontal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbHorizontal.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            this.pbHorizontal.TabIndex = 4;
            this.pbHorizontal.Text = "10";
            this.pbHorizontal.Values.ExtraText = "of 100";
            this.pbHorizontal.Values.Text = "10";
            // 
            // knudHorizontal
            // 
            this.knudHorizontal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudHorizontal.Location = new System.Drawing.Point(161, 39);
            this.knudHorizontal.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knudHorizontal.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudHorizontal.Name = "knudHorizontal";
            this.knudHorizontal.Size = new System.Drawing.Size(120, 22);
            this.knudHorizontal.TabIndex = 3;
            this.knudHorizontal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudHorizontal.ValueChanged += new System.EventHandler(this.knudHorizontal_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(39, 39);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Value:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kryptonProgressBarToolStripItem1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(404, 28);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // kryptonProgressBarToolStripItem1
            // 
            this.kryptonProgressBarToolStripItem1.Name = "kryptonProgressBarToolStripItem1";
            this.kryptonProgressBarToolStripItem1.Size = new System.Drawing.Size(100, 26);
            this.kryptonProgressBarToolStripItem1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonProgressBarToolStripItem1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBarToolStripItem1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBarToolStripItem1.Values.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 319);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton ProgressBar Examples";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonProgressBar pbVertical;
        private Krypton.Toolkit.KryptonProgressBar pbHorizontal;
        private Krypton.Toolkit.KryptonNumericUpDown knudHorizontal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonProgressBar progressBar1;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Krypton.Toolkit.KryptonProgressBarToolStripItem kryptonProgressBarToolStripItem1;
    }
}

