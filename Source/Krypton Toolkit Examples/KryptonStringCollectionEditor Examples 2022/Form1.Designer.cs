namespace KryptonStringCollectionEditorExamples
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
            this.kbtnShow = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtHeaderText = new Krypton.Toolkit.KryptonTextBox();
            this.kcbUseRichTextBox = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtCueText = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.ktxOKButtonText = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtCancelButtonText = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtHelpMessageBoxTitleText = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtHelpMessageBoxText = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.ktxtHelpMessageBoxText);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.ktxtHelpMessageBoxTitleText);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.ktxtCancelButtonText);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.ktxOKButtonText);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.ktxtCueText);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.ktxtHeaderText);
            this.kryptonPanel1.Controls.Add(this.kcbUseRichTextBox);
            this.kryptonPanel1.Controls.Add(this.kbtnShow);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(548, 228);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnShow
            // 
            this.kbtnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnShow.Location = new System.Drawing.Point(446, 191);
            this.kbtnShow.Name = "kbtnShow";
            this.kbtnShow.Size = new System.Drawing.Size(90, 25);
            this.kbtnShow.TabIndex = 0;
            this.kbtnShow.Values.Text = "&Show";
            this.kbtnShow.Click += new System.EventHandler(this.kbtnShow_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Header Text:";
            // 
            // ktxtHeaderText
            // 
            this.ktxtHeaderText.Location = new System.Drawing.Point(103, 12);
            this.ktxtHeaderText.Name = "ktxtHeaderText";
            this.ktxtHeaderText.Size = new System.Drawing.Size(433, 23);
            this.ktxtHeaderText.TabIndex = 2;
            this.ktxtHeaderText.Text = "Enter the strings in the collection (one per line):";
            // 
            // kcbUseRichTextBox
            // 
            this.kcbUseRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kcbUseRichTextBox.Location = new System.Drawing.Point(12, 196);
            this.kcbUseRichTextBox.Name = "kcbUseRichTextBox";
            this.kcbUseRichTextBox.Size = new System.Drawing.Size(120, 20);
            this.kcbUseRichTextBox.TabIndex = 3;
            this.kcbUseRichTextBox.Values.Text = "Use Rich &Text Box";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 41);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Cue Text:";
            // 
            // ktxtCueText
            // 
            this.ktxtCueText.Location = new System.Drawing.Point(103, 41);
            this.ktxtCueText.Name = "ktxtCueText";
            this.ktxtCueText.Size = new System.Drawing.Size(433, 23);
            this.ktxtCueText.TabIndex = 5;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 70);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(103, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Ok Button Text:";
            // 
            // ktxOKButtonText
            // 
            this.ktxOKButtonText.Location = new System.Drawing.Point(121, 70);
            this.ktxOKButtonText.Name = "ktxOKButtonText";
            this.ktxOKButtonText.Size = new System.Drawing.Size(415, 23);
            this.ktxOKButtonText.TabIndex = 7;
            this.ktxOKButtonText.Text = "O&K";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 99);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(124, 20);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Cancel Button Text:";
            // 
            // ktxtCancelButtonText
            // 
            this.ktxtCancelButtonText.Location = new System.Drawing.Point(144, 99);
            this.ktxtCancelButtonText.Name = "ktxtCancelButtonText";
            this.ktxtCancelButtonText.Size = new System.Drawing.Size(392, 23);
            this.ktxtCancelButtonText.TabIndex = 9;
            this.ktxtCancelButtonText.Text = "C&ancel";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 128);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(175, 20);
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Help Messagebox Title Text:";
            // 
            // ktxtHelpMessageBoxTitleText
            // 
            this.ktxtHelpMessageBoxTitleText.Location = new System.Drawing.Point(193, 128);
            this.ktxtHelpMessageBoxTitleText.Name = "ktxtHelpMessageBoxTitleText";
            this.ktxtHelpMessageBoxTitleText.Size = new System.Drawing.Size(343, 23);
            this.ktxtHelpMessageBoxTitleText.TabIndex = 11;
            this.ktxtHelpMessageBoxTitleText.Text = "Krypton String Collection Editor Help";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 157);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(146, 20);
            this.kryptonLabel6.TabIndex = 12;
            this.kryptonLabel6.Values.Text = "Help Messagebox Text:";
            // 
            // ktxtHelpMessageBoxText
            // 
            this.ktxtHelpMessageBoxText.Location = new System.Drawing.Point(193, 157);
            this.ktxtHelpMessageBoxText.Name = "ktxtHelpMessageBoxText";
            this.ktxtHelpMessageBoxText.Size = new System.Drawing.Size(343, 23);
            this.ktxtHelpMessageBoxText.TabIndex = 13;
            this.ktxtHelpMessageBoxText.Text = resources.GetString("ktxtHelpMessageBoxText.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 228);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnShow;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox ktxtHelpMessageBoxText;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox ktxtHelpMessageBoxTitleText;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox ktxtCancelButtonText;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox ktxOKButtonText;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox ktxtCueText;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox ktxtHeaderText;
        private Krypton.Toolkit.KryptonCheckBox kcbUseRichTextBox;
    }
}
