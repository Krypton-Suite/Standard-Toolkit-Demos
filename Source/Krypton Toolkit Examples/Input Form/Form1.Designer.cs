namespace InputForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2010MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.office2007MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparkleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripOffice2010 = new System.Windows.Forms.ToolStripButton();
            this.toolStripOffice2007 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSparkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSystem = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new Krypton.Toolkit.KryptonLabel();
            this.labelAddress = new Krypton.Toolkit.KryptonLabel();
            this.labelTelephone = new Krypton.Toolkit.KryptonLabel();
            this.labelStatus = new Krypton.Toolkit.KryptonLabel();
            this.labelAge = new Krypton.Toolkit.KryptonLabel();
            this.labelDOB = new Krypton.Toolkit.KryptonLabel();
            this.labelGender = new Krypton.Toolkit.KryptonLabel();
            this.labelEmployed = new Krypton.Toolkit.KryptonLabel();
            this.textBoxName = new Krypton.Toolkit.KryptonTextBox();
            this.richTextBoxAddress = new Krypton.Toolkit.KryptonRichTextBox();
            this.maskedTextBoxTelephone = new Krypton.Toolkit.KryptonMaskedTextBox();
            this.clearTelephone = new Krypton.Toolkit.ButtonSpecAny();
            this.comboStatus = new Krypton.Toolkit.KryptonComboBox();
            this.numericAge = new Krypton.Toolkit.KryptonNumericUpDown();
            this.dtpDOB = new Krypton.Toolkit.KryptonDateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonMale = new Krypton.Toolkit.KryptonRadioButton();
            this.radioButtonFemale = new Krypton.Toolkit.KryptonRadioButton();
            this.checkBoxEmployed = new Krypton.Toolkit.KryptonCheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOK = new Krypton.Toolkit.KryptonButton();
            this.buttonCancel = new Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboStatus)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.office2010MenuItem,
            this.office2007MenuItem,
            this.sparkleMenuItem,
            this.systemMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // office2010MenuItem
            // 
            this.office2010MenuItem.Checked = true;
            this.office2010MenuItem.CheckOnClick = true;
            this.office2010MenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.office2010MenuItem.Name = "office2010MenuItem";
            this.office2010MenuItem.Size = new System.Drawing.Size(167, 22);
            this.office2010MenuItem.Text = "Office 2010 - Blue";
            this.office2010MenuItem.Click += new System.EventHandler(this.office2010_Click);
            // 
            // office2007MenuItem
            // 
            this.office2007MenuItem.CheckOnClick = true;
            this.office2007MenuItem.Name = "office2007MenuItem";
            this.office2007MenuItem.Size = new System.Drawing.Size(167, 22);
            this.office2007MenuItem.Text = "Office 2007 - Blue";
            this.office2007MenuItem.Click += new System.EventHandler(this.office2007_Click);
            // 
            // sparkleMenuItem
            // 
            this.sparkleMenuItem.Name = "sparkleMenuItem";
            this.sparkleMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sparkleMenuItem.Text = "Sparkle - Blue";
            this.sparkleMenuItem.Click += new System.EventHandler(this.sparkle_Click);
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.CheckOnClick = true;
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.Size = new System.Drawing.Size(167, 22);
            this.systemMenuItem.Text = "System";
            this.systemMenuItem.Click += new System.EventHandler(this.system_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOffice2010,
            this.toolStripOffice2007,
            this.toolStripSparkle,
            this.toolStripSystem});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(180, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripOffice2010
            // 
            this.toolStripOffice2010.Checked = true;
            this.toolStripOffice2010.CheckOnClick = true;
            this.toolStripOffice2010.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripOffice2010.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2010.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2010.Image")));
            this.toolStripOffice2010.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2010.Name = "toolStripOffice2010";
            this.toolStripOffice2010.Size = new System.Drawing.Size(35, 22);
            this.toolStripOffice2010.Text = "2010";
            this.toolStripOffice2010.Click += new System.EventHandler(this.office2010_Click);
            // 
            // toolStripOffice2007
            // 
            this.toolStripOffice2007.CheckOnClick = true;
            this.toolStripOffice2007.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOffice2007.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOffice2007.Image")));
            this.toolStripOffice2007.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOffice2007.Name = "toolStripOffice2007";
            this.toolStripOffice2007.Size = new System.Drawing.Size(35, 22);
            this.toolStripOffice2007.Text = "2007";
            this.toolStripOffice2007.Click += new System.EventHandler(this.office2007_Click);
            // 
            // toolStripSparkle
            // 
            this.toolStripSparkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSparkle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSparkle.Image")));
            this.toolStripSparkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSparkle.Name = "toolStripSparkle";
            this.toolStripSparkle.Size = new System.Drawing.Size(49, 22);
            this.toolStripSparkle.Text = "Sparkle";
            this.toolStripSparkle.Click += new System.EventHandler(this.sparkle_Click);
            // 
            // toolStripSystem
            // 
            this.toolStripSystem.CheckOnClick = true;
            this.toolStripSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSystem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSystem.Image")));
            this.toolStripSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSystem.Name = "toolStripSystem";
            this.toolStripSystem.Size = new System.Drawing.Size(49, 22);
            this.toolStripSystem.Text = "System";
            this.toolStripSystem.Click += new System.EventHandler(this.system_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.kryptonPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(311, 370);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(311, 395);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(10, 14, 10, 10);
            this.kryptonPanel1.Size = new System.Drawing.Size(311, 370);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTelephone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelDOB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelGender, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelEmployed, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxTelephone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboStatus, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericAge, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDOB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxEmployed, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(3, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 23);
            this.labelName.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelName.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelName.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelName.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelName.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelName.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelName.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelName.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelName.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelName.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelName.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelName.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelName.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelName.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelName.TabIndex = 4;
            this.labelName.Values.Text = "Name";
            // 
            // labelAddress
            // 
            this.labelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddress.Location = new System.Drawing.Point(3, 32);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 96);
            this.labelAddress.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelAddress.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelAddress.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelAddress.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelAddress.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelAddress.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelAddress.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelAddress.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelAddress.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelAddress.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelAddress.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelAddress.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelAddress.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.labelAddress.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Values.Text = "Address";
            // 
            // labelTelephone
            // 
            this.labelTelephone.Location = new System.Drawing.Point(3, 134);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(68, 20);
            this.labelTelephone.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelTelephone.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelTelephone.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelTelephone.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelTelephone.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelTelephone.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelTelephone.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelTelephone.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelTelephone.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelTelephone.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelTelephone.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelTelephone.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelTelephone.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelTelephone.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelTelephone.TabIndex = 6;
            this.labelTelephone.Values.Text = "Telephone";
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Location = new System.Drawing.Point(3, 163);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(68, 21);
            this.labelStatus.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelStatus.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelStatus.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelStatus.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelStatus.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelStatus.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelStatus.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelStatus.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelStatus.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelStatus.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelStatus.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelStatus.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelStatus.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelStatus.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Values.Text = "Status";
            // 
            // labelAge
            // 
            this.labelAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAge.Location = new System.Drawing.Point(3, 190);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(68, 22);
            this.labelAge.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelAge.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelAge.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelAge.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelAge.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelAge.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelAge.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelAge.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelAge.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelAge.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelAge.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelAge.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelAge.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelAge.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelAge.TabIndex = 13;
            this.labelAge.Values.Text = "Age";
            // 
            // labelDOB
            // 
            this.labelDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDOB.Location = new System.Drawing.Point(3, 218);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(68, 21);
            this.labelDOB.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelDOB.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelDOB.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelDOB.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelDOB.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelDOB.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelDOB.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelDOB.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelDOB.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelDOB.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelDOB.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelDOB.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelDOB.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelDOB.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelDOB.TabIndex = 15;
            this.labelDOB.Values.Text = "D.O.B";
            // 
            // labelGender
            // 
            this.labelGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGender.Location = new System.Drawing.Point(3, 245);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(68, 20);
            this.labelGender.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelGender.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelGender.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelGender.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelGender.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelGender.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelGender.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelGender.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelGender.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelGender.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelGender.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelGender.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelGender.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelGender.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelGender.TabIndex = 8;
            this.labelGender.Values.Text = "Gender";
            // 
            // labelEmployed
            // 
            this.labelEmployed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmployed.Location = new System.Drawing.Point(3, 271);
            this.labelEmployed.Name = "labelEmployed";
            this.labelEmployed.Size = new System.Drawing.Size(68, 20);
            this.labelEmployed.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit;
            this.labelEmployed.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit;
            this.labelEmployed.StateCommon.Padding = new System.Windows.Forms.Padding(-1);
            this.labelEmployed.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelEmployed.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.labelEmployed.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit;
            this.labelEmployed.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.labelEmployed.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.labelEmployed.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit;
            this.labelEmployed.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelEmployed.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit;
            this.labelEmployed.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.labelEmployed.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.labelEmployed.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.labelEmployed.TabIndex = 9;
            this.labelEmployed.Values.Text = "Employed";
            // 
            // textBoxName
            // 
            this.textBoxName.AlwaysActive = false;
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxName.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.textBoxName.Location = new System.Drawing.Point(77, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxName.Size = new System.Drawing.Size(189, 23);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.AlwaysActive = false;
            this.richTextBoxAddress.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.richTextBoxAddress.Location = new System.Drawing.Point(77, 32);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.richTextBoxAddress.Size = new System.Drawing.Size(189, 96);
            this.richTextBoxAddress.TabIndex = 1;
            this.richTextBoxAddress.Text = "";
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.AlwaysActive = false;
            this.maskedTextBoxTelephone.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.clearTelephone});
            this.maskedTextBoxTelephone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.maskedTextBoxTelephone.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.maskedTextBoxTelephone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(77, 134);
            this.maskedTextBoxTelephone.Mask = "(000) 000-000";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.PromptChar = '?';
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(130, 23);
            this.maskedTextBoxTelephone.TabIndex = 2;
            this.maskedTextBoxTelephone.Text = "(   )    -";
            this.maskedTextBoxTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.maskedTextBoxTelephone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // clearTelephone
            // 
            this.clearTelephone.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.clearTelephone.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.clearTelephone.UniqueName = "C1E393B3D313481AC1E393B3D313481A";
            this.clearTelephone.Click += new System.EventHandler(this.clearTelephone_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.AlwaysActive = false;
            this.comboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.comboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.comboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboStatus.DropDownWidth = 150;
            this.comboStatus.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.comboStatus.IntegralHeight = false;
            this.comboStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Separated"});
            this.comboStatus.Location = new System.Drawing.Point(77, 163);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(130, 21);
            this.comboStatus.TabIndex = 3;
            // 
            // numericAge
            // 
            this.numericAge.AlwaysActive = false;
            this.numericAge.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAge.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.numericAge.Location = new System.Drawing.Point(77, 190);
            this.numericAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(61, 22);
            this.numericAge.TabIndex = 4;
            this.numericAge.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.numericAge.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // dtpDOB
            // 
            this.dtpDOB.AlwaysActive = false;
            this.dtpDOB.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpDOB.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Default;
            this.dtpDOB.CalendarTodayDate = new System.DateTime(2009, 8, 23, 0, 0, 0, 0);
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDOB.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.dtpDOB.Location = new System.Drawing.Point(77, 218);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.PaletteMode = Krypton.Toolkit.PaletteMode.Global;
            this.dtpDOB.Size = new System.Drawing.Size(186, 21);
            this.dtpDOB.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.radioButtonMale);
            this.flowLayoutPanel2.Controls.Add(this.radioButtonFemale);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(74, 242);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(122, 26);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioButtonMale.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioButtonMale.Location = new System.Drawing.Point(3, 3);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioButtonMale.Size = new System.Drawing.Size(49, 20);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.Values.Text = "Male";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.radioButtonFemale.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.radioButtonFemale.Location = new System.Drawing.Point(58, 3);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.radioButtonFemale.Size = new System.Drawing.Size(61, 20);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.Values.Text = "Female";
            // 
            // checkBoxEmployed
            // 
            this.checkBoxEmployed.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.checkBoxEmployed.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.checkBoxEmployed.Location = new System.Drawing.Point(77, 271);
            this.checkBoxEmployed.Name = "checkBoxEmployed";
            this.checkBoxEmployed.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.checkBoxEmployed.Size = new System.Drawing.Size(78, 20);
            this.checkBoxEmployed.TabIndex = 6;
            this.checkBoxEmployed.Values.Text = "Employed";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonOK);
            this.flowLayoutPanel1.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(74, 294);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 44);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(3, 16);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonOK.Size = new System.Drawing.Size(90, 25);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Values.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(99, 16);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonCancel.Size = new System.Drawing.Size(90, 25);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Values.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 419);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(327, 458);
            this.Name = "Form1";
            this.Text = "Input Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboStatus)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ToolStripButton toolStripOffice2010;
        private System.Windows.Forms.ToolStripButton toolStripOffice2007;
        private System.Windows.Forms.ToolStripButton toolStripSystem;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ToolStripMenuItem office2010MenuItem;
        private System.Windows.Forms.ToolStripMenuItem office2007MenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel labelName;
        private Krypton.Toolkit.KryptonLabel labelAddress;
        private Krypton.Toolkit.KryptonTextBox textBoxName;
        private Krypton.Toolkit.KryptonMaskedTextBox maskedTextBoxTelephone;
        private Krypton.Toolkit.KryptonLabel labelTelephone;
        private Krypton.Toolkit.KryptonComboBox comboStatus;
        private Krypton.Toolkit.KryptonLabel labelStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonButton buttonOK;
        private Krypton.Toolkit.KryptonButton buttonCancel;
        private Krypton.Toolkit.KryptonLabel labelEmployed;
        private Krypton.Toolkit.KryptonCheckBox checkBoxEmployed;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Krypton.Toolkit.KryptonRadioButton radioButtonMale;
        private Krypton.Toolkit.KryptonRadioButton radioButtonFemale;
        private Krypton.Toolkit.KryptonLabel labelGender;
        private Krypton.Toolkit.KryptonRichTextBox richTextBoxAddress;
        private Krypton.Toolkit.ButtonSpecAny clearTelephone;
        private System.Windows.Forms.ToolStripMenuItem sparkleMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripSparkle;
        private Krypton.Toolkit.KryptonLabel labelAge;
        private Krypton.Toolkit.KryptonNumericUpDown numericAge;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDOB;
        private Krypton.Toolkit.KryptonLabel labelDOB;
    }
}

