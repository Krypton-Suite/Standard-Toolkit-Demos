// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV) & Giduac 2026 - 2026. All rights reserved.
// *****************************************************************************

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using Krypton.Gauges;
using Krypton.Toolkit;

using KryptonAnalogueGaugeExamples.Properties;

namespace KryptonAnalogueGaugeExamples;

/// <summary>
/// Consumer demo for circular, linear, and rectangular analogue gauges (#4656).
/// </summary>
public partial class Form1 : KryptonForm
{
    private bool _sync;

    public Form1()
    {
        InitializeComponent();
        using (var ms = new System.IO.MemoryStream(Resources.Krypton))
        {
            Icon = new Icon(ms);
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Configure(kcgMain.CircularValues, "Speed", "mph");
        Configure(klgMain.LinearValues, "Fuel", "%");
        Configure(krgMain.RectangularValues, "Temp", "C");
        krgSegments.RectangularValues.Style = RectangularGaugeStyle.Segmented;
        Configure(krgSegments.RectangularValues, "Segs", string.Empty);
        krgSegments.RectangularValues.ShowValueText = false;

        kcgInteractive.CircularValues.Caption = "Drag me";
        kcgInteractive.CircularValues.InputMode = GaugeInputMode.Interactive;
        kcgInteractive.Value = 35d;

        kcgMain.Value = 55d;
        klgMain.Value = 55d;
        krgMain.Value = 55d;
        krgSegments.Value = 55d;
        ktrkValue.Value = 55;
        UpdateLabel(55d);
    }

    private static void Configure(GaugeValues values, string caption, string units)
    {
        values.Minimum = 0d;
        values.Maximum = 100d;
        values.Caption = caption;
        values.Units = units;
        values.Ranges.Clear();
        values.Ranges.Add(new GaugeRange(70d, 85d, GaugeRangeSeverity.Warning));
        values.Ranges.Add(new GaugeRange(85d, 100d, GaugeRangeSeverity.Error));
    }

    private void ktrkValue_ValueChanged(object sender, EventArgs e)
    {
        if (_sync)
        {
            return;
        }

        _sync = true;
        double value = ktrkValue.Value;
        kcgMain.Value = value;
        klgMain.Value = value;
        krgMain.Value = value;
        krgSegments.Value = value;
        UpdateLabel(value);
        _sync = false;
    }

    private void kcgInteractive_ValueChanged(object sender, GaugeValueChangedEventArgs e)
    {
        if (_sync)
        {
            return;
        }

        _sync = true;
        int rounded = (int)Math.Round(e.NewValue);
        ktrkValue.Value = Math.Max(ktrkValue.Minimum, Math.Min(ktrkValue.Maximum, rounded));
        UpdateLabel(e.NewValue);
        _sync = false;
    }

    private void kchkInteractive_CheckedChanged(object sender, EventArgs e)
    {
        GaugeInputMode mode = kchkInteractive.Checked ? GaugeInputMode.Interactive : GaugeInputMode.Manual;
        kcgMain.Values.InputMode = mode;
        klgMain.Values.InputMode = mode;
        krgMain.Values.InputMode = mode;
        krgSegments.Values.InputMode = mode;
        kcgInteractive.Values.InputMode = GaugeInputMode.Interactive;
    }

    private void UpdateLabel(double value) =>
        klblValue.Text = "Value: " + value.ToString("0.##", CultureInfo.CurrentCulture);
}
