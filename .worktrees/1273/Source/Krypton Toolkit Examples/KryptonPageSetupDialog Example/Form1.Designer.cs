
namespace KryptonFontDialog_Example_2019
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPalette = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            this.buttonShowFontDialog = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.chkShowEffects = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowApply = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowVectorFonts = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowSimulations = new Krypton.Toolkit.KryptonCheckBox();
            this.chkAllowScriptChange = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowColour = new Krypton.Toolkit.KryptonCheckBox();
            this.chkShowHelp = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette.Panel)).BeginInit();
            this.groupBoxPalette.Panel.SuspendLayout();
            this.groupBoxPalette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPalette
            // 
            this.groupBoxPalette.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPalette.Name = "groupBoxPalette";
            // 
            // groupBoxPalette.Panel
            // 
            this.groupBoxPalette.Panel.Controls.Add(this.kryptonThemeComboBox1);
            this.groupBoxPalette.Size = new System.Drawing.Size(353, 135);
            this.groupBoxPalette.TabIndex = 18;
            this.groupBoxPalette.Values.Heading = "Palette";
            // 
            // kryptonThemeComboBox1
            // 
            this.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            this.kryptonThemeComboBox1.DisplayMember = "Key";
            this.kryptonThemeComboBox1.DropDownWidth = 293;
            this.kryptonThemeComboBox1.IntegralHeight = false;
            this.kryptonThemeComboBox1.Location = new System.Drawing.Point(15, 16);
            this.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            this.kryptonThemeComboBox1.Size = new System.Drawing.Size(320, 26);
            this.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonThemeComboBox1.TabIndex = 17;
            this.kryptonThemeComboBox1.ValueMember = "Value";
            // 
            // buttonShowFontDialog
            // 
            this.buttonShowFontDialog.Location = new System.Drawing.Point(264, 323);
            this.buttonShowFontDialog.Name = "buttonShowFontDialog";
            this.buttonShowFontDialog.Size = new System.Drawing.Size(307, 59);
            this.buttonShowFontDialog.TabIndex = 19;
            this.buttonShowFontDialog.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.buttonShowFontDialog.Values.Text = "Show FontDialog";
            this.buttonShowFontDialog.Click += new System.EventHandler(this.ButtonShowFontDialog_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Controls.Add(this.groupBoxPalette);
            this.kryptonPanel1.Controls.Add(this.buttonShowFontDialog);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(614, 412);
            this.kryptonPanel1.TabIndex = 20;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(372, 28);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowEffects);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowApply);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowVectorFonts);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowSimulations);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkAllowScriptChange);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowColour);
            this.kryptonGroupBox2.Panel.Controls.Add(this.chkShowHelp);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(199, 289);
            this.kryptonGroupBox2.TabIndex = 21;
            this.kryptonGroupBox2.Values.Heading = "Options:";
            // 
            // chkShowEffects
            // 
            this.chkShowEffects.Checked = true;
            this.chkShowEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowEffects.Location = new System.Drawing.Point(4, 180);
            this.chkShowEffects.Name = "chkShowEffects";
            this.chkShowEffects.Size = new System.Drawing.Size(110, 24);
            this.chkShowEffects.TabIndex = 6;
            this.chkShowEffects.Values.Text = "Show Effects";
            // 
            // chkShowApply
            // 
            this.chkShowApply.Location = new System.Drawing.Point(4, 150);
            this.chkShowApply.Name = "chkShowApply";
            this.chkShowApply.Size = new System.Drawing.Size(105, 24);
            this.chkShowApply.TabIndex = 5;
            this.chkShowApply.Values.Text = "Show Apply";
            // 
            // chkAllowVectorFonts
            // 
            this.chkAllowVectorFonts.Location = new System.Drawing.Point(4, 120);
            this.chkAllowVectorFonts.Name = "chkAllowVectorFonts";
            this.chkAllowVectorFonts.Size = new System.Drawing.Size(152, 24);
            this.chkAllowVectorFonts.TabIndex = 4;
            this.chkAllowVectorFonts.Values.Text = "Allow Vector Fonts";
            // 
            // chkAllowSimulations
            // 
            this.chkAllowSimulations.Location = new System.Drawing.Point(4, 90);
            this.chkAllowSimulations.Name = "chkAllowSimulations";
            this.chkAllowSimulations.Size = new System.Drawing.Size(145, 24);
            this.chkAllowSimulations.TabIndex = 3;
            this.chkAllowSimulations.Values.Text = "Allow Simulations";
            // 
            // chkAllowScriptChange
            // 
            this.chkAllowScriptChange.Location = new System.Drawing.Point(3, 60);
            this.chkAllowScriptChange.Name = "chkAllowScriptChange";
            this.chkAllowScriptChange.Size = new System.Drawing.Size(161, 24);
            this.chkAllowScriptChange.TabIndex = 2;
            this.chkAllowScriptChange.Values.Text = "Allow Script Change";
            // 
            // chkShowColour
            // 
            this.chkShowColour.Checked = true;
            this.chkShowColour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowColour.Location = new System.Drawing.Point(4, 30);
            this.chkShowColour.Name = "chkShowColour";
            this.chkShowColour.Size = new System.Drawing.Size(111, 24);
            this.chkShowColour.TabIndex = 1;
            this.chkShowColour.Values.Text = "Show Colour";
            // 
            // chkShowHelp
            // 
            this.chkShowHelp.Location = new System.Drawing.Point(4, 0);
            this.chkShowHelp.Name = "chkShowHelp";
            this.chkShowHelp.Size = new System.Drawing.Size(98, 24);
            this.chkShowHelp.TabIndex = 0;
            this.chkShowHelp.Values.Text = "Show Help";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 153);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonNumericUpDown1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonCheckBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonListBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonComboBox1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(348, 164);
            this.kryptonGroupBox1.TabIndex = 20;
            this.kryptonGroupBox1.Values.Heading = "Style to match:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(156, 29);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(134, 27);
            this.kryptonTextBox1.TabIndex = 6;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(156, 97);
            this.kryptonNumericUpDown1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(90, 26);
            this.kryptonNumericUpDown1.TabIndex = 5;
            this.kryptonNumericUpDown1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(156, 65);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 4;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(156, 4);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(152, 24);
            this.kryptonCheckBox1.TabIndex = 2;
            this.kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonListBox1
            // 
            this.kryptonListBox1.Items.AddRange(new object[] {
            "Font 1",
            "Font 2",
            "Font 1Font 1Font 1Font 1"});
            this.kryptonListBox1.Location = new System.Drawing.Point(4, 29);
            this.kryptonListBox1.Name = "kryptonListBox1";
            this.kryptonListBox1.Size = new System.Drawing.Size(120, 96);
            this.kryptonListBox1.TabIndex = 1;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 121;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Microsoft Sans Serif"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(4, 4);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(146, 26);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 0;
            this.kryptonComboBox1.Text = "Microsoft Sans Serif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 412);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form1";
            this.Text = "KryptonFontDialog Example";
            this.UseThemeFormChromeBorderWidth = false;
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette.Panel)).EndInit();
            this.groupBoxPalette.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxPalette)).EndInit();
            this.groupBoxPalette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonThemeComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox groupBoxPalette;
        private Krypton.Toolkit.KryptonButton buttonShowFontDialog;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonCheckBox chkShowHelp;
        private Krypton.Toolkit.KryptonCheckBox chkShowColour;
        private Krypton.Toolkit.KryptonCheckBox chkShowEffects;
        private Krypton.Toolkit.KryptonCheckBox chkShowApply;
        private Krypton.Toolkit.KryptonCheckBox chkAllowVectorFonts;
        private Krypton.Toolkit.KryptonCheckBox chkAllowSimulations;
        private Krypton.Toolkit.KryptonCheckBox chkAllowScriptChange;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
    }
}

