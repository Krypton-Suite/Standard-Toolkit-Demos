namespace KryptonLoadingCircleExample;

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
        this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
        this.kwlblInfo = new Krypton.Toolkit.KryptonWrapLabel();
        this.kcmbTheme = new Krypton.Toolkit.KryptonThemeComboBox();
        this.spinner = new Krypton.Toolkit.Utilities.KryptonLoadingCircle();
        this.chkActive = new Krypton.Toolkit.KryptonCheckBox();
        this.chkEnabled = new Krypton.Toolkit.KryptonCheckBox();
        this.chkUsePalette = new Krypton.Toolkit.KryptonCheckBox();
        this.klblPreset = new Krypton.Toolkit.KryptonLabel();
        this.cmbPreset = new Krypton.Toolkit.KryptonComboBox();
        this.btnOverrideRed = new Krypton.Toolkit.KryptonButton();
        this.btnResetColor = new Krypton.Toolkit.KryptonButton();
        this.kwlblStatus = new Krypton.Toolkit.KryptonWrapLabel();
        ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
        this.kryptonPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.cmbPreset)).BeginInit();
        this.SuspendLayout();
        //
        // kryptonPanel1
        //
        this.kryptonPanel1.Controls.Add(this.kwlblInfo);
        this.kryptonPanel1.Controls.Add(this.kcmbTheme);
        this.kryptonPanel1.Controls.Add(this.spinner);
        this.kryptonPanel1.Controls.Add(this.chkActive);
        this.kryptonPanel1.Controls.Add(this.chkEnabled);
        this.kryptonPanel1.Controls.Add(this.chkUsePalette);
        this.kryptonPanel1.Controls.Add(this.klblPreset);
        this.kryptonPanel1.Controls.Add(this.cmbPreset);
        this.kryptonPanel1.Controls.Add(this.btnOverrideRed);
        this.kryptonPanel1.Controls.Add(this.btnResetColor);
        this.kryptonPanel1.Controls.Add(this.kwlblStatus);
        this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
        this.kryptonPanel1.Name = "kryptonPanel1";
        this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(16);
        this.kryptonPanel1.Size = new System.Drawing.Size(640, 320);
        this.kryptonPanel1.TabIndex = 0;
        //
        // kwlblInfo
        //
        this.kwlblInfo.Location = new System.Drawing.Point(19, 19);
        this.kwlblInfo.Name = "kwlblInfo";
        this.kwlblInfo.Size = new System.Drawing.Size(600, 48);
        this.kwlblInfo.Text = "KryptonLoadingCircle: toolbox spinner. With Color = Empty (default), spokes use the active palette and update on theme change. Uncheck Use palette colour or click Override red for an explicit colour.";
        //
        // kcmbTheme
        //
        this.kcmbTheme.DefaultPalette = Krypton.Toolkit.PaletteMode.Global;
        this.kcmbTheme.DropDownWidth = 240;
        this.kcmbTheme.IntegralHeight = false;
        this.kcmbTheme.Location = new System.Drawing.Point(19, 76);
        this.kcmbTheme.Name = "kcmbTheme";
        this.kcmbTheme.Size = new System.Drawing.Size(240, 22);
        this.kcmbTheme.TabIndex = 1;
        this.kcmbTheme.SelectedIndexChanged += new System.EventHandler(this.kcmbTheme_SelectedIndexChanged);
        //
        // spinner
        //
        this.spinner.Location = new System.Drawing.Point(19, 110);
        this.spinner.Name = "spinner";
        this.spinner.Size = new System.Drawing.Size(72, 72);
        this.spinner.TabIndex = 2;
        //
        // chkActive
        //
        this.chkActive.Location = new System.Drawing.Point(110, 110);
        this.chkActive.Name = "chkActive";
        this.chkActive.Size = new System.Drawing.Size(62, 20);
        this.chkActive.TabIndex = 3;
        this.chkActive.Values.Text = "Active";
        this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
        //
        // chkEnabled
        //
        this.chkEnabled.Checked = true;
        this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkEnabled.Location = new System.Drawing.Point(110, 136);
        this.chkEnabled.Name = "chkEnabled";
        this.chkEnabled.Size = new System.Drawing.Size(70, 20);
        this.chkEnabled.TabIndex = 4;
        this.chkEnabled.Values.Text = "Enabled";
        this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
        //
        // chkUsePalette
        //
        this.chkUsePalette.Checked = true;
        this.chkUsePalette.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkUsePalette.Location = new System.Drawing.Point(110, 162);
        this.chkUsePalette.Name = "chkUsePalette";
        this.chkUsePalette.Size = new System.Drawing.Size(136, 20);
        this.chkUsePalette.TabIndex = 5;
        this.chkUsePalette.Values.Text = "Use palette colour";
        this.chkUsePalette.CheckedChanged += new System.EventHandler(this.chkUsePalette_CheckedChanged);
        //
        // klblPreset
        //
        this.klblPreset.Location = new System.Drawing.Point(280, 110);
        this.klblPreset.Name = "klblPreset";
        this.klblPreset.Size = new System.Drawing.Size(46, 20);
        this.klblPreset.TabIndex = 6;
        this.klblPreset.Values.Text = "Preset:";
        //
        // cmbPreset
        //
        this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbPreset.DropDownWidth = 120;
        this.cmbPreset.IntegralHeight = false;
        this.cmbPreset.Location = new System.Drawing.Point(332, 110);
        this.cmbPreset.Name = "cmbPreset";
        this.cmbPreset.Size = new System.Drawing.Size(120, 21);
        this.cmbPreset.TabIndex = 7;
        this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
        //
        // btnOverrideRed
        //
        this.btnOverrideRed.Location = new System.Drawing.Point(280, 148);
        this.btnOverrideRed.Name = "btnOverrideRed";
        this.btnOverrideRed.Size = new System.Drawing.Size(100, 28);
        this.btnOverrideRed.TabIndex = 8;
        this.btnOverrideRed.Values.Text = "Override red";
        this.btnOverrideRed.Click += new System.EventHandler(this.btnOverrideRed_Click);
        //
        // btnResetColor
        //
        this.btnResetColor.Location = new System.Drawing.Point(386, 148);
        this.btnResetColor.Name = "btnResetColor";
        this.btnResetColor.Size = new System.Drawing.Size(120, 28);
        this.btnResetColor.TabIndex = 9;
        this.btnResetColor.Values.Text = "Reset to palette";
        this.btnResetColor.Click += new System.EventHandler(this.btnResetColor_Click);
        //
        // kwlblStatus
        //
        this.kwlblStatus.Location = new System.Drawing.Point(19, 220);
        this.kwlblStatus.Name = "kwlblStatus";
        this.kwlblStatus.Size = new System.Drawing.Size(600, 48);
        this.kwlblStatus.Text = "Ready.";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(640, 320);
        this.Controls.Add(this.kryptonPanel1);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Krypton Loading Circle Example";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
        this.kryptonPanel1.ResumeLayout(false);
        this.kryptonPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.cmbPreset)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    private Krypton.Toolkit.KryptonWrapLabel kwlblInfo;
    private Krypton.Toolkit.KryptonThemeComboBox kcmbTheme;
    private Krypton.Toolkit.Utilities.KryptonLoadingCircle spinner;
    private Krypton.Toolkit.KryptonCheckBox chkActive;
    private Krypton.Toolkit.KryptonCheckBox chkEnabled;
    private Krypton.Toolkit.KryptonCheckBox chkUsePalette;
    private Krypton.Toolkit.KryptonLabel klblPreset;
    private Krypton.Toolkit.KryptonComboBox cmbPreset;
    private Krypton.Toolkit.KryptonButton btnOverrideRed;
    private Krypton.Toolkit.KryptonButton btnResetColor;
    private Krypton.Toolkit.KryptonWrapLabel kwlblStatus;
}
