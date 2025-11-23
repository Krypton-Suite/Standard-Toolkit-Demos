// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
// By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2023 - 2025. All rights reserved.
// *****************************************************************************

namespace KryptonProgressBarExamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kchkShowTextShadow = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kcbtnProgressBarColour = new Krypton.Toolkit.KryptonColorButton();
            this.kcmbProgressBarStyle = new Krypton.Toolkit.KryptonComboBox();
            this.klblColorStyle = new Krypton.Toolkit.KryptonLabel();
            this.kcmbColorStyle = new Krypton.Toolkit.KryptonComboBox();
            this.kchkShowTextBackdrop = new Krypton.Toolkit.KryptonCheckBox();
            this.kcbtnBackdropColor = new Krypton.Toolkit.KryptonColorButton();
            this.kchkUseProgressValueAsText = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ktrkProgressValues = new Krypton.Toolkit.KryptonTrackBar();
            this.ProgressBarDisabled = new Krypton.Toolkit.KryptonProgressBar();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            this.pbVertical = new Krypton.Toolkit.KryptonProgressBar();
            this.pbCustomColor = new Krypton.Toolkit.KryptonProgressBar();
            this.pbHorizontal2 = new Krypton.Toolkit.KryptonProgressBar();
            this.pbHorizontal = new Krypton.Toolkit.KryptonProgressBar();
            this.knudHorizontal = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.kryptonProgressBarToolStripItem1 = new Krypton.Toolkit.KryptonProgressBarToolStripItem();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbProgressBarStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbColorStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kchkShowTextShadow);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kcbtnProgressBarColour);
            this.kryptonPanel1.Controls.Add(this.kcmbProgressBarStyle);
            this.kryptonPanel1.Controls.Add(this.klblColorStyle);
            this.kryptonPanel1.Controls.Add(this.kcmbColorStyle);
            this.kryptonPanel1.Controls.Add(this.kchkShowTextBackdrop);
            this.kryptonPanel1.Controls.Add(this.kcbtnBackdropColor);
            this.kryptonPanel1.Controls.Add(this.kchkUseProgressValueAsText);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.ktrkProgressValues);
            this.kryptonPanel1.Controls.Add(this.ProgressBarDisabled);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonThemeComboBox1);
            this.kryptonPanel1.Controls.Add(this.pbVertical);
            this.kryptonPanel1.Controls.Add(this.pbCustomColor);
            this.kryptonPanel1.Controls.Add(this.pbHorizontal2);
            this.kryptonPanel1.Controls.Add(this.pbHorizontal);
            this.kryptonPanel1.Controls.Add(this.knudHorizontal);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(799, 422);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kchkShowTextShadow
            // 
            this.kchkShowTextShadow.Location = new System.Drawing.Point(43, 307);
            this.kchkShowTextShadow.Name = "kchkShowTextShadow";
            this.kchkShowTextShadow.Size = new System.Drawing.Size(131, 21);
            this.kchkShowTextShadow.TabIndex = 33;
            this.kchkShowTextShadow.Values.Text = "Show text shadow";
            this.kchkShowTextShadow.CheckedChanged += new System.EventHandler(this.kchkShowTextShadow_CheckedChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(262, 239);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(94, 21);
            this.kryptonLabel3.TabIndex = 32;
            this.kryptonLabel3.Values.Text = "Progress Style";
            // 
            // kcbtnProgressBarColour
            // 
            this.kcbtnProgressBarColour.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle;
            this.kcbtnProgressBarColour.Location = new System.Drawing.Point(43, 265);
            this.kcbtnProgressBarColour.Name = "kcbtnProgressBarColour";
            this.kcbtnProgressBarColour.SelectedColor = System.Drawing.Color.Green;
            this.kcbtnProgressBarColour.Size = new System.Drawing.Size(177, 25);
            this.kcbtnProgressBarColour.TabIndex = 27;
            this.kcbtnProgressBarColour.Values.Image = ((System.Drawing.Image)(resources.GetObject("kcbtnProgressBarColour.Values.Image")));
            this.kcbtnProgressBarColour.Values.RoundedCorners = 8;
            this.kcbtnProgressBarColour.Values.Text = "Custom Color";
            this.kcbtnProgressBarColour.SelectedColorChanged += new System.EventHandler<Krypton.Toolkit.ColorEventArgs>(this.kcbtnProgressBarColour_SelectedColorChanged);
            // 
            // kcmbProgressBarStyle
            // 
            this.kcmbProgressBarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbProgressBarStyle.DropDownWidth = 261;
            this.kcmbProgressBarStyle.IntegralHeight = false;
            this.kcmbProgressBarStyle.Location = new System.Drawing.Point(373, 237);
            this.kcmbProgressBarStyle.Name = "kcmbProgressBarStyle";
            this.kcmbProgressBarStyle.Size = new System.Drawing.Size(179, 24);
            this.kcmbProgressBarStyle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbProgressBarStyle.TabIndex = 26;
            this.kcmbProgressBarStyle.SelectedIndexChanged += new System.EventHandler(this.kcmbProgressBarStyle_SelectedIndexChanged);
            // 
            // klblColorStyle
            // 
            this.klblColorStyle.Location = new System.Drawing.Point(262, 266);
            this.klblColorStyle.Name = "klblColorStyle";
            this.klblColorStyle.Size = new System.Drawing.Size(75, 21);
            this.klblColorStyle.TabIndex = 28;
            this.klblColorStyle.Values.Text = "Color Style";
            // 
            // kcmbColorStyle
            // 
            this.kcmbColorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbColorStyle.DropDownWidth = 179;
            this.kcmbColorStyle.IntegralHeight = false;
            this.kcmbColorStyle.Location = new System.Drawing.Point(373, 265);
            this.kcmbColorStyle.Name = "kcmbColorStyle";
            this.kcmbColorStyle.Size = new System.Drawing.Size(179, 24);
            this.kcmbColorStyle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbColorStyle.TabIndex = 29;
            this.kcmbColorStyle.SelectedIndexChanged += new System.EventHandler(this.kcmbColorStyle_SelectedIndexChanged);
            // 
            // kchkShowTextBackdrop
            // 
            this.kchkShowTextBackdrop.Location = new System.Drawing.Point(43, 333);
            this.kchkShowTextBackdrop.Name = "kchkShowTextBackdrop";
            this.kchkShowTextBackdrop.Size = new System.Drawing.Size(141, 21);
            this.kchkShowTextBackdrop.TabIndex = 30;
            this.kchkShowTextBackdrop.Values.Text = "Show text backdrop";
            this.kchkShowTextBackdrop.CheckedChanged += new System.EventHandler(this.kchkShowTextBackdrop_CheckedChanged);
            // 
            // kcbtnBackdropColor
            // 
            this.kcbtnBackdropColor.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle;
            this.kcbtnBackdropColor.Location = new System.Drawing.Point(43, 359);
            this.kcbtnBackdropColor.Name = "kcbtnBackdropColor";
            this.kcbtnBackdropColor.SelectedColor = System.Drawing.Color.WhiteSmoke;
            this.kcbtnBackdropColor.Size = new System.Drawing.Size(177, 25);
            this.kcbtnBackdropColor.TabIndex = 31;
            this.kcbtnBackdropColor.Values.Image = ((System.Drawing.Image)(resources.GetObject("kcbtnBackdropColor.Values.Image")));
            this.kcbtnBackdropColor.Values.RoundedCorners = 8;
            this.kcbtnBackdropColor.Values.Text = "Text Backdrop Colour";
            this.kcbtnBackdropColor.SelectedColorChanged += new System.EventHandler<Krypton.Toolkit.ColorEventArgs>(this.kcbtnBackdropColor_SelectedColorChanged);
            // 
            // kchkUseProgressValueAsText
            // 
            this.kchkUseProgressValueAsText.Checked = true;
            this.kchkUseProgressValueAsText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kchkUseProgressValueAsText.Location = new System.Drawing.Point(43, 239);
            this.kchkUseProgressValueAsText.Name = "kchkUseProgressValueAsText";
            this.kchkUseProgressValueAsText.Size = new System.Drawing.Size(177, 21);
            this.kchkUseProgressValueAsText.TabIndex = 25;
            this.kchkUseProgressValueAsText.Values.Text = "Use progress value as text";
            this.kchkUseProgressValueAsText.CheckedChanged += new System.EventHandler(this.kchkUseProgressValueAsText_CheckedChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(43, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(57, 21);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "Theme:";
            // 
            // ktrkProgressValues
            // 
            this.ktrkProgressValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktrkProgressValues.Location = new System.Drawing.Point(187, 37);
            this.ktrkProgressValues.Maximum = 100;
            this.ktrkProgressValues.Name = "ktrkProgressValues";
            this.ktrkProgressValues.Size = new System.Drawing.Size(590, 33);
            this.ktrkProgressValues.TabIndex = 14;
            this.ktrkProgressValues.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ktrkProgressValues.ValueChanged += new System.EventHandler(this.ktrkProgressValues_ValueChanged);
            // 
            // ProgressBarDisabled
            // 
            this.ProgressBarDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarDisabled.Enabled = false;
            this.ProgressBarDisabled.Location = new System.Drawing.Point(43, 203);
            this.ProgressBarDisabled.Name = "ProgressBarDisabled";
            this.ProgressBarDisabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBarDisabled.Size = new System.Drawing.Size(738, 23);
            this.ProgressBarDisabled.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProgressBarDisabled.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProgressBarDisabled.StateCommon.Border.Rounding = 10F;
            this.ProgressBarDisabled.TabIndex = 12;
            this.ProgressBarDisabled.Text = "Disabled (RTL)";
            this.ProgressBarDisabled.TextBackdropColor = System.Drawing.Color.Empty;
            this.ProgressBarDisabled.TextShadowColor = System.Drawing.Color.Empty;
            this.ProgressBarDisabled.Value = 75;
            this.ProgressBarDisabled.Values.Text = "Disabled (RTL)";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kryptonButton1.Location = new System.Drawing.Point(704, 357);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(73, 29);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.TabIndex = 11;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "&Close";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonThemeComboBox1
            // 
            this.kryptonThemeComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonThemeComboBox1.DisplayMember = "Key";
            this.kryptonThemeComboBox1.DropDownWidth = 321;
            this.kryptonThemeComboBox1.IntegralHeight = false;
            this.kryptonThemeComboBox1.Location = new System.Drawing.Point(104, 10);
            this.kryptonThemeComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            this.kryptonThemeComboBox1.Size = new System.Drawing.Size(677, 24);
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonThemeComboBox1.TabIndex = 10;
            this.kryptonThemeComboBox1.ValueMember = "Value";
            // 
            // pbVertical
            // 
            this.pbVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbVertical.Location = new System.Drawing.Point(10, 10);
            this.pbVertical.Margin = new System.Windows.Forms.Padding(2);
            this.pbVertical.Name = "pbVertical";
            this.pbVertical.Orientation = Krypton.Toolkit.VisualOrientation.Left;
            this.pbVertical.Size = new System.Drawing.Size(24, 376);
            this.pbVertical.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbVertical.TabIndex = 9;
            this.pbVertical.Text = "75%";
            this.pbVertical.TextBackdropColor = System.Drawing.Color.Empty;
            this.pbVertical.TextShadowColor = System.Drawing.Color.Empty;
            this.pbVertical.UseValueAsText = true;
            this.pbVertical.Value = 75;
            this.pbVertical.Values.Text = "75%";
            // 
            // pbCustomColor
            // 
            this.pbCustomColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCustomColor.Location = new System.Drawing.Point(43, 165);
            this.pbCustomColor.Name = "pbCustomColor";
            this.pbCustomColor.Size = new System.Drawing.Size(738, 23);
            this.pbCustomColor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbCustomColor.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pbCustomColor.StateCommon.Border.Rounding = 10F;
            this.pbCustomColor.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pbCustomColor.TabIndex = 8;
            this.pbCustomColor.Text = "75%";
            this.pbCustomColor.TextBackdropColor = System.Drawing.Color.Empty;
            this.pbCustomColor.TextShadowColor = System.Drawing.Color.Empty;
            this.pbCustomColor.UseValueAsText = true;
            this.pbCustomColor.Value = 75;
            this.pbCustomColor.Values.ExtraText = " (Custom Color)";
            this.pbCustomColor.Values.Text = "75%";
            // 
            // pbHorizontal2
            // 
            this.pbHorizontal2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHorizontal2.Location = new System.Drawing.Point(43, 130);
            this.pbHorizontal2.Name = "pbHorizontal2";
            this.pbHorizontal2.Size = new System.Drawing.Size(738, 23);
            this.pbHorizontal2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pbHorizontal2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbHorizontal2.TabIndex = 7;
            this.pbHorizontal2.Text = "75%";
            this.pbHorizontal2.TextBackdropColor = System.Drawing.Color.Empty;
            this.pbHorizontal2.TextShadowColor = System.Drawing.Color.Empty;
            this.pbHorizontal2.UseValueAsText = true;
            this.pbHorizontal2.Value = 75;
            this.pbHorizontal2.Values.Text = "75%";
            // 
            // pbHorizontal
            // 
            this.pbHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHorizontal.Location = new System.Drawing.Point(43, 79);
            this.pbHorizontal.Name = "pbHorizontal";
            this.pbHorizontal.Size = new System.Drawing.Size(738, 45);
            this.pbHorizontal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbHorizontal.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            this.pbHorizontal.TabIndex = 4;
            this.pbHorizontal.Text = "75%";
            this.pbHorizontal.TextBackdropColor = System.Drawing.Color.Empty;
            this.pbHorizontal.TextShadowColor = System.Drawing.Color.Empty;
            this.pbHorizontal.UseValueAsText = true;
            this.pbHorizontal.Value = 75;
            this.pbHorizontal.Values.ExtraText = "of 100";
            this.pbHorizontal.Values.Text = "75%";
            // 
            // knudHorizontal
            // 
            this.knudHorizontal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.knudHorizontal.Location = new System.Drawing.Point(104, 41);
            this.knudHorizontal.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knudHorizontal.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudHorizontal.Name = "knudHorizontal";
            this.knudHorizontal.Size = new System.Drawing.Size(71, 24);
            this.knudHorizontal.TabIndex = 3;
            this.knudHorizontal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knudHorizontal.ValueChanged += new System.EventHandler(this.knudHorizontal_ValueChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(43, 43);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 21);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Value:";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.BaseFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonManager1.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
            this.kryptonManager1.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kryptonProgressBarToolStripItem1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(799, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // kryptonProgressBarToolStripItem1
            // 
            this.kryptonProgressBarToolStripItem1.Name = "kryptonProgressBarToolStripItem1";
            this.kryptonProgressBarToolStripItem1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonProgressBarToolStripItem1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBarToolStripItem1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBarToolStripItem1.Text = "0%";
            this.kryptonProgressBarToolStripItem1.UseValueAsText = true;
            this.kryptonProgressBarToolStripItem1.Values.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton ProgressBar Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbProgressBarStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbColorStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonProgressBar pbHorizontal2;
        private Krypton.Toolkit.KryptonProgressBar pbHorizontal;
        private Krypton.Toolkit.KryptonNumericUpDown knudHorizontal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonProgressBar pbCustomColor;
        private Krypton.Toolkit.KryptonProgressBar pbVertical;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonProgressBar ProgressBarDisabled;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Krypton.Toolkit.KryptonProgressBarToolStripItem kryptonProgressBarToolStripItem1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTrackBar ktrkProgressValues;
        private Krypton.Toolkit.KryptonCheckBox kchkShowTextShadow;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonColorButton kcbtnProgressBarColour;
        private Krypton.Toolkit.KryptonComboBox kcmbProgressBarStyle;
        private Krypton.Toolkit.KryptonLabel klblColorStyle;
        private Krypton.Toolkit.KryptonComboBox kcmbColorStyle;
        private Krypton.Toolkit.KryptonCheckBox kchkShowTextBackdrop;
        private Krypton.Toolkit.KryptonColorButton kcbtnBackdropColor;
        private Krypton.Toolkit.KryptonCheckBox kchkUseProgressValueAsText;
    }
}

