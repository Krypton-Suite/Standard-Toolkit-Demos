namespace KryptonTaskDialogExamples;

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
        this.labelCaption = new System.Windows.Forms.Label();
        this.labelMainInstructions = new System.Windows.Forms.Label();
        this.labelContent = new System.Windows.Forms.Label();
        this.textBoxCaption = new System.Windows.Forms.TextBox();
        this.textBoxMainInstructions = new System.Windows.Forms.TextBox();
        this.textBoxContent = new System.Windows.Forms.TextBox();
        this.buttonShowTaskDialog = new System.Windows.Forms.Button();
        this.kryptonTaskDialog = new Krypton.Toolkit.KryptonTaskDialog();
        this.kryptonTaskDialogCommandLinkButton1 = new Krypton.Toolkit.InternalKryptonCommandLinkButton();
        this.kryptonTaskDialogCommandLinkButton2 = new Krypton.Toolkit.InternalKryptonCommandLinkButton();
        this.kryptonTaskDialogCommandLinkButton3 = new Krypton.Toolkit.InternalKryptonCommandLinkButton();
        this.kryptonTaskDialogRadioButton1 = new Krypton.Toolkit.KryptonRadioButton();
        this.kryptonTaskDialogRadioButton2 = new Krypton.Toolkit.KryptonRadioButton();
        this.kryptonTaskDialogRadioButton3 = new Krypton.Toolkit.KryptonRadioButton();
        this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
        this.checkBoxOK = new System.Windows.Forms.CheckBox();
        this.checkBoxYes = new System.Windows.Forms.CheckBox();
        this.checkBoxNo = new System.Windows.Forms.CheckBox();
        this.checkBoxCancel = new System.Windows.Forms.CheckBox();
        this.checkBoxClose = new System.Windows.Forms.CheckBox();
        this.checkBoxRetry = new System.Windows.Forms.CheckBox();
        this.groupBoxBasic = new System.Windows.Forms.GroupBox();
        this.buttonFill = new System.Windows.Forms.Button();
        this.comboBoxIcon = new System.Windows.Forms.ComboBox();
        this.labelIcon = new System.Windows.Forms.Label();
        this.groupBoxFooter = new System.Windows.Forms.GroupBox();
        this.comboBoxFooterIcon = new System.Windows.Forms.ComboBox();
        this.labelFooterIcon = new System.Windows.Forms.Label();
        this.labelFooterText = new System.Windows.Forms.Label();
        this.labelFooterHyperlink = new System.Windows.Forms.Label();
        this.textBoxFooterText = new System.Windows.Forms.TextBox();
        this.textBoxFooterHyperlink = new System.Windows.Forms.TextBox();
        this.groupBoxCheckBox = new System.Windows.Forms.GroupBox();
        this.checkBoxInitialState = new System.Windows.Forms.CheckBox();
        this.label1 = new System.Windows.Forms.Label();
        this.textBoxCheckBoxText = new System.Windows.Forms.TextBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.checkBoxCommandButtons = new System.Windows.Forms.CheckBox();
        this.checkBoxRadioButtons = new System.Windows.Forms.CheckBox();
        this.groupBoxPalette = new System.Windows.Forms.GroupBox();
        this.paletteSparkleOrange = new System.Windows.Forms.RadioButton();
        this.palette2010Black = new System.Windows.Forms.RadioButton();
        this.palette2010Silver = new System.Windows.Forms.RadioButton();
        this.paletteProfessional = new System.Windows.Forms.RadioButton();
        this.palette2007Blue = new System.Windows.Forms.RadioButton();
        this.palette2010Blue = new System.Windows.Forms.RadioButton();
        this.groupBoxBasic.SuspendLayout();
        this.groupBoxFooter.SuspendLayout();
        this.groupBoxCheckBox.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBoxPalette.SuspendLayout();
        this.SuspendLayout();
        // 
        // labelCaption
        // 
        this.labelCaption.AutoSize = true;
        this.labelCaption.Location = new System.Drawing.Point(23, 39);
        this.labelCaption.Name = "labelCaption";
        this.labelCaption.Size = new System.Drawing.Size(68, 13);
        this.labelCaption.TabIndex = 0;
        this.labelCaption.Text = "Window Title";
        // 
        // labelMainInstructions
        // 
        this.labelMainInstructions.AutoSize = true;
        this.labelMainInstructions.Location = new System.Drawing.Point(-2, 68);
        this.labelMainInstructions.Name = "labelMainInstructions";
        this.labelMainInstructions.Size = new System.Drawing.Size(89, 13);
        this.labelMainInstructions.TabIndex = 1;
        this.labelMainInstructions.Text = "Main Instructions";
        // 
        // labelContent
        // 
        this.labelContent.AutoSize = true;
        this.labelContent.Location = new System.Drawing.Point(51, 94);
        this.labelContent.Name = "labelContent";
        this.labelContent.Size = new System.Drawing.Size(46, 13);
        this.labelContent.TabIndex = 2;
        this.labelContent.Text = "Content";
        // 
        // textBoxCaption
        // 
        this.textBoxCaption.Location = new System.Drawing.Point(111, 36);
        this.textBoxCaption.Name = "textBoxCaption";
        this.textBoxCaption.Size = new System.Drawing.Size(214, 21);
        this.textBoxCaption.TabIndex = 3;
        this.textBoxCaption.Text = "Window Title";
        // 
        // textBoxMainInstructions
        // 
        this.textBoxMainInstructions.Location = new System.Drawing.Point(111, 65);
        this.textBoxMainInstructions.Name = "textBoxMainInstructions";
        this.textBoxMainInstructions.Size = new System.Drawing.Size(214, 21);
        this.textBoxMainInstructions.TabIndex = 4;
        this.textBoxMainInstructions.Text = "Main Instructions";
        // 
        // textBoxContent
        // 
        this.textBoxContent.Location = new System.Drawing.Point(111, 91);
        this.textBoxContent.Multiline = true;
        this.textBoxContent.Name = "textBoxContent";
        this.textBoxContent.Size = new System.Drawing.Size(214, 68);
        this.textBoxContent.TabIndex = 5;
        this.textBoxContent.Text = "Content";
        // 
        // buttonShowTaskDialog
        // 
        this.buttonShowTaskDialog.Location = new System.Drawing.Point(396, 341);
        this.buttonShowTaskDialog.Name = "buttonShowTaskDialog";
        this.buttonShowTaskDialog.Size = new System.Drawing.Size(254, 59);
        this.buttonShowTaskDialog.TabIndex = 6;
        this.buttonShowTaskDialog.Text = "Show TaskDialog";
        this.buttonShowTaskDialog.UseVisualStyleBackColor = true;
        this.buttonShowTaskDialog.Click += new System.EventHandler(this.buttonShowTaskDialog_Click);
        // 
        // kryptonTaskDialog
        // 
        this.kryptonTaskDialog.CheckBox.Checked = false;
        this.kryptonTaskDialog.CheckBox.Text = string.Empty;
        this.kryptonTaskDialog.CheckBox.Visible = false;
        this.kryptonTaskDialog.CommandLinkButtons.Buttons.Add(this.kryptonTaskDialogCommandLinkButton1);
        this.kryptonTaskDialog.CommandLinkButtons.Buttons.Add(this.kryptonTaskDialogCommandLinkButton2);
        this.kryptonTaskDialog.CommandLinkButtons.Buttons.Add(this.kryptonTaskDialogCommandLinkButton3);
        this.kryptonTaskDialog.CommandLinkButtons.Visible = false;
        this.kryptonTaskDialog.Content.Text = string.Empty;
        this.kryptonTaskDialog.Content.Visible = true;
        this.kryptonTaskDialog.Dialog.Form.Text = string.Empty;
        this.kryptonTaskDialog.FooterBar.CommonButtons.AcceptButton = Krypton.Toolkit.KryptonTaskDialogCommonButtonTypes.OK;
        this.kryptonTaskDialog.FooterBar.CommonButtons.Buttons = Krypton.Toolkit.KryptonTaskDialogCommonButtonTypes.OK;
        this.kryptonTaskDialog.FooterBar.CommonButtons.CancelButton = Krypton.Toolkit.KryptonTaskDialogCommonButtonTypes.None;
        this.kryptonTaskDialog.FooterBar.Footer.EnableExpanderControls = false;
        this.kryptonTaskDialog.FooterBar.Footer.FootNoteText = string.Empty;
        this.kryptonTaskDialog.FooterBar.Footer.IconType = Krypton.Toolkit.KryptonTaskDialogIconType.None;
        this.kryptonTaskDialog.FreeWheeler1.Visible = false;
        this.kryptonTaskDialog.Heading.IconType = Krypton.Toolkit.KryptonTaskDialogIconType.None;
        this.kryptonTaskDialog.Heading.Text = string.Empty;
        this.kryptonTaskDialog.Heading.Visible = true;
        //
        // kryptonTaskDialogCommandLinkButton1
        //
        this.kryptonTaskDialogCommandLinkButton1.CommandLinkTextValues.Description = "First command link button";
        this.kryptonTaskDialogCommandLinkButton1.CommandLinkTextValues.UseDefaultImage = false;
        this.kryptonTaskDialogCommandLinkButton1.CommandLinkTextValues.Image = global::KryptonTaskDialogExamples.Properties.Resources.arrow_right_green;
        this.kryptonTaskDialogCommandLinkButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.kryptonTaskDialogCommandLinkButton1.Name = "kryptonTaskDialogCommandLinkButton1";
        this.kryptonTaskDialogCommandLinkButton1.Text = "Command One";
        //
        // kryptonTaskDialogCommandLinkButton2
        //
        this.kryptonTaskDialogCommandLinkButton2.CommandLinkTextValues.Description = "Second command link button";
        this.kryptonTaskDialogCommandLinkButton2.CommandLinkTextValues.UseDefaultImage = false;
        this.kryptonTaskDialogCommandLinkButton2.CommandLinkTextValues.Image = global::KryptonTaskDialogExamples.Properties.Resources.arrow_right_green;
        this.kryptonTaskDialogCommandLinkButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.kryptonTaskDialogCommandLinkButton2.Name = "kryptonTaskDialogCommandLinkButton2";
        this.kryptonTaskDialogCommandLinkButton2.Text = "Command Two";
        //
        // kryptonTaskDialogCommandLinkButton3
        //
        this.kryptonTaskDialogCommandLinkButton3.CommandLinkTextValues.Description = "Third command link button";
        this.kryptonTaskDialogCommandLinkButton3.CommandLinkTextValues.UseDefaultImage = false;
        this.kryptonTaskDialogCommandLinkButton3.CommandLinkTextValues.Image = global::KryptonTaskDialogExamples.Properties.Resources.arrow_right_green;
        this.kryptonTaskDialogCommandLinkButton3.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.kryptonTaskDialogCommandLinkButton3.Name = "kryptonTaskDialogCommandLinkButton3";
        this.kryptonTaskDialogCommandLinkButton3.Text = "Command Three";
        //
        // kryptonTaskDialogRadioButton1
        //
        this.kryptonTaskDialogRadioButton1.AutoSize = true;
        this.kryptonTaskDialogRadioButton1.Location = new System.Drawing.Point(0, 0);
        this.kryptonTaskDialogRadioButton1.Name = "kryptonTaskDialogRadioButton1";
        this.kryptonTaskDialogRadioButton1.Size = new System.Drawing.Size(83, 17);
        this.kryptonTaskDialogRadioButton1.TabIndex = 0;
        this.kryptonTaskDialogRadioButton1.Text = "First button";
        this.kryptonTaskDialogRadioButton1.Values.Text = "First button";
        //
        // kryptonTaskDialogRadioButton2
        //
        this.kryptonTaskDialogRadioButton2.AutoSize = true;
        this.kryptonTaskDialogRadioButton2.Location = new System.Drawing.Point(0, 0);
        this.kryptonTaskDialogRadioButton2.Name = "kryptonTaskDialogRadioButton2";
        this.kryptonTaskDialogRadioButton2.Size = new System.Drawing.Size(93, 17);
        this.kryptonTaskDialogRadioButton2.TabIndex = 1;
        this.kryptonTaskDialogRadioButton2.Text = "Second option";
        this.kryptonTaskDialogRadioButton2.Values.Text = "Second option";
        //
        // kryptonTaskDialogRadioButton3
        //
        this.kryptonTaskDialogRadioButton3.AutoSize = true;
        this.kryptonTaskDialogRadioButton3.Location = new System.Drawing.Point(0, 0);
        this.kryptonTaskDialogRadioButton3.Name = "kryptonTaskDialogRadioButton3";
        this.kryptonTaskDialogRadioButton3.Size = new System.Drawing.Size(77, 17);
        this.kryptonTaskDialogRadioButton3.TabIndex = 2;
        this.kryptonTaskDialogRadioButton3.Text = "Third option";
        this.kryptonTaskDialogRadioButton3.Values.Text = "Third option";
        // 
        // kryptonManager
        // 
        this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
        // 
        // checkBoxOK
        // 
        this.checkBoxOK.AutoSize = true;
        this.checkBoxOK.Checked = true;
        this.checkBoxOK.CheckState = System.Windows.Forms.CheckState.Checked;
        this.checkBoxOK.Location = new System.Drawing.Point(115, 201);
        this.checkBoxOK.Name = "checkBoxOK";
        this.checkBoxOK.Size = new System.Drawing.Size(40, 17);
        this.checkBoxOK.TabIndex = 7;
        this.checkBoxOK.Text = "OK";
        this.checkBoxOK.UseVisualStyleBackColor = true;
        // 
        // checkBoxYes
        // 
        this.checkBoxYes.AutoSize = true;
        this.checkBoxYes.Location = new System.Drawing.Point(115, 224);
        this.checkBoxYes.Name = "checkBoxYes";
        this.checkBoxYes.Size = new System.Drawing.Size(43, 17);
        this.checkBoxYes.TabIndex = 8;
        this.checkBoxYes.Text = "Yes";
        this.checkBoxYes.UseVisualStyleBackColor = true;
        // 
        // checkBoxNo
        // 
        this.checkBoxNo.AutoSize = true;
        this.checkBoxNo.Location = new System.Drawing.Point(187, 224);
        this.checkBoxNo.Name = "checkBoxNo";
        this.checkBoxNo.Size = new System.Drawing.Size(39, 17);
        this.checkBoxNo.TabIndex = 9;
        this.checkBoxNo.Text = "No";
        this.checkBoxNo.UseVisualStyleBackColor = true;
        // 
        // checkBoxCancel
        // 
        this.checkBoxCancel.AutoSize = true;
        this.checkBoxCancel.Checked = true;
        this.checkBoxCancel.CheckState = System.Windows.Forms.CheckState.Checked;
        this.checkBoxCancel.Location = new System.Drawing.Point(187, 201);
        this.checkBoxCancel.Name = "checkBoxCancel";
        this.checkBoxCancel.Size = new System.Drawing.Size(58, 17);
        this.checkBoxCancel.TabIndex = 10;
        this.checkBoxCancel.Text = "Cancel";
        this.checkBoxCancel.UseVisualStyleBackColor = true;
        // 
        // checkBoxClose
        // 
        this.checkBoxClose.AutoSize = true;
        this.checkBoxClose.Location = new System.Drawing.Point(269, 201);
        this.checkBoxClose.Name = "checkBoxClose";
        this.checkBoxClose.Size = new System.Drawing.Size(52, 17);
        this.checkBoxClose.TabIndex = 11;
        this.checkBoxClose.Text = "Close";
        this.checkBoxClose.UseVisualStyleBackColor = true;
        // 
        // checkBoxRetry
        // 
        this.checkBoxRetry.AutoSize = true;
        this.checkBoxRetry.Location = new System.Drawing.Point(270, 224);
        this.checkBoxRetry.Name = "checkBoxRetry";
        this.checkBoxRetry.Size = new System.Drawing.Size(53, 17);
        this.checkBoxRetry.TabIndex = 12;
        this.checkBoxRetry.Text = "Retry";
        this.checkBoxRetry.UseVisualStyleBackColor = true;
        // 
        // groupBoxBasic
        // 
        this.groupBoxBasic.Controls.Add(this.buttonFill);
        this.groupBoxBasic.Controls.Add(this.comboBoxIcon);
        this.groupBoxBasic.Controls.Add(this.labelIcon);
        this.groupBoxBasic.Controls.Add(this.labelCaption);
        this.groupBoxBasic.Controls.Add(this.checkBoxRetry);
        this.groupBoxBasic.Controls.Add(this.labelMainInstructions);
        this.groupBoxBasic.Controls.Add(this.checkBoxClose);
        this.groupBoxBasic.Controls.Add(this.labelContent);
        this.groupBoxBasic.Controls.Add(this.checkBoxCancel);
        this.groupBoxBasic.Controls.Add(this.textBoxCaption);
        this.groupBoxBasic.Controls.Add(this.checkBoxNo);
        this.groupBoxBasic.Controls.Add(this.textBoxMainInstructions);
        this.groupBoxBasic.Controls.Add(this.checkBoxYes);
        this.groupBoxBasic.Controls.Add(this.textBoxContent);
        this.groupBoxBasic.Controls.Add(this.checkBoxOK);
        this.groupBoxBasic.Location = new System.Drawing.Point(12, 12);
        this.groupBoxBasic.Name = "groupBoxBasic";
        this.groupBoxBasic.Size = new System.Drawing.Size(346, 259);
        this.groupBoxBasic.TabIndex = 13;
        this.groupBoxBasic.TabStop = false;
        this.groupBoxBasic.Text = "Basic Settings";
        // 
        // buttonFill
        // 
        this.buttonFill.Location = new System.Drawing.Point(64, 136);
        this.buttonFill.Name = "buttonFill";
        this.buttonFill.Size = new System.Drawing.Size(40, 23);
        this.buttonFill.TabIndex = 15;
        this.buttonFill.Text = "Fill";
        this.buttonFill.UseVisualStyleBackColor = true;
        this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
        // 
        // comboBoxIcon
        // 
        this.comboBoxIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBoxIcon.FormattingEnabled = true;
        this.comboBoxIcon.Items.AddRange(new object[] {
        "None",
        "Error",
        "Question",
        "Warning",
        "Information"});
        this.comboBoxIcon.Location = new System.Drawing.Point(111, 165);
        this.comboBoxIcon.Name = "comboBoxIcon";
        this.comboBoxIcon.Size = new System.Drawing.Size(214, 21);
        this.comboBoxIcon.TabIndex = 14;
        // 
        // labelIcon
        // 
        this.labelIcon.AutoSize = true;
        this.labelIcon.Location = new System.Drawing.Point(77, 168);
        this.labelIcon.Name = "labelIcon";
        this.labelIcon.Size = new System.Drawing.Size(28, 13);
        this.labelIcon.TabIndex = 13;
        this.labelIcon.Text = "Icon";
        // 
        // groupBoxFooter
        // 
        this.groupBoxFooter.Controls.Add(this.comboBoxFooterIcon);
        this.groupBoxFooter.Controls.Add(this.labelFooterIcon);
        this.groupBoxFooter.Controls.Add(this.labelFooterText);
        this.groupBoxFooter.Controls.Add(this.labelFooterHyperlink);
        this.groupBoxFooter.Controls.Add(this.textBoxFooterText);
        this.groupBoxFooter.Controls.Add(this.textBoxFooterHyperlink);
        this.groupBoxFooter.Location = new System.Drawing.Point(12, 277);
        this.groupBoxFooter.Name = "groupBoxFooter";
        this.groupBoxFooter.Size = new System.Drawing.Size(346, 123);
        this.groupBoxFooter.TabIndex = 14;
        this.groupBoxFooter.TabStop = false;
        this.groupBoxFooter.Text = "Footer Settings";
        // 
        // comboBoxFooterIcon
        // 
        this.comboBoxFooterIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBoxFooterIcon.FormattingEnabled = true;
        this.comboBoxFooterIcon.Items.AddRange(new object[] {
        "None",
        "Error",
        "Question",
        "Warning",
        "Information"});
        this.comboBoxFooterIcon.Location = new System.Drawing.Point(113, 84);
        this.comboBoxFooterIcon.Name = "comboBoxFooterIcon";
        this.comboBoxFooterIcon.Size = new System.Drawing.Size(214, 21);
        this.comboBoxFooterIcon.TabIndex = 10;
        // 
        // labelFooterIcon
        // 
        this.labelFooterIcon.AutoSize = true;
        this.labelFooterIcon.Location = new System.Drawing.Point(70, 87);
        this.labelFooterIcon.Name = "labelFooterIcon";
        this.labelFooterIcon.Size = new System.Drawing.Size(31, 13);
        this.labelFooterIcon.TabIndex = 9;
        this.labelFooterIcon.Text = " Icon";
        // 
        // labelFooterText
        // 
        this.labelFooterText.AutoSize = true;
        this.labelFooterText.Location = new System.Drawing.Point(73, 29);
        this.labelFooterText.Name = "labelFooterText";
        this.labelFooterText.Size = new System.Drawing.Size(29, 13);
        this.labelFooterText.TabIndex = 5;
        this.labelFooterText.Text = "Text";
        // 
        // labelFooterHyperlink
        // 
        this.labelFooterHyperlink.AutoSize = true;
        this.labelFooterHyperlink.Location = new System.Drawing.Point(45, 58);
        this.labelFooterHyperlink.Name = "labelFooterHyperlink";
        this.labelFooterHyperlink.Size = new System.Drawing.Size(51, 13);
        this.labelFooterHyperlink.TabIndex = 6;
        this.labelFooterHyperlink.Text = "Hyperlink";
        // 
        // textBoxFooterText
        // 
        this.textBoxFooterText.Location = new System.Drawing.Point(113, 26);
        this.textBoxFooterText.Name = "textBoxFooterText";
        this.textBoxFooterText.Size = new System.Drawing.Size(214, 21);
        this.textBoxFooterText.TabIndex = 7;
        this.textBoxFooterText.Text = "Footer Text";
        // 
        // textBoxFooterHyperlink
        // 
        this.textBoxFooterHyperlink.Location = new System.Drawing.Point(113, 55);
        this.textBoxFooterHyperlink.Name = "textBoxFooterHyperlink";
        this.textBoxFooterHyperlink.Size = new System.Drawing.Size(214, 21);
        this.textBoxFooterHyperlink.TabIndex = 8;
        this.textBoxFooterHyperlink.Text = "Hyperlink";
        // 
        // groupBoxCheckBox
        // 
        this.groupBoxCheckBox.Controls.Add(this.checkBoxInitialState);
        this.groupBoxCheckBox.Controls.Add(this.label1);
        this.groupBoxCheckBox.Controls.Add(this.textBoxCheckBoxText);
        this.groupBoxCheckBox.Location = new System.Drawing.Point(364, 12);
        this.groupBoxCheckBox.Name = "groupBoxCheckBox";
        this.groupBoxCheckBox.Size = new System.Drawing.Size(322, 88);
        this.groupBoxCheckBox.TabIndex = 15;
        this.groupBoxCheckBox.TabStop = false;
        this.groupBoxCheckBox.Text = "CheckBox Settings";
        // 
        // checkBoxInitialState
        // 
        this.checkBoxInitialState.AutoSize = true;
        this.checkBoxInitialState.Location = new System.Drawing.Point(68, 59);
        this.checkBoxInitialState.Name = "checkBoxInitialState";
        this.checkBoxInitialState.Size = new System.Drawing.Size(81, 17);
        this.checkBoxInitialState.TabIndex = 10;
        this.checkBoxInitialState.Text = "Initial State";
        this.checkBoxInitialState.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(19, 35);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(29, 13);
        this.label1.TabIndex = 8;
        this.label1.Text = "Text";
        // 
        // textBoxCheckBoxText
        // 
        this.textBoxCheckBoxText.Location = new System.Drawing.Point(68, 32);
        this.textBoxCheckBoxText.Name = "textBoxCheckBoxText";
        this.textBoxCheckBoxText.Size = new System.Drawing.Size(200, 21);
        this.textBoxCheckBoxText.TabIndex = 9;
        this.textBoxCheckBoxText.Text = "CheckBox Text";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.checkBoxCommandButtons);
        this.groupBox1.Controls.Add(this.checkBoxRadioButtons);
        this.groupBox1.Location = new System.Drawing.Point(364, 107);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(322, 91);
        this.groupBox1.TabIndex = 16;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Extra Settings";
        // 
        // checkBoxCommandButtons
        // 
        this.checkBoxCommandButtons.AutoSize = true;
        this.checkBoxCommandButtons.Checked = true;
        this.checkBoxCommandButtons.CheckState = System.Windows.Forms.CheckState.Checked;
        this.checkBoxCommandButtons.Location = new System.Drawing.Point(22, 54);
        this.checkBoxCommandButtons.Name = "checkBoxCommandButtons";
        this.checkBoxCommandButtons.Size = new System.Drawing.Size(185, 17);
        this.checkBoxCommandButtons.TabIndex = 12;
        this.checkBoxCommandButtons.Text = "Show Example Command Buttons";
        this.checkBoxCommandButtons.UseVisualStyleBackColor = true;
        // 
        // checkBoxRadioButtons
        // 
        this.checkBoxRadioButtons.AutoSize = true;
        this.checkBoxRadioButtons.Checked = true;
        this.checkBoxRadioButtons.CheckState = System.Windows.Forms.CheckState.Checked;
        this.checkBoxRadioButtons.Location = new System.Drawing.Point(22, 31);
        this.checkBoxRadioButtons.Name = "checkBoxRadioButtons";
        this.checkBoxRadioButtons.Size = new System.Drawing.Size(165, 17);
        this.checkBoxRadioButtons.TabIndex = 11;
        this.checkBoxRadioButtons.Text = "Show Example Radio Buttons";
        this.checkBoxRadioButtons.UseVisualStyleBackColor = true;
        // 
        // groupBoxPalette
        // 
        this.groupBoxPalette.Controls.Add(this.paletteSparkleOrange);
        this.groupBoxPalette.Controls.Add(this.palette2010Black);
        this.groupBoxPalette.Controls.Add(this.palette2010Silver);
        this.groupBoxPalette.Controls.Add(this.paletteProfessional);
        this.groupBoxPalette.Controls.Add(this.palette2007Blue);
        this.groupBoxPalette.Controls.Add(this.palette2010Blue);
        this.groupBoxPalette.Location = new System.Drawing.Point(364, 205);
        this.groupBoxPalette.Name = "groupBoxPalette";
        this.groupBoxPalette.Size = new System.Drawing.Size(322, 118);
        this.groupBoxPalette.TabIndex = 17;
        this.groupBoxPalette.TabStop = false;
        this.groupBoxPalette.Text = "Palette";
        // 
        // paletteSparkleOrange
        // 
        this.paletteSparkleOrange.AutoSize = true;
        this.paletteSparkleOrange.Location = new System.Drawing.Point(171, 54);
        this.paletteSparkleOrange.Name = "paletteSparkleOrange";
        this.paletteSparkleOrange.Size = new System.Drawing.Size(106, 17);
        this.paletteSparkleOrange.TabIndex = 5;
        this.paletteSparkleOrange.Text = "Sparkle - Orange";
        this.paletteSparkleOrange.UseVisualStyleBackColor = true;
        this.paletteSparkleOrange.CheckedChanged += new System.EventHandler(this.paletteSparkleOrange_CheckedChanged);
        // 
        // palette2010Black
        // 
        this.palette2010Black.AutoSize = true;
        this.palette2010Black.Location = new System.Drawing.Point(22, 77);
        this.palette2010Black.Name = "palette2010Black";
        this.palette2010Black.Size = new System.Drawing.Size(115, 17);
        this.palette2010Black.TabIndex = 4;
        this.palette2010Black.Text = "Office 2010 - Black";
        this.palette2010Black.UseVisualStyleBackColor = true;
        this.palette2010Black.CheckedChanged += new System.EventHandler(this.palette2010Black_CheckedChanged);
        // 
        // palette2010Silver
        // 
        this.palette2010Silver.AutoSize = true;
        this.palette2010Silver.Location = new System.Drawing.Point(22, 54);
        this.palette2010Silver.Name = "palette2010Silver";
        this.palette2010Silver.Size = new System.Drawing.Size(117, 17);
        this.palette2010Silver.TabIndex = 3;
        this.palette2010Silver.Text = "Office 2010 - Silver";
        this.palette2010Silver.UseVisualStyleBackColor = true;
        this.palette2010Silver.CheckedChanged += new System.EventHandler(this.palette2010Silver_CheckedChanged);
        // 
        // paletteProfessional
        // 
        this.paletteProfessional.AutoSize = true;
        this.paletteProfessional.Location = new System.Drawing.Point(171, 77);
        this.paletteProfessional.Name = "paletteProfessional";
        this.paletteProfessional.Size = new System.Drawing.Size(83, 17);
        this.paletteProfessional.TabIndex = 2;
        this.paletteProfessional.Text = "Professional";
        this.paletteProfessional.UseVisualStyleBackColor = true;
        this.paletteProfessional.CheckedChanged += new System.EventHandler(this.paletteProfessional_CheckedChanged);
        // 
        // palette2007Blue
        // 
        this.palette2007Blue.AutoSize = true;
        this.palette2007Blue.Location = new System.Drawing.Point(171, 31);
        this.palette2007Blue.Name = "palette2007Blue";
        this.palette2007Blue.Size = new System.Drawing.Size(111, 17);
        this.palette2007Blue.TabIndex = 1;
        this.palette2007Blue.Text = "Office 2007 - Blue";
        this.palette2007Blue.UseVisualStyleBackColor = true;
        this.palette2007Blue.CheckedChanged += new System.EventHandler(this.palette2007Blue_CheckedChanged);
        // 
        // palette2010Blue
        // 
        this.palette2010Blue.AutoSize = true;
        this.palette2010Blue.Checked = true;
        this.palette2010Blue.Location = new System.Drawing.Point(22, 31);
        this.palette2010Blue.Name = "palette2010Blue";
        this.palette2010Blue.Size = new System.Drawing.Size(111, 17);
        this.palette2010Blue.TabIndex = 0;
        this.palette2010Blue.TabStop = true;
        this.palette2010Blue.Text = "Office 2010 - Blue";
        this.palette2010Blue.UseVisualStyleBackColor = true;
        this.palette2010Blue.CheckedChanged += new System.EventHandler(this.palette2010Blue_CheckedChanged);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(704, 416);
        this.Controls.Add(this.groupBoxPalette);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.groupBoxCheckBox);
        this.Controls.Add(this.groupBoxFooter);
        this.Controls.Add(this.groupBoxBasic);
        this.Controls.Add(this.buttonShowTaskDialog);
        this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form1";
        this.Text = "KryptonTaskDialog Examples";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.groupBoxBasic.ResumeLayout(false);
        this.groupBoxBasic.PerformLayout();
        this.groupBoxFooter.ResumeLayout(false);
        this.groupBoxFooter.PerformLayout();
        this.groupBoxCheckBox.ResumeLayout(false);
        this.groupBoxCheckBox.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBoxPalette.ResumeLayout(false);
        this.groupBoxPalette.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelCaption;
    private System.Windows.Forms.Label labelMainInstructions;
    private System.Windows.Forms.Label labelContent;
    private System.Windows.Forms.TextBox textBoxCaption;
    private System.Windows.Forms.TextBox textBoxMainInstructions;
    private System.Windows.Forms.TextBox textBoxContent;
    private System.Windows.Forms.Button buttonShowTaskDialog;
    private Krypton.Toolkit.KryptonTaskDialog kryptonTaskDialog;
    private Krypton.Toolkit.KryptonManager kryptonManager;
    private System.Windows.Forms.CheckBox checkBoxOK;
    private System.Windows.Forms.CheckBox checkBoxYes;
    private System.Windows.Forms.CheckBox checkBoxNo;
    private System.Windows.Forms.CheckBox checkBoxCancel;
    private System.Windows.Forms.CheckBox checkBoxClose;
    private System.Windows.Forms.CheckBox checkBoxRetry;
    private System.Windows.Forms.GroupBox groupBoxBasic;
    private System.Windows.Forms.GroupBox groupBoxFooter;
    private System.Windows.Forms.Label labelFooterText;
    private System.Windows.Forms.Label labelFooterHyperlink;
    private System.Windows.Forms.TextBox textBoxFooterText;
    private System.Windows.Forms.TextBox textBoxFooterHyperlink;
    private System.Windows.Forms.Label labelFooterIcon;
    private System.Windows.Forms.ComboBox comboBoxIcon;
    private System.Windows.Forms.Label labelIcon;
    private System.Windows.Forms.ComboBox comboBoxFooterIcon;
    private System.Windows.Forms.GroupBox groupBoxCheckBox;
    private System.Windows.Forms.CheckBox checkBoxInitialState;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxCheckBoxText;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox checkBoxCommandButtons;
    private System.Windows.Forms.CheckBox checkBoxRadioButtons;
    private Krypton.Toolkit.InternalKryptonCommandLinkButton kryptonTaskDialogCommandLinkButton1;
    private Krypton.Toolkit.InternalKryptonCommandLinkButton kryptonTaskDialogCommandLinkButton2;
    private Krypton.Toolkit.InternalKryptonCommandLinkButton kryptonTaskDialogCommandLinkButton3;
    private Krypton.Toolkit.KryptonRadioButton kryptonTaskDialogRadioButton1;
    private Krypton.Toolkit.KryptonRadioButton kryptonTaskDialogRadioButton2;
    private Krypton.Toolkit.KryptonRadioButton kryptonTaskDialogRadioButton3;
    private System.Windows.Forms.GroupBox groupBoxPalette;
    private System.Windows.Forms.RadioButton paletteSparkleOrange;
    private System.Windows.Forms.RadioButton palette2010Black;
    private System.Windows.Forms.RadioButton palette2010Silver;
    private System.Windows.Forms.RadioButton paletteProfessional;
    private System.Windows.Forms.RadioButton palette2007Blue;
    private System.Windows.Forms.RadioButton palette2010Blue;
    private System.Windows.Forms.Button buttonFill;
}
