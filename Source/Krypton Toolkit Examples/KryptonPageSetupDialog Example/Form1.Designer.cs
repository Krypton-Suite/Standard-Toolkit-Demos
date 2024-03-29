﻿
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
            this.chkShowEffects = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowApply = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowVectorFonts = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowSimulations = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowScriptChange = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowColour = new Krypton.Toolkit.KryptonCheckBox();
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
            this.groupBoxPalette.Location = new System.Drawing.Point(12, 12);
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
            this.groupBoxPalette.Size = new System.Drawing.Size(353, 135);
            this.groupBoxPalette.TabIndex = 18;
            this.groupBoxPalette.Values.Heading = "Palette";
            // 
            // paletteSparkleOrange
            // 
            this.paletteSparkleOrange.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.paletteSparkleOrange.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.paletteSparkleOrange.Location = new System.Drawing.Point(184, 40);
            this.paletteSparkleOrange.Name = "paletteSparkleOrange";
            this.paletteSparkleOrange.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.paletteSparkleOrange.Size = new System.Drawing.Size(139, 24);
            this.paletteSparkleOrange.TabIndex = 5;
            this.paletteSparkleOrange.Values.Text = "Sparkle - Orange";
            this.paletteSparkleOrange.CheckedChanged += new System.EventHandler(this.PaletteSparkleOrange_CheckedChanged);
            // 
            // palette2010Black
            // 
            this.palette2010Black.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2010Black.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2010Black.Location = new System.Drawing.Point(15, 63);
            this.palette2010Black.Name = "palette2010Black";
            this.palette2010Black.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2010Black.Size = new System.Drawing.Size(151, 24);
            this.palette2010Black.TabIndex = 4;
            this.palette2010Black.Values.Text = "Office 2010 - Black";
            this.palette2010Black.CheckedChanged += new System.EventHandler(this.Palette2010Black_CheckedChanged);
            // 
            // palette2010Silver
            // 
            this.palette2010Silver.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2010Silver.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2010Silver.Location = new System.Drawing.Point(15, 40);
            this.palette2010Silver.Name = "palette2010Silver";
            this.palette2010Silver.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2010Silver.Size = new System.Drawing.Size(153, 24);
            this.palette2010Silver.TabIndex = 3;
            this.palette2010Silver.Values.Text = "Office 2010 - Silver";
            this.palette2010Silver.CheckedChanged += new System.EventHandler(this.Palette2010Silver_CheckedChanged);
            // 
            // paletteProfessional
            // 
            this.paletteProfessional.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.paletteProfessional.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.paletteProfessional.Location = new System.Drawing.Point(184, 63);
            this.paletteProfessional.Name = "paletteProfessional";
            this.paletteProfessional.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.paletteProfessional.Size = new System.Drawing.Size(106, 24);
            this.paletteProfessional.TabIndex = 2;
            this.paletteProfessional.Values.Text = "Professional";
            this.paletteProfessional.CheckedChanged += new System.EventHandler(this.PaletteProfessional_CheckedChanged);
            // 
            // palette2007Blue
            // 
            this.palette2007Blue.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2007Blue.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2007Blue.Location = new System.Drawing.Point(184, 17);
            this.palette2007Blue.Name = "palette2007Blue";
            this.palette2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2007Blue.Size = new System.Drawing.Size(145, 24);
            this.palette2007Blue.TabIndex = 1;
            this.palette2007Blue.Values.Text = "Office 2007 - Blue";
            this.palette2007Blue.CheckedChanged += new System.EventHandler(this.Palette2007Blue_CheckedChanged);
            // 
            // palette2010Blue
            // 
            this.palette2010Blue.Checked = true;
            this.palette2010Blue.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.palette2010Blue.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.palette2010Blue.Location = new System.Drawing.Point(15, 17);
            this.palette2010Blue.Name = "palette2010Blue";
            this.palette2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.palette2010Blue.Size = new System.Drawing.Size(145, 24);
            this.palette2010Blue.TabIndex = 0;
            this.palette2010Blue.Values.Text = "Office 2010 - Blue";
            this.palette2010Blue.CheckedChanged += new System.EventHandler(this.Palette2010Blue_CheckedChanged);
            // 
            // buttonShowFontDialog
            // 
            this.buttonShowFontDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.buttonShowFontDialog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonShowFontDialog.Location = new System.Drawing.Point(264, 323);
            this.buttonShowFontDialog.Name = "buttonShowFontDialog";
            this.buttonShowFontDialog.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.buttonShowFontDialog.Size = new System.Drawing.Size(307, 59);
            this.buttonShowFontDialog.TabIndex = 19;
            this.buttonShowFontDialog.Values.Text = "Show FontDialog";
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
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(594, 410);
            this.kryptonPanel1.TabIndex = 20;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonGroupBox2.CaptionEdge = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonGroupBox2.CaptionOrientation = Krypton.Toolkit.ButtonOrientation.Auto;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(372, 28);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowEffects);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowApply);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowVectorFonts);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowSimulations);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowScriptChange);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowColour);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowHelp);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(199, 289);
            this.kryptonGroupBox2.TabIndex = 21;
            this.kryptonGroupBox2.Values.Heading = "Options:";
            // 
            // chkShowEffects
            // 
            this.chkShowEffects.Checked = true;
            this.chkShowEffects.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkShowEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowEffects.Location = new System.Drawing.Point(4, 180);
            this.chkShowEffects.Name = "chkShowEffects";
            this.chkShowEffects.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkShowEffects.Size = new System.Drawing.Size(110, 24);
            this.chkShowEffects.TabIndex = 6;
            this.chkShowEffects.Values.Text = "Show Effects";
            // 
            // chkShowApply
            // 
            this.chkShowApply.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkShowApply.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkShowApply.Location = new System.Drawing.Point(4, 150);
            this.chkShowApply.Name = "chkShowApply";
            this.chkShowApply.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkShowApply.Size = new System.Drawing.Size(105, 24);
            this.chkShowApply.TabIndex = 5;
            this.chkShowApply.Values.Text = "Show Apply";
            // 
            // chkAllowVectorFonts
            // 
            this.chkAllowVectorFonts.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkAllowVectorFonts.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkAllowVectorFonts.Location = new System.Drawing.Point(4, 120);
            this.chkAllowVectorFonts.Name = "chkAllowVectorFonts";
            this.chkAllowVectorFonts.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkAllowVectorFonts.Size = new System.Drawing.Size(152, 24);
            this.chkAllowVectorFonts.TabIndex = 4;
            this.chkAllowVectorFonts.Values.Text = "Allow Vector Fonts";
            // 
            // chkAllowSimulations
            // 
            this.chkAllowSimulations.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkAllowSimulations.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkAllowSimulations.Location = new System.Drawing.Point(4, 90);
            this.chkAllowSimulations.Name = "chkAllowSimulations";
            this.chkAllowSimulations.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkAllowSimulations.Size = new System.Drawing.Size(145, 24);
            this.chkAllowSimulations.TabIndex = 3;
            this.chkAllowSimulations.Values.Text = "Allow Simulations";
            // 
            // chkAllowScriptChange
            // 
            this.chkAllowScriptChange.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkAllowScriptChange.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkAllowScriptChange.Location = new System.Drawing.Point(3, 60);
            this.chkAllowScriptChange.Name = "chkAllowScriptChange";
            this.chkAllowScriptChange.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkAllowScriptChange.Size = new System.Drawing.Size(161, 24);
            this.chkAllowScriptChange.TabIndex = 2;
            this.chkAllowScriptChange.Values.Text = "Allow Script Change";
            // 
            // chkShowColour
            // 
            this.chkShowColour.Checked = true;
            this.chkShowColour.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkShowColour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowColour.Location = new System.Drawing.Point(4, 30);
            this.chkShowColour.Name = "chkShowColour";
            this.chkShowColour.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkShowColour.Size = new System.Drawing.Size(111, 24);
            this.chkShowColour.TabIndex = 1;
            this.chkShowColour.Values.Text = "Show Colour";
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.chkShowHelp.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkShowHelp.Location = new System.Drawing.Point(4, 0);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.chkShowHelp.Size = new System.Drawing.Size(98, 24);
            this.chkShowHelp.TabIndex = 0;
            this.chkShowHelp.Values.Text = "Show Help";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonGroupBox1.CaptionEdge = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonGroupBox1.CaptionOrientation = Krypton.Toolkit.ButtonOrientation.Auto;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 153);
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
            this.kryptonGroupBox1.Size = new System.Drawing.Size(348, 164);
            this.kryptonGroupBox1.TabIndex = 20;
            this.kryptonGroupBox1.Values.Heading = "Style to match:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kryptonTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kryptonTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kryptonTextBox1.Location = new System.Drawing.Point(156, 29);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kryptonTextBox1.Size = new System.Drawing.Size(134, 27);
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
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(156, 97);
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
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(90, 26);
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
            this.kryptonButton1.Location = new System.Drawing.Point(156, 65);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.CheckPosition = Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.kryptonCheckBox1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonCheckBox1.Location = new System.Drawing.Point(156, 4);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Orientation = Krypton.Toolkit.VisualOrientation.Top;
            this.kryptonCheckBox1.Size = new System.Drawing.Size(152, 24);
            this.kryptonCheckBox1.TabIndex = 2;
            this.kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonListBox1
            // 
            this.kryptonListBox1.Items.AddRange(new object[] {
            "Font 1",
            "Font 2",
            "Font 1Font 1Font 1Font 1"});
            this.kryptonListBox1.Location = new System.Drawing.Point(4, 29);
            this.kryptonListBox1.Name = "kryptonListBox1";
            this.kryptonListBox1.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonListBox1.SelectionMode = System.Windows.Forms.SelectionMode.One;
            this.kryptonListBox1.Size = new System.Drawing.Size(120, 96);
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
            this.kryptonComboBox1.Location = new System.Drawing.Point(4, 4);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(146, 25);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(-1);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 0;
            this.kryptonComboBox1.Text = "Microsoft Sans Serif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 410);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form1";
            this.Text = "KryptonFontDialog Example";
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
        private Krypton.Toolkit.KryptonCheckBox chkShowColour;
        private Krypton.Toolkit.KryptonCheckBox chkShowEffects;
        private Krypton.Toolkit.KryptonCheckBox chkShowApply;
        private Krypton.Toolkit.KryptonCheckBox chkAllowVectorFonts;
        private Krypton.Toolkit.KryptonCheckBox chkAllowSimulations;
        private Krypton.Toolkit.KryptonCheckBox chkAllowScriptChange;
    }
}

