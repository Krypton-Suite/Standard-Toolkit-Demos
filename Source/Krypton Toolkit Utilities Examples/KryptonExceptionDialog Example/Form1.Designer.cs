namespace KryptonExceptionDialogExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kcbtnHighlightColor = new Krypton.Toolkit.KryptonColorButton();
            this.kchkShowCopyButton = new Krypton.Toolkit.KryptonCheckBox();
            this.kchkShowSearchItems = new Krypton.Toolkit.KryptonCheckBox();
            this.kchkShowReportBugButton = new Krypton.Toolkit.KryptonCheckBox();
            this.kbtnTriggerException = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnTriggerException);
            this.kryptonPanel1.Controls.Add(this.kchkShowReportBugButton);
            this.kryptonPanel1.Controls.Add(this.kchkShowSearchItems);
            this.kryptonPanel1.Controls.Add(this.kchkShowCopyButton);
            this.kryptonPanel1.Controls.Add(this.kcbtnHighlightColor);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(274, 161);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kcbtnHighlightColor
            // 
            this.kcbtnHighlightColor.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle;
            this.kcbtnHighlightColor.Location = new System.Drawing.Point(13, 13);
            this.kcbtnHighlightColor.Name = "kcbtnHighlightColor";
            this.kcbtnHighlightColor.SelectedColor = System.Drawing.Color.LightYellow;
            this.kcbtnHighlightColor.Size = new System.Drawing.Size(247, 25);
            this.kcbtnHighlightColor.TabIndex = 0;
            this.kcbtnHighlightColor.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonColorButton1.Values.Image")));
            this.kcbtnHighlightColor.Values.RoundedCorners = 8;
            this.kcbtnHighlightColor.Values.Text = "Highlight Color";
            // 
            // kchkShowCopyButton
            // 
            this.kchkShowCopyButton.Location = new System.Drawing.Point(13, 45);
            this.kchkShowCopyButton.Name = "kchkShowCopyButton";
            this.kchkShowCopyButton.Size = new System.Drawing.Size(125, 20);
            this.kchkShowCopyButton.TabIndex = 1;
            this.kchkShowCopyButton.Values.Text = "Show Copy Button";
            // 
            // kchkShowSearchItems
            // 
            this.kchkShowSearchItems.Location = new System.Drawing.Point(13, 71);
            this.kchkShowSearchItems.Name = "kchkShowSearchItems";
            this.kchkShowSearchItems.Size = new System.Drawing.Size(126, 20);
            this.kchkShowSearchItems.TabIndex = 1;
            this.kchkShowSearchItems.Values.Text = "Show Search Items";
            // 
            // kchkShowReportBugButton
            // 
            this.kchkShowReportBugButton.Location = new System.Drawing.Point(13, 97);
            this.kchkShowReportBugButton.Name = "kchkShowReportBugButton";
            this.kchkShowReportBugButton.Size = new System.Drawing.Size(158, 20);
            this.kchkShowReportBugButton.TabIndex = 1;
            this.kchkShowReportBugButton.Values.Text = "Show Report Bug Button";
            // 
            // kbtnTriggerException
            // 
            this.kbtnTriggerException.Location = new System.Drawing.Point(13, 123);
            this.kbtnTriggerException.Name = "kbtnTriggerException";
            this.kbtnTriggerException.Size = new System.Drawing.Size(247, 25);
            this.kbtnTriggerException.TabIndex = 2;
            this.kbtnTriggerException.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kbtnTriggerException.Values.Text = "Trigger Exception";
            this.kbtnTriggerException.Click += new System.EventHandler(this.kbtnTriggerException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Exception Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonColorButton kcbtnHighlightColor;
        private Krypton.Toolkit.KryptonCheckBox kchkShowCopyButton;
        private Krypton.Toolkit.KryptonCheckBox kchkShowSearchItems;
        private Krypton.Toolkit.KryptonCheckBox kchkShowReportBugButton;
        private Krypton.Toolkit.KryptonButton kbtnTriggerException;
    }
}