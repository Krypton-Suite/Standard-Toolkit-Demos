
namespace KryptonInputBoxExamples
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnShow = new Krypton.Toolkit.KryptonButton();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kchkUsePasswordOption = new Krypton.Toolkit.KryptonCheckBox();
            this.kbtnCueTypeface = new Krypton.Toolkit.KryptonButton();
            this.kcbCueTextColour = new Krypton.Toolkit.KryptonColorButton();
            this.ktxtCueText = new Krypton.Toolkit.KryptonTextBox();
            this.ktxtDefaultResponseText = new Krypton.Toolkit.KryptonTextBox();
            this.ktxtCaptionText = new Krypton.Toolkit.KryptonTextBox();
            this.ktxtPromptText = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnShow);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 272);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(653, 62);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnShow
            // 
            this.kbtnShow.Location = new System.Drawing.Point(264, 16);
            this.kbtnShow.Margin = new System.Windows.Forms.Padding(4);
            this.kbtnShow.Name = "kbtnShow";
            this.kbtnShow.Size = new System.Drawing.Size(120, 31);
            this.kbtnShow.TabIndex = 1;
            this.kbtnShow.Values.Text = "&Show";
            this.kbtnShow.Click += new System.EventHandler(this.kbtnShow_Click);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(653, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kchkUsePasswordOption);
            this.kryptonPanel2.Controls.Add(this.kbtnCueTypeface);
            this.kryptonPanel2.Controls.Add(this.kcbCueTextColour);
            this.kryptonPanel2.Controls.Add(this.ktxtCueText);
            this.kryptonPanel2.Controls.Add(this.ktxtDefaultResponseText);
            this.kryptonPanel2.Controls.Add(this.ktxtCaptionText);
            this.kryptonPanel2.Controls.Add(this.ktxtPromptText);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(653, 272);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kchkUsePasswordOption
            // 
            this.kchkUsePasswordOption.Location = new System.Drawing.Point(192, 234);
            this.kchkUsePasswordOption.Margin = new System.Windows.Forms.Padding(4);
            this.kchkUsePasswordOption.Name = "kchkUsePasswordOption";
            this.kchkUsePasswordOption.Size = new System.Drawing.Size(170, 24);
            this.kchkUsePasswordOption.TabIndex = 10;
            this.kchkUsePasswordOption.Values.Text = "Use Password &Option";
            // 
            // kbtnCueTypeface
            // 
            this.kbtnCueTypeface.Location = new System.Drawing.Point(385, 195);
            this.kbtnCueTypeface.Margin = new System.Windows.Forms.Padding(4);
            this.kbtnCueTypeface.Name = "kbtnCueTypeface";
            this.kbtnCueTypeface.Size = new System.Drawing.Size(120, 31);
            this.kbtnCueTypeface.TabIndex = 9;
            this.kbtnCueTypeface.Values.Text = "Cue T&ypeface";
            this.kbtnCueTypeface.Click += new System.EventHandler(this.kbtnCueTypeface_Click);
            // 
            // kcbCueTextColour
            // 
            this.kcbCueTextColour.Location = new System.Drawing.Point(192, 195);
            this.kcbCueTextColour.Margin = new System.Windows.Forms.Padding(4);
            this.kcbCueTextColour.Name = "kcbCueTextColour";
            this.kcbCueTextColour.SelectedColor = System.Drawing.Color.Gray;
            this.kcbCueTextColour.Size = new System.Drawing.Size(184, 31);
            this.kcbCueTextColour.TabIndex = 8;
            this.kcbCueTextColour.Values.Text = "C&ue Colour";
            // 
            // ktxtCueText
            // 
            this.ktxtCueText.Location = new System.Drawing.Point(179, 158);
            this.ktxtCueText.Margin = new System.Windows.Forms.Padding(4);
            this.ktxtCueText.Name = "ktxtCueText";
            this.ktxtCueText.Size = new System.Drawing.Size(444, 27);
            this.ktxtCueText.TabIndex = 7;
            this.ktxtCueText.Text = "Sample Cue Text";
            // 
            // ktxtDefaultResponseText
            // 
            this.ktxtDefaultResponseText.Location = new System.Drawing.Point(179, 122);
            this.ktxtDefaultResponseText.Margin = new System.Windows.Forms.Padding(4);
            this.ktxtDefaultResponseText.Name = "ktxtDefaultResponseText";
            this.ktxtDefaultResponseText.Size = new System.Drawing.Size(444, 27);
            this.ktxtDefaultResponseText.TabIndex = 5;
            this.ktxtDefaultResponseText.Text = "Default Response";
            // 
            // ktxtCaptionText
            // 
            this.ktxtCaptionText.Location = new System.Drawing.Point(178, 13);
            this.ktxtCaptionText.Margin = new System.Windows.Forms.Padding(4);
            this.ktxtCaptionText.Name = "ktxtCaptionText";
            this.ktxtCaptionText.Size = new System.Drawing.Size(444, 27);
            this.ktxtCaptionText.TabIndex = 1;
            this.ktxtCaptionText.Text = "Windows Title";
            // 
            // ktxtPromptText
            // 
            this.ktxtPromptText.Location = new System.Drawing.Point(178, 48);
            this.ktxtPromptText.Margin = new System.Windows.Forms.Padding(4);
            this.ktxtPromptText.Multiline = true;
            this.ktxtPromptText.Name = "ktxtPromptText";
            this.ktxtPromptText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ktxtPromptText.Size = new System.Drawing.Size(444, 66);
            this.ktxtPromptText.TabIndex = 3;
            this.ktxtPromptText.Text = "User Prompt";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(84, 158);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(74, 24);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Cue &Text:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(17, 122);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(134, 24);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Default &Response:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(89, 13);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(68, 24);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "&Caption:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(92, 48);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(66, 24);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "&Prompt:";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 334);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Krypton Input Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnShow;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton kbtnCueTypeface;
        private Krypton.Toolkit.KryptonColorButton kcbCueTextColour;
        private Krypton.Toolkit.KryptonTextBox ktxtCueText;
        private Krypton.Toolkit.KryptonTextBox ktxtDefaultResponseText;
        private Krypton.Toolkit.KryptonTextBox ktxtCaptionText;
        private Krypton.Toolkit.KryptonTextBox ktxtPromptText;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonCheckBox kchkUsePasswordOption;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}