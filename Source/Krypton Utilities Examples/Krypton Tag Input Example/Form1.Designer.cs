namespace KryptonTagInputExample;

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
        this.ktiTags = new Krypton.Toolkit.Utilities.KryptonTagInputControl();
        this.chkReadOnly = new Krypton.Toolkit.KryptonCheckBox();
        this.chkAllowDuplicates = new Krypton.Toolkit.KryptonCheckBox();
        this.kbtnAddUrgent = new Krypton.Toolkit.KryptonButton();
        this.kbtnClear = new Krypton.Toolkit.KryptonButton();
        this.kwlblStatus = new Krypton.Toolkit.KryptonWrapLabel();
        ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
        this.kryptonPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.ktiTags)).BeginInit();
        this.SuspendLayout();
        // 
        // kryptonPanel1
        // 
        this.kryptonPanel1.Controls.Add(this.kwlblInfo);
        this.kryptonPanel1.Controls.Add(this.kcmbTheme);
        this.kryptonPanel1.Controls.Add(this.ktiTags);
        this.kryptonPanel1.Controls.Add(this.chkReadOnly);
        this.kryptonPanel1.Controls.Add(this.chkAllowDuplicates);
        this.kryptonPanel1.Controls.Add(this.kbtnAddUrgent);
        this.kryptonPanel1.Controls.Add(this.kbtnClear);
        this.kryptonPanel1.Controls.Add(this.kwlblStatus);
        this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
        this.kryptonPanel1.Name = "kryptonPanel1";
        this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(16);
        this.kryptonPanel1.Size = new System.Drawing.Size(720, 360);
        this.kryptonPanel1.TabIndex = 0;
        // 
        // kwlblInfo
        // 
        this.kwlblInfo.Location = new System.Drawing.Point(19, 19);
        this.kwlblInfo.Name = "kwlblInfo";
        this.kwlblInfo.Size = new System.Drawing.Size(680, 48);
        this.kwlblInfo.Text = "KryptonTagInputControl: type a tag and press Enter or comma. Backspace removes the last chip when the input is empty. Suggestions include Bug, Feature, and Security with category colours. The sample cancels the tag 'reject'.";
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
        // 
        // ktiTags
        // 
        this.ktiTags.Location = new System.Drawing.Point(19, 110);
        this.ktiTags.Name = "ktiTags";
        this.ktiTags.Size = new System.Drawing.Size(680, 80);
        this.ktiTags.TabIndex = 2;
        this.ktiTags.TagAdding += new System.EventHandler<Krypton.Toolkit.Utilities.KryptonTagCancelEventArgs>(this.ktiTags_TagAdding);
        this.ktiTags.TagAdded += new System.EventHandler<Krypton.Toolkit.Utilities.KryptonTagEventArgs>(this.ktiTags_TagAdded);
        this.ktiTags.TagRemoved += new System.EventHandler<Krypton.Toolkit.Utilities.KryptonTagEventArgs>(this.ktiTags_TagRemoved);
        // 
        // chkReadOnly
        // 
        this.chkReadOnly.Location = new System.Drawing.Point(19, 204);
        this.chkReadOnly.Name = "chkReadOnly";
        this.chkReadOnly.Size = new System.Drawing.Size(90, 20);
        this.chkReadOnly.TabIndex = 3;
        this.chkReadOnly.Values.Text = "Read only";
        this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
        // 
        // chkAllowDuplicates
        // 
        this.chkAllowDuplicates.Location = new System.Drawing.Point(130, 204);
        this.chkAllowDuplicates.Name = "chkAllowDuplicates";
        this.chkAllowDuplicates.Size = new System.Drawing.Size(130, 20);
        this.chkAllowDuplicates.TabIndex = 4;
        this.chkAllowDuplicates.Values.Text = "Allow duplicates";
        this.chkAllowDuplicates.CheckedChanged += new System.EventHandler(this.chkAllowDuplicates_CheckedChanged);
        // 
        // kbtnAddUrgent
        // 
        this.kbtnAddUrgent.Location = new System.Drawing.Point(280, 200);
        this.kbtnAddUrgent.Name = "kbtnAddUrgent";
        this.kbtnAddUrgent.Size = new System.Drawing.Size(100, 28);
        this.kbtnAddUrgent.TabIndex = 5;
        this.kbtnAddUrgent.Values.Text = "Add Urgent";
        this.kbtnAddUrgent.Click += new System.EventHandler(this.kbtnAddUrgent_Click);
        // 
        // kbtnClear
        // 
        this.kbtnClear.Location = new System.Drawing.Point(386, 200);
        this.kbtnClear.Name = "kbtnClear";
        this.kbtnClear.Size = new System.Drawing.Size(75, 28);
        this.kbtnClear.TabIndex = 6;
        this.kbtnClear.Values.Text = "Clear";
        this.kbtnClear.Click += new System.EventHandler(this.kbtnClear_Click);
        // 
        // kwlblStatus
        // 
        this.kwlblStatus.Location = new System.Drawing.Point(19, 248);
        this.kwlblStatus.Name = "kwlblStatus";
        this.kwlblStatus.Size = new System.Drawing.Size(680, 40);
        this.kwlblStatus.Text = "No tags.";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(720, 360);
        this.Controls.Add(this.kryptonPanel1);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Krypton Tag Input Example";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
        this.kryptonPanel1.ResumeLayout(false);
        this.kryptonPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.kcmbTheme)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.ktiTags)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Krypton.Toolkit.KryptonPanel kryptonPanel1;
    private Krypton.Toolkit.KryptonWrapLabel kwlblInfo;
    private Krypton.Toolkit.KryptonThemeComboBox kcmbTheme;
    private Krypton.Toolkit.Utilities.KryptonTagInputControl ktiTags;
    private Krypton.Toolkit.KryptonCheckBox chkReadOnly;
    private Krypton.Toolkit.KryptonCheckBox chkAllowDuplicates;
    private Krypton.Toolkit.KryptonButton kbtnAddUrgent;
    private Krypton.Toolkit.KryptonButton kbtnClear;
    private Krypton.Toolkit.KryptonWrapLabel kwlblStatus;
}
