#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV), Giduac, tobitege, Lesandro, KamaniAR, et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Windows.Forms;

using Krypton.Gauges;
using Krypton.Toolkit;

namespace KryptonEqualizerExamples;

/// <summary>
/// Consumer demo for <see cref="KryptonEqualizer"/> (#4660).
/// </summary>
public partial class Form1 : KryptonForm
{
    private readonly Timer _simTimer = new Timer { Interval = 40 };
    private readonly Random _random = new Random(4660);

    public Form1()
    {
        InitializeComponent();
        _simTimer.Tick += OnSimulateTick;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Seed(keqBars);
        Seed(keqSegments);
        keqSegments.Values.Style = EqualizerStyle.Segments;
        keqBars.Values.PeakHold = true;
        keqSegments.Values.PeakHold = true;
        kchkSimulate.Checked = true;
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        _simTimer.Stop();
        _simTimer.Dispose();
    }

    private void kchkSimulate_CheckedChanged(object sender, EventArgs e)
    {
        if (kchkSimulate.Checked)
        {
            kchkCapture.Checked = false;
            _simTimer.Start();
        }
        else
        {
            _simTimer.Stop();
        }
    }

    private void kchkCapture_CheckedChanged(object sender, EventArgs e)
    {
        if (kchkCapture.Checked)
        {
            kchkSimulate.Checked = false;
            _simTimer.Stop();
        }

        EqualizerInputMode mode = kchkCapture.Checked ? EqualizerInputMode.Capture : EqualizerInputMode.Manual;
        keqBars.Values.InputMode = mode;
        keqSegments.Values.InputMode = mode;
    }

    private void kchkPeak_CheckedChanged(object sender, EventArgs e)
    {
        keqBars.Values.PeakHold = kchkPeak.Checked;
        keqSegments.Values.PeakHold = kchkPeak.Checked;
    }

    private void kbtnResetGains_Click(object sender, EventArgs e)
    {
        foreach (EqualizerBand band in keqBars.Values.Bands)
        {
            band.Gain = 0d;
        }

        foreach (EqualizerBand band in keqSegments.Values.Bands)
        {
            band.Gain = 0d;
        }
    }

    private void keqBars_CaptureFailed(object sender, EqualizerCaptureFailedEventArgs e)
    {
        kchkCapture.Checked = false;
        klblStatus.Text = "Capture failed: " + e.Message;
    }

    private void OnSimulateTick(object sender, EventArgs e)
    {
        double[] levels = new double[keqBars.Values.BandCount];
        double t = Environment.TickCount / 220d;
        for (int i = 0; i < levels.Length; i++)
        {
            levels[i] = Math.Min(1d, 0.3d + (0.5d * Math.Abs(Math.Sin(t + (i * 0.55d)))) + (0.08d * _random.NextDouble()));
        }

        keqBars.SetLevels(levels);
        keqSegments.SetLevels(levels);
        klblStatus.Text = "Simulating spectrum. Drag thumbs to change gain (capture would update levels only).";
    }

    private static void Seed(KryptonEqualizer equalizer)
    {
        double[] levels = new double[equalizer.Values.BandCount];
        for (int i = 0; i < levels.Length; i++)
        {
            levels[i] = 0.2d + (0.5d * (i / (double)Math.Max(1, levels.Length - 1)));
        }

        equalizer.SetLevels(levels);
    }
}
