// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
// By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2023 - 2025. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace KryptonProgressBarExamples
{
    public partial class Form1 : KryptonForm
    {
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
        }

        private void kcbtnProgressBarColour_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            pbCustomColor.StateCommon.Back.Color1 = e.Color;
        }
    }
}
