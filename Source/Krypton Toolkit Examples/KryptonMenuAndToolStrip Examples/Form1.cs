using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonMenuAndToolStripExamples;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
        Text = "Krypton MenuStrip + ToolStrip (#1100 scheme strip text)";
        kryptonThemeComboBox1.SelectedIndexChanged += (_, _) => RefreshReadout();
        kcbtnMenuStrip.SelectedColorChanged += (_, e) => Apply(SchemeBaseColors.MenuStripText, e.Color);
        kcbtnToolStrip.SelectedColorChanged += (_, e) => Apply(SchemeBaseColors.ToolStripText, e.Color);
        kcbtnStatusStrip.SelectedColorChanged += (_, e) => Apply(SchemeBaseColors.StatusStripText, e.Color);
        kcbtnMenuItem.SelectedColorChanged += (_, e) => Apply(SchemeBaseColors.MenuItemText, e.Color);
        kbtnContrast.Click += (_, _) =>
        {
            Apply(SchemeBaseColors.MenuStripText, Color.Firebrick);
            Apply(SchemeBaseColors.ToolStripText, Color.MediumBlue);
            Apply(SchemeBaseColors.StatusStripText, Color.DarkGreen);
            Apply(SchemeBaseColors.MenuItemText, Color.DarkOrange);
            kcbtnMenuStrip.SelectedColor = Color.Firebrick;
            kcbtnToolStrip.SelectedColor = Color.MediumBlue;
            kcbtnStatusStrip.SelectedColor = Color.DarkGreen;
            kcbtnMenuItem.SelectedColor = Color.DarkOrange;
        };
        kbtnReset.Click += (_, _) =>
        {
            Apply(SchemeBaseColors.MenuStripText, Color.Empty);
            Apply(SchemeBaseColors.ToolStripText, Color.Empty);
            Apply(SchemeBaseColors.StatusStripText, Color.Empty);
            Apply(SchemeBaseColors.MenuItemText, Color.Empty);
            kcbtnMenuStrip.SelectedColor = Color.Empty;
            kcbtnToolStrip.SelectedColor = Color.Empty;
            kcbtnStatusStrip.SelectedColor = Color.Empty;
            kcbtnMenuItem.SelectedColor = Color.Empty;
        };
        RefreshReadout();
    }

    private void RefreshReadout()
    {
        var palette = KryptonManager.CurrentGlobalPalette;
        var table = palette?.ColorTable;
        klblReadout.Values.Text =
            "Issue #1100: MenuStripText, ToolStripText, StatusStripText, and MenuItemText are independent. " +
            "Empty slots keep the historic ColorTable alias." + Environment.NewLine +
            $"Slots: Menu={Fmt(palette, SchemeBaseColors.MenuStripText)}  Tool={Fmt(palette, SchemeBaseColors.ToolStripText)}  " +
            $"Status={Fmt(palette, SchemeBaseColors.StatusStripText)}  Item={Fmt(palette, SchemeBaseColors.MenuItemText)}" +
            Environment.NewLine +
            $"ColorTable: Menu={Fmt(table?.MenuStripText)}  Tool={Fmt(table?.ToolStripText)}  " +
            $"Status={Fmt(table?.StatusStripText)}  Item={Fmt(table?.MenuItemText)}";
    }

    private static string Fmt(PaletteBase? palette, SchemeBaseColors role)
    {
        if (palette is null)
        {
            return "(none)";
        }

        try
        {
            return Fmt(palette.GetSchemeColor(role));
        }
        catch (IndexOutOfRangeException)
        {
            return "(n/a)";
        }
    }

    private static string Fmt(Color? color)
    {
        if (color is null || color.Value.IsEmpty)
        {
            return "(default)";
        }

        var value = color.Value;
        return $"#{value.R:X2}{value.G:X2}{value.B:X2}";
    }

    private void Apply(SchemeBaseColors role, Color color)
    {
        var palette = KryptonManager.CurrentGlobalPalette;
        if (palette is null)
        {
            return;
        }

        try
        {
            palette.SetSchemeColor(role, color.IsEmpty || color.A == 0
                ? Color.Empty
                : color);
        }
        catch (IndexOutOfRangeException)
        {
            // Professional palettes may not expose the full scheme array.
        }

        RefreshReadout();
        Invalidate(true);
    }
}
