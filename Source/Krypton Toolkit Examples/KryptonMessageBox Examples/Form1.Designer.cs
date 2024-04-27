namespace KryptonMessageBoxExamples
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
            this.textBoxCaption = new Krypton.Toolkit.KryptonTextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.radioButtonNone = new Krypton.Toolkit.KryptonRadioButton();
            this.groupBoxIcon = new Krypton.Toolkit.KryptonGroupBox();
            this.kcmbIcons = new Krypton.Toolkit.KryptonComboBox();
            this.rbShield = new Krypton.Toolkit.KryptonRadioButton();
            this.kradWinLogo = new Krypton.Toolkit.KryptonRadioButton();
            this.kradQuestion = new Krypton.Toolkit.KryptonRadioButton();
            this.kradError = new Krypton.Toolkit.KryptonRadioButton();
            this.kradInformation = new Krypton.Toolkit.KryptonRadioButton();
            this.kradWarning = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kradYesNo = new Krypton.Toolkit.KryptonRadioButton();
            this.kradCancelTryContinue = new Krypton.Toolkit.KryptonRadioButton();
            this.kradRetryCancel = new Krypton.Toolkit.KryptonRadioButton();
            this.kradOK = new Krypton.Toolkit.KryptonRadioButton();
            this.kradYesNoCancel = new Krypton.Toolkit.KryptonRadioButton();
            this.kradAbortRetryIgnore = new Krypton.Toolkit.KryptonRadioButton();
            this.kradOKCancel = new Krypton.Toolkit.KryptonRadioButton();
            this.kbtnShow = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnDummyText = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ktxtResourcePath = new Krypton.Toolkit.KryptonTextBox();
            this.bsaBrowse = new Krypton.Toolkit.ButtonSpecAny();
            this.knudLinkAreaEnd = new Krypton.Toolkit.KryptonNumericUpDown();
            this.klblLinkAreaEnd = new Krypton.Toolkit.KryptonLabel();
            this.knudLinkAreaStart = new Krypton.Toolkit.KryptonNumericUpDown();
            this.klblLinkAreaStart = new Krypton.Toolkit.KryptonLabel();
            this.kcmbContentAreaType = new Krypton.Toolkit.KryptonComboBox();
            this.chkShowHelp = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            this.kchkRtlReading = new Krypton.Toolkit.KryptonCheckBox();
            this.kchkRightAlign = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kcmdTest = new Krypton.Toolkit.KryptonCommand();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon.Panel)).BeginInit();
            this.groupBoxIcon.Panel.SuspendLayout();
            this.groupBoxIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbContentAreaType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Target = this.textBoxCaption;
            this.label1.Values.Text = "&Caption";
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.textBoxCaption.Location = new System.Drawing.Point(70, 21);
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(246, 23);
            this.textBoxCaption.TabIndex = 1;
            this.textBoxCaption.Text = "Caption";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(70, 52);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(246, 112);
            this.textBoxMessage.TabIndex = 2;
            this.textBoxMessage.Text = "This is a message box!";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.Location = new System.Drawing.Point(14, 3);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(52, 20);
            this.radioButtonNone.TabIndex = 0;
            this.radioButtonNone.Tag = "0";
            this.radioButtonNone.Values.Text = "&None";
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // groupBoxIcon
            // 
            this.groupBoxIcon.Location = new System.Drawing.Point(331, 318);
            this.groupBoxIcon.Name = "groupBoxIcon";
            // 
            // groupBoxIcon.Panel
            // 
            this.groupBoxIcon.Panel.Controls.Add(this.kcmbIcons);
            this.groupBoxIcon.Panel.Controls.Add(this.rbShield);
            this.groupBoxIcon.Panel.Controls.Add(this.kradWinLogo);
            this.groupBoxIcon.Panel.Controls.Add(this.kradQuestion);
            this.groupBoxIcon.Panel.Controls.Add(this.kradError);
            this.groupBoxIcon.Panel.Controls.Add(this.kradInformation);
            this.groupBoxIcon.Panel.Controls.Add(this.radioButtonNone);
            this.groupBoxIcon.Panel.Controls.Add(this.kradWarning);
            this.groupBoxIcon.Size = new System.Drawing.Size(331, 172);
            this.groupBoxIcon.TabIndex = 5;
            this.groupBoxIcon.Values.Heading = "Icon";
            // 
            // kcmbIcons
            // 
            this.kcmbIcons.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kcmbIcons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbIcons.DropDownWidth = 215;
            this.kcmbIcons.IntegralHeight = false;
            this.kcmbIcons.Location = new System.Drawing.Point(14, 114);
            this.kcmbIcons.Name = "kcmbIcons";
            this.kcmbIcons.Size = new System.Drawing.Size(298, 21);
            this.kcmbIcons.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbIcons.TabIndex = 7;
            this.kcmbIcons.SelectedIndexChanged += new System.EventHandler(this.kcmbIcons_SelectedIndexChanged);
            // 
            // rbShield
            // 
            this.rbShield.Location = new System.Drawing.Point(111, 29);
            this.rbShield.Name = "rbShield";
            this.rbShield.Size = new System.Drawing.Size(56, 20);
            this.rbShield.TabIndex = 5;
            this.rbShield.Values.Text = "&Shield";
            this.rbShield.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // kradWinLogo
            // 
            this.kradWinLogo.Location = new System.Drawing.Point(111, 53);
            this.kradWinLogo.Name = "kradWinLogo";
            this.kradWinLogo.Size = new System.Drawing.Size(72, 20);
            this.kradWinLogo.TabIndex = 6;
            this.kradWinLogo.Values.Text = "Win&Logo";
            this.kradWinLogo.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // kradQuestion
            // 
            this.kradQuestion.Location = new System.Drawing.Point(14, 53);
            this.kradQuestion.Name = "kradQuestion";
            this.kradQuestion.Size = new System.Drawing.Size(72, 20);
            this.kradQuestion.TabIndex = 2;
            this.kradQuestion.Values.Text = "&Question";
            this.kradQuestion.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // kradError
            // 
            this.kradError.Location = new System.Drawing.Point(14, 29);
            this.kradError.Name = "kradError";
            this.kradError.Size = new System.Drawing.Size(49, 20);
            this.kradError.TabIndex = 1;
            this.kradError.Values.Text = "&Error";
            this.kradError.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // kradInformation
            // 
            this.kradInformation.Location = new System.Drawing.Point(111, 3);
            this.kradInformation.Name = "kradInformation";
            this.kradInformation.Size = new System.Drawing.Size(87, 20);
            this.kradInformation.TabIndex = 4;
            this.kradInformation.Values.Text = "&Information";
            this.kradInformation.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // kradWarning
            // 
            this.kradWarning.Checked = true;
            this.kradWarning.Location = new System.Drawing.Point(14, 79);
            this.kradWarning.Name = "kradWarning";
            this.kradWarning.Size = new System.Drawing.Size(69, 20);
            this.kradWarning.TabIndex = 3;
            this.kradWarning.Values.Text = "&Warning";
            this.kradWarning.CheckedChanged += new System.EventHandler(this.icon_CheckedChanged);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(331, 176);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kradYesNo);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kradCancelTryContinue);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kradRetryCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kradOK);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kradYesNoCancel);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kradAbortRetryIgnore);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kradOKCancel);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(331, 136);
            this.kryptonGroupBox1.TabIndex = 6;
            this.kryptonGroupBox1.Values.Heading = "Buttons";
            // 
            // kradYesNo
            // 
            this.kradYesNo.Location = new System.Drawing.Point(169, 55);
            this.kradYesNo.Name = "kradYesNo";
            this.kradYesNo.Size = new System.Drawing.Size(61, 20);
            this.kradYesNo.TabIndex = 6;
            this.kradYesNo.Values.Text = "Yes No";
            this.kradYesNo.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // kradCancelTryContinue
            // 
            this.kradCancelTryContinue.Location = new System.Drawing.Point(14, 81);
            this.kradCancelTryContinue.Name = "kradCancelTryContinue";
            this.kradCancelTryContinue.Size = new System.Drawing.Size(132, 20);
            this.kradCancelTryContinue.TabIndex = 3;
            this.kradCancelTryContinue.ToolTipValues.Description = "This option will only work if using .NET 6 or greater";
            this.kradCancelTryContinue.ToolTipValues.EnableToolTips = true;
            this.kradCancelTryContinue.Values.Text = "Cancel Try Continue";
            this.kradCancelTryContinue.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // kradRetryCancel
            // 
            this.kradRetryCancel.Location = new System.Drawing.Point(14, 55);
            this.kradRetryCancel.Name = "kradRetryCancel";
            this.kradRetryCancel.Size = new System.Drawing.Size(90, 20);
            this.kradRetryCancel.TabIndex = 2;
            this.kradRetryCancel.Values.Text = "Retry Cancel";
            this.kradRetryCancel.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // kradOK
            // 
            this.kradOK.Location = new System.Drawing.Point(14, 3);
            this.kradOK.Name = "kradOK";
            this.kradOK.Size = new System.Drawing.Size(39, 20);
            this.kradOK.TabIndex = 0;
            this.kradOK.Values.Text = "OK";
            this.kradOK.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // kradYesNoCancel
            // 
            this.kradYesNoCancel.Location = new System.Drawing.Point(169, 29);
            this.kradYesNoCancel.Name = "kradYesNoCancel";
            this.kradYesNoCancel.Size = new System.Drawing.Size(100, 20);
            this.kradYesNoCancel.TabIndex = 5;
            this.kradYesNoCancel.Values.Text = "Yes No Cancel";
            this.kradYesNoCancel.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // kradAbortRetryIgnore
            // 
            this.kradAbortRetryIgnore.Location = new System.Drawing.Point(169, 3);
            this.kradAbortRetryIgnore.Name = "kradAbortRetryIgnore";
            this.kradAbortRetryIgnore.Size = new System.Drawing.Size(124, 20);
            this.kradAbortRetryIgnore.TabIndex = 4;
            this.kradAbortRetryIgnore.Values.Text = "Abort Retry Ignore";
            this.kradAbortRetryIgnore.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // kradOKCancel
            // 
            this.kradOKCancel.Checked = true;
            this.kradOKCancel.Location = new System.Drawing.Point(14, 29);
            this.kradOKCancel.Name = "kradOKCancel";
            this.kradOKCancel.Size = new System.Drawing.Size(78, 20);
            this.kradOKCancel.TabIndex = 1;
            this.kradOKCancel.Values.Text = "OK Cancel";
            this.kradOKCancel.CheckedChanged += new System.EventHandler(this.buttons_CheckedChanged);
            // 
            // kbtnShow
            // 
            this.kbtnShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnShow.Location = new System.Drawing.Point(70, 503);
            this.kbtnShow.Name = "kbtnShow";
            this.kbtnShow.Size = new System.Drawing.Size(592, 57);
            this.kbtnShow.TabIndex = 7;
            this.kbtnShow.Values.Text = "Show";
            this.kbtnShow.Click += new System.EventHandler(this.kbtnShow_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnDummyText);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.chkShowHelp);
            this.kryptonPanel1.Controls.Add(this.kbtnShow);
            this.kryptonPanel1.Controls.Add(this.kryptonThemeComboBox1);
            this.kryptonPanel1.Controls.Add(this.kchkRtlReading);
            this.kryptonPanel1.Controls.Add(this.kchkRightAlign);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.groupBoxIcon);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(690, 574);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnDummyText
            // 
            this.kbtnDummyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnDummyText.Location = new System.Drawing.Point(331, 149);
            this.kbtnDummyText.Name = "kbtnDummyText";
            this.kbtnDummyText.Size = new System.Drawing.Size(148, 26);
            this.kbtnDummyText.TabIndex = 10;
            this.kbtnDummyText.Values.Text = "Insert Dummy Text";
            this.kbtnDummyText.Click += new System.EventHandler(this.kbtnDummyText_Click);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(70, 176);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox2.Panel.Controls.Add(this.ktxtResourcePath);
            this.kryptonGroupBox2.Panel.Controls.Add(this.knudLinkAreaEnd);
            this.kryptonGroupBox2.Panel.Controls.Add(this.klblLinkAreaEnd);
            this.kryptonGroupBox2.Panel.Controls.Add(this.knudLinkAreaStart);
            this.kryptonGroupBox2.Panel.Controls.Add(this.klblLinkAreaStart);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kcmbContentAreaType);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(246, 187);
            this.kryptonGroupBox2.TabIndex = 9;
            this.kryptonGroupBox2.Values.Heading = "Content Area Type";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(14, 107);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(96, 20);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Text Alignment:";
            // 
            // ktxtResourcePath
            // 
            this.ktxtResourcePath.ButtonSpecs.Add(this.bsaBrowse);
            this.ktxtResourcePath.Enabled = false;
            this.ktxtResourcePath.Location = new System.Drawing.Point(14, 77);
            this.ktxtResourcePath.Name = "ktxtResourcePath";
            this.ktxtResourcePath.Size = new System.Drawing.Size(215, 24);
            this.ktxtResourcePath.TabIndex = 5;
            // 
            // bsaBrowse
            // 
            this.bsaBrowse.Text = "...";
            this.bsaBrowse.UniqueName = "ffe02cb1dc9f459c96d1eaf55bd7e985";
            this.bsaBrowse.Click += new System.EventHandler(this.bsaBrowse_Click);
            // 
            // knudLinkAreaEnd
            // 
            this.knudLinkAreaEnd.Enabled = false;
            this.knudLinkAreaEnd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudLinkAreaEnd.Location = new System.Drawing.Point(160, 40);
            this.knudLinkAreaEnd.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knudLinkAreaEnd.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudLinkAreaEnd.Name = "knudLinkAreaEnd";
            this.knudLinkAreaEnd.Size = new System.Drawing.Size(55, 22);
            this.knudLinkAreaEnd.TabIndex = 4;
            this.knudLinkAreaEnd.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // klblLinkAreaEnd
            // 
            this.klblLinkAreaEnd.Enabled = false;
            this.klblLinkAreaEnd.Location = new System.Drawing.Point(120, 40);
            this.klblLinkAreaEnd.Name = "klblLinkAreaEnd";
            this.klblLinkAreaEnd.Size = new System.Drawing.Size(34, 20);
            this.klblLinkAreaEnd.TabIndex = 3;
            this.klblLinkAreaEnd.Values.Text = "End:";
            // 
            // knudLinkAreaStart
            // 
            this.knudLinkAreaStart.Enabled = false;
            this.knudLinkAreaStart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudLinkAreaStart.Location = new System.Drawing.Point(59, 40);
            this.knudLinkAreaStart.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knudLinkAreaStart.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudLinkAreaStart.Name = "knudLinkAreaStart";
            this.knudLinkAreaStart.Size = new System.Drawing.Size(55, 22);
            this.knudLinkAreaStart.TabIndex = 2;
            this.knudLinkAreaStart.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // klblLinkAreaStart
            // 
            this.klblLinkAreaStart.Enabled = false;
            this.klblLinkAreaStart.Location = new System.Drawing.Point(14, 40);
            this.klblLinkAreaStart.Name = "klblLinkAreaStart";
            this.klblLinkAreaStart.Size = new System.Drawing.Size(39, 20);
            this.klblLinkAreaStart.TabIndex = 1;
            this.klblLinkAreaStart.Values.Text = "Start:";
            // 
            // kcmbContentAreaType
            // 
            this.kcmbContentAreaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbContentAreaType.DropDownWidth = 215;
            this.kcmbContentAreaType.IntegralHeight = false;
            this.kcmbContentAreaType.Location = new System.Drawing.Point(14, 9);
            this.kcmbContentAreaType.Name = "kcmbContentAreaType";
            this.kcmbContentAreaType.Size = new System.Drawing.Size(215, 21);
            this.kcmbContentAreaType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbContentAreaType.TabIndex = 0;
            this.kcmbContentAreaType.SelectedIndexChanged += new System.EventHandler(this.kcmbContentAreaType_SelectedIndexChanged);
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.Location = new System.Drawing.Point(331, 123);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Size = new System.Drawing.Size(82, 20);
            this.chkShowHelp.TabIndex = 8;
            this.chkShowHelp.Values.Text = "Show &Help";
            // 
            // kryptonThemeComboBox1
            // 
            this.kryptonThemeComboBox1.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonThemeComboBox1.DropDownWidth = 340;
            this.kryptonThemeComboBox1.IntegralHeight = false;
            this.kryptonThemeComboBox1.Location = new System.Drawing.Point(322, 23);
            this.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            this.kryptonThemeComboBox1.Size = new System.Drawing.Size(340, 21);
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonThemeComboBox1.TabIndex = 2;
            // 
            // kchkRtlReading
            // 
            this.kchkRtlReading.Location = new System.Drawing.Point(331, 93);
            this.kchkRtlReading.Name = "kchkRtlReading";
            this.kchkRtlReading.Size = new System.Drawing.Size(197, 20);
            this.kchkRtlReading.TabIndex = 4;
            this.kchkRtlReading.Values.Text = "MessageBoxOptions.RtlReading";
            this.kchkRtlReading.Click += new System.EventHandler(this.ChkRtlReading_CheckedChanged);
            // 
            // kchkRightAlign
            // 
            this.kchkRightAlign.Location = new System.Drawing.Point(331, 67);
            this.kchkRightAlign.Name = "kchkRightAlign";
            this.kchkRightAlign.Size = new System.Drawing.Size(195, 20);
            this.kchkRightAlign.TabIndex = 3;
            this.kchkRightAlign.Values.Text = "MessageBoxOptions.RightAlign";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 52);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Target = this.textBoxMessage;
            this.kryptonLabel1.Values.Text = "&Message";
            // 
            // kcmdTest
            // 
            this.kcmdTest.Text = "kryptonCommand1";
            this.kcmdTest.Execute += new System.EventHandler(this.kcmdTest_Execute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 574);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxCaption);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonMessageBox Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.ChkRightAlign_CheckedChanged);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon.Panel)).EndInit();
            this.groupBoxIcon.Panel.ResumeLayout(false);
            this.groupBoxIcon.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxIcon)).EndInit();
            this.groupBoxIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbContentAreaType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel label1;
        private Krypton.Toolkit.KryptonTextBox textBoxCaption;
        private System.Windows.Forms.TextBox textBoxMessage;
        private Krypton.Toolkit.KryptonRadioButton radioButtonNone;
        private Krypton.Toolkit.KryptonGroupBox groupBoxIcon;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonRadioButton kradWinLogo;
        private Krypton.Toolkit.KryptonRadioButton kradQuestion;
        private Krypton.Toolkit.KryptonRadioButton kradError;
        private Krypton.Toolkit.KryptonRadioButton kradInformation;
        private Krypton.Toolkit.KryptonRadioButton kradWarning;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonRadioButton kradYesNo;
        private Krypton.Toolkit.KryptonRadioButton kradCancelTryContinue;
        private Krypton.Toolkit.KryptonRadioButton kradRetryCancel;
        private Krypton.Toolkit.KryptonRadioButton kradOK;
        private Krypton.Toolkit.KryptonRadioButton kradYesNoCancel;
        private Krypton.Toolkit.KryptonRadioButton kradAbortRetryIgnore;
        private Krypton.Toolkit.KryptonRadioButton kradOKCancel;
        private Krypton.Toolkit.KryptonButton kbtnShow;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonCheckBox kchkRtlReading;
        private Krypton.Toolkit.KryptonCheckBox kchkRightAlign;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Krypton.Toolkit.KryptonRadioButton rbShield;
        private Krypton.Toolkit.KryptonCheckBox chkShowHelp;
        private Krypton.Toolkit.KryptonComboBox kcmbIcons;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonComboBox kcmbContentAreaType;
        private Krypton.Toolkit.KryptonLabel klblLinkAreaStart;
        private Krypton.Toolkit.KryptonNumericUpDown knudLinkAreaEnd;
        private Krypton.Toolkit.KryptonLabel klblLinkAreaEnd;
        private Krypton.Toolkit.KryptonNumericUpDown knudLinkAreaStart;
        private Krypton.Toolkit.KryptonTextBox ktxtResourcePath;
        private Krypton.Toolkit.ButtonSpecAny bsaBrowse;
        private Krypton.Toolkit.KryptonCommand kcmdTest;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton kbtnDummyText;
    }
}

