﻿namespace KryptonToastNotificationExamples
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
            this.kchkShowProgressBar = new Krypton.Toolkit.KryptonCheckBox();
            this.kcmbToastTitleAlignment = new Krypton.Toolkit.KryptonComboBox();
            this.knudCountdownSeconds = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kbtnTitleFont = new Krypton.Toolkit.KryptonButton();
            this.kbtnContentFont = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kchkShowCloseBox = new Krypton.Toolkit.KryptonCheckBox();
            this.kchkTopMost = new Krypton.Toolkit.KryptonCheckBox();
            this.kchkUseFade = new Krypton.Toolkit.KryptonCheckBox();
            this.ktxtCustomToastIconPath = new Krypton.Toolkit.KryptonTextBox();
            this.kcmbToastIcon = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtToastContent = new Krypton.Toolkit.KryptonTextBox();
            this.ktxtToastTitle = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbToastTitleAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbToastIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnShow);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderEdge1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 410);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kryptonPanel1.Size = new System.Drawing.Size(810, 50);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnShow
            // 
            this.kbtnShow.Location = new System.Drawing.Point(702, 13);
            this.kbtnShow.Name = "kbtnShow";
            this.kbtnShow.Size = new System.Drawing.Size(90, 25);
            this.kbtnShow.TabIndex = 1;
            this.kbtnShow.Values.Text = "Show";
            this.kbtnShow.Click += new System.EventHandler(this.kbtnShow_Click);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary;
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(810, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kchkShowProgressBar);
            this.kryptonPanel2.Controls.Add(this.kcmbToastTitleAlignment);
            this.kryptonPanel2.Controls.Add(this.knudCountdownSeconds);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.kbtnTitleFont);
            this.kryptonPanel2.Controls.Add(this.kbtnContentFont);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kchkShowCloseBox);
            this.kryptonPanel2.Controls.Add(this.kchkTopMost);
            this.kryptonPanel2.Controls.Add(this.kchkUseFade);
            this.kryptonPanel2.Controls.Add(this.ktxtCustomToastIconPath);
            this.kryptonPanel2.Controls.Add(this.kcmbToastIcon);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.ktxtToastContent);
            this.kryptonPanel2.Controls.Add(this.ktxtToastTitle);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(810, 410);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kchkShowProgressBar
            // 
            this.kchkShowProgressBar.Location = new System.Drawing.Point(187, 221);
            this.kchkShowProgressBar.Name = "kchkShowProgressBar";
            this.kchkShowProgressBar.Size = new System.Drawing.Size(125, 20);
            this.kchkShowProgressBar.TabIndex = 17;
            this.kchkShowProgressBar.Values.Text = "Show Progress Bar";
            // 
            // kcmbToastTitleAlignment
            // 
            this.kcmbToastTitleAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbToastTitleAlignment.DropDownWidth = 274;
            this.kcmbToastTitleAlignment.IntegralHeight = false;
            this.kcmbToastTitleAlignment.Location = new System.Drawing.Point(173, 298);
            this.kcmbToastTitleAlignment.Name = "kcmbToastTitleAlignment";
            this.kcmbToastTitleAlignment.Size = new System.Drawing.Size(274, 21);
            this.kcmbToastTitleAlignment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbToastTitleAlignment.TabIndex = 16;
            this.kcmbToastTitleAlignment.SelectedIndexChanged += new System.EventHandler(this.kcmbToastTitleAlignment_SelectedIndexChanged);
            // 
            // knudCountdownSeconds
            // 
            this.knudCountdownSeconds.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudCountdownSeconds.Location = new System.Drawing.Point(192, 366);
            this.knudCountdownSeconds.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.knudCountdownSeconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.knudCountdownSeconds.Name = "knudCountdownSeconds";
            this.knudCountdownSeconds.Size = new System.Drawing.Size(120, 22);
            this.knudCountdownSeconds.TabIndex = 15;
            this.knudCountdownSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.knudCountdownSeconds.ValueChanged += new System.EventHandler(this.knudCountdownSeconds_ValueChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(13, 366);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(126, 20);
            this.kryptonLabel5.TabIndex = 14;
            this.kryptonLabel5.Values.Text = "Countdown Seconds:";
            // 
            // kbtnTitleFont
            // 
            this.kbtnTitleFont.AutoSize = true;
            this.kbtnTitleFont.Location = new System.Drawing.Point(208, 335);
            this.kbtnTitleFont.Name = "kbtnTitleFont";
            this.kbtnTitleFont.Size = new System.Drawing.Size(117, 25);
            this.kbtnTitleFont.TabIndex = 13;
            this.kbtnTitleFont.Values.Text = "Title Font";
            this.kbtnTitleFont.Click += new System.EventHandler(this.kbtnTitleFont_Click);
            // 
            // kbtnContentFont
            // 
            this.kbtnContentFont.AutoSize = true;
            this.kbtnContentFont.Location = new System.Drawing.Point(85, 335);
            this.kbtnContentFont.Name = "kbtnContentFont";
            this.kbtnContentFont.Size = new System.Drawing.Size(117, 25);
            this.kbtnContentFont.TabIndex = 12;
            this.kbtnContentFont.Values.Text = "Content Font";
            this.kbtnContentFont.Click += new System.EventHandler(this.kbtnContentFont_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(13, 298);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(96, 20);
            this.kryptonLabel4.TabIndex = 10;
            this.kryptonLabel4.Values.Text = "Title Alignment:";
            // 
            // kchkShowCloseBox
            // 
            this.kchkShowCloseBox.Location = new System.Drawing.Point(85, 273);
            this.kchkShowCloseBox.Name = "kchkShowCloseBox";
            this.kchkShowCloseBox.Size = new System.Drawing.Size(110, 20);
            this.kchkShowCloseBox.TabIndex = 9;
            this.kchkShowCloseBox.Values.Text = "Show Close Box";
            this.kchkShowCloseBox.CheckedChanged += new System.EventHandler(this.kchkShowCloseBox_CheckedChanged);
            // 
            // kchkTopMost
            // 
            this.kchkTopMost.Checked = true;
            this.kchkTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kchkTopMost.Location = new System.Drawing.Point(85, 247);
            this.kchkTopMost.Name = "kchkTopMost";
            this.kchkTopMost.Size = new System.Drawing.Size(76, 20);
            this.kchkTopMost.TabIndex = 8;
            this.kchkTopMost.Values.Text = "Top Most";
            this.kchkTopMost.CheckedChanged += new System.EventHandler(this.kchkTopMost_CheckedChanged);
            // 
            // kchkUseFade
            // 
            this.kchkUseFade.Location = new System.Drawing.Point(85, 221);
            this.kchkUseFade.Name = "kchkUseFade";
            this.kchkUseFade.Size = new System.Drawing.Size(73, 20);
            this.kchkUseFade.TabIndex = 7;
            this.kchkUseFade.Values.Text = "Use Fade";
            this.kchkUseFade.CheckedChanged += new System.EventHandler(this.kchkUseFade_CheckedChanged);
            // 
            // ktxtCustomToastIconPath
            // 
            this.ktxtCustomToastIconPath.Enabled = false;
            this.ktxtCustomToastIconPath.Location = new System.Drawing.Point(85, 191);
            this.ktxtCustomToastIconPath.Name = "ktxtCustomToastIconPath";
            this.ktxtCustomToastIconPath.ShowEllipsisButton = true;
            this.ktxtCustomToastIconPath.Size = new System.Drawing.Size(274, 24);
            this.ktxtCustomToastIconPath.TabIndex = 6;
            // 
            // kcmbToastIcon
            // 
            this.kcmbToastIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbToastIcon.DropDownWidth = 274;
            this.kcmbToastIcon.IntegralHeight = false;
            this.kcmbToastIcon.Location = new System.Drawing.Point(85, 165);
            this.kcmbToastIcon.Name = "kcmbToastIcon";
            this.kcmbToastIcon.Size = new System.Drawing.Size(274, 21);
            this.kcmbToastIcon.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbToastIcon.TabIndex = 5;
            this.kcmbToastIcon.SelectedIndexChanged += new System.EventHandler(this.kcmbToastIcon_SelectedIndexChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 165);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Icon:";
            // 
            // ktxtToastContent
            // 
            this.ktxtToastContent.Location = new System.Drawing.Point(85, 41);
            this.ktxtToastContent.Multiline = true;
            this.ktxtToastContent.Name = "ktxtToastContent";
            this.ktxtToastContent.Size = new System.Drawing.Size(274, 118);
            this.ktxtToastContent.TabIndex = 3;
            this.ktxtToastContent.Text = "Put your message here...";
            this.ktxtToastContent.TextChanged += new System.EventHandler(this.ktxtToastContent_TextChanged);
            // 
            // ktxtToastTitle
            // 
            this.ktxtToastTitle.Location = new System.Drawing.Point(85, 13);
            this.ktxtToastTitle.Name = "ktxtToastTitle";
            this.ktxtToastTitle.Size = new System.Drawing.Size(274, 23);
            this.ktxtToastTitle.TabIndex = 2;
            this.ktxtToastTitle.Text = "This is a test";
            this.ktxtToastTitle.TextChanged += new System.EventHandler(this.ktxtToastTitle_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(13, 39);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Text:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Title:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 460);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Toast Notification";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbToastTitleAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbToastIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnShow;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonCheckBox kchkShowProgressBar;
        private Krypton.Toolkit.KryptonComboBox kcmbToastTitleAlignment;
        private Krypton.Toolkit.KryptonNumericUpDown knudCountdownSeconds;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonButton kbtnTitleFont;
        private Krypton.Toolkit.KryptonButton kbtnContentFont;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonCheckBox kchkShowCloseBox;
        private Krypton.Toolkit.KryptonCheckBox kchkTopMost;
        private Krypton.Toolkit.KryptonCheckBox kchkUseFade;
        private Krypton.Toolkit.KryptonTextBox ktxtCustomToastIconPath;
        private Krypton.Toolkit.KryptonComboBox kcmbToastIcon;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox ktxtToastContent;
        private Krypton.Toolkit.KryptonTextBox ktxtToastTitle;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}