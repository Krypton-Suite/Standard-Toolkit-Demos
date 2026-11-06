#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV), Giduac, tobitege, Lesandro, KamaniAR, et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

namespace KryptonEqualizerExamples;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.klblInstructions = new Krypton.Toolkit.KryptonLabel();
        this.keqBars = new Krypton.Gauges.KryptonEqualizer();
        this.keqSegments = new Krypton.Gauges.KryptonEqualizer();
        this.kchkSimulate = new Krypton.Toolkit.KryptonCheckBox();
        this.kchkCapture = new Krypton.Toolkit.KryptonCheckBox();
        this.kchkPeak = new Krypton.Toolkit.KryptonCheckBox();
        this.kbtnResetGains = new Krypton.Toolkit.KryptonButton();
        this.klblStatus = new Krypton.Toolkit.KryptonLabel();
        this.ktheme = new Krypton.Toolkit.KryptonThemeComboBox();
        this.SuspendLayout();
        //
        // klblInstructions
        //
        this.klblInstructions.Location = new System.Drawing.Point(12, 12);
        this.klblInstructions.Name = "klblInstructions";
        this.klblInstructions.Size = new System.Drawing.Size(760, 40);
        this.klblInstructions.TabIndex = 0;
        this.klblInstructions.Values.Text = "KryptonEqualizer (#4660): multi-band spectrum with interactive gain thumbs. Simulate levels or Capture the microphone (FFT). Capture updates levels only.";
        //
        // keqBars
        //
        this.keqBars.Location = new System.Drawing.Point(12, 60);
        this.keqBars.Name = "keqBars";
        this.keqBars.Size = new System.Drawing.Size(480, 200);
        this.keqBars.TabIndex = 1;
        this.keqBars.CaptureFailed += new System.EventHandler<Krypton.Gauges.EqualizerCaptureFailedEventArgs>(this.keqBars_CaptureFailed);
        //
        // keqSegments
        //
        this.keqSegments.Location = new System.Drawing.Point(510, 60);
        this.keqSegments.Name = "keqSegments";
        this.keqSegments.Size = new System.Drawing.Size(260, 200);
        this.keqSegments.TabIndex = 2;
        this.keqSegments.Values.Style = Krypton.Gauges.EqualizerStyle.Segments;
        //
        // kchkSimulate
        //
        this.kchkSimulate.Location = new System.Drawing.Point(12, 280);
        this.kchkSimulate.Name = "kchkSimulate";
        this.kchkSimulate.Size = new System.Drawing.Size(90, 20);
        this.kchkSimulate.TabIndex = 3;
        this.kchkSimulate.Values.Text = "Simulate";
        this.kchkSimulate.CheckedChanged += new System.EventHandler(this.kchkSimulate_CheckedChanged);
        //
        // kchkCapture
        //
        this.kchkCapture.Location = new System.Drawing.Point(120, 280);
        this.kchkCapture.Name = "kchkCapture";
        this.kchkCapture.Size = new System.Drawing.Size(80, 20);
        this.kchkCapture.TabIndex = 4;
        this.kchkCapture.Values.Text = "Capture";
        this.kchkCapture.CheckedChanged += new System.EventHandler(this.kchkCapture_CheckedChanged);
        //
        // kchkPeak
        //
        this.kchkPeak.Checked = true;
        this.kchkPeak.CheckState = System.Windows.Forms.CheckState.Checked;
        this.kchkPeak.Location = new System.Drawing.Point(220, 280);
        this.kchkPeak.Name = "kchkPeak";
        this.kchkPeak.Size = new System.Drawing.Size(90, 20);
        this.kchkPeak.TabIndex = 5;
        this.kchkPeak.Values.Text = "Peak hold";
        this.kchkPeak.CheckedChanged += new System.EventHandler(this.kchkPeak_CheckedChanged);
        //
        // kbtnResetGains
        //
        this.kbtnResetGains.Location = new System.Drawing.Point(330, 276);
        this.kbtnResetGains.Name = "kbtnResetGains";
        this.kbtnResetGains.Size = new System.Drawing.Size(110, 28);
        this.kbtnResetGains.TabIndex = 6;
        this.kbtnResetGains.Values.Text = "Reset gains";
        this.kbtnResetGains.Click += new System.EventHandler(this.kbtnResetGains_Click);
        //
        // ktheme
        //
        this.ktheme.DropDownWidth = 220;
        this.ktheme.Location = new System.Drawing.Point(460, 278);
        this.ktheme.Name = "ktheme";
        this.ktheme.Size = new System.Drawing.Size(220, 22);
        this.ktheme.TabIndex = 7;
        //
        // klblStatus
        //
        this.klblStatus.Location = new System.Drawing.Point(12, 318);
        this.klblStatus.Name = "klblStatus";
        this.klblStatus.Size = new System.Drawing.Size(760, 20);
        this.klblStatus.TabIndex = 8;
        this.klblStatus.Values.Text = "Ready";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(792, 360);
        this.Controls.Add(this.klblStatus);
        this.Controls.Add(this.ktheme);
        this.Controls.Add(this.kbtnResetGains);
        this.Controls.Add(this.kchkPeak);
        this.Controls.Add(this.kchkCapture);
        this.Controls.Add(this.kchkSimulate);
        this.Controls.Add(this.keqSegments);
        this.Controls.Add(this.keqBars);
        this.Controls.Add(this.klblInstructions);
        this.Name = "Form1";
        this.Text = "Krypton Equalizer Examples";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Krypton.Toolkit.KryptonLabel klblInstructions;
    private Krypton.Gauges.KryptonEqualizer keqBars;
    private Krypton.Gauges.KryptonEqualizer keqSegments;
    private Krypton.Toolkit.KryptonCheckBox kchkSimulate;
    private Krypton.Toolkit.KryptonCheckBox kchkCapture;
    private Krypton.Toolkit.KryptonCheckBox kchkPeak;
    private Krypton.Toolkit.KryptonButton kbtnResetGains;
    private Krypton.Toolkit.KryptonLabel klblStatus;
    private Krypton.Toolkit.KryptonThemeComboBox ktheme;
}
