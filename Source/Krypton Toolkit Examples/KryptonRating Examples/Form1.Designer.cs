// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV) & Giduac 2026 - 2026. All rights reserved.
// *****************************************************************************

namespace KryptonRatingExamples
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.kwlHeader = new Krypton.Toolkit.KryptonWrapLabel();
            this.kratingMain = new Krypton.Toolkit.KryptonRating();
            this.klblValue = new Krypton.Toolkit.KryptonLabel();
            this.klblPrecision = new Krypton.Toolkit.KryptonLabel();
            this.kcmbPrecision = new Krypton.Toolkit.KryptonComboBox();
            this.kchkReadOnly = new Krypton.Toolkit.KryptonCheckBox();
            this.kchkAllowClear = new Krypton.Toolkit.KryptonCheckBox();
            this.kchkRtl = new Krypton.Toolkit.KryptonCheckBox();
            this.klblGlyph = new Krypton.Toolkit.KryptonLabel();
            this.kcmbGlyph = new Krypton.Toolkit.KryptonComboBox();
            this.klblOrientation = new Krypton.Toolkit.KryptonLabel();
            this.kcmbOrientation = new Krypton.Toolkit.KryptonComboBox();
            this.klblMaximum = new Krypton.Toolkit.KryptonLabel();
            this.knudMaximum = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kcmbTheme = new Krypton.Toolkit.KryptonThemeComboBox();
            this.kbtnFillGold = new Krypton.Toolkit.KryptonButton();
            this.kbtnFillBlue = new Krypton.Toolkit.KryptonButton();
            this.klblDisabled = new Krypton.Toolkit.KryptonLabel();
            this.kratingDisabled = new Krypton.Toolkit.KryptonRating();
            this.klblHeart = new Krypton.Toolkit.KryptonLabel();
            this.kratingHeart = new Krypton.Toolkit.KryptonRating();
            this.klblCircle = new Krypton.Toolkit.KryptonLabel();
            this.kratingCircle = new Krypton.Toolkit.KryptonRating();
            this.klblExact = new Krypton.Toolkit.KryptonLabel();
            this.kratingExact = new Krypton.Toolkit.KryptonRating();
            this.klblImage = new Krypton.Toolkit.KryptonLabel();
            this.kratingImage = new Krypton.Toolkit.KryptonRating();
            this.klblMax3 = new Krypton.Toolkit.KryptonLabel();
            this.kratingMax3 = new Krypton.Toolkit.KryptonRating();
            this.klblMax10 = new Krypton.Toolkit.KryptonLabel();
            this.kratingMax10 = new Krypton.Toolkit.KryptonRating();
            this.klblVertical = new Krypton.Toolkit.KryptonLabel();
            this.kratingVertical = new Krypton.Toolkit.KryptonRating();
            this.kpgMain = new Krypton.Toolkit.KryptonPropertyGrid();
            this.kbtnClose = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbGlyph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbOrientation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).BeginInit();
            this.SuspendLayout();
            //
            // kwlHeader
            //
            this.kwlHeader.Location = new System.Drawing.Point(12, 9);
            this.kwlHeader.Name = "kwlHeader";
            this.kwlHeader.Size = new System.Drawing.Size(500, 60);
            this.kwlHeader.TabIndex = 0;
            this.kwlHeader.Text = "KryptonRating (#3928). Hover for a preview, click to set the value, and switch Pre" +
    "cision between Full, Half, and Exact. Use arrow keys, Home/End, and digits 1–9 when focused.";
            //
            // kratingMain
            //
            this.kratingMain.Location = new System.Drawing.Point(16, 76);
            this.kratingMain.Name = "kratingMain";
            this.kratingMain.Size = new System.Drawing.Size(124, 24);
            this.kratingMain.TabIndex = 1;
            this.kratingMain.Value = new decimal(new int[] { 3, 0, 0, 0 });
            this.kratingMain.ValueChanged += new System.EventHandler(this.kratingMain_ValueChanged);
            this.kratingMain.MouseLeave += new System.EventHandler(this.kratingMain_MouseLeave);
            this.kratingMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kratingMain_MouseMove);
            //
            // klblValue
            //
            this.klblValue.Location = new System.Drawing.Point(16, 110);
            this.klblValue.Name = "klblValue";
            this.klblValue.Size = new System.Drawing.Size(400, 20);
            this.klblValue.TabIndex = 2;
            this.klblValue.Values.Text = "Value 3 / 5";
            //
            // klblPrecision
            //
            this.klblPrecision.Location = new System.Drawing.Point(16, 144);
            this.klblPrecision.Name = "klblPrecision";
            this.klblPrecision.Size = new System.Drawing.Size(66, 20);
            this.klblPrecision.TabIndex = 3;
            this.klblPrecision.Values.Text = "Precision";
            //
            // kcmbPrecision
            //
            this.kcmbPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbPrecision.Location = new System.Drawing.Point(88, 142);
            this.kcmbPrecision.Name = "kcmbPrecision";
            this.kcmbPrecision.Size = new System.Drawing.Size(120, 21);
            this.kcmbPrecision.TabIndex = 4;
            this.kcmbPrecision.SelectedIndexChanged += new System.EventHandler(this.kcmbPrecision_SelectedIndexChanged);
            //
            // kchkReadOnly
            //
            this.kchkReadOnly.Location = new System.Drawing.Point(220, 144);
            this.kchkReadOnly.Name = "kchkReadOnly";
            this.kchkReadOnly.Size = new System.Drawing.Size(82, 20);
            this.kchkReadOnly.TabIndex = 5;
            this.kchkReadOnly.Values.Text = "ReadOnly";
            this.kchkReadOnly.CheckedChanged += new System.EventHandler(this.kchkReadOnly_CheckedChanged);
            //
            // kchkAllowClear
            //
            this.kchkAllowClear.Checked = true;
            this.kchkAllowClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kchkAllowClear.Location = new System.Drawing.Point(308, 144);
            this.kchkAllowClear.Name = "kchkAllowClear";
            this.kchkAllowClear.Size = new System.Drawing.Size(88, 20);
            this.kchkAllowClear.TabIndex = 6;
            this.kchkAllowClear.Values.Text = "AllowClear";
            this.kchkAllowClear.CheckedChanged += new System.EventHandler(this.kchkAllowClear_CheckedChanged);
            //
            // kchkRtl
            //
            this.kchkRtl.Location = new System.Drawing.Point(408, 144);
            this.kchkRtl.Name = "kchkRtl";
            this.kchkRtl.Size = new System.Drawing.Size(48, 20);
            this.kchkRtl.TabIndex = 7;
            this.kchkRtl.Values.Text = "RTL";
            this.kchkRtl.CheckedChanged += new System.EventHandler(this.kchkRtl_CheckedChanged);
            //
            // klblGlyph
            //
            this.klblGlyph.Location = new System.Drawing.Point(16, 176);
            this.klblGlyph.Name = "klblGlyph";
            this.klblGlyph.Size = new System.Drawing.Size(44, 20);
            this.klblGlyph.TabIndex = 8;
            this.klblGlyph.Values.Text = "Glyph";
            //
            // kcmbGlyph
            //
            this.kcmbGlyph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbGlyph.Location = new System.Drawing.Point(88, 174);
            this.kcmbGlyph.Name = "kcmbGlyph";
            this.kcmbGlyph.Size = new System.Drawing.Size(120, 21);
            this.kcmbGlyph.TabIndex = 9;
            this.kcmbGlyph.SelectedIndexChanged += new System.EventHandler(this.kcmbGlyph_SelectedIndexChanged);
            //
            // klblOrientation
            //
            this.klblOrientation.Location = new System.Drawing.Point(220, 176);
            this.klblOrientation.Name = "klblOrientation";
            this.klblOrientation.Size = new System.Drawing.Size(74, 20);
            this.klblOrientation.TabIndex = 10;
            this.klblOrientation.Values.Text = "Orientation";
            //
            // kcmbOrientation
            //
            this.kcmbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbOrientation.Location = new System.Drawing.Point(300, 174);
            this.kcmbOrientation.Name = "kcmbOrientation";
            this.kcmbOrientation.Size = new System.Drawing.Size(120, 21);
            this.kcmbOrientation.TabIndex = 11;
            this.kcmbOrientation.SelectedIndexChanged += new System.EventHandler(this.kcmbOrientation_SelectedIndexChanged);
            //
            // klblMaximum
            //
            this.klblMaximum.Location = new System.Drawing.Point(16, 208);
            this.klblMaximum.Name = "klblMaximum";
            this.klblMaximum.Size = new System.Drawing.Size(62, 20);
            this.klblMaximum.TabIndex = 12;
            this.klblMaximum.Values.Text = "Maximum";
            //
            // knudMaximum
            //
            this.knudMaximum.Location = new System.Drawing.Point(88, 206);
            this.knudMaximum.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            this.knudMaximum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.knudMaximum.Name = "knudMaximum";
            this.knudMaximum.Size = new System.Drawing.Size(60, 22);
            this.knudMaximum.TabIndex = 13;
            this.knudMaximum.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.knudMaximum.ValueChanged += new System.EventHandler(this.knudMaximum_ValueChanged);
            //
            // kcmbTheme
            //
            this.kcmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbTheme.Location = new System.Drawing.Point(160, 206);
            this.kcmbTheme.Name = "kcmbTheme";
            this.kcmbTheme.Size = new System.Drawing.Size(260, 21);
            this.kcmbTheme.TabIndex = 14;
            //
            // kbtnFillGold
            //
            this.kbtnFillGold.Location = new System.Drawing.Point(16, 240);
            this.kbtnFillGold.Name = "kbtnFillGold";
            this.kbtnFillGold.Size = new System.Drawing.Size(100, 25);
            this.kbtnFillGold.TabIndex = 15;
            this.kbtnFillGold.Values.Text = "Reset colours";
            this.kbtnFillGold.Click += new System.EventHandler(this.kbtnFillGold_Click);
            //
            // kbtnFillBlue
            //
            this.kbtnFillBlue.Location = new System.Drawing.Point(122, 240);
            this.kbtnFillBlue.Name = "kbtnFillBlue";
            this.kbtnFillBlue.Size = new System.Drawing.Size(100, 25);
            this.kbtnFillBlue.TabIndex = 16;
            this.kbtnFillBlue.Values.Text = "Blue override";
            this.kbtnFillBlue.Click += new System.EventHandler(this.kbtnFillBlue_Click);
            //
            // klblDisabled
            //
            this.klblDisabled.Location = new System.Drawing.Point(16, 280);
            this.klblDisabled.Name = "klblDisabled";
            this.klblDisabled.Size = new System.Drawing.Size(60, 20);
            this.klblDisabled.TabIndex = 17;
            this.klblDisabled.Values.Text = "Disabled";
            //
            // kratingDisabled
            //
            this.kratingDisabled.Enabled = false;
            this.kratingDisabled.Location = new System.Drawing.Point(16, 304);
            this.kratingDisabled.Name = "kratingDisabled";
            this.kratingDisabled.Size = new System.Drawing.Size(124, 24);
            this.kratingDisabled.TabIndex = 18;
            this.kratingDisabled.Value = new decimal(new int[] { 3, 0, 0, 0 });
            //
            // klblHeart
            //
            this.klblHeart.Location = new System.Drawing.Point(160, 280);
            this.klblHeart.Name = "klblHeart";
            this.klblHeart.Size = new System.Drawing.Size(90, 20);
            this.klblHeart.TabIndex = 19;
            this.klblHeart.Values.Text = "Heart (half)";
            //
            // kratingHeart
            //
            this.kratingHeart.Location = new System.Drawing.Point(160, 304);
            this.kratingHeart.Name = "kratingHeart";
            this.kratingHeart.Size = new System.Drawing.Size(124, 24);
            this.kratingHeart.TabIndex = 20;
            //
            // klblCircle
            //
            this.klblCircle.Location = new System.Drawing.Point(304, 280);
            this.klblCircle.Name = "klblCircle";
            this.klblCircle.Size = new System.Drawing.Size(44, 20);
            this.klblCircle.TabIndex = 21;
            this.klblCircle.Values.Text = "Circle";
            //
            // kratingCircle
            //
            this.kratingCircle.Location = new System.Drawing.Point(304, 304);
            this.kratingCircle.Name = "kratingCircle";
            this.kratingCircle.Size = new System.Drawing.Size(124, 24);
            this.kratingCircle.TabIndex = 22;
            //
            // klblExact
            //
            this.klblExact.Location = new System.Drawing.Point(16, 340);
            this.klblExact.Name = "klblExact";
            this.klblExact.Size = new System.Drawing.Size(90, 20);
            this.klblExact.TabIndex = 23;
            this.klblExact.Values.Text = "Exact 2.75";
            //
            // kratingExact
            //
            this.kratingExact.Location = new System.Drawing.Point(16, 364);
            this.kratingExact.Name = "kratingExact";
            this.kratingExact.Size = new System.Drawing.Size(124, 24);
            this.kratingExact.TabIndex = 24;
            //
            // klblImage
            //
            this.klblImage.Location = new System.Drawing.Point(160, 340);
            this.klblImage.Name = "klblImage";
            this.klblImage.Size = new System.Drawing.Size(90, 20);
            this.klblImage.TabIndex = 25;
            this.klblImage.Values.Text = "Image (stock)";
            //
            // kratingImage
            //
            this.kratingImage.Location = new System.Drawing.Point(160, 364);
            this.kratingImage.Name = "kratingImage";
            this.kratingImage.Size = new System.Drawing.Size(124, 24);
            this.kratingImage.TabIndex = 26;
            //
            // klblMax3
            //
            this.klblMax3.Location = new System.Drawing.Point(304, 340);
            this.klblMax3.Name = "klblMax3";
            this.klblMax3.Size = new System.Drawing.Size(70, 20);
            this.klblMax3.TabIndex = 27;
            this.klblMax3.Values.Text = "Maximum 3";
            //
            // kratingMax3
            //
            this.kratingMax3.Location = new System.Drawing.Point(304, 364);
            this.kratingMax3.Name = "kratingMax3";
            this.kratingMax3.Size = new System.Drawing.Size(76, 24);
            this.kratingMax3.TabIndex = 28;
            //
            // klblMax10
            //
            this.klblMax10.Location = new System.Drawing.Point(16, 400);
            this.klblMax10.Name = "klblMax10";
            this.klblMax10.Size = new System.Drawing.Size(80, 20);
            this.klblMax10.TabIndex = 29;
            this.klblMax10.Values.Text = "Maximum 10";
            //
            // kratingMax10
            //
            this.kratingMax10.Location = new System.Drawing.Point(16, 424);
            this.kratingMax10.Name = "kratingMax10";
            this.kratingMax10.Size = new System.Drawing.Size(244, 24);
            this.kratingMax10.TabIndex = 30;
            //
            // klblVertical
            //
            this.klblVertical.Location = new System.Drawing.Point(440, 280);
            this.klblVertical.Name = "klblVertical";
            this.klblVertical.Size = new System.Drawing.Size(52, 20);
            this.klblVertical.TabIndex = 31;
            this.klblVertical.Values.Text = "Vertical";
            //
            // kratingVertical
            //
            this.kratingVertical.Location = new System.Drawing.Point(448, 304);
            this.kratingVertical.Name = "kratingVertical";
            this.kratingVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kratingVertical.Size = new System.Drawing.Size(24, 124);
            this.kratingVertical.TabIndex = 32;
            //
            // kpgMain
            //
            this.kpgMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kpgMain.Location = new System.Drawing.Point(520, 12);
            this.kpgMain.Name = "kpgMain";
            this.kpgMain.Size = new System.Drawing.Size(348, 480);
            this.kpgMain.TabIndex = 33;
            //
            // kbtnClose
            //
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.Location = new System.Drawing.Point(793, 504);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(75, 25);
            this.kbtnClose.TabIndex = 34;
            this.kbtnClose.Values.Text = "Close";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.kbtnClose);
            this.Controls.Add(this.kpgMain);
            this.Controls.Add(this.kratingVertical);
            this.Controls.Add(this.klblVertical);
            this.Controls.Add(this.kratingMax10);
            this.Controls.Add(this.klblMax10);
            this.Controls.Add(this.kratingMax3);
            this.Controls.Add(this.klblMax3);
            this.Controls.Add(this.kratingImage);
            this.Controls.Add(this.klblImage);
            this.Controls.Add(this.kratingExact);
            this.Controls.Add(this.klblExact);
            this.Controls.Add(this.kratingCircle);
            this.Controls.Add(this.klblCircle);
            this.Controls.Add(this.kratingHeart);
            this.Controls.Add(this.klblHeart);
            this.Controls.Add(this.kratingDisabled);
            this.Controls.Add(this.klblDisabled);
            this.Controls.Add(this.kbtnFillBlue);
            this.Controls.Add(this.kbtnFillGold);
            this.Controls.Add(this.kcmbTheme);
            this.Controls.Add(this.knudMaximum);
            this.Controls.Add(this.klblMaximum);
            this.Controls.Add(this.kcmbOrientation);
            this.Controls.Add(this.klblOrientation);
            this.Controls.Add(this.kcmbGlyph);
            this.Controls.Add(this.klblGlyph);
            this.Controls.Add(this.kchkRtl);
            this.Controls.Add(this.kchkAllowClear);
            this.Controls.Add(this.kchkReadOnly);
            this.Controls.Add(this.kcmbPrecision);
            this.Controls.Add(this.klblPrecision);
            this.Controls.Add(this.klblValue);
            this.Controls.Add(this.kratingMain);
            this.Controls.Add(this.kwlHeader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KryptonRating Examples";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbGlyph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbOrientation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonWrapLabel kwlHeader;
        private Krypton.Toolkit.KryptonRating kratingMain;
        private Krypton.Toolkit.KryptonLabel klblValue;
        private Krypton.Toolkit.KryptonLabel klblPrecision;
        private Krypton.Toolkit.KryptonComboBox kcmbPrecision;
        private Krypton.Toolkit.KryptonCheckBox kchkReadOnly;
        private Krypton.Toolkit.KryptonCheckBox kchkAllowClear;
        private Krypton.Toolkit.KryptonCheckBox kchkRtl;
        private Krypton.Toolkit.KryptonLabel klblGlyph;
        private Krypton.Toolkit.KryptonComboBox kcmbGlyph;
        private Krypton.Toolkit.KryptonLabel klblOrientation;
        private Krypton.Toolkit.KryptonComboBox kcmbOrientation;
        private Krypton.Toolkit.KryptonLabel klblMaximum;
        private Krypton.Toolkit.KryptonNumericUpDown knudMaximum;
        private Krypton.Toolkit.KryptonThemeComboBox kcmbTheme;
        private Krypton.Toolkit.KryptonButton kbtnFillGold;
        private Krypton.Toolkit.KryptonButton kbtnFillBlue;
        private Krypton.Toolkit.KryptonLabel klblDisabled;
        private Krypton.Toolkit.KryptonRating kratingDisabled;
        private Krypton.Toolkit.KryptonLabel klblHeart;
        private Krypton.Toolkit.KryptonRating kratingHeart;
        private Krypton.Toolkit.KryptonLabel klblCircle;
        private Krypton.Toolkit.KryptonRating kratingCircle;
        private Krypton.Toolkit.KryptonLabel klblExact;
        private Krypton.Toolkit.KryptonRating kratingExact;
        private Krypton.Toolkit.KryptonLabel klblImage;
        private Krypton.Toolkit.KryptonRating kratingImage;
        private Krypton.Toolkit.KryptonLabel klblMax3;
        private Krypton.Toolkit.KryptonRating kratingMax3;
        private Krypton.Toolkit.KryptonLabel klblMax10;
        private Krypton.Toolkit.KryptonRating kratingMax10;
        private Krypton.Toolkit.KryptonLabel klblVertical;
        private Krypton.Toolkit.KryptonRating kratingVertical;
        private Krypton.Toolkit.KryptonPropertyGrid kpgMain;
        private Krypton.Toolkit.KryptonButton kbtnClose;
    }
}
