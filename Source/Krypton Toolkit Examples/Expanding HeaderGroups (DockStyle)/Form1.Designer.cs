namespace ExpandingHeaderGroupsDockStyle
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOffice2010 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOffice2007 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSparkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolOffice2010 = new System.Windows.Forms.ToolStripButton();
            this.toolOffice2007 = new System.Windows.Forms.ToolStripButton();
            this.toolSparkle = new System.Windows.Forms.ToolStripButton();
            this.toolSystem = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.groupFiller = new Krypton.Toolkit.KryptonGroup();
            this.textBoxMainFill = new Krypton.Toolkit.KryptonTextBox();
            this.header2Border = new Krypton.Toolkit.KryptonPanel();
            this.header2 = new Krypton.Toolkit.KryptonHeaderGroup();
            this.buttonSpecHeaderGroup1 = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.textBox3 = new Krypton.Toolkit.KryptonTextBox();
            this.textBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.labelPosition = new Krypton.Toolkit.KryptonLabel();
            this.labelAge = new Krypton.Toolkit.KryptonLabel();
            this.textBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.textBoxFirstName = new Krypton.Toolkit.KryptonTextBox();
            this.labelLastName = new Krypton.Toolkit.KryptonLabel();
            this.labelFirstName = new Krypton.Toolkit.KryptonLabel();
            this.header1Border = new Krypton.Toolkit.KryptonPanel();
            this.header1 = new Krypton.Toolkit.KryptonHeaderGroup();
            this.header1ButtonSpec = new Krypton.Toolkit.ButtonSpecHeaderGroup();
            this.kryptonButtonPrevious = new Krypton.Toolkit.KryptonButton();
            this.textBoxFind = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonNext = new Krypton.Toolkit.KryptonButton();
            this.labelFind = new Krypton.Toolkit.KryptonLabel();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupFiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFiller.Panel)).BeginInit();
            this.groupFiller.Panel.SuspendLayout();
            this.groupFiller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header2Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header2.Panel)).BeginInit();
            this.header2.Panel.SuspendLayout();
            this.header2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header1Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1.Panel)).BeginInit();
            this.header1.Panel.SuspendLayout();
            this.header1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(359, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOffice2010,
            this.menuOffice2007,
            this.menuSparkle,
            this.menuSystem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuOffice2010
            // 
            this.menuOffice2010.Checked = true;
            this.menuOffice2010.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuOffice2010.Name = "menuOffice2010";
            this.menuOffice2010.Size = new System.Drawing.Size(167, 22);
            this.menuOffice2010.Text = "Office 2010 - Blue";
            this.menuOffice2010.Click += new System.EventHandler(this.toolOffice2010_Click);
            // 
            // menuOffice2007
            // 
            this.menuOffice2007.Name = "menuOffice2007";
            this.menuOffice2007.Size = new System.Drawing.Size(167, 22);
            this.menuOffice2007.Text = "Office 2007 - Blue";
            this.menuOffice2007.Click += new System.EventHandler(this.toolOffice2007_Click);
            // 
            // menuSparkle
            // 
            this.menuSparkle.Name = "menuSparkle";
            this.menuSparkle.Size = new System.Drawing.Size(167, 22);
            this.menuSparkle.Text = "Sparkle - Blue";
            this.menuSparkle.Click += new System.EventHandler(this.toolSparkle_Click);
            // 
            // menuSystem
            // 
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(167, 22);
            this.menuSystem.Text = "System";
            this.menuSystem.Click += new System.EventHandler(this.toolSystem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOffice2010,
            this.toolOffice2007,
            this.toolSparkle,
            this.toolSystem});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(180, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolOffice2010
            // 
            this.toolOffice2010.Checked = true;
            this.toolOffice2010.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolOffice2010.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolOffice2010.Image = ((System.Drawing.Image)(resources.GetObject("toolOffice2010.Image")));
            this.toolOffice2010.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOffice2010.Name = "toolOffice2010";
            this.toolOffice2010.Size = new System.Drawing.Size(35, 22);
            this.toolOffice2010.Text = "2010";
            this.toolOffice2010.Click += new System.EventHandler(this.toolOffice2010_Click);
            // 
            // toolOffice2007
            // 
            this.toolOffice2007.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolOffice2007.Image = ((System.Drawing.Image)(resources.GetObject("toolOffice2007.Image")));
            this.toolOffice2007.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOffice2007.Name = "toolOffice2007";
            this.toolOffice2007.Size = new System.Drawing.Size(35, 22);
            this.toolOffice2007.Text = "2007";
            this.toolOffice2007.Click += new System.EventHandler(this.toolOffice2007_Click);
            // 
            // toolSparkle
            // 
            this.toolSparkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSparkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSparkle.Name = "toolSparkle";
            this.toolSparkle.Size = new System.Drawing.Size(49, 22);
            this.toolSparkle.Text = "Sparkle";
            this.toolSparkle.Click += new System.EventHandler(this.toolSparkle_Click);
            // 
            // toolSystem
            // 
            this.toolSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSystem.Name = "toolSystem";
            this.toolSystem.Size = new System.Drawing.Size(49, 22);
            this.toolSystem.Text = "System";
            this.toolSystem.Click += new System.EventHandler(this.toolSystem_Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.kryptonPanel1);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(359, 351);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(359, 376);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.groupFiller);
            this.kryptonPanel1.Controls.Add(this.header2Border);
            this.kryptonPanel1.Controls.Add(this.header2);
            this.kryptonPanel1.Controls.Add(this.header1Border);
            this.kryptonPanel1.Controls.Add(this.header1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel1.Size = new System.Drawing.Size(359, 351);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // groupFiller
            // 
            this.groupFiller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupFiller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFiller.Location = new System.Drawing.Point(5, 199);
            this.groupFiller.Name = "groupFiller";
            // 
            // groupFiller.Panel
            // 
            this.groupFiller.Panel.Controls.Add(this.textBoxMainFill);
            this.groupFiller.Panel.Padding = new System.Windows.Forms.Padding(5);
            this.groupFiller.Size = new System.Drawing.Size(349, 147);
            this.groupFiller.TabIndex = 2;
            // 
            // textBoxMainFill
            // 
            this.textBoxMainFill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxMainFill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxMainFill.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxMainFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMainFill.Location = new System.Drawing.Point(5, 5);
            this.textBoxMainFill.Multiline = true;
            this.textBoxMainFill.Name = "textBoxMainFill";
            this.textBoxMainFill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxMainFill.Size = new System.Drawing.Size(337, 135);
            this.textBoxMainFill.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.textBoxMainFill.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit;
            this.textBoxMainFill.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.textBoxMainFill.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxMainFill.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit;
            this.textBoxMainFill.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit;
            this.textBoxMainFill.TabIndex = 0;
            this.textBoxMainFill.Text = resources.GetString("textBoxMainFill.Text");
            this.textBoxMainFill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // header2Border
            // 
            this.header2Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.header2Border.Location = new System.Drawing.Point(5, 194);
            this.header2Border.Name = "header2Border";
            this.header2Border.Size = new System.Drawing.Size(349, 5);
            this.header2Border.TabIndex = 3;
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header2.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.buttonSpecHeaderGroup1});
            this.header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.header2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.header2.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top;
            this.header2.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom;
            this.header2.HeaderVisibleSecondary = false;
            this.header2.Location = new System.Drawing.Point(5, 89);
            this.header2.Name = "header2";
            // 
            // header2.Panel
            // 
            this.header2.Panel.Controls.Add(this.textBox3);
            this.header2.Panel.Controls.Add(this.textBox2);
            this.header2.Panel.Controls.Add(this.labelPosition);
            this.header2.Panel.Controls.Add(this.labelAge);
            this.header2.Panel.Controls.Add(this.textBox1);
            this.header2.Panel.Controls.Add(this.textBoxFirstName);
            this.header2.Panel.Controls.Add(this.labelLastName);
            this.header2.Panel.Controls.Add(this.labelFirstName);
            this.header2.Panel.Padding = new System.Windows.Forms.Padding(10);
            this.header2.Size = new System.Drawing.Size(349, 105);
            this.header2.TabIndex = 1;
            this.header2.ValuesPrimary.Heading = "User Details";
            this.header2.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("header2.ValuesPrimary.Image")));
            // 
            // buttonSpecHeaderGroup1
            // 
            this.buttonSpecHeaderGroup1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.buttonSpecHeaderGroup1.UniqueName = "4A15006157B94C7D4A15006157B94C7D";
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox3.Location = new System.Drawing.Point(240, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox3.Size = new System.Drawing.Size(94, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Roman Emperor";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox2.Location = new System.Drawing.Point(240, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.Size = new System.Drawing.Size(94, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "24";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelPosition
            // 
            this.labelPosition.Location = new System.Drawing.Point(186, 37);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(54, 20);
            this.labelPosition.TabIndex = 4;
            this.labelPosition.Values.Text = "Position";
            // 
            // labelAge
            // 
            this.labelAge.Location = new System.Drawing.Point(185, 12);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 20);
            this.labelAge.TabIndex = 3;
            this.labelAge.Values.Text = "Age";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox1.Location = new System.Drawing.Point(82, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.Size = new System.Drawing.Size(89, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Ceaser";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFirstName.Location = new System.Drawing.Point(82, 11);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxFirstName.Size = new System.Drawing.Size(89, 23);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Text = "Augustus";
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(10, 37);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(68, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Values.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(10, 12);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(69, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Values.Text = "First Name";
            // 
            // header1Border
            // 
            this.header1Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1Border.Location = new System.Drawing.Point(5, 84);
            this.header1Border.Name = "header1Border";
            this.header1Border.Size = new System.Drawing.Size(349, 5);
            this.header1Border.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header1.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecHeaderGroup[] {
            this.header1ButtonSpec});
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.header1.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top;
            this.header1.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom;
            this.header1.HeaderVisibleSecondary = false;
            this.header1.Location = new System.Drawing.Point(5, 5);
            this.header1.Name = "header1";
            // 
            // header1.Panel
            // 
            this.header1.Panel.Controls.Add(this.kryptonButtonPrevious);
            this.header1.Panel.Controls.Add(this.textBoxFind);
            this.header1.Panel.Controls.Add(this.kryptonButtonNext);
            this.header1.Panel.Controls.Add(this.labelFind);
            this.header1.Panel.Padding = new System.Windows.Forms.Padding(10);
            this.header1.Size = new System.Drawing.Size(349, 79);
            this.header1.TabIndex = 0;
            this.header1.ValuesPrimary.Heading = "Find";
            this.header1.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("header1.ValuesPrimary.Image")));
            // 
            // header1ButtonSpec
            // 
            this.header1ButtonSpec.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp;
            this.header1ButtonSpec.UniqueName = "3F21FD013FD447823F21FD013FD44782";
            // 
            // kryptonButtonPrevious
            // 
            this.kryptonButtonPrevious.AutoSize = true;
            this.kryptonButtonPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButtonPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonButtonPrevious.Location = new System.Drawing.Point(232, 11);
            this.kryptonButtonPrevious.Name = "kryptonButtonPrevious";
            this.kryptonButtonPrevious.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButtonPrevious.Size = new System.Drawing.Size(46, 24);
            this.kryptonButtonPrevious.TabIndex = 1;
            this.kryptonButtonPrevious.Values.Text = "< Prev";
            // 
            // textBoxFind
            // 
            this.textBoxFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFind.Location = new System.Drawing.Point(47, 11);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxFind.Size = new System.Drawing.Size(171, 23);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.Text = "example string";
            this.textBoxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kryptonButtonNext
            // 
            this.kryptonButtonNext.AutoSize = true;
            this.kryptonButtonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButtonNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonButtonNext.Location = new System.Drawing.Point(287, 11);
            this.kryptonButtonNext.Name = "kryptonButtonNext";
            this.kryptonButtonNext.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButtonNext.Size = new System.Drawing.Size(48, 24);
            this.kryptonButtonNext.TabIndex = 2;
            this.kryptonButtonNext.Values.Text = "Next >";
            // 
            // labelFind
            // 
            this.labelFind.Location = new System.Drawing.Point(10, 12);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(33, 20);
            this.labelFind.TabIndex = 0;
            this.labelFind.Values.Text = "Text";
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(359, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 422);
            this.Controls.Add(this.toolStripContainer);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Expanding HeaderGroups (DockStyle)";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupFiller.Panel)).EndInit();
            this.groupFiller.Panel.ResumeLayout(false);
            this.groupFiller.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupFiller)).EndInit();
            this.groupFiller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.header2Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header2.Panel)).EndInit();
            this.header2.Panel.ResumeLayout(false);
            this.header2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header2)).EndInit();
            this.header2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.header1Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header1.Panel)).EndInit();
            this.header1.Panel.ResumeLayout(false);
            this.header1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.header1)).EndInit();
            this.header1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuSparkle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolSystem;
        private System.Windows.Forms.ToolStripButton toolSparkle;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroup groupFiller;
        private Krypton.Toolkit.KryptonPanel header2Border;
        private Krypton.Toolkit.KryptonHeaderGroup header2;
        private Krypton.Toolkit.ButtonSpecHeaderGroup buttonSpecHeaderGroup1;
        private Krypton.Toolkit.KryptonPanel header1Border;
        private Krypton.Toolkit.KryptonHeaderGroup header1;
        private Krypton.Toolkit.ButtonSpecHeaderGroup header1ButtonSpec;
        private Krypton.Toolkit.KryptonButton kryptonButtonNext;
        private Krypton.Toolkit.KryptonLabel labelFind;
        private Krypton.Toolkit.KryptonTextBox textBoxFind;
        private Krypton.Toolkit.KryptonTextBox textBoxFirstName;
        private Krypton.Toolkit.KryptonLabel labelLastName;
        private Krypton.Toolkit.KryptonLabel labelFirstName;
        private Krypton.Toolkit.KryptonTextBox textBoxMainFill;
        private Krypton.Toolkit.KryptonTextBox textBox1;
        private Krypton.Toolkit.KryptonTextBox textBox3;
        private Krypton.Toolkit.KryptonTextBox textBox2;
        private Krypton.Toolkit.KryptonLabel labelPosition;
        private Krypton.Toolkit.KryptonLabel labelAge;
        private Krypton.Toolkit.KryptonButton kryptonButtonPrevious;
        private System.Windows.Forms.ToolStripButton toolOffice2007;
        private System.Windows.Forms.ToolStripButton toolOffice2010;
        private System.Windows.Forms.ToolStripMenuItem menuOffice2010;
        private System.Windows.Forms.ToolStripMenuItem menuOffice2007;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

