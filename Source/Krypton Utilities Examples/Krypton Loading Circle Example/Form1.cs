#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonLoadingCircleExample;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        cmbPreset.Items.AddRange(new object[] { "Custom", "MacOSX", "Firefox", "IE7" });
        cmbPreset.SelectedIndex = 1;
        ApplyPreset();
        spinner.Active = true;
        chkActive.Checked = true;
        UpdateStatus();
    }

    private void chkActive_CheckedChanged(object? sender, EventArgs e)
    {
        spinner.Active = chkActive.Checked;
        UpdateStatus();
    }

    private void chkEnabled_CheckedChanged(object? sender, EventArgs e)
    {
        spinner.Enabled = chkEnabled.Checked;
        UpdateStatus();
    }

    private void chkUsePalette_CheckedChanged(object? sender, EventArgs e)
    {
        ApplyColorMode();
        UpdateStatus();
    }

    private void cmbPreset_SelectedIndexChanged(object? sender, EventArgs e)
    {
        ApplyPreset();
        UpdateStatus();
    }

    private void btnOverrideRed_Click(object? sender, EventArgs e)
    {
        chkUsePalette.Checked = false;
        spinner.Color = Color.Firebrick;
        UpdateStatus();
    }

    private void btnResetColor_Click(object? sender, EventArgs e)
    {
        chkUsePalette.Checked = true;
        ApplyColorMode();
        UpdateStatus();
    }

    private void kcmbTheme_SelectedIndexChanged(object? sender, EventArgs e) => UpdateStatus();

    private void ApplyPreset()
    {
        spinner.StylePreset = cmbPreset.SelectedItem?.ToString() switch
        {
            "MacOSX" => StylePresets.MacOSX,
            "Firefox" => StylePresets.Firefox,
            "IE7" => StylePresets.IE7,
            _ => StylePresets.Custom
        };
    }

    private void ApplyColorMode()
    {
        spinner.Color = chkUsePalette.Checked ? Color.Empty : Color.SteelBlue;
    }

    private void UpdateStatus()
    {
        string colorMode = spinner.Color.IsEmpty
            ? "palette (Color.Empty)"
            : $"override {ColorTranslator.ToHtml(spinner.Color)}";
        kwlblStatus.Text =
            $"Active={spinner.Active}, Enabled={spinner.Enabled}, Preset={spinner.StylePreset}, Colour={colorMode}. " +
            "Change Theme to confirm spokes follow the palette when Colour is Empty.";
    }
}
