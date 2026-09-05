// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV) & Giduac 2026 - 2026. All rights reserved.
// *****************************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonRatingExamples;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        PopulateCombo(kcmbPrecision, typeof(KryptonRatingPrecision), kratingMain.Precision);
        PopulateCombo(kcmbGlyph, typeof(KryptonRatingGlyph), kratingMain.RatingValues.Glyph);
        PopulateCombo(kcmbOrientation, typeof(Orientation), kratingMain.Orientation);

        knudMaximum.Value = kratingMain.Maximum;
        kchkReadOnly.Checked = kratingMain.ReadOnly;
        kchkAllowClear.Checked = kratingMain.AllowClear;
        kchkRtl.Checked = kratingMain.RightToLeft == RightToLeft.Yes;

        kratingDisabled.Value = 3m;
        kratingHeart.Precision = KryptonRatingPrecision.Half;
        kratingHeart.RatingValues.Glyph = KryptonRatingGlyph.Heart;
        kratingHeart.Value = 3.5m;
        kratingCircle.RatingValues.Glyph = KryptonRatingGlyph.Circle;
        kratingCircle.Value = 4m;
        kratingExact.Precision = KryptonRatingPrecision.Exact;
        kratingExact.Value = 2.75m;
        kratingImage.RatingValues.Glyph = KryptonRatingGlyph.Image;
        kratingImage.Value = 4m;
        kratingMax3.Maximum = 3;
        kratingMax3.Value = 2m;
        kratingMax10.Maximum = 10;
        kratingMax10.Value = 7m;
        kratingVertical.Orientation = Orientation.Vertical;
        kratingVertical.Value = 3m;
        kpgMain.SelectedObject = kratingMain;
        UpdateReadout();
    }

    private static void PopulateCombo(KryptonComboBox combo, Type enumType, object selected)
    {
        combo.Items.Clear();
        foreach (object value in Enum.GetValues(enumType))
        {
            combo.Items.Add(value);
        }

        combo.SelectedItem = selected;
    }

    private void UpdateReadout()
    {
        klblValue.Values.Text = kratingMain.IsHovering
            ? $@"Value {kratingMain.Value}  Hover {kratingMain.HoverValue}  / {kratingMain.Maximum}"
            : $@"Value {kratingMain.Value} / {kratingMain.Maximum}";
    }

    private void kratingMain_ValueChanged(object? sender, EventArgs e) => UpdateReadout();

    private void kratingMain_MouseMove(object? sender, MouseEventArgs e) => UpdateReadout();

    private void kratingMain_MouseLeave(object? sender, EventArgs e) => UpdateReadout();

    private void kcmbPrecision_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (kcmbPrecision.SelectedItem is KryptonRatingPrecision precision)
        {
            kratingMain.Precision = precision;
        }
    }

    private void kcmbGlyph_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (kcmbGlyph.SelectedItem is KryptonRatingGlyph glyph)
        {
            kratingMain.RatingValues.Glyph = glyph;
        }
    }

    private void kcmbOrientation_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (kcmbOrientation.SelectedItem is Orientation orientation)
        {
            kratingMain.Orientation = orientation;
        }
    }

    private void knudMaximum_ValueChanged(object? sender, EventArgs e)
    {
        kratingMain.Maximum = (int)knudMaximum.Value;
        UpdateReadout();
    }

    private void kchkReadOnly_CheckedChanged(object? sender, EventArgs e) =>
        kratingMain.ReadOnly = kchkReadOnly.Checked;

    private void kchkAllowClear_CheckedChanged(object? sender, EventArgs e) =>
        kratingMain.AllowClear = kchkAllowClear.Checked;

    private void kchkRtl_CheckedChanged(object? sender, EventArgs e) =>
        kratingMain.RightToLeft = kchkRtl.Checked ? RightToLeft.Yes : RightToLeft.No;

    private void kbtnFillGold_Click(object? sender, EventArgs e)
    {
        kratingMain.ResetStateCommon();
        kratingMain.ResetStateNormal();
        kratingMain.ResetStateTracking();
        kratingMain.ResetStateDisabled();
    }

    private void kbtnFillBlue_Click(object? sender, EventArgs e)
    {
        kratingMain.StateNormal.Fill = Color.DodgerBlue;
        kratingMain.StateTracking.Fill = Color.SkyBlue;
        kratingMain.StateCommon.Empty = Color.LightSteelBlue;
    }

    private void kbtnClose_Click(object? sender, EventArgs e) => Close();
}
