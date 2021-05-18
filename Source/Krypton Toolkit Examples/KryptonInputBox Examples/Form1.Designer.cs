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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kbtnShow = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtCueText = new Krypton.Toolkit.KryptonTextBox();
            this.ktxtUserPrompt = new Krypton.Toolkit.KryptonTextBox();
            this.ktxtDefaultResponse = new Krypton.Toolkit.KryptonTextBox();
            this.ktxtCaption = new Krypton.Toolkit.KryptonTextBox();
            this.kcbCueColour = new Krypton.Toolkit.KryptonColorButton();
            this.kbtnCueTypeface = new Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.fdCueTypeface = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnCueTypeface);
            this.kryptonPanel1.Controls.Add(this.kcbCueColour);
            this.kryptonPanel1.Controls.Add(this.ktxtCaption);
            this.kryptonPanel1.Controls.Add(this.ktxtDefaultResponse);
            this.kryptonPanel1.Controls.Add(this.ktxtUserPrompt);
            this.kryptonPanel1.Controls.Add(this.ktxtCueText);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kbtnShow);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(384, 261);
            this.kryptonPanel1.TabIndex = 7;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(61, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Prompt:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(59, 51);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Caption:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 80);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Default Response:";
            // 
            // kbtnShow
            // 
            this.kbtnShow.Location = new System.Drawing.Point(119, 208);
            this.kbtnShow.Name = "kbtnShow";
            this.kbtnShow.Size = new System.Drawing.Size(245, 41);
            this.kbtnShow.TabIndex = 3;
            this.kbtnShow.Values.Text = "&Show";
            this.kbtnShow.Click += new System.EventHandler(this.kbtnShow_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(55, 109);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Cue Text:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(41, 139);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "Cue Colour:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(29, 171);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel6.TabIndex = 6;
            this.kryptonLabel6.Values.Text = "Cue Typeface:";
            // 
            // ktxtCueText
            // 
            this.ktxtCueText.Location = new System.Drawing.Point(119, 109);
            this.ktxtCueText.Name = "ktxtCueText";
            this.ktxtCueText.Size = new System.Drawing.Size(245, 23);
            this.ktxtCueText.TabIndex = 7;
            this.ktxtCueText.Text = "Sample Cue Text";
            // 
            // ktxtUserPrompt
            // 
            this.ktxtUserPrompt.Location = new System.Drawing.Point(119, 22);
            this.ktxtUserPrompt.Name = "ktxtUserPrompt";
            this.ktxtUserPrompt.Size = new System.Drawing.Size(245, 23);
            this.ktxtUserPrompt.TabIndex = 8;
            this.ktxtUserPrompt.Text = "User Prompt";
            // 
            // ktxtDefaultResponse
            // 
            this.ktxtDefaultResponse.Location = new System.Drawing.Point(119, 80);
            this.ktxtDefaultResponse.Name = "ktxtDefaultResponse";
            this.ktxtDefaultResponse.Size = new System.Drawing.Size(245, 23);
            this.ktxtDefaultResponse.TabIndex = 9;
            this.ktxtDefaultResponse.Text = "Default Response";
            // 
            // ktxtCaption
            // 
            this.ktxtCaption.Location = new System.Drawing.Point(119, 51);
            this.ktxtCaption.Name = "ktxtCaption";
            this.ktxtCaption.Size = new System.Drawing.Size(245, 23);
            this.ktxtCaption.TabIndex = 10;
            this.ktxtCaption.Text = "Window Title";
            // 
            // kcbCueColour
            // 
            this.kcbCueColour.Location = new System.Drawing.Point(119, 139);
            this.kcbCueColour.Name = "kcbCueColour";
            this.kcbCueColour.SelectedColor = System.Drawing.Color.Black;
            this.kcbCueColour.Size = new System.Drawing.Size(184, 25);
            this.kcbCueColour.TabIndex = 11;
            this.kcbCueColour.Values.Text = "&Cue Colour";
            // 
            // kbtnCueTypeface
            // 
            this.kbtnCueTypeface.Location = new System.Drawing.Point(119, 171);
            this.kbtnCueTypeface.Name = "kbtnCueTypeface";
            this.kbtnCueTypeface.Size = new System.Drawing.Size(184, 25);
            this.kbtnCueTypeface.TabIndex = 12;
            this.kbtnCueTypeface.Values.Text = "Cue &Typeface";
            this.kbtnCueTypeface.Click += new System.EventHandler(this.kbtnCueTypeface_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonInputBox Examples";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton kbtnShow;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kbtnCueTypeface;
        private Krypton.Toolkit.KryptonColorButton kcbCueColour;
        private Krypton.Toolkit.KryptonTextBox ktxtCaption;
        private Krypton.Toolkit.KryptonTextBox ktxtDefaultResponse;
        private Krypton.Toolkit.KryptonTextBox ktxtUserPrompt;
        private Krypton.Toolkit.KryptonTextBox ktxtCueText;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.FontDialog fdCueTypeface;
    }
}

