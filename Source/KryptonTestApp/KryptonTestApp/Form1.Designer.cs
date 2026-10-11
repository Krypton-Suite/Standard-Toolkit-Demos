namespace KryptonTestApp
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
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.kryptonBreadCrumb1 = new Krypton.Toolkit.KryptonBreadCrumb();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonBreadCrumb1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(297, 145);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.NotificationBar.ActionButtonTexts = new string[] {
        "Update now"};
            this.kryptonRibbon1.SelectedTab = null;
            this.kryptonRibbon1.Size = new System.Drawing.Size(800, 114);
            this.kryptonRibbon1.TabIndex = 2;
            // 
            // kryptonBreadCrumb1
            // 
            this.kryptonBreadCrumb1.Location = new System.Drawing.Point(70, 203);
            this.kryptonBreadCrumb1.Name = "kryptonBreadCrumb1";
            // 
            // 
            // 
            this.kryptonBreadCrumb1.RootItem.ShortText = "Root";
            this.kryptonBreadCrumb1.Size = new System.Drawing.Size(200, 28);
            this.kryptonBreadCrumb1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.CloseBox = false;
            this.Controls.Add(this.kryptonBreadCrumb1);
            this.Controls.Add(this.kryptonRibbon1);
            this.Controls.Add(this.kryptonButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonBreadCrumb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Toolkit.KryptonBreadCrumb kryptonBreadCrumb1;
    }
}
