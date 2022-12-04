namespace KryptonDataGridViewExamples
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.dataSet = new System.Data.DataSet();
            this.dtTestData = new System.Data.DataTable();
            this.dataDateTime = new System.Data.DataColumn();
            this.dataComboBox = new System.Data.DataColumn();
            this.dataTextBox = new System.Data.DataColumn();
            this.dataMaskedTextBox = new System.Data.DataColumn();
            this.dataDomainUpDown = new System.Data.DataColumn();
            this.dataNumericUpDown = new System.Data.DataColumn();
            this.dataButton = new System.Data.DataColumn();
            this.dataCheckBox = new System.Data.DataColumn();
            this.groupBoxPalette = new System.Windows.Forms.GroupBox();
            this.rbOffice2010Blue = new System.Windows.Forms.RadioButton();
            this.rbSparkle = new System.Windows.Forms.RadioButton();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.rbOffice2003 = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Black = new System.Windows.Forms.RadioButton();
            this.rbOffice2007Blue = new System.Windows.Forms.RadioButton();
            this.rbStyleList = new System.Windows.Forms.RadioButton();
            this.groupBoxGridStyle = new System.Windows.Forms.GroupBox();
            this.rbStyleCustom = new System.Windows.Forms.RadioButton();
            this.rbStyleSheet = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearCellColors = new Krypton.Toolkit.KryptonButton();
            this.buttonRandomCellColors = new Krypton.Toolkit.KryptonButton();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuHeading1 = new Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuSeparator1 = new Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuCheckBox1 = new Krypton.Toolkit.KryptonContextMenuCheckBox();
            this.kryptonContextMenuCheckButton1 = new Krypton.Toolkit.KryptonContextMenuCheckButton();
            this.kryptonContextMenuRadioButton1 = new Krypton.Toolkit.KryptonContextMenuRadioButton();
            this.kryptonContextMenuLinkLabel1 = new Krypton.Toolkit.KryptonContextMenuLinkLabel();
            this.kryptonContextMenuColorColumns1 = new Krypton.Toolkit.KryptonContextMenuColorColumns();
            this.kryptonContextMenuImageSelect1 = new Krypton.Toolkit.KryptonContextMenuImageSelect();
            this.kryptonContextMenuMonthCalendar1 = new Krypton.Toolkit.KryptonContextMenuMonthCalendar();
            this.kryptonPalette = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
            this.colDateTime = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.colComboBox = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.colTextBox = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colMaskedTextBox = new Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn();
            this.colDomainUpDown = new Krypton.Toolkit.KryptonDataGridViewDomainUpDownColumn();
            this.colNumericUpDown = new Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn();
            this.colCheckBox = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTestData)).BeginInit();
            this.groupBoxPalette.SuspendLayout();
            this.groupBoxGridStyle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.propertyGrid);
            this.groupBox4.Location = new System.Drawing.Point(888, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 473);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties for KryptonDataGridView";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(3, 20);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(330, 450);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTestData});
            // 
            // dtTestData
            // 
            this.dtTestData.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataDateTime,
            this.dataComboBox,
            this.dataTextBox,
            this.dataMaskedTextBox,
            this.dataDomainUpDown,
            this.dataNumericUpDown,
            this.dataButton,
            this.dataCheckBox});
            this.dtTestData.TableName = "TestData";
            // 
            // dataDateTime
            // 
            this.dataDateTime.Caption = "DateTime";
            this.dataDateTime.ColumnName = "DateTime";
            this.dataDateTime.DataType = typeof(System.DateTime);
            // 
            // dataComboBox
            // 
            this.dataComboBox.Caption = "ComboBox";
            this.dataComboBox.ColumnName = "ComboBox";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Caption = "TextBox";
            this.dataTextBox.ColumnName = "TextBox";
            // 
            // dataMaskedTextBox
            // 
            this.dataMaskedTextBox.Caption = "MaskedTextBox";
            this.dataMaskedTextBox.ColumnName = "MaskedTextBox";
            // 
            // dataDomainUpDown
            // 
            this.dataDomainUpDown.Caption = "DomainUpDown";
            this.dataDomainUpDown.ColumnName = "DomainUpDown";
            // 
            // dataNumericUpDown
            // 
            this.dataNumericUpDown.Caption = "NumericUpDown";
            this.dataNumericUpDown.ColumnName = "NumericUpDown";
            this.dataNumericUpDown.DataType = typeof(decimal);
            // 
            // dataButton
            // 
            this.dataButton.Caption = "Button";
            this.dataButton.ColumnName = "Button";
            // 
            // dataCheckBox
            // 
            this.dataCheckBox.Caption = "CheckBox";
            this.dataCheckBox.ColumnName = "CheckBox";
            this.dataCheckBox.DataType = typeof(bool);
            // 
            // groupBoxPalette
            // 
            this.groupBoxPalette.Controls.Add(this.rbOffice2010Blue);
            this.groupBoxPalette.Controls.Add(this.rbSparkle);
            this.groupBoxPalette.Controls.Add(this.rbSystem);
            this.groupBoxPalette.Controls.Add(this.rbOffice2003);
            this.groupBoxPalette.Controls.Add(this.rbOffice2007Black);
            this.groupBoxPalette.Controls.Add(this.rbOffice2007Blue);
            this.groupBoxPalette.Location = new System.Drawing.Point(12, 278);
            this.groupBoxPalette.Name = "groupBoxPalette";
            this.groupBoxPalette.Size = new System.Drawing.Size(144, 171);
            this.groupBoxPalette.TabIndex = 1;
            this.groupBoxPalette.TabStop = false;
            this.groupBoxPalette.Text = "Palette";
            // 
            // rbOffice2010Blue
            // 
            this.rbOffice2010Blue.AutoSize = true;
            this.rbOffice2010Blue.Checked = true;
            this.rbOffice2010Blue.Location = new System.Drawing.Point(16, 26);
            this.rbOffice2010Blue.Name = "rbOffice2010Blue";
            this.rbOffice2010Blue.Size = new System.Drawing.Size(137, 21);
            this.rbOffice2010Blue.TabIndex = 6;
            this.rbOffice2010Blue.TabStop = true;
            this.rbOffice2010Blue.Text = "Office 2010 - Blue";
            this.rbOffice2010Blue.UseVisualStyleBackColor = true;
            this.rbOffice2010Blue.CheckedChanged += new System.EventHandler(this.rbOffice2010Blue_CheckedChanged);
            // 
            // rbSparkle
            // 
            this.rbSparkle.AutoSize = true;
            this.rbSparkle.Location = new System.Drawing.Point(16, 118);
            this.rbSparkle.Name = "rbSparkle";
            this.rbSparkle.Size = new System.Drawing.Size(111, 21);
            this.rbSparkle.TabIndex = 4;
            this.rbSparkle.Text = "Sparkle - Blue";
            this.rbSparkle.UseVisualStyleBackColor = true;
            this.rbSparkle.CheckedChanged += new System.EventHandler(this.rbSparkle_CheckedChanged);
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.Location = new System.Drawing.Point(16, 141);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(75, 21);
            this.rbSystem.TabIndex = 5;
            this.rbSystem.Text = "System";
            this.rbSystem.UseVisualStyleBackColor = true;
            this.rbSystem.CheckedChanged += new System.EventHandler(this.rbSystem_CheckedChanged);
            // 
            // rbOffice2003
            // 
            this.rbOffice2003.AutoSize = true;
            this.rbOffice2003.Location = new System.Drawing.Point(16, 95);
            this.rbOffice2003.Name = "rbOffice2003";
            this.rbOffice2003.Size = new System.Drawing.Size(99, 21);
            this.rbOffice2003.TabIndex = 3;
            this.rbOffice2003.Text = "Office 2003";
            this.rbOffice2003.UseVisualStyleBackColor = true;
            this.rbOffice2003.CheckedChanged += new System.EventHandler(this.rbOffice2003_CheckedChanged);
            // 
            // rbOffice2007Black
            // 
            this.rbOffice2007Black.AutoSize = true;
            this.rbOffice2007Black.Location = new System.Drawing.Point(16, 72);
            this.rbOffice2007Black.Name = "rbOffice2007Black";
            this.rbOffice2007Black.Size = new System.Drawing.Size(143, 21);
            this.rbOffice2007Black.TabIndex = 2;
            this.rbOffice2007Black.Text = "Office 2007 - Black";
            this.rbOffice2007Black.UseVisualStyleBackColor = true;
            this.rbOffice2007Black.CheckedChanged += new System.EventHandler(this.rbOffice2007Black_CheckedChanged);
            // 
            // rbOffice2007Blue
            // 
            this.rbOffice2007Blue.AutoSize = true;
            this.rbOffice2007Blue.Location = new System.Drawing.Point(16, 49);
            this.rbOffice2007Blue.Name = "rbOffice2007Blue";
            this.rbOffice2007Blue.Size = new System.Drawing.Size(137, 21);
            this.rbOffice2007Blue.TabIndex = 0;
            this.rbOffice2007Blue.Text = "Office 2007 - Blue";
            this.rbOffice2007Blue.UseVisualStyleBackColor = true;
            this.rbOffice2007Blue.CheckedChanged += new System.EventHandler(this.rbOffice2007Blue_CheckedChanged);
            // 
            // rbStyleList
            // 
            this.rbStyleList.AutoSize = true;
            this.rbStyleList.Checked = true;
            this.rbStyleList.Location = new System.Drawing.Point(18, 26);
            this.rbStyleList.Name = "rbStyleList";
            this.rbStyleList.Size = new System.Drawing.Size(49, 21);
            this.rbStyleList.TabIndex = 0;
            this.rbStyleList.TabStop = true;
            this.rbStyleList.Text = "List";
            this.rbStyleList.UseVisualStyleBackColor = true;
            this.rbStyleList.CheckedChanged += new System.EventHandler(this.rbStyleList_CheckedChanged);
            // 
            // groupBoxGridStyle
            // 
            this.groupBoxGridStyle.Controls.Add(this.rbStyleCustom);
            this.groupBoxGridStyle.Controls.Add(this.rbStyleSheet);
            this.groupBoxGridStyle.Controls.Add(this.rbStyleList);
            this.groupBoxGridStyle.Location = new System.Drawing.Point(162, 278);
            this.groupBoxGridStyle.Name = "groupBoxGridStyle";
            this.groupBoxGridStyle.Size = new System.Drawing.Size(91, 171);
            this.groupBoxGridStyle.TabIndex = 2;
            this.groupBoxGridStyle.TabStop = false;
            this.groupBoxGridStyle.Text = "GridStyle";
            // 
            // rbStyleCustom
            // 
            this.rbStyleCustom.AutoSize = true;
            this.rbStyleCustom.Location = new System.Drawing.Point(18, 72);
            this.rbStyleCustom.Name = "rbStyleCustom";
            this.rbStyleCustom.Size = new System.Drawing.Size(77, 21);
            this.rbStyleCustom.TabIndex = 2;
            this.rbStyleCustom.Text = "Custom";
            this.rbStyleCustom.UseVisualStyleBackColor = true;
            this.rbStyleCustom.CheckedChanged += new System.EventHandler(this.rbStyleCustom_CheckedChanged);
            // 
            // rbStyleSheet
            // 
            this.rbStyleSheet.AutoSize = true;
            this.rbStyleSheet.Location = new System.Drawing.Point(18, 49);
            this.rbStyleSheet.Name = "rbStyleSheet";
            this.rbStyleSheet.Size = new System.Drawing.Size(64, 21);
            this.rbStyleSheet.TabIndex = 1;
            this.rbStyleSheet.Text = "Sheet";
            this.rbStyleSheet.UseVisualStyleBackColor = true;
            this.rbStyleSheet.CheckedChanged += new System.EventHandler(this.rbStyleSheet_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearCellColors);
            this.groupBox1.Controls.Add(this.buttonRandomCellColors);
            this.groupBox1.Location = new System.Drawing.Point(259, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // buttonClearCellColors
            // 
            this.buttonClearCellColors.Location = new System.Drawing.Point(12, 60);
            this.buttonClearCellColors.Name = "buttonClearCellColors";
            this.buttonClearCellColors.Size = new System.Drawing.Size(129, 29);
            this.buttonClearCellColors.TabIndex = 1;
            this.buttonClearCellColors.Values.Text = "Clear Cell Colors";
            this.buttonClearCellColors.Click += new System.EventHandler(this.buttonClearCellColors_Click);
            // 
            // buttonRandomCellColors
            // 
            this.buttonRandomCellColors.Location = new System.Drawing.Point(13, 26);
            this.buttonRandomCellColors.Name = "buttonRandomCellColors";
            this.buttonRandomCellColors.Size = new System.Drawing.Size(129, 29);
            this.buttonRandomCellColors.TabIndex = 0;
            this.buttonRandomCellColors.Values.Text = "Random Cell Colors";
            this.buttonRandomCellColors.Click += new System.EventHandler(this.buttonRandomCellColors_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnForm2.Location = new System.Drawing.Point(477, 419);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(308, 30);
            this.btnForm2.TabIndex = 7;
            this.btnForm2.Text = "&Open Programatic Populate";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.BtnForm2_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(477, 279);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(295, 24);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Right click grid for Krypton Context Menu";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeight = 36;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.colComboBox,
            this.colTextBox,
            this.colMaskedTextBox,
            this.colDomainUpDown,
            this.colNumericUpDown,
            this.colCheckBox});
            this.kryptonDataGridView1.DataMember = "TestData";
            this.kryptonDataGridView1.DataSource = this.dataSet;
            this.kryptonDataGridView1.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.kryptonDataGridView1.KryptonContextMenu = this.kryptonContextMenu1;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(12, 20);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(870, 252);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.kryptonDataGridView1_CellToolTipTextNeeded);
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1,
            this.kryptonContextMenuHeading1,
            this.kryptonContextMenuSeparator1,
            this.kryptonContextMenuCheckBox1,
            this.kryptonContextMenuCheckButton1,
            this.kryptonContextMenuRadioButton1,
            this.kryptonContextMenuLinkLabel1,
            this.kryptonContextMenuColorColumns1,
            this.kryptonContextMenuImageSelect1,
            this.kryptonContextMenuMonthCalendar1});
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuCheckBox1
            // 
            this.kryptonContextMenuCheckBox1.ExtraText = "";
            this.kryptonContextMenuCheckBox1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            // 
            // kryptonContextMenuCheckButton1
            // 
            this.kryptonContextMenuCheckButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone;
            this.kryptonContextMenuCheckButton1.Text = "CheckButton";
            // 
            // kryptonContextMenuRadioButton1
            // 
            this.kryptonContextMenuRadioButton1.ExtraText = "";
            this.kryptonContextMenuRadioButton1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            // 
            // kryptonContextMenuLinkLabel1
            // 
            this.kryptonContextMenuLinkLabel1.ExtraText = "";
            this.kryptonContextMenuLinkLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonContextMenuLinkLabel1.LinkBehavior = Krypton.Toolkit.KryptonLinkBehavior.AlwaysUnderline;
            // 
            // kryptonContextMenuImageSelect1
            // 
            this.kryptonContextMenuImageSelect1.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            // 
            // kryptonContextMenuMonthCalendar1
            // 
            this.kryptonContextMenuMonthCalendar1.DayOfWeekStyle = Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.kryptonContextMenuMonthCalendar1.DayStyle = Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.kryptonContextMenuMonthCalendar1.HeaderStyle = Krypton.Toolkit.HeaderStyle.Calendar;
            // 
            // kryptonPalette
            // 
            this.kryptonPalette.BasePaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            this.kryptonPalette.GridStyles.GridCustom1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateCommon.Background.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette.GridStyles.GridCustom1.StateCommon.Background.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.Color2 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Content.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Content.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPalette = this.kryptonPalette;
            this.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // colDateTime
            // 
            this.colDateTime.Checked = false;
            this.colDateTime.DataPropertyName = "DateTime";
            this.colDateTime.HeaderText = "DateTime";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ToolTipText = "Datetime Tool tip text";
            this.colDateTime.Width = 190;
            // 
            // colComboBox
            // 
            this.colComboBox.DataPropertyName = "ComboBox";
            this.colComboBox.DataSource = null;
            this.colComboBox.DropDownWidth = 121;
            this.colComboBox.HeaderText = "ComboBox";
            this.colComboBox.Items.Add("Mr");
            this.colComboBox.Items.Add("Mrs");
            this.colComboBox.Items.Add("Miss");
            this.colComboBox.Items.Add("Ms");
            this.colComboBox.MinimumWidth = 6;
            this.colComboBox.Name = "colComboBox";
            this.colComboBox.Width = 75;
            // 
            // colTextBox
            // 
            this.colTextBox.DataPropertyName = "TextBox";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colTextBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTextBox.HeaderText = "TextBox";
            this.colTextBox.MinimumWidth = 100;
            this.colTextBox.Multiline = true;
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Width = 100;
            // 
            // colMaskedTextBox
            // 
            this.colMaskedTextBox.DataPropertyName = "MaskedTextBox";
            this.colMaskedTextBox.HeaderText = "MaskedTextBox";
            this.colMaskedTextBox.Mask = "(99) 9999-9999";
            this.colMaskedTextBox.MinimumWidth = 6;
            this.colMaskedTextBox.Name = "colMaskedTextBox";
            this.colMaskedTextBox.Width = 100;
            // 
            // colDomainUpDown
            // 
            this.colDomainUpDown.DataPropertyName = "DomainUpDown";
            this.colDomainUpDown.HeaderText = "DomainUpDown";
            this.colDomainUpDown.Items.AddRange(new string[] {
            "Single",
            "Married",
            "Divorced",
            "Separated"});
            this.colDomainUpDown.MinimumWidth = 6;
            this.colDomainUpDown.Name = "colDomainUpDown";
            this.colDomainUpDown.Width = 105;
            // 
            // colNumericUpDown
            // 
            this.colNumericUpDown.AllowDecimals = false;
            this.colNumericUpDown.DataPropertyName = "NumericUpDown";
            this.colNumericUpDown.HeaderText = "NumericUpDown";
            this.colNumericUpDown.MinimumWidth = 6;
            this.colNumericUpDown.Name = "colNumericUpDown";
            this.colNumericUpDown.Width = 105;
            // 
            // colCheckBox
            // 
            this.colCheckBox.DataPropertyName = "CheckBox";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.colCheckBox.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCheckBox.FalseValue = null;
            this.colCheckBox.HeaderText = "CheckBox";
            this.colCheckBox.IndeterminateValue = null;
            this.colCheckBox.MinimumWidth = 6;
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.TrueValue = null;
            this.colCheckBox.Width = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 497);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGridStyle);
            this.Controls.Add(this.groupBoxPalette);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1254, 544);
            this.Name = "Form1";
            this.Text = "KryptonDataGridView Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTestData)).EndInit();
            this.groupBoxPalette.ResumeLayout(false);
            this.groupBoxPalette.PerformLayout();
            this.groupBoxGridStyle.ResumeLayout(false);
            this.groupBoxGridStyle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.GroupBox groupBoxPalette;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbOffice2003;
        private System.Windows.Forms.RadioButton rbOffice2007Black;
        private System.Windows.Forms.RadioButton rbOffice2007Blue;
        private System.Windows.Forms.RadioButton rbStyleList;
        private System.Windows.Forms.GroupBox groupBoxGridStyle;
        private System.Windows.Forms.RadioButton rbStyleCustom;
        private System.Windows.Forms.RadioButton rbStyleSheet;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dtTestData;
        private Krypton.Toolkit.KryptonPalette kryptonPalette;
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonButton buttonRandomCellColors;
        private Krypton.Toolkit.KryptonButton buttonClearCellColors;
        private System.Windows.Forms.RadioButton rbSparkle;
        private System.Windows.Forms.RadioButton rbOffice2010Blue;
        private System.Data.DataColumn dataDateTime;
        private System.Data.DataColumn dataComboBox;
        private System.Data.DataColumn dataTextBox;
        private System.Data.DataColumn dataMaskedTextBox;
        private System.Data.DataColumn dataDomainUpDown;
        private System.Data.DataColumn dataNumericUpDown;
        private System.Data.DataColumn dataButton;
        private System.Data.DataColumn dataCheckBox;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private Krypton.Toolkit.KryptonContextMenuCheckBox kryptonContextMenuCheckBox1;
        private Krypton.Toolkit.KryptonContextMenuCheckButton kryptonContextMenuCheckButton1;
        private Krypton.Toolkit.KryptonContextMenuRadioButton kryptonContextMenuRadioButton1;
        private Krypton.Toolkit.KryptonContextMenuLinkLabel kryptonContextMenuLinkLabel1;
        private Krypton.Toolkit.KryptonContextMenuColorColumns kryptonContextMenuColorColumns1;
        private Krypton.Toolkit.KryptonContextMenuImageSelect kryptonContextMenuImageSelect1;
        private Krypton.Toolkit.KryptonContextMenuMonthCalendar kryptonContextMenuMonthCalendar1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Button btnForm2;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn colDateTime;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn colComboBox;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colTextBox;
        private Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn colMaskedTextBox;
        private Krypton.Toolkit.KryptonDataGridViewDomainUpDownColumn colDomainUpDown;
        private Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn colNumericUpDown;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn colCheckBox;
    }
}

