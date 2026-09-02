namespace KryptonBrowserControlExample
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
            this.kryptonBrowserControl1 = new Krypton.Toolkit.Utilities.KryptonBrowserControl();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonBrowserControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonBrowserControl1
            // 
            this.kryptonBrowserControl1.CurrentPath = "C:\\Users\\Peter William Wagner\\OneDrive\\Documents";
            this.kryptonBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBrowserControl1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBrowserControl1.Name = "kryptonBrowserControl1";
            this.kryptonBrowserControl1.Size = new System.Drawing.Size(793, 410);
            this.kryptonBrowserControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 410);
            this.Controls.Add(this.kryptonBrowserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Krypton Browser Control Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonBrowserControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.Utilities.KryptonBrowserControl kryptonBrowserControl1;
    }
}
