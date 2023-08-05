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
            this.components = new System.ComponentModel.Container();
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
            this.chkShowAlphaSlider = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowIcon = new Krypton.Toolkit.KryptonCheckBox();
            this.chkSolidColorOnly = new Krypton.Toolkit.KryptonCheckBox();
            this.chkFullOPen = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAnyColor = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowFullOpen = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowHelp = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTrackBar1 = new Krypton.Toolkit.KryptonTrackBar();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonManager = new Krypton.Toolkit.KryptonManager(this.components);
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
            this.groupBoxPalette.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.groupBoxPalette.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.groupBoxPalette.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.groupBoxPalette.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPalette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.paletteSparkleOrange.Location = new System.Drawing.Point(184, 39);
            this.paletteSparkleOrange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paletteSparkleOrange.Name = "paletteSparkleOrange";
            this.paletteSparkleOrange.Size = new System.Drawing.Size(139, 24);
            this.paletteSparkleOrange.TabIndex = 5;
            this.paletteSparkleOrange.Values.Text = "Sparkle - Orange";
            this.paletteSparkleOrange.CheckedChanged += new System.EventHandler(this.PaletteSparkleOrange_CheckedChanged);
            // 
            // palette2010Black
            // 
            this.palette2010Black.Location = new System.Drawing.Point(15, 63);
            this.palette2010Black.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palette2010Black.Name = "palette2010Black";
            this.palette2010Black.Size = new System.Drawing.Size(151, 24);
            this.palette2010Black.TabIndex = 4;
            this.palette2010Black.Values.Text = "Office 2010 - Black";
            this.palette2010Black.CheckedChanged += new System.EventHandler(this.Palette2010Black_CheckedChanged);
            // 
            // palette2010Silver
            // 
            this.palette2010Silver.Location = new System.Drawing.Point(15, 39);
            this.palette2010Silver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palette2010Silver.Name = "palette2010Silver";
            this.palette2010Silver.Size = new System.Drawing.Size(153, 24);
            this.palette2010Silver.TabIndex = 3;
            this.palette2010Silver.Values.Text = "Office 2010 - Silver";
            this.palette2010Silver.CheckedChanged += new System.EventHandler(this.Palette2010Silver_CheckedChanged);
            // 
            // paletteProfessional
            // 
            this.paletteProfessional.Location = new System.Drawing.Point(184, 63);
            this.paletteProfessional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paletteProfessional.Name = "paletteProfessional";
            this.paletteProfessional.Size = new System.Drawing.Size(106, 24);
            this.paletteProfessional.TabIndex = 2;
            this.paletteProfessional.Values.Text = "Professional";
            this.paletteProfessional.CheckedChanged += new System.EventHandler(this.PaletteProfessional_CheckedChanged);
            // 
            // palette2007Blue
            // 
            this.palette2007Blue.Location = new System.Drawing.Point(184, 17);
            this.palette2007Blue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palette2007Blue.Name = "palette2007Blue";
            this.palette2007Blue.Size = new System.Drawing.Size(145, 24);
            this.palette2007Blue.TabIndex = 1;
            this.palette2007Blue.Values.Text = "Office 2007 - Blue";
            this.palette2007Blue.CheckedChanged += new System.EventHandler(this.Palette2007Blue_CheckedChanged);
            // 
            // palette2010Blue
            // 
            this.palette2010Blue.Checked = true;
            this.palette2010Blue.Location = new System.Drawing.Point(15, 17);
            this.palette2010Blue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.palette2010Blue.Name = "palette2010Blue";
            this.palette2010Blue.Size = new System.Drawing.Size(145, 24);
            this.palette2010Blue.TabIndex = 0;
            this.palette2010Blue.Values.Text = "Office 2010 - Blue";
            this.palette2010Blue.CheckedChanged += new System.EventHandler(this.Palette2010Blue_CheckedChanged);
            // 
            // buttonShowFontDialog
            // 
            this.buttonShowFontDialog.Location = new System.Drawing.Point(264, 322);
            this.buttonShowFontDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowFontDialog.Name = "buttonShowFontDialog";
            this.buttonShowFontDialog.Size = new System.Drawing.Size(307, 59);
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
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(595, 410);
            this.kryptonPanel1.TabIndex = 20;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox2.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(372, 28);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowAlphaSlider);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowIcon);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkSolidColorOnly);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkFullOPen);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAnyColor);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowFullOpen);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowHelp);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(199, 289);
            this.kryptonGroupBox2.TabIndex = 21;
            this.kryptonGroupBox2.Values.Heading = "Options:";
            // 
            // chkShowAlphaSlider
            // 
            this.chkShowAlphaSlider.Location = new System.Drawing.Point(7, 177);
            this.chkShowAlphaSlider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowAlphaSlider.Name = "chkShowAlphaSlider";
            this.chkShowAlphaSlider.Size = new System.Drawing.Size(148, 24);
            this.chkShowAlphaSlider.TabIndex = 6;
            this.chkShowAlphaSlider.Values.Text = "Show Alpha Slider";
            // 
            // chkShowIcon
            // 
            this.chkShowIcon.Location = new System.Drawing.Point(4, 149);
            this.chkShowIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowIcon.Name = "chkShowIcon";
            this.chkShowIcon.Size = new System.Drawing.Size(95, 24);
            this.chkShowIcon.TabIndex = 5;
            this.chkShowIcon.Values.Text = "Show Icon";
            // 
            // chkSolidColorOnly
            // 
            this.chkSolidColorOnly.Location = new System.Drawing.Point(4, 121);
            this.chkSolidColorOnly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSolidColorOnly.Name = "chkSolidColorOnly";
            this.chkSolidColorOnly.Size = new System.Drawing.Size(135, 24);
            this.chkSolidColorOnly.TabIndex = 4;
            this.chkSolidColorOnly.Values.Text = "Solid Color Only";
            // 
            // chkFullOPen
            // 
            this.chkFullOPen.Location = new System.Drawing.Point(4, 90);
            this.chkFullOPen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFullOPen.Name = "chkFullOPen";
            this.chkFullOPen.Size = new System.Drawing.Size(90, 24);
            this.chkFullOPen.TabIndex = 3;
            this.chkFullOPen.Values.Text = "Full Open";
            // 
            // chkAnyColor
            // 
            this.chkAnyColor.Location = new System.Drawing.Point(3, 60);
            this.chkAnyColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAnyColor.Name = "chkAnyColor";
            this.chkAnyColor.Size = new System.Drawing.Size(92, 24);
            this.chkAnyColor.TabIndex = 2;
            this.chkAnyColor.Values.Text = "Any Color";
            // 
            // chkAllowFullOpen
            // 
            this.chkAllowFullOpen.Checked = true;
            this.chkAllowFullOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowFullOpen.Location = new System.Drawing.Point(4, 30);
            this.chkAllowFullOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAllowFullOpen.Name = "chkAllowFullOpen";
            this.chkAllowFullOpen.Size = new System.Drawing.Size(132, 24);
            this.chkAllowFullOpen.TabIndex = 1;
            this.chkAllowFullOpen.Values.Text = "Allow Full Open";
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.Location = new System.Drawing.Point(4, 0);
            this.chkShowHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Size = new System.Drawing.Size(98, 24);
            this.chkShowHelp.TabIndex = 0;
            this.chkShowHelp.Values.Text = "Show Help";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 153);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTrackBar1);
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(288, 97);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Orientation = Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonLabel1.Size = new System.Drawing.Size(24, 36);
            this.kryptonLabel1.TabIndex = 23;
            this.kryptonLabel1.Values.Text = "255";
            // 
            // kryptonTrackBar1
            // 
            this.kryptonTrackBar1.AutoSize = false;
            this.kryptonTrackBar1.Location = new System.Drawing.Point(318, 69);
            this.kryptonTrackBar1.Maximum = 255;
            this.kryptonTrackBar1.Name = "kryptonTrackBar1";
            this.kryptonTrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonTrackBar1.Size = new System.Drawing.Size(23, 57);
            this.kryptonTrackBar1.TabIndex = 22;
            this.kryptonTrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.kryptonTrackBar1.ToolTipValues.Description = "Alpha";
            this.kryptonTrackBar1.ToolTipValues.EnableToolTips = true;
            this.kryptonTrackBar1.ToolTipValues.Heading = "";
            this.kryptonTrackBar1.ToolTipValues.ShowIntervalDelay = 250;
            this.kryptonTrackBar1.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Top;
            this.kryptonTrackBar1.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonTrackBar1.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large;
            this.kryptonTrackBar1.VolumeControl = true;
            this.kryptonTrackBar1.ValueChanged += new System.EventHandler(this.kryptonTrackBar1_ValueChanged);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(156, 30);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(133, 27);
            this.kryptonTextBox1.TabIndex = 6;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(156, 97);
            this.kryptonNumericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(91, 26);
            this.kryptonNumericUpDown1.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(156, 65);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(91, 25);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(156, 4);
            this.kryptonCheckBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
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
            this.kryptonListBox1.Location = new System.Drawing.Point(4, 30);
            this.kryptonListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonListBox1.Name = "kryptonListBox1";
            this.kryptonListBox1.Size = new System.Drawing.Size(120, 96);
            this.kryptonListBox1.TabIndex = 1;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 121;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Microsoft Sans Serif"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(4, 4);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(147, 25);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 0;
            this.kryptonComboBox1.Text = "Microsoft Sans Serif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 410);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private Krypton.Toolkit.KryptonManager kryptonManager;
        private Krypton.Toolkit.KryptonCheckBox chkShowIcon;
        private Krypton.Toolkit.KryptonCheckBox chkShowAlphaSlider;
        private Krypton.Toolkit.KryptonTrackBar kryptonTrackBar1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

