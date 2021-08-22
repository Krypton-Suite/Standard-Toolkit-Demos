
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
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 192);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(490, 50);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnShow
            // 
            this.kbtnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kbtnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kbtnShow.Location = new System.Drawing.Point(198, 13);
            this.kbtnShow.Name = "kbtnShow";
            this.kbtnShow.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kbtnShow.Size = new System.Drawing.Size(90, 25);
            this.kbtnShow.TabIndex = 1;
            this.kbtnShow.Values.Text = "&Show";
            this.kbtnShow.Click += new System.EventHandler(this.kbtnShow_Click);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(490, 1);
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
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(490, 192);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kchkUsePasswordOption
            // 
            this.kchkUsePasswordOption.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.kchkUsePasswordOption.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kchkUsePasswordOption.Location = new System.Drawing.Point(144, 162);
            this.kchkUsePasswordOption.Name = "kchkUsePasswordOption";
            this.kchkUsePasswordOption.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kchkUsePasswordOption.Size = new System.Drawing.Size(140, 20);
            this.kchkUsePasswordOption.TabIndex = 10;
            this.kchkUsePasswordOption.Values.Text = "Use &Password Option";
            // 
            // kbtnCueTypeface
            // 
            this.kbtnCueTypeface.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kbtnCueTypeface.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kbtnCueTypeface.Location = new System.Drawing.Point(289, 130);
            this.kbtnCueTypeface.Name = "kbtnCueTypeface";
            this.kbtnCueTypeface.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kbtnCueTypeface.Size = new System.Drawing.Size(90, 25);
            this.kbtnCueTypeface.TabIndex = 9;
            this.kbtnCueTypeface.Values.Text = "Cue &Typeface";
            this.kbtnCueTypeface.Click += new System.EventHandler(this.kbtnCueTypeface_Click);
            // 
            // kcbCueTextColour
            // 
            this.kcbCueTextColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kcbCueTextColour.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kcbCueTextColour.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kcbCueTextColour.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom;
            this.kcbCueTextColour.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right;
            this.kcbCueTextColour.EmptyBorderColor = System.Drawing.Color.DarkGray;
            this.kcbCueTextColour.Location = new System.Drawing.Point(144, 130);
            this.kcbCueTextColour.Name = "kcbCueTextColour";
            this.kcbCueTextColour.SchemeStandard = Krypton.Toolkit.ColorScheme.OfficeStandard;
            this.kcbCueTextColour.SchemeThemes = Krypton.Toolkit.ColorScheme.OfficeThemes;
            this.kcbCueTextColour.SelectedColor = System.Drawing.Color.Gray;
            this.kcbCueTextColour.SelectedRect = new System.Drawing.Rectangle(0, 12, 16, 4);
            this.kcbCueTextColour.Size = new System.Drawing.Size(138, 25);
            this.kcbCueTextColour.TabIndex = 8;
            this.kcbCueTextColour.Values.Text = "Cue &Colour";
            // 
            // ktxtCueText
            // 
            this.ktxtCueText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktxtCueText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktxtCueText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ktxtCueText.Location = new System.Drawing.Point(134, 100);
            this.ktxtCueText.Name = "ktxtCueText";
            this.ktxtCueText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktxtCueText.Size = new System.Drawing.Size(333, 23);
            this.ktxtCueText.TabIndex = 7;
            this.ktxtCueText.Text = "Sample Cue Text";
            this.ktxtCueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ktxtDefaultResponseText
            // 
            this.ktxtDefaultResponseText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktxtDefaultResponseText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktxtDefaultResponseText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ktxtDefaultResponseText.Location = new System.Drawing.Point(134, 71);
            this.ktxtDefaultResponseText.Name = "ktxtDefaultResponseText";
            this.ktxtDefaultResponseText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktxtDefaultResponseText.Size = new System.Drawing.Size(333, 23);
            this.ktxtDefaultResponseText.TabIndex = 6;
            this.ktxtDefaultResponseText.Text = "Default Response";
            this.ktxtDefaultResponseText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ktxtCaptionText
            // 
            this.ktxtCaptionText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktxtCaptionText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktxtCaptionText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ktxtCaptionText.Location = new System.Drawing.Point(134, 42);
            this.ktxtCaptionText.Name = "ktxtCaptionText";
            this.ktxtCaptionText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktxtCaptionText.Size = new System.Drawing.Size(333, 23);
            this.ktxtCaptionText.TabIndex = 5;
            this.ktxtCaptionText.Text = "Windows Title";
            this.ktxtCaptionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ktxtPromptText
            // 
            this.ktxtPromptText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ktxtPromptText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ktxtPromptText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ktxtPromptText.Location = new System.Drawing.Point(134, 13);
            this.ktxtPromptText.Name = "ktxtPromptText";
            this.ktxtPromptText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ktxtPromptText.Size = new System.Drawing.Size(333, 23);
            this.ktxtPromptText.TabIndex = 4;
            this.ktxtPromptText.Text = "User Prompt";
            this.ktxtPromptText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(63, 100);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "Cue Text:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 71);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Default Response:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(69, 42);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Caption:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(70, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Prompt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 242);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}