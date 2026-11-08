// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
// By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2023 - 2025. All rights reserved.
// *****************************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace KryptonProgressBarExamples;

public partial class Form1 : KryptonForm
{
    private KryptonProgressBar? _pbScheme;
    private KryptonLabel? _klblSchemeReadout;
    private KryptonButton? _kbtnSchemeContrast;
    private KryptonButton? _kbtnSchemeReset;

    public Form1() => InitializeComponent();

    private void kryptonButton1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        foreach (object? value in Enum.GetValues(typeof(ProgressBarStyle)))
        {
            kcmbProgressBarStyle.Items.Add(value);
        }

        kcmbProgressBarStyle.SelectedIndex = 1;

        foreach (object? value in Enum.GetValues(typeof(PaletteColorStyle)))
        {
            kcmbColorStyle.Items.Add(value);
        }

        kcmbColorStyle.SelectedItem = PaletteColorStyle.GlassNormalFull;

        ktrkProgressValues.Value = 75;
        AppendSchemeSlotUi();
        kryptonThemeComboBox1.SelectedIndexChanged += (_, _) => RefreshSchemeReadout();
    }

    private void AppendSchemeSlotUi()
    {
        ClientSize = new Size(Math.Max(ClientSize.Width, 799), Math.Max(ClientSize.Height, 520));

        var header = new KryptonLabel
        {
            Location = new Point(12, 430),
            Size = new Size(520, 20)
        };
        header.Values.Text = "Issue #4684 SchemeBaseColors.ProgressBarValue (theme fill; local Color1 overrides still win)";

        _pbScheme = new KryptonProgressBar
        {
            Location = new Point(12, 456),
            Size = new Size(360, 26),
            Value = ktrkProgressValues.Value,
            Maximum = ktrkProgressValues.Maximum,
            UseValueAsText = true
        };

        _klblSchemeReadout = new KryptonLabel
        {
            Location = new Point(380, 458),
            Size = new Size(200, 20)
        };

        _kbtnSchemeContrast = new KryptonButton
        {
            Location = new Point(590, 454),
            Size = new Size(90, 28)
        };
        _kbtnSchemeContrast.Values.Text = "Contrast";
        _kbtnSchemeContrast.Click += (_, _) =>
        {
            KryptonManager.CurrentGlobalPalette?.SetSchemeColor(SchemeBaseColors.ProgressBarValue, Color.MediumBlue);
            ResetBackColor1(_pbScheme!.StateCommon.Back);
            RefreshSchemeReadout();
        };

        _kbtnSchemeReset = new KryptonButton
        {
            Location = new Point(690, 454),
            Size = new Size(90, 28)
        };
        _kbtnSchemeReset.Values.Text = "Reset";
        _kbtnSchemeReset.Click += (_, _) =>
        {
            KryptonManager.CurrentGlobalPalette?.SetSchemeColor(SchemeBaseColors.ProgressBarValue, Color.Green);
            ResetBackColor1(_pbScheme!.StateCommon.Back);
            RefreshSchemeReadout();
        };

        kryptonPanel1.Controls.Add(header);
        kryptonPanel1.Controls.Add(_pbScheme);
        kryptonPanel1.Controls.Add(_klblSchemeReadout);
        kryptonPanel1.Controls.Add(_kbtnSchemeContrast);
        kryptonPanel1.Controls.Add(_kbtnSchemeReset);
        RefreshSchemeReadout();
    }

    private void RefreshSchemeReadout()
    {
        if (_klblSchemeReadout == null)
        {
            return;
        }

        var palette = KryptonManager.CurrentGlobalPalette;
        Color slot = palette?.GetSchemeColor(SchemeBaseColors.ProgressBarValue) ?? Color.Empty;
        Color fill = slot;
        if (slot.IsEmpty && palette != null)
        {
            fill = palette.GetSchemeColor(SchemeBaseColors.TrackBarFillTrack);
        }

        _klblSchemeReadout.Values.Text = slot.IsEmpty
            ? $"ProgressBarValue=Empty (fill={fill.R},{fill.G},{fill.B})"
            : $"ProgressBarValue={slot.R},{slot.G},{slot.B}";
    }

    private static void ResetBackColor1(PaletteBack back)
    {
        PropertyDescriptor? property = TypeDescriptor.GetProperties(back)[nameof(PaletteBack.Color1)];
        property?.ResetValue(back);
    }

    private void knudHorizontal_ValueChanged(object sender, EventArgs e)
    {
        ktrkProgressValues.Value = (int)knudHorizontal.Value;
        pbHorizontal.Value = ktrkProgressValues.Value;
        pbHorizontal2.Value = ktrkProgressValues.Value;
        pbCustomColor.Value = ktrkProgressValues.Value;
        pbVertical.Value = ktrkProgressValues.Value;
        ProgressBarDisabled.Value = ktrkProgressValues.Value;
        kryptonProgressBarToolStripItem1.Value = ktrkProgressValues.Value;
    }

    private void kchkUseProgressValueAsText_CheckedChanged(object sender, EventArgs e)
    {
        pbHorizontal.UseValueAsText = kchkUseProgressValueAsText.Checked;
        pbHorizontal2.UseValueAsText = kchkUseProgressValueAsText.Checked;
        pbCustomColor.UseValueAsText = kchkUseProgressValueAsText.Checked;
        pbVertical.UseValueAsText = kchkUseProgressValueAsText.Checked;
        ProgressBarDisabled.UseValueAsText = kchkUseProgressValueAsText.Checked;
        kryptonProgressBarToolStripItem1.UseValueAsText = kchkUseProgressValueAsText.Checked;
    }

    private void kcbtnBackdropColor_SelectedColorChanged(object sender, ColorEventArgs e)
    {
        pbHorizontal.TextBackdropColor = e.Color;
        pbHorizontal2.TextBackdropColor = e.Color;
        pbCustomColor.TextBackdropColor = e.Color;
        pbVertical.TextBackdropColor = e.Color;
        ProgressBarDisabled.TextBackdropColor = e.Color;
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.TextBackdropColor = e.Color;
    }

    private void kchkShowTextBackdrop_CheckedChanged(object sender, EventArgs e)
    {
        pbHorizontal.ShowTextBackdrop = kchkShowTextBackdrop.Checked;
        pbHorizontal2.ShowTextBackdrop = kchkShowTextBackdrop.Checked;
        pbCustomColor.ShowTextBackdrop = kchkShowTextBackdrop.Checked;
        pbVertical.ShowTextBackdrop = kchkShowTextBackdrop.Checked;
        ProgressBarDisabled.ShowTextBackdrop = kchkShowTextBackdrop.Checked;
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.ShowTextBackdrop = kchkShowTextBackdrop.Checked;
    }

    private void kcmbProgressBarStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        var newStyle = (ProgressBarStyle)Enum.Parse(typeof(ProgressBarStyle), kcmbProgressBarStyle.Text);
        pbHorizontal.Style = newStyle;
        pbHorizontal2.Style = newStyle;
        pbCustomColor.Style = newStyle;
        pbVertical.Style = newStyle;
        ProgressBarDisabled.Style = newStyle;
        kryptonProgressBarToolStripItem1.Style = newStyle;
    }

    private void kcmbColorStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        var newStyle = (PaletteColorStyle)Enum.Parse(typeof(PaletteColorStyle), kcmbColorStyle.Text);
        pbHorizontal.ValueBackColorStyle = newStyle;
        pbHorizontal2.ValueBackColorStyle = newStyle;
        pbCustomColor.ValueBackColorStyle = newStyle;
        pbVertical.ValueBackColorStyle = newStyle;
        ProgressBarDisabled.ValueBackColorStyle = newStyle;
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.ValueBackColorStyle = newStyle;
    }

    private void kchkShowTextShadow_CheckedChanged(object sender, EventArgs e)
    {
        pbHorizontal.ShowTextShadow = kchkShowTextShadow.Checked;
        pbHorizontal2.ShowTextShadow = kchkShowTextShadow.Checked;
        pbCustomColor.ShowTextShadow = kchkShowTextShadow.Checked;
        pbVertical.ShowTextShadow = kchkShowTextShadow.Checked;
        ProgressBarDisabled.ShowTextShadow = kchkShowTextShadow.Checked;
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.ShowTextShadow = kchkShowTextShadow.Checked;
    }

    private void ktrkProgressValues_ValueChanged(object sender, EventArgs e)
    {
        pbHorizontal.Value = ktrkProgressValues.Value;
        pbHorizontal2.Value = ktrkProgressValues.Value;
        pbCustomColor.Value = ktrkProgressValues.Value;
        knudHorizontal.Value = ktrkProgressValues.Value;
        pbVertical.Value = ktrkProgressValues.Value;
        ProgressBarDisabled.Value = ktrkProgressValues.Value;
        kryptonProgressBarToolStripItem1.Value = ktrkProgressValues.Value;
        if (_pbScheme != null)
        {
            _pbScheme.Value = ktrkProgressValues.Value;
        }
    }

    private void kcbtnProgressBarColour_SelectedColorChanged(object sender, ColorEventArgs e)
    {
        pbCustomColor.StateCommon.Back.Color1 = e.Color;
    }
}
