namespace KryptonNumericUpDownExamples
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.buttonClose = new System.Windows.Forms.Button();
            this.nud1 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nud2 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nud3 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nud4 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.nud5 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.nud6 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems1 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem3 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuHeading2 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItems2 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem4 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem5 = new Krypton.Toolkit.KryptonContextMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud7 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nud12 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.buttonSpecAny4 = new Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny5 = new Krypton.Toolkit.ButtonSpecAny();
            this.nud8 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nud11 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.buttonSpecAny6 = new Krypton.Toolkit.ButtonSpecAny();
            this.nud9 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.nud10 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSystem = new System.Windows.Forms.Button();
            this.buttonOffice2007Blue = new System.Windows.Forms.Button();
            this.buttonSparkleBlue = new System.Windows.Forms.Button();
            this.buttonOffice2010Blue = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(303, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(322, 426);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for Selected KryptonNumericUpDown";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Location = new System.Drawing.Point(6, 22);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(310, 396);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(550, 448);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 28);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // nud1
            // 
            this.nud1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud1.Location = new System.Drawing.Point(21, 31);
            this.nud1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(76, 33);
            this.nud1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud1.TabIndex = 0;
            this.nud1.ThousandsSeparator = true;
            this.nud1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud1.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // nud2
            // 
            this.nud2.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud2.Location = new System.Drawing.Point(21, 69);
            this.nud2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud2.MinimumSize = new System.Drawing.Size(0, 30);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(76, 30);
            this.nud2.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.nud2.TabIndex = 1;
            this.nud2.ThousandsSeparator = true;
            this.nud2.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud2.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // nud3
            // 
            this.nud3.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud3.Location = new System.Drawing.Point(21, 108);
            this.nud3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud3.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(76, 26);
            this.nud3.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.nud3.TabIndex = 2;
            this.nud3.ThousandsSeparator = true;
            this.nud3.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nud3.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // nud4
            // 
            this.nud4.AllowDecimals = true;
            this.nud4.DecimalPlaces = 2;
            this.nud4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud4.Location = new System.Drawing.Point(138, 31);
            this.nud4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud4.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud4.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud4.Name = "nud4";
            this.nud4.Size = new System.Drawing.Size(76, 26);
            this.nud4.TabIndex = 3;
            this.nud4.ThousandsSeparator = true;
            this.nud4.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud4.Value = new decimal(new int[] {
            3350,
            0,
            0,
            131072});
            this.nud4.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonManager1.ToolkitImages.ToolbarImages.Copy = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Copy")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.Cut = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Cut")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.New = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.New")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.Open = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Open")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.PageSetup = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.PageSetup")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.Paste = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Paste")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.Print = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Print")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.PrintPreview = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.PrintPreview")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.QuickPrint = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.QuickPrint")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.Redo = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Redo")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.Save = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Save")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.SaveAll = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.SaveAll")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.SaveAs = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.SaveAs")));
            this.kryptonManager1.ToolkitImages.ToolbarImages.Undo = ((System.Drawing.Image)(resources.GetObject("kryptonManager1.ToolkitImages.ToolbarImages.Undo")));
            // 
            // nud5
            // 
            this.nud5.AllowDecimals = true;
            this.nud5.ButtonSpecs.Add(this.buttonSpecAny1);
            this.nud5.DecimalPlaces = 3;
            this.nud5.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud5.Location = new System.Drawing.Point(138, 69);
            this.nud5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud5.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud5.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud5.Name = "nud5";
            this.nud5.Size = new System.Drawing.Size(102, 26);
            this.nud5.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.nud5.TabIndex = 4;
            this.nud5.ThousandsSeparator = true;
            this.nud5.ToolTipValues.EnableToolTips = true;
            this.nud5.TrailingZeroes = false;
            this.nud5.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud5.Value = new decimal(new int[] {
            3350,
            0,
            0,
            131072});
            this.nud5.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "65211BA9781346D365211BA9781346D3";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // nud6
            // 
            this.nud6.AllowDecimals = true;
            this.nud6.ButtonSpecs.Add(this.buttonSpecAny2);
            this.nud6.ButtonSpecs.Add(this.buttonSpecAny3);
            this.nud6.DecimalPlaces = 4;
            this.nud6.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud6.Location = new System.Drawing.Point(138, 108);
            this.nud6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud6.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud6.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud6.Name = "nud6";
            this.nud6.Size = new System.Drawing.Size(127, 26);
            this.nud6.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.nud6.TabIndex = 5;
            this.nud6.ThousandsSeparator = true;
            this.nud6.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud6.Value = new decimal(new int[] {
            3350,
            0,
            0,
            131072});
            this.nud6.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny2.UniqueName = "65211BA9781346D365211BA9781346D3";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.KryptonContextMenu = this.kryptonContextMenu1;
            this.buttonSpecAny3.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.DropDown;
            this.buttonSpecAny3.UniqueName = "55BDC4B174064C5F55BDC4B174064C5F";
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this.kryptonContextMenuItems1,
            this.kryptonContextMenuSeparator1,
            this.kryptonContextMenuHeading2,
            this.kryptonContextMenuItems2});
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            this.kryptonContextMenuHeading1.Text = "Fixed Values";
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuItem3});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "10.0000";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.kryptonContextMenuItem1_Click);
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "20.0000";
            this.kryptonContextMenuItem2.Click += new System.EventHandler(this.kryptonContextMenuItem2_Click);
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Text = "40.0000";
            this.kryptonContextMenuItem3.Click += new System.EventHandler(this.kryptonContextMenuItem3_Click);
            // 
            // kryptonContextMenuHeading2
            // 
            this.kryptonContextMenuHeading2.ExtraText = "";
            this.kryptonContextMenuHeading2.Text = "Limits";
            // 
            // kryptonContextMenuItems2
            // 
            this.kryptonContextMenuItems2.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem4,
            this.kryptonContextMenuItem5});
            // 
            // kryptonContextMenuItem4
            // 
            this.kryptonContextMenuItem4.Text = "Minimum";
            this.kryptonContextMenuItem4.Click += new System.EventHandler(this.kryptonContextMenuItem4_Click);
            // 
            // kryptonContextMenuItem5
            // 
            this.kryptonContextMenuItem5.Text = "Maximum";
            this.kryptonContextMenuItem5.Click += new System.EventHandler(this.kryptonContextMenuItem5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud1);
            this.groupBox1.Controls.Add(this.nud6);
            this.groupBox1.Controls.Add(this.nud2);
            this.groupBox1.Controls.Add(this.nud5);
            this.groupBox1.Controls.Add(this.nud3);
            this.groupBox1.Controls.Add(this.nud4);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(285, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Normal Style";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud7);
            this.groupBox2.Controls.Add(this.nud12);
            this.groupBox2.Controls.Add(this.nud8);
            this.groupBox2.Controls.Add(this.nud11);
            this.groupBox2.Controls.Add(this.nud9);
            this.groupBox2.Controls.Add(this.nud10);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(285, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ribbon Style";
            // 
            // nud7
            // 
            this.nud7.AlwaysActive = false;
            this.nud7.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud7.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.nud7.Location = new System.Drawing.Point(21, 31);
            this.nud7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud7.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud7.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud7.Name = "nud7";
            this.nud7.Size = new System.Drawing.Size(76, 26);
            this.nud7.TabIndex = 0;
            this.nud7.ThousandsSeparator = true;
            this.nud7.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud7.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // nud12
            // 
            this.nud12.AllowDecimals = true;
            this.nud12.AlwaysActive = false;
            this.nud12.ButtonSpecs.Add(this.buttonSpecAny4);
            this.nud12.ButtonSpecs.Add(this.buttonSpecAny5);
            this.nud12.DecimalPlaces = 4;
            this.nud12.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud12.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.nud12.Location = new System.Drawing.Point(138, 108);
            this.nud12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud12.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud12.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud12.Name = "nud12";
            this.nud12.Size = new System.Drawing.Size(127, 26);
            this.nud12.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.nud12.TabIndex = 5;
            this.nud12.ThousandsSeparator = true;
            this.nud12.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud12.Value = new decimal(new int[] {
            3350,
            0,
            0,
            131072});
            this.nud12.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny4.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny4.UniqueName = "65211BA9781346D365211BA9781346D3";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.KryptonContextMenu = this.kryptonContextMenu1;
            this.buttonSpecAny5.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny5.Type = Krypton.Toolkit.PaletteButtonSpecStyle.DropDown;
            this.buttonSpecAny5.UniqueName = "55BDC4B174064C5F55BDC4B174064C5F";
            // 
            // nud8
            // 
            this.nud8.AlwaysActive = false;
            this.nud8.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud8.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.nud8.Location = new System.Drawing.Point(21, 69);
            this.nud8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud8.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud8.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud8.Name = "nud8";
            this.nud8.Size = new System.Drawing.Size(76, 26);
            this.nud8.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.nud8.TabIndex = 1;
            this.nud8.ThousandsSeparator = true;
            this.nud8.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud8.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // nud11
            // 
            this.nud11.AllowDecimals = true;
            this.nud11.AlwaysActive = false;
            this.nud11.ButtonSpecs.Add(this.buttonSpecAny6);
            this.nud11.DecimalPlaces = 3;
            this.nud11.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud11.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.nud11.Location = new System.Drawing.Point(138, 69);
            this.nud11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud11.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud11.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud11.Name = "nud11";
            this.nud11.Size = new System.Drawing.Size(102, 26);
            this.nud11.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.nud11.TabIndex = 4;
            this.nud11.ThousandsSeparator = true;
            this.nud11.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud11.Value = new decimal(new int[] {
            3350,
            0,
            0,
            131072});
            this.nud11.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.buttonSpecAny6.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny6.UniqueName = "65211BA9781346D365211BA9781346D3";
            this.buttonSpecAny6.Click += new System.EventHandler(this.buttonSpecAny6_Click);
            // 
            // nud9
            // 
            this.nud9.AlwaysActive = false;
            this.nud9.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud9.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.nud9.Location = new System.Drawing.Point(21, 108);
            this.nud9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud9.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud9.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud9.Name = "nud9";
            this.nud9.Size = new System.Drawing.Size(76, 26);
            this.nud9.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.nud9.TabIndex = 2;
            this.nud9.ThousandsSeparator = true;
            this.nud9.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nud9.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // nud10
            // 
            this.nud10.AllowDecimals = true;
            this.nud10.AlwaysActive = false;
            this.nud10.DecimalPlaces = 2;
            this.nud10.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud10.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.nud10.Location = new System.Drawing.Point(138, 31);
            this.nud10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud10.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud10.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud10.Name = "nud10";
            this.nud10.Size = new System.Drawing.Size(76, 26);
            this.nud10.TabIndex = 3;
            this.nud10.ThousandsSeparator = true;
            this.nud10.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nud10.Value = new decimal(new int[] {
            3350,
            0,
            0,
            131072});
            this.nud10.Enter += new System.EventHandler(this.nud_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSystem);
            this.groupBox3.Controls.Add(this.buttonOffice2007Blue);
            this.groupBox3.Controls.Add(this.buttonSparkleBlue);
            this.groupBox3.Controls.Add(this.buttonOffice2010Blue);
            this.groupBox3.Location = new System.Drawing.Point(12, 334);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(285, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Palettes";
            // 
            // buttonSystem
            // 
            this.buttonSystem.Location = new System.Drawing.Point(149, 62);
            this.buttonSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSystem.Name = "buttonSystem";
            this.buttonSystem.Size = new System.Drawing.Size(137, 29);
            this.buttonSystem.TabIndex = 3;
            this.buttonSystem.Text = "System";
            this.buttonSystem.UseVisualStyleBackColor = true;
            this.buttonSystem.Click += new System.EventHandler(this.buttonSystem_Click);
            // 
            // buttonOffice2007Blue
            // 
            this.buttonOffice2007Blue.Location = new System.Drawing.Point(3, 62);
            this.buttonOffice2007Blue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOffice2007Blue.Name = "buttonOffice2007Blue";
            this.buttonOffice2007Blue.Size = new System.Drawing.Size(137, 29);
            this.buttonOffice2007Blue.TabIndex = 1;
            this.buttonOffice2007Blue.Text = "Office 2007 - Blue";
            this.buttonOffice2007Blue.UseVisualStyleBackColor = true;
            this.buttonOffice2007Blue.Click += new System.EventHandler(this.buttonOffice2007Blue_Click);
            // 
            // buttonSparkleBlue
            // 
            this.buttonSparkleBlue.Location = new System.Drawing.Point(149, 29);
            this.buttonSparkleBlue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSparkleBlue.Name = "buttonSparkleBlue";
            this.buttonSparkleBlue.Size = new System.Drawing.Size(137, 29);
            this.buttonSparkleBlue.TabIndex = 2;
            this.buttonSparkleBlue.Text = "Sparkle - Blue";
            this.buttonSparkleBlue.UseVisualStyleBackColor = true;
            this.buttonSparkleBlue.Click += new System.EventHandler(this.buttonSparkleBlue_Click);
            // 
            // buttonOffice2010Blue
            // 
            this.buttonOffice2010Blue.Location = new System.Drawing.Point(3, 29);
            this.buttonOffice2010Blue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOffice2010Blue.Name = "buttonOffice2010Blue";
            this.buttonOffice2010Blue.Size = new System.Drawing.Size(137, 29);
            this.buttonOffice2010Blue.TabIndex = 0;
            this.buttonOffice2010Blue.Text = "Office 2010 - Blue";
            this.buttonOffice2010Blue.UseVisualStyleBackColor = true;
            this.buttonOffice2010Blue.Click += new System.EventHandler(this.buttonOffice2010Blue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "KryptonNumericUpDown Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Button buttonClose;
        private Krypton.Toolkit.KryptonNumericUpDown nud1;
        private Krypton.Toolkit.KryptonNumericUpDown nud2;
        private Krypton.Toolkit.KryptonNumericUpDown nud3;
        private Krypton.Toolkit.KryptonNumericUpDown nud4;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonNumericUpDown nud5;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonNumericUpDown nud6;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Krypton.Toolkit.KryptonNumericUpDown nud7;
        private Krypton.Toolkit.KryptonNumericUpDown nud12;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private Krypton.Toolkit.KryptonNumericUpDown nud8;
        private Krypton.Toolkit.KryptonNumericUpDown nud11;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private Krypton.Toolkit.KryptonNumericUpDown nud9;
        private Krypton.Toolkit.KryptonNumericUpDown nud10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSystem;
        private System.Windows.Forms.Button buttonOffice2007Blue;
        private System.Windows.Forms.Button buttonSparkleBlue;
        private System.Windows.Forms.Button buttonOffice2010Blue;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem4;
        private Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem5;
    }
}

