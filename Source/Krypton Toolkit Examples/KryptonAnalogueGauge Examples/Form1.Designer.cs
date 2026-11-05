// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV) & Giduac 2026 - 2026. All rights reserved.
// *****************************************************************************

namespace KryptonAnalogueGaugeExamples;

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
        this.kpnlRoot = new Krypton.Toolkit.KryptonPanel();
        this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
        this.klblInstructions = new Krypton.Toolkit.KryptonLabel();
        this.flpGauges = new System.Windows.Forms.FlowLayoutPanel();
        this.kcgMain = new Krypton.Gauges.KryptonCircularGauge();
        this.klgMain = new Krypton.Gauges.KryptonLinearGauge();
        this.krgMain = new Krypton.Gauges.KryptonRectangularGauge();
        this.krgSegments = new Krypton.Gauges.KryptonRectangularGauge();
        this.kcgInteractive = new Krypton.Gauges.KryptonCircularGauge();
        this.kpnlControls = new Krypton.Toolkit.KryptonPanel();
        this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
        this.klblValue = new Krypton.Toolkit.KryptonLabel();
        this.ktrkValue = new Krypton.Toolkit.KryptonTrackBar();
        this.kchkInteractive = new Krypton.Toolkit.KryptonCheckBox();
        ((System.ComponentModel.ISupportInitialize)(this.kpnlRoot)).BeginInit();
        this.kpnlRoot.SuspendLayout();
        this.tlpMain.SuspendLayout();
        this.flpGauges.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).BeginInit();
        this.kpnlControls.SuspendLayout();
        this.tlpControls.SuspendLayout();
        this.SuspendLayout();
        //
        // kpnlRoot
        //
        this.kpnlRoot.Controls.Add(this.tlpMain);
        this.kpnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
        this.kpnlRoot.Location = new System.Drawing.Point(0, 0);
        this.kpnlRoot.Name = "kpnlRoot";
        this.kpnlRoot.Size = new System.Drawing.Size(760, 480);
        this.kpnlRoot.TabIndex = 0;
        //
        // tlpMain
        //
        this.tlpMain.ColumnCount = 1;
        this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpMain.Controls.Add(this.klblInstructions, 0, 0);
        this.tlpMain.Controls.Add(this.flpGauges, 0, 1);
        this.tlpMain.Controls.Add(this.kpnlControls, 0, 2);
        this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpMain.Location = new System.Drawing.Point(0, 0);
        this.tlpMain.Name = "tlpMain";
        this.tlpMain.Padding = new System.Windows.Forms.Padding(8);
        this.tlpMain.RowCount = 3;
        this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
        this.tlpMain.Size = new System.Drawing.Size(760, 480);
        this.tlpMain.TabIndex = 0;
        //
        // klblInstructions
        //
        this.klblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
        this.klblInstructions.Location = new System.Drawing.Point(11, 11);
        this.klblInstructions.Name = "klblInstructions";
        this.klblInstructions.Size = new System.Drawing.Size(738, 34);
        this.klblInstructions.TabIndex = 0;
        this.klblInstructions.Values.Text = "Analogue gauges (#4656): circular, linear, rectangular (solid / segmented). Drag the trackbar or the interactive dial.";
        //
        // flpGauges
        //
        this.flpGauges.Controls.Add(this.kcgMain);
        this.flpGauges.Controls.Add(this.klgMain);
        this.flpGauges.Controls.Add(this.krgMain);
        this.flpGauges.Controls.Add(this.krgSegments);
        this.flpGauges.Controls.Add(this.kcgInteractive);
        this.flpGauges.Dock = System.Windows.Forms.DockStyle.Fill;
        this.flpGauges.Location = new System.Drawing.Point(11, 51);
        this.flpGauges.Name = "flpGauges";
        this.flpGauges.Padding = new System.Windows.Forms.Padding(4);
        this.flpGauges.Size = new System.Drawing.Size(738, 346);
        this.flpGauges.TabIndex = 1;
        //
        // kcgMain
        //
        this.kcgMain.Location = new System.Drawing.Point(7, 7);
        this.kcgMain.Name = "kcgMain";
        this.kcgMain.Size = new System.Drawing.Size(170, 170);
        this.kcgMain.TabIndex = 0;
        //
        // klgMain
        //
        this.klgMain.Location = new System.Drawing.Point(183, 7);
        this.klgMain.Name = "klgMain";
        this.klgMain.Size = new System.Drawing.Size(220, 56);
        this.klgMain.TabIndex = 1;
        //
        // krgMain
        //
        this.krgMain.Location = new System.Drawing.Point(409, 7);
        this.krgMain.Name = "krgMain";
        this.krgMain.Size = new System.Drawing.Size(150, 50);
        this.krgMain.TabIndex = 2;
        //
        // krgSegments
        //
        this.krgSegments.Location = new System.Drawing.Point(565, 7);
        this.krgSegments.Name = "krgSegments";
        this.krgSegments.Size = new System.Drawing.Size(160, 44);
        this.krgSegments.TabIndex = 3;
        //
        // kcgInteractive
        //
        this.kcgInteractive.Location = new System.Drawing.Point(7, 183);
        this.kcgInteractive.Name = "kcgInteractive";
        this.kcgInteractive.Size = new System.Drawing.Size(150, 150);
        this.kcgInteractive.TabIndex = 4;
        this.kcgInteractive.ValueChanged += new System.EventHandler<Krypton.Gauges.GaugeValueChangedEventArgs>(this.kcgInteractive_ValueChanged);
        //
        // kpnlControls
        //
        this.kpnlControls.Controls.Add(this.tlpControls);
        this.kpnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
        this.kpnlControls.Location = new System.Drawing.Point(11, 403);
        this.kpnlControls.Name = "kpnlControls";
        this.kpnlControls.Size = new System.Drawing.Size(738, 66);
        this.kpnlControls.TabIndex = 2;
        //
        // tlpControls
        //
        this.tlpControls.ColumnCount = 3;
        this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
        this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
        this.tlpControls.Controls.Add(this.klblValue, 0, 0);
        this.tlpControls.Controls.Add(this.ktrkValue, 1, 0);
        this.tlpControls.Controls.Add(this.kchkInteractive, 2, 0);
        this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpControls.Location = new System.Drawing.Point(0, 0);
        this.tlpControls.Name = "tlpControls";
        this.tlpControls.Padding = new System.Windows.Forms.Padding(4);
        this.tlpControls.RowCount = 1;
        this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpControls.Size = new System.Drawing.Size(738, 66);
        this.tlpControls.TabIndex = 0;
        //
        // klblValue
        //
        this.klblValue.Dock = System.Windows.Forms.DockStyle.Fill;
        this.klblValue.Location = new System.Drawing.Point(7, 7);
        this.klblValue.Name = "klblValue";
        this.klblValue.Size = new System.Drawing.Size(84, 52);
        this.klblValue.TabIndex = 0;
        this.klblValue.Values.Text = "Value: 0";
        //
        // ktrkValue
        //
        this.ktrkValue.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ktrkValue.Location = new System.Drawing.Point(97, 7);
        this.ktrkValue.Maximum = 100;
        this.ktrkValue.Name = "ktrkValue";
        this.ktrkValue.Size = new System.Drawing.Size(494, 52);
        this.ktrkValue.TabIndex = 1;
        this.ktrkValue.ValueChanged += new System.EventHandler(this.ktrkValue_ValueChanged);
        //
        // kchkInteractive
        //
        this.kchkInteractive.Dock = System.Windows.Forms.DockStyle.Fill;
        this.kchkInteractive.Location = new System.Drawing.Point(597, 7);
        this.kchkInteractive.Name = "kchkInteractive";
        this.kchkInteractive.Size = new System.Drawing.Size(134, 52);
        this.kchkInteractive.TabIndex = 2;
        this.kchkInteractive.Values.Text = "Interactive all";
        this.kchkInteractive.CheckedChanged += new System.EventHandler(this.kchkInteractive_CheckedChanged);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(760, 480);
        this.Controls.Add(this.kpnlRoot);
        this.Name = "Form1";
        this.Text = "Krypton Analogue Gauge Examples";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.kpnlRoot)).EndInit();
        this.kpnlRoot.ResumeLayout(false);
        this.tlpMain.ResumeLayout(false);
        this.tlpMain.PerformLayout();
        this.flpGauges.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).EndInit();
        this.kpnlControls.ResumeLayout(false);
        this.tlpControls.ResumeLayout(false);
        this.tlpControls.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private Krypton.Toolkit.KryptonPanel kpnlRoot;
    private System.Windows.Forms.TableLayoutPanel tlpMain;
    private Krypton.Toolkit.KryptonLabel klblInstructions;
    private System.Windows.Forms.FlowLayoutPanel flpGauges;
    private Krypton.Gauges.KryptonCircularGauge kcgMain;
    private Krypton.Gauges.KryptonLinearGauge klgMain;
    private Krypton.Gauges.KryptonRectangularGauge krgMain;
    private Krypton.Gauges.KryptonRectangularGauge krgSegments;
    private Krypton.Gauges.KryptonCircularGauge kcgInteractive;
    private Krypton.Toolkit.KryptonPanel kpnlControls;
    private System.Windows.Forms.TableLayoutPanel tlpControls;
    private Krypton.Toolkit.KryptonLabel klblValue;
    private Krypton.Toolkit.KryptonTrackBar ktrkValue;
    private Krypton.Toolkit.KryptonCheckBox kchkInteractive;
}
