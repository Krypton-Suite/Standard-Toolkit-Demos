
namespace KryptonScrollBars
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
            this.knudHorizontal = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.knudVertical = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ksbHorizontal = new Krypton.Toolkit.KryptonScrollBar();
            this.ksbVertical = new Krypton.Toolkit.KryptonScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.knudHorizontal);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.knudVertical);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.ksbHorizontal);
            this.kryptonPanel1.Controls.Add(this.ksbVertical);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(417, 266);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // knudHorizontal
            // 
            this.knudHorizontal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudHorizontal.Location = new System.Drawing.Point(225, 116);
            this.knudHorizontal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.knudHorizontal.Size = new System.Drawing.Size(160, 26);
            this.knudHorizontal.TabIndex = 6;
            this.knudHorizontal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudHorizontal.ValueChanged += new System.EventHandler(this.knudHorizontal_ValueChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(69, 116);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(137, 26);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Horizontal Value:";
            // 
            // knudVertical
            // 
            this.knudVertical.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudVertical.Location = new System.Drawing.Point(225, 66);
            this.knudVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.knudVertical.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knudVertical.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudVertical.Name = "knudVertical";
            this.knudVertical.Size = new System.Drawing.Size(160, 26);
            this.knudVertical.TabIndex = 4;
            this.knudVertical.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudVertical.ValueChanged += new System.EventHandler(this.knudVertical_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(69, 66);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(116, 26);
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Vertical Value:";
            // 
            // ksbHorizontal
            // 
            this.ksbHorizontal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(140)))), ((int)(((byte)(201)))));
            this.ksbHorizontal.DisabledBorderColor = System.Drawing.Color.Gray;
            this.ksbHorizontal.Location = new System.Drawing.Point(49, 15);
            this.ksbHorizontal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ksbHorizontal.Name = "ksbHorizontal";
            this.ksbHorizontal.Opacity = 1D;
            this.ksbHorizontal.Orientation = Krypton.Toolkit.ScrollBarOrientation.Horizontal;
            this.ksbHorizontal.ScrollBarWidth = 336;
            this.ksbHorizontal.Size = new System.Drawing.Size(336, 23);
            this.ksbHorizontal.TabIndex = 2;
            this.ksbHorizontal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ksbHorizontal_Scroll);
            // 
            // ksbVertical
            // 
            this.ksbVertical.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(140)))), ((int)(((byte)(201)))));
            this.ksbVertical.DisabledBorderColor = System.Drawing.Color.Gray;
            this.ksbVertical.Location = new System.Drawing.Point(16, 15);
            this.ksbVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ksbVertical.Name = "ksbVertical";
            this.ksbVertical.Opacity = 1D;
            this.ksbVertical.ScrollBarWidth = 25;
            this.ksbVertical.Size = new System.Drawing.Size(25, 246);
            this.ksbVertical.TabIndex = 1;
            this.ksbVertical.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ksbVertical_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 266);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton ScrollBars";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonNumericUpDown knudHorizontal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonNumericUpDown knudVertical;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonScrollBar ksbHorizontal;
        private Krypton.Toolkit.KryptonScrollBar ksbVertical;
    }
}

