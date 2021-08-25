
namespace KryptonFontDialog_Example_2019
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxPalette = new Krypton.Toolkit.KryptonGroupBox();
            this.paletteSparkleOrange = new Krypton.Toolkit.KryptonRadioButton();
            this.palette2010Black = new Krypton.Toolkit.KryptonRadioButton();
            this.palette2010Silver = new Krypton.Toolkit.KryptonRadioButton();
            this.paletteProfessional = new Krypton.Toolkit.KryptonRadioButton();
            this.palette2007Blue = new Krypton.Toolkit.KryptonRadioButton();
            this.palette2010Blue = new Krypton.Toolkit.KryptonRadioButton();
            this.buttonShowFontDialog = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.chkSolidColorOnly = new Krypton.Toolkit.KryptonCheckBox();
            this.chkFullOPen = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAnyColor = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowFullOpen = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowHelp = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette.Panel)).BeginInit();
            this.groupBoxPalette.Panel.SuspendLayout();
            this.groupBoxPalette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPalette
            // 
            this.groupBoxPalette.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxPalette.CaptionEdge = Krypton.Toolkit.VisualOrientation.Top;
            this.groupBoxPalette.CaptionOrientation = Krypton.Toolkit.ButtonOrientation.Auto;
            this.groupBoxPalette.Location = new System.Drawing.Point(9, 10);
            this.groupBoxPalette.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPalette.Name = "groupBoxPalette";
            // 
            // groupBoxPalette.Panel
            // 
            this.groupBoxPalette.Panel.Controls.Add(this.paletteSparkleOrange);
            this.groupBoxPalette.Panel.Controls.Add(this.palette2010Black);
            this.groupBoxPalette.Panel.Controls.Add(this.palette2010Silver);
            this.groupBoxPalette.Panel.Controls.Add(this.paletteProfessional);
            this.groupBoxPalette.Panel.Controls.Add(this.palette2007Blue);
            this.groupBoxPalette.Panel.Controls.Add(this.palette2010Blue);
            this.groupBoxPalette.Size = new System.Drawing.Size(265, 110);
            this.groupBoxPalette.TabIndex = 18;
            this.groupBoxPalette.Values.Heading = "Palette";
            // 
            // paletteSparkleOrange
            // 
            this.paletteSparkleOrange.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.paletteSparkleOrange.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.paletteSparkleOrange.Location = new System.Drawing.Point(138, 32);
            this.paletteSparkleOrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paletteSparkleOrange.Name = "paletteSparkleOrange";
            this.paletteSparkleOrange.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.paletteSparkleOrange.Size = new System.Drawing.Size(115, 20);
            this.paletteSparkleOrange.TabIndex = 5;
            this.paletteSparkleOrange.Values.Text = "Sparkle - Orange";
            this.paletteSparkleOrange.CheckedChanged += new System.EventHandler(this.PaletteSparkleOrange_CheckedChanged);
            // 
            // palette2010Black
            // 
            this.palette2010Black.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2010Black.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2010Black.Location = new System.Drawing.Point(11, 51);
            this.palette2010Black.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.palette2010Black.Name = "palette2010Black";
            this.palette2010Black.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2010Black.Size = new System.Drawing.Size(125, 20);
            this.palette2010Black.TabIndex = 4;
            this.palette2010Black.Values.Text = "Office 2010 - Black";
            this.palette2010Black.CheckedChanged += new System.EventHandler(this.Palette2010Black_CheckedChanged);
            // 
            // palette2010Silver
            // 
            this.palette2010Silver.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2010Silver.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2010Silver.Location = new System.Drawing.Point(11, 32);
            this.palette2010Silver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.palette2010Silver.Name = "palette2010Silver";
            this.palette2010Silver.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2010Silver.Size = new System.Drawing.Size(126, 20);
            this.palette2010Silver.TabIndex = 3;
            this.palette2010Silver.Values.Text = "Office 2010 - Silver";
            this.palette2010Silver.CheckedChanged += new System.EventHandler(this.Palette2010Silver_CheckedChanged);
            // 
            // paletteProfessional
            // 
            this.paletteProfessional.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.paletteProfessional.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.paletteProfessional.Location = new System.Drawing.Point(138, 51);
            this.paletteProfessional.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paletteProfessional.Name = "paletteProfessional";
            this.paletteProfessional.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.paletteProfessional.Size = new System.Drawing.Size(88, 20);
            this.paletteProfessional.TabIndex = 2;
            this.paletteProfessional.Values.Text = "Professional";
            this.paletteProfessional.CheckedChanged += new System.EventHandler(this.PaletteProfessional_CheckedChanged);
            // 
            // palette2007Blue
            // 
            this.palette2007Blue.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2007Blue.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2007Blue.Location = new System.Drawing.Point(138, 14);
            this.palette2007Blue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.palette2007Blue.Name = "palette2007Blue";
            this.palette2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2007Blue.Size = new System.Drawing.Size(120, 20);
            this.palette2007Blue.TabIndex = 1;
            this.palette2007Blue.Values.Text = "Office 2007 - Blue";
            this.palette2007Blue.CheckedChanged += new System.EventHandler(this.Palette2007Blue_CheckedChanged);
            // 
            // palette2010Blue
            // 
            this.palette2010Blue.Checked = true;
            this.palette2010Blue.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2010Blue.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2010Blue.Location = new System.Drawing.Point(11, 14);
            this.palette2010Blue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.palette2010Blue.Name = "palette2010Blue";
            this.palette2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2010Blue.Size = new System.Drawing.Size(120, 20);
            this.palette2010Blue.TabIndex = 0;
            this.palette2010Blue.Values.Text = "Office 2010 - Blue";
            this.palette2010Blue.CheckedChanged += new System.EventHandler(this.Palette2010Blue_CheckedChanged);
            // 
            // buttonShowFontDialog
            // 
            this.buttonShowFontDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonShowFontDialog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonShowFontDialog.Location = new System.Drawing.Point(198, 262);
            this.buttonShowFontDialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShowFontDialog.Name = "buttonShowFontDialog";
            this.buttonShowFontDialog.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonShowFontDialog.Size = new System.Drawing.Size(230, 48);
            this.buttonShowFontDialog.TabIndex = 19;
            this.buttonShowFontDialog.Values.Text = "Show ColorDialog";
            this.buttonShowFontDialog.Click += new System.EventHandler(this.ButtonShowFontDialog_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.groupBoxPalette);
            this.kryptonPanel1.Controls.Add(this.buttonShowFontDialog);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(446, 333);
            this.kryptonPanel1.TabIndex = 20;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonGroupBox2.CaptionEdge = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonGroupBox2.CaptionOrientation = Krypton.Toolkit.ButtonOrientation.Auto;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(279, 23);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkSolidColorOnly);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkFullOPen);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAnyColor);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowFullOpen);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowHelp);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(149, 235);
            this.kryptonGroupBox2.TabIndex = 21;
            this.kryptonGroupBox2.Values.Heading = "Options:";
            // 
            // chkSolidColorOnly
            // 
            this.chkSolidColorOnly.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkSolidColorOnly.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkSolidColorOnly.Location = new System.Drawing.Point(3, 98);
            this.chkSolidColorOnly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSolidColorOnly.Name = "chkSolidColorOnly";
            this.chkSolidColorOnly.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkSolidColorOnly.Size = new System.Drawing.Size(112, 20);
            this.chkSolidColorOnly.TabIndex = 4;
            this.chkSolidColorOnly.Values.Text = "Solid Color Only";
            // 
            // chkFullOPen
            // 
            this.chkFullOPen.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkFullOPen.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkFullOPen.Location = new System.Drawing.Point(3, 73);
            this.chkFullOPen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkFullOPen.Name = "chkFullOPen";
            this.chkFullOPen.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkFullOPen.Size = new System.Drawing.Size(76, 20);
            this.chkFullOPen.TabIndex = 3;
            this.chkFullOPen.Values.Text = "Full Open";
            // 
            // chkAnyColor
            // 
            this.chkAnyColor.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkAnyColor.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkAnyColor.Location = new System.Drawing.Point(2, 49);
            this.chkAnyColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAnyColor.Name = "chkAnyColor";
            this.chkAnyColor.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkAnyColor.Size = new System.Drawing.Size(77, 20);
            this.chkAnyColor.TabIndex = 2;
            this.chkAnyColor.Values.Text = "Any Color";
            // 
            // chkAllowFullOpen
            // 
            this.chkAllowFullOpen.Checked = true;
            this.chkAllowFullOpen.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkAllowFullOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowFullOpen.Location = new System.Drawing.Point(3, 24);
            this.chkAllowFullOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAllowFullOpen.Name = "chkAllowFullOpen";
            this.chkAllowFullOpen.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkAllowFullOpen.Size = new System.Drawing.Size(109, 20);
            this.chkAllowFullOpen.TabIndex = 1;
            this.chkAllowFullOpen.Values.Text = "Allow Full Open";
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkShowHelp.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkShowHelp.Location = new System.Drawing.Point(3, 0);
            this.chkShowHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkShowHelp.Size = new System.Drawing.Size(82, 20);
            this.chkShowHelp.TabIndex = 0;
            this.chkShowHelp.Values.Text = "Show Help";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonGroupBox1.CaptionEdge = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonGroupBox1.CaptionOrientation = Krypton.Toolkit.ButtonOrientation.Auto;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(9, 124);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonNumericUpDown1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonCheckBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonListBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonComboBox1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(261, 133);
            this.kryptonGroupBox1.TabIndex = 20;
            this.kryptonGroupBox1.Values.Heading = "Style to match:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox1.Location = new System.Drawing.Point(117, 24);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox1.Size = new System.Drawing.Size(100, 23);
            this.kryptonTextBox1.TabIndex = 6;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            this.kryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(117, 79);
            this.kryptonNumericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonNumericUpDown1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(68, 22);
            this.kryptonNumericUpDown1.TabIndex = 5;
            this.kryptonNumericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.kryptonNumericUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.kryptonButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.kryptonButton1.Location = new System.Drawing.Point(117, 53);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButton1.Size = new System.Drawing.Size(68, 20);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonCheckBox1.Location = new System.Drawing.Point(117, 3);
            this.kryptonCheckBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonCheckBox1.Size = new System.Drawing.Size(125, 20);
            this.kryptonCheckBox1.TabIndex = 2;
            this.kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonListBox1
            // 
            this.kryptonListBox1.Items.AddRange(new object[] {
            "Font 1",
            "Font 2",
            "Font 1Font 1Font 1Font 1"});
            this.kryptonListBox1.Location = new System.Drawing.Point(3, 24);
            this.kryptonListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonListBox1.Name = "kryptonListBox1";
            this.kryptonListBox1.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonListBox1.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.kryptonListBox1.Size = new System.Drawing.Size(90, 78);
            this.kryptonListBox1.TabIndex = 1;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 121;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Microsoft Sans Serif"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(3, 3);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(110, 21);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 0;
            this.kryptonComboBox1.Text = "Microsoft Sans Serif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 333);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "KryptonColorDialog Example";
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette.Panel)).EndInit();
            this.groupBoxPalette.Panel.ResumeLayout(false);
            this.groupBoxPalette.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette)).EndInit();
            this.groupBoxPalette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox groupBoxPalette;
        private Krypton.Toolkit.KryptonRadioButton paletteSparkleOrange;
        private Krypton.Toolkit.KryptonRadioButton palette2010Black;
        private Krypton.Toolkit.KryptonRadioButton palette2010Silver;
        private Krypton.Toolkit.KryptonRadioButton paletteProfessional;
        private Krypton.Toolkit.KryptonRadioButton palette2007Blue;
        private Krypton.Toolkit.KryptonRadioButton palette2010Blue;
        private Krypton.Toolkit.KryptonButton buttonShowFontDialog;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonCheckBox chkShowHelp;
        private Krypton.Toolkit.KryptonCheckBox chkAllowFullOpen;
        private Krypton.Toolkit.KryptonCheckBox chkSolidColorOnly;
        private Krypton.Toolkit.KryptonCheckBox chkFullOPen;
        private Krypton.Toolkit.KryptonCheckBox chkAnyColor;
    }
}

