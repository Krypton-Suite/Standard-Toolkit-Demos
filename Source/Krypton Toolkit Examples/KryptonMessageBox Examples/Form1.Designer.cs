﻿namespace KryptonMessageBoxExamples
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
            this.label1 = new Krypton.Toolkit.KryptonLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCaption = new Krypton.Toolkit.KryptonTextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.radioButtonNone = new Krypton.Toolkit.KryptonRadioButton();
            this.radioButtonError = new System.Windows.Forms.RadioButton();
            this.radioButtonQuestion = new System.Windows.Forms.RadioButton();
            this.radioButtonWarning = new System.Windows.Forms.RadioButton();
            this.radioButtonInformation = new System.Windows.Forms.RadioButton();
            this.radioButtonOK = new System.Windows.Forms.RadioButton();
            this.radioButtonOKCancel = new System.Windows.Forms.RadioButton();
            this.radioButtonAbortRetryIgnore = new System.Windows.Forms.RadioButton();
            this.radioButtonYesNoCancel = new System.Windows.Forms.RadioButton();
            this.groupBoxIcon = new Krypton.Toolkit.KryptonGroupBox();
            this.radioButtonWinLogo = new System.Windows.Forms.RadioButton();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonYesNo = new System.Windows.Forms.RadioButton();
            this.radioButtonRetryCancel = new System.Windows.Forms.RadioButton();
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonOffice365Blue = new System.Windows.Forms.RadioButton();
            this.radioButtonSystem = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice2003 = new System.Windows.Forms.RadioButton();
            this.radioButtonSparklePurple = new System.Windows.Forms.RadioButton();
            this.radioButtonSparkleOrange = new System.Windows.Forms.RadioButton();
            this.radioButtonSparkleBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice2007Black = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice2007Silver = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice2007Blue = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice2010Black = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice2010Silver = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice2010Blue = new System.Windows.Forms.RadioButton();
            this.chkRightAlign = new System.Windows.Forms.CheckBox();
            this.chkRtlReading = new System.Windows.Forms.CheckBox();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon.Panel)).BeginInit();
            this.groupBoxIcon.Panel.SuspendLayout();
            this.groupBoxIcon.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Values.Text = "Caption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Location = new System.Drawing.Point(70, 21);
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(246, 27);
            this.textBoxCaption.TabIndex = 1;
            this.textBoxCaption.Text = "Caption";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(70, 52);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(246, 112);
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.Text = "This is a message box!";
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.Location = new System.Drawing.Point(14, 3);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(61, 24);
            this.radioButtonNone.TabIndex = 0;
            this.radioButtonNone.Tag = "0";
            this.radioButtonNone.Values.Text = "None";
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // radioButtonError
            // 
            this.radioButtonError.AutoSize = true;
            this.radioButtonError.Location = new System.Drawing.Point(14, 26);
            this.radioButtonError.Name = "radioButtonError";
            this.radioButtonError.Size = new System.Drawing.Size(60, 21);
            this.radioButtonError.TabIndex = 1;
            this.radioButtonError.Tag = "16";
            this.radioButtonError.Text = "Error";
            this.radioButtonError.UseVisualStyleBackColor = true;
            this.radioButtonError.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // radioButtonQuestion
            // 
            this.radioButtonQuestion.AutoSize = true;
            this.radioButtonQuestion.Location = new System.Drawing.Point(14, 49);
            this.radioButtonQuestion.Name = "radioButtonQuestion";
            this.radioButtonQuestion.Size = new System.Drawing.Size(83, 21);
            this.radioButtonQuestion.TabIndex = 2;
            this.radioButtonQuestion.Tag = "32";
            this.radioButtonQuestion.Text = "Question";
            this.radioButtonQuestion.UseVisualStyleBackColor = true;
            this.radioButtonQuestion.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // radioButtonWarning
            // 
            this.radioButtonWarning.AutoSize = true;
            this.radioButtonWarning.Checked = true;
            this.radioButtonWarning.Location = new System.Drawing.Point(117, 3);
            this.radioButtonWarning.Name = "radioButtonWarning";
            this.radioButtonWarning.Size = new System.Drawing.Size(81, 21);
            this.radioButtonWarning.TabIndex = 3;
            this.radioButtonWarning.TabStop = true;
            this.radioButtonWarning.Tag = "48";
            this.radioButtonWarning.Text = "Warning";
            this.radioButtonWarning.UseVisualStyleBackColor = true;
            this.radioButtonWarning.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // radioButtonInformation
            // 
            this.radioButtonInformation.AutoSize = true;
            this.radioButtonInformation.Location = new System.Drawing.Point(117, 26);
            this.radioButtonInformation.Name = "radioButtonInformation";
            this.radioButtonInformation.Size = new System.Drawing.Size(100, 21);
            this.radioButtonInformation.TabIndex = 4;
            this.radioButtonInformation.Tag = "64";
            this.radioButtonInformation.Text = "Information";
            this.radioButtonInformation.UseVisualStyleBackColor = true;
            this.radioButtonInformation.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // radioButtonOK
            // 
            this.radioButtonOK.AutoSize = true;
            this.radioButtonOK.Location = new System.Drawing.Point(16, 23);
            this.radioButtonOK.Name = "radioButtonOK";
            this.radioButtonOK.Size = new System.Drawing.Size(47, 21);
            this.radioButtonOK.TabIndex = 0;
            this.radioButtonOK.Tag = "0";
            this.radioButtonOK.Text = "OK";
            this.radioButtonOK.UseVisualStyleBackColor = true;
            this.radioButtonOK.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // radioButtonOKCancel
            // 
            this.radioButtonOKCancel.AutoSize = true;
            this.radioButtonOKCancel.Checked = true;
            this.radioButtonOKCancel.Location = new System.Drawing.Point(16, 46);
            this.radioButtonOKCancel.Name = "radioButtonOKCancel";
            this.radioButtonOKCancel.Size = new System.Drawing.Size(91, 21);
            this.radioButtonOKCancel.TabIndex = 1;
            this.radioButtonOKCancel.TabStop = true;
            this.radioButtonOKCancel.Tag = "1";
            this.radioButtonOKCancel.Text = "OK Cancel";
            this.radioButtonOKCancel.UseVisualStyleBackColor = true;
            this.radioButtonOKCancel.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // radioButtonAbortRetryIgnore
            // 
            this.radioButtonAbortRetryIgnore.AutoSize = true;
            this.radioButtonAbortRetryIgnore.Location = new System.Drawing.Point(98, 23);
            this.radioButtonAbortRetryIgnore.Name = "radioButtonAbortRetryIgnore";
            this.radioButtonAbortRetryIgnore.Size = new System.Drawing.Size(145, 21);
            this.radioButtonAbortRetryIgnore.TabIndex = 3;
            this.radioButtonAbortRetryIgnore.Tag = "2";
            this.radioButtonAbortRetryIgnore.Text = "Abort Retry Ignore";
            this.radioButtonAbortRetryIgnore.UseVisualStyleBackColor = true;
            this.radioButtonAbortRetryIgnore.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // radioButtonYesNoCancel
            // 
            this.radioButtonYesNoCancel.AutoSize = true;
            this.radioButtonYesNoCancel.Location = new System.Drawing.Point(113, 50);
            this.radioButtonYesNoCancel.Name = "radioButtonYesNoCancel";
            this.radioButtonYesNoCancel.Size = new System.Drawing.Size(115, 21);
            this.radioButtonYesNoCancel.TabIndex = 5;
            this.radioButtonYesNoCancel.Tag = "3";
            this.radioButtonYesNoCancel.Text = "Yes No Cancel";
            this.radioButtonYesNoCancel.UseVisualStyleBackColor = true;
            this.radioButtonYesNoCancel.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // groupBoxIcon
            // 
            this.groupBoxIcon.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.groupBoxIcon.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.groupBoxIcon.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.groupBoxIcon.Location = new System.Drawing.Point(70, 176);
            this.groupBoxIcon.Name = "groupBoxIcon";
            // 
            // groupBoxIcon.Panel
            // 
            this.groupBoxIcon.Panel.Controls.Add(this.radioButtonWinLogo);
            this.groupBoxIcon.Panel.Controls.Add(this.radioButtonNone);
            this.groupBoxIcon.Panel.Controls.Add(this.radioButtonError);
            this.groupBoxIcon.Panel.Controls.Add(this.radioButtonQuestion);
            this.groupBoxIcon.Panel.Controls.Add(this.radioButtonWarning);
            this.groupBoxIcon.Panel.Controls.Add(this.radioButtonInformation);
            this.groupBoxIcon.Size = new System.Drawing.Size(246, 100);
            this.groupBoxIcon.TabIndex = 4;
            this.groupBoxIcon.Values.Heading = "Icon";
            // 
            // radioButtonWinLogo
            // 
            this.radioButtonWinLogo.AutoSize = true;
            this.radioButtonWinLogo.Location = new System.Drawing.Point(117, 49);
            this.radioButtonWinLogo.Name = "radioButtonWinLogo";
            this.radioButtonWinLogo.Size = new System.Drawing.Size(84, 21);
            this.radioButtonWinLogo.TabIndex = 5;
            this.radioButtonWinLogo.Tag = "32";
            this.radioButtonWinLogo.Text = "WinLogo";
            this.radioButtonWinLogo.UseVisualStyleBackColor = true;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.radioButtonYesNo);
            this.groupBoxButtons.Controls.Add(this.radioButtonRetryCancel);
            this.groupBoxButtons.Controls.Add(this.radioButtonOK);
            this.groupBoxButtons.Controls.Add(this.radioButtonOKCancel);
            this.groupBoxButtons.Controls.Add(this.radioButtonYesNoCancel);
            this.groupBoxButtons.Controls.Add(this.radioButtonAbortRetryIgnore);
            this.groupBoxButtons.Location = new System.Drawing.Point(70, 283);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(246, 100);
            this.groupBoxButtons.TabIndex = 5;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Buttons";
            // 
            // radioButtonYesNo
            // 
            this.radioButtonYesNo.AutoSize = true;
            this.radioButtonYesNo.Location = new System.Drawing.Point(129, 74);
            this.radioButtonYesNo.Name = "radioButtonYesNo";
            this.radioButtonYesNo.Size = new System.Drawing.Size(71, 21);
            this.radioButtonYesNo.TabIndex = 4;
            this.radioButtonYesNo.Tag = "4";
            this.radioButtonYesNo.Text = "Yes No";
            this.radioButtonYesNo.UseVisualStyleBackColor = true;
            this.radioButtonYesNo.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // radioButtonRetryCancel
            // 
            this.radioButtonRetryCancel.AutoSize = true;
            this.radioButtonRetryCancel.Location = new System.Drawing.Point(16, 71);
            this.radioButtonRetryCancel.Name = "radioButtonRetryCancel";
            this.radioButtonRetryCancel.Size = new System.Drawing.Size(107, 21);
            this.radioButtonRetryCancel.TabIndex = 2;
            this.radioButtonRetryCancel.Tag = "5";
            this.radioButtonRetryCancel.Text = "Retry Cancel";
            this.radioButtonRetryCancel.UseVisualStyleBackColor = true;
            this.radioButtonRetryCancel.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(70, 398);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(466, 57);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonOffice365Blue);
            this.groupBox3.Controls.Add(this.radioButtonSystem);
            this.groupBox3.Controls.Add(this.radioButtonOffice2003);
            this.groupBox3.Controls.Add(this.radioButtonSparklePurple);
            this.groupBox3.Controls.Add(this.radioButtonSparkleOrange);
            this.groupBox3.Controls.Add(this.radioButtonSparkleBlue);
            this.groupBox3.Controls.Add(this.radioButtonOffice2007Black);
            this.groupBox3.Controls.Add(this.radioButtonOffice2007Silver);
            this.groupBox3.Controls.Add(this.radioButtonOffice2007Blue);
            this.groupBox3.Controls.Add(this.radioButtonOffice2010Black);
            this.groupBox3.Controls.Add(this.radioButtonOffice2010Silver);
            this.groupBox3.Controls.Add(this.radioButtonOffice2010Blue);
            this.groupBox3.Location = new System.Drawing.Point(329, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 315);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Palette";
            // 
            // radioButtonOffice365Blue
            // 
            this.radioButtonOffice365Blue.AutoSize = true;
            this.radioButtonOffice365Blue.Location = new System.Drawing.Point(14, 275);
            this.radioButtonOffice365Blue.Name = "radioButtonOffice365Blue";
            this.radioButtonOffice365Blue.Size = new System.Drawing.Size(129, 21);
            this.radioButtonOffice365Blue.TabIndex = 11;
            this.radioButtonOffice365Blue.Tag = "0";
            this.radioButtonOffice365Blue.Text = "Office 365 - Blue";
            this.radioButtonOffice365Blue.UseVisualStyleBackColor = true;
            // 
            // radioButtonSystem
            // 
            this.radioButtonSystem.AutoSize = true;
            this.radioButtonSystem.Location = new System.Drawing.Point(14, 252);
            this.radioButtonSystem.Name = "radioButtonSystem";
            this.radioButtonSystem.Size = new System.Drawing.Size(159, 21);
            this.radioButtonSystem.TabIndex = 10;
            this.radioButtonSystem.Tag = "0";
            this.radioButtonSystem.Text = "Professional - System";
            this.radioButtonSystem.UseVisualStyleBackColor = true;
            this.radioButtonSystem.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonOffice2003
            // 
            this.radioButtonOffice2003.AutoSize = true;
            this.radioButtonOffice2003.Location = new System.Drawing.Point(14, 229);
            this.radioButtonOffice2003.Name = "radioButtonOffice2003";
            this.radioButtonOffice2003.Size = new System.Drawing.Size(183, 21);
            this.radioButtonOffice2003.TabIndex = 9;
            this.radioButtonOffice2003.Tag = "0";
            this.radioButtonOffice2003.Text = "Professional - Office 2003";
            this.radioButtonOffice2003.UseVisualStyleBackColor = true;
            this.radioButtonOffice2003.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonSparklePurple
            // 
            this.radioButtonSparklePurple.AutoSize = true;
            this.radioButtonSparklePurple.Location = new System.Drawing.Point(14, 206);
            this.radioButtonSparklePurple.Name = "radioButtonSparklePurple";
            this.radioButtonSparklePurple.Size = new System.Drawing.Size(124, 21);
            this.radioButtonSparklePurple.TabIndex = 8;
            this.radioButtonSparklePurple.Tag = "0";
            this.radioButtonSparklePurple.Text = "Sparkle - Purple";
            this.radioButtonSparklePurple.UseVisualStyleBackColor = true;
            this.radioButtonSparklePurple.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonSparkleOrange
            // 
            this.radioButtonSparkleOrange.AutoSize = true;
            this.radioButtonSparkleOrange.Location = new System.Drawing.Point(14, 183);
            this.radioButtonSparkleOrange.Name = "radioButtonSparkleOrange";
            this.radioButtonSparkleOrange.Size = new System.Drawing.Size(131, 21);
            this.radioButtonSparkleOrange.TabIndex = 7;
            this.radioButtonSparkleOrange.Tag = "0";
            this.radioButtonSparkleOrange.Text = "Sparkle - Orange";
            this.radioButtonSparkleOrange.UseVisualStyleBackColor = true;
            this.radioButtonSparkleOrange.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonSparkleBlue
            // 
            this.radioButtonSparkleBlue.AutoSize = true;
            this.radioButtonSparkleBlue.Location = new System.Drawing.Point(14, 160);
            this.radioButtonSparkleBlue.Name = "radioButtonSparkleBlue";
            this.radioButtonSparkleBlue.Size = new System.Drawing.Size(111, 21);
            this.radioButtonSparkleBlue.TabIndex = 6;
            this.radioButtonSparkleBlue.Tag = "0";
            this.radioButtonSparkleBlue.Text = "Sparkle - Blue";
            this.radioButtonSparkleBlue.UseVisualStyleBackColor = true;
            this.radioButtonSparkleBlue.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonOffice2007Black
            // 
            this.radioButtonOffice2007Black.AutoSize = true;
            this.radioButtonOffice2007Black.Location = new System.Drawing.Point(14, 137);
            this.radioButtonOffice2007Black.Name = "radioButtonOffice2007Black";
            this.radioButtonOffice2007Black.Size = new System.Drawing.Size(143, 21);
            this.radioButtonOffice2007Black.TabIndex = 5;
            this.radioButtonOffice2007Black.Tag = "0";
            this.radioButtonOffice2007Black.Text = "Office 2007 - Black";
            this.radioButtonOffice2007Black.UseVisualStyleBackColor = true;
            this.radioButtonOffice2007Black.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonOffice2007Silver
            // 
            this.radioButtonOffice2007Silver.AutoSize = true;
            this.radioButtonOffice2007Silver.Location = new System.Drawing.Point(14, 114);
            this.radioButtonOffice2007Silver.Name = "radioButtonOffice2007Silver";
            this.radioButtonOffice2007Silver.Size = new System.Drawing.Size(144, 21);
            this.radioButtonOffice2007Silver.TabIndex = 4;
            this.radioButtonOffice2007Silver.Tag = "0";
            this.radioButtonOffice2007Silver.Text = "Office 2007 - Silver";
            this.radioButtonOffice2007Silver.UseVisualStyleBackColor = true;
            this.radioButtonOffice2007Silver.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonOffice2007Blue
            // 
            this.radioButtonOffice2007Blue.AutoSize = true;
            this.radioButtonOffice2007Blue.Location = new System.Drawing.Point(14, 91);
            this.radioButtonOffice2007Blue.Name = "radioButtonOffice2007Blue";
            this.radioButtonOffice2007Blue.Size = new System.Drawing.Size(137, 21);
            this.radioButtonOffice2007Blue.TabIndex = 3;
            this.radioButtonOffice2007Blue.Tag = "0";
            this.radioButtonOffice2007Blue.Text = "Office 2007 - Blue";
            this.radioButtonOffice2007Blue.UseVisualStyleBackColor = true;
            this.radioButtonOffice2007Blue.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonOffice2010Black
            // 
            this.radioButtonOffice2010Black.AutoSize = true;
            this.radioButtonOffice2010Black.Location = new System.Drawing.Point(14, 68);
            this.radioButtonOffice2010Black.Name = "radioButtonOffice2010Black";
            this.radioButtonOffice2010Black.Size = new System.Drawing.Size(143, 21);
            this.radioButtonOffice2010Black.TabIndex = 2;
            this.radioButtonOffice2010Black.Tag = "0";
            this.radioButtonOffice2010Black.Text = "Office 2010 - Black";
            this.radioButtonOffice2010Black.UseVisualStyleBackColor = true;
            this.radioButtonOffice2010Black.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonOffice2010Silver
            // 
            this.radioButtonOffice2010Silver.AutoSize = true;
            this.radioButtonOffice2010Silver.Location = new System.Drawing.Point(14, 45);
            this.radioButtonOffice2010Silver.Name = "radioButtonOffice2010Silver";
            this.radioButtonOffice2010Silver.Size = new System.Drawing.Size(144, 21);
            this.radioButtonOffice2010Silver.TabIndex = 1;
            this.radioButtonOffice2010Silver.Tag = "0";
            this.radioButtonOffice2010Silver.Text = "Office 2010 - Silver";
            this.radioButtonOffice2010Silver.UseVisualStyleBackColor = true;
            this.radioButtonOffice2010Silver.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // radioButtonOffice2010Blue
            // 
            this.radioButtonOffice2010Blue.AutoSize = true;
            this.radioButtonOffice2010Blue.Checked = true;
            this.radioButtonOffice2010Blue.Location = new System.Drawing.Point(14, 22);
            this.radioButtonOffice2010Blue.Name = "radioButtonOffice2010Blue";
            this.radioButtonOffice2010Blue.Size = new System.Drawing.Size(137, 21);
            this.radioButtonOffice2010Blue.TabIndex = 0;
            this.radioButtonOffice2010Blue.TabStop = true;
            this.radioButtonOffice2010Blue.Tag = "0";
            this.radioButtonOffice2010Blue.Text = "Office 2010 - Blue";
            this.radioButtonOffice2010Blue.UseVisualStyleBackColor = true;
            this.radioButtonOffice2010Blue.CheckedChanged += new System.EventHandler(this.palette_CheckedChanged);
            // 
            // chkRightAlign
            // 
            this.chkRightAlign.AutoSize = true;
            this.chkRightAlign.Location = new System.Drawing.Point(329, 330);
            this.chkRightAlign.Name = "chkRightAlign";
            this.chkRightAlign.Size = new System.Drawing.Size(216, 21);
            this.chkRightAlign.TabIndex = 6;
            this.chkRightAlign.Text = "MessageBoxOptions.RightAlign";
            this.chkRightAlign.UseVisualStyleBackColor = true;
            this.chkRightAlign.CheckedChanged += new System.EventHandler(this.ChkRightAlign_CheckedChanged);
            // 
            // chkRtlReading
            // 
            this.chkRtlReading.AutoSize = true;
            this.chkRtlReading.Location = new System.Drawing.Point(329, 357);
            this.chkRtlReading.Name = "chkRtlReading";
            this.chkRtlReading.Size = new System.Drawing.Size(221, 21);
            this.chkRtlReading.TabIndex = 7;
            this.chkRtlReading.Text = "MessageBoxOptions.RtlReading";
            this.chkRtlReading.UseVisualStyleBackColor = true;
            this.chkRtlReading.CheckedChanged += new System.EventHandler(this.ChkRtlReading_CheckedChanged);
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2010Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BlurValues.BlurWhenFocusLost = true;
            this.ClientSize = new System.Drawing.Size(557, 473);
            this.Controls.Add(this.chkRtlReading);
            this.Controls.Add(this.chkRightAlign);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxIcon);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxCaption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "KryptonMessageBox Examples";
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon.Panel)).EndInit();
            this.groupBoxIcon.Panel.ResumeLayout(false);
            this.groupBoxIcon.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon)).EndInit();
            this.groupBoxIcon.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxButtons.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel label1;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox textBoxCaption;
        private System.Windows.Forms.TextBox textBoxMessage;
        private Krypton.Toolkit.KryptonRadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonError;
        private System.Windows.Forms.RadioButton radioButtonQuestion;
        private System.Windows.Forms.RadioButton radioButtonWarning;
        private System.Windows.Forms.RadioButton radioButtonInformation;
        private System.Windows.Forms.RadioButton radioButtonOK;
        private System.Windows.Forms.RadioButton radioButtonOKCancel;
        private System.Windows.Forms.RadioButton radioButtonAbortRetryIgnore;
        private System.Windows.Forms.RadioButton radioButtonYesNoCancel;
        private Krypton.Toolkit.KryptonGroupBox groupBoxIcon;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.RadioButton radioButtonYesNo;
        private System.Windows.Forms.RadioButton radioButtonRetryCancel;
        private System.Windows.Forms.Button buttonShow;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonSystem;
        private System.Windows.Forms.RadioButton radioButtonOffice2003;
        private System.Windows.Forms.RadioButton radioButtonSparklePurple;
        private System.Windows.Forms.RadioButton radioButtonSparkleOrange;
        private System.Windows.Forms.RadioButton radioButtonSparkleBlue;
        private System.Windows.Forms.RadioButton radioButtonOffice2007Black;
        private System.Windows.Forms.RadioButton radioButtonOffice2007Silver;
        private System.Windows.Forms.RadioButton radioButtonOffice2007Blue;
        private System.Windows.Forms.RadioButton radioButtonOffice2010Black;
        private System.Windows.Forms.RadioButton radioButtonOffice2010Silver;
        private System.Windows.Forms.RadioButton radioButtonOffice2010Blue;
        private System.Windows.Forms.RadioButton radioButtonOffice365Blue;
        private System.Windows.Forms.CheckBox chkRightAlign;
        private System.Windows.Forms.CheckBox chkRtlReading;
        private System.Windows.Forms.RadioButton radioButtonWinLogo;
    }
}

