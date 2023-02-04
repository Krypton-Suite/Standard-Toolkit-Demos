
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonFileOpenDialog = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonThemeComboBox1 = new Krypton.Toolkit.KryptonThemeComboBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            chkShowEffects = new Krypton.Toolkit.KryptonCheckBox();
            chkShowApply = new Krypton.Toolkit.KryptonCheckBox();
            chkAllowVectorFonts = new Krypton.Toolkit.KryptonCheckBox();
            chkAllowSimulations = new Krypton.Toolkit.KryptonCheckBox();
            chkAllowScriptChange = new Krypton.Toolkit.KryptonCheckBox();
            chkShowColour = new Krypton.Toolkit.KryptonCheckBox();
            chkShowHelp = new Krypton.Toolkit.KryptonCheckBox();
            kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2.Panel).BeginInit();
            kryptonGroupBox2.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonFileOpenDialog
            // 
            buttonFileOpenDialog.Location = new System.Drawing.Point(264, 323);
            buttonFileOpenDialog.Name = "buttonFileOpenDialog";
            buttonFileOpenDialog.Size = new System.Drawing.Size(307, 59);
            buttonFileOpenDialog.TabIndex = 19;
            buttonFileOpenDialog.Values.Text = "File Open Dialog";
            buttonFileOpenDialog.Click += ButtonShowFontDialog_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonThemeComboBox1);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(kryptonGroupBox2);
            kryptonPanel1.Controls.Add(kryptonGroupBox1);
            kryptonPanel1.Controls.Add(buttonFileOpenDialog);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(594, 410);
            kryptonPanel1.TabIndex = 20;
            // 
            // kryptonThemeComboBox1
            // 
            kryptonThemeComboBox1.CornerRoundingRadius = -1F;
            kryptonThemeComboBox1.DisplayMember = "30";
            kryptonThemeComboBox1.DropDownWidth = 339;
            kryptonThemeComboBox1.IntegralHeight = false;
            kryptonThemeComboBox1.Location = new System.Drawing.Point(12, 58);
            kryptonThemeComboBox1.Name = "kryptonThemeComboBox1";
            kryptonThemeComboBox1.Size = new System.Drawing.Size(339, 25);
            kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonThemeComboBox1.TabIndex = 25;
            kryptonThemeComboBox1.ValueMember = "30";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            kryptonLabel1.Location = new System.Drawing.Point(12, 28);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new System.Drawing.Size(68, 24);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Target = kryptonThemeComboBox1;
            kryptonLabel1.Values.Text = "&Themes:";
            // 
            // kryptonGroupBox2
            // 
            kryptonGroupBox2.Location = new System.Drawing.Point(372, 28);
            kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // 
            // 
            kryptonGroupBox2.Panel.Controls.Add(chkShowEffects);
            kryptonGroupBox2.Panel.Controls.Add(chkShowApply);
            kryptonGroupBox2.Panel.Controls.Add(chkAllowVectorFonts);
            kryptonGroupBox2.Panel.Controls.Add(chkAllowSimulations);
            kryptonGroupBox2.Panel.Controls.Add(chkAllowScriptChange);
            kryptonGroupBox2.Panel.Controls.Add(chkShowColour);
            kryptonGroupBox2.Panel.Controls.Add(chkShowHelp);
            kryptonGroupBox2.Size = new System.Drawing.Size(199, 289);
            kryptonGroupBox2.TabIndex = 21;
            kryptonGroupBox2.Values.Heading = "Options:";
            // 
            // chkShowEffects
            // 
            chkShowEffects.Checked = true;
            chkShowEffects.CheckState = System.Windows.Forms.CheckState.Checked;
            chkShowEffects.Location = new System.Drawing.Point(4, 180);
            chkShowEffects.Name = "chkShowEffects";
            chkShowEffects.Size = new System.Drawing.Size(110, 24);
            chkShowEffects.TabIndex = 6;
            chkShowEffects.Values.Text = "Show Effects";
            // 
            // chkShowApply
            // 
            chkShowApply.Location = new System.Drawing.Point(4, 150);
            chkShowApply.Name = "chkShowApply";
            chkShowApply.Size = new System.Drawing.Size(105, 24);
            chkShowApply.TabIndex = 5;
            chkShowApply.Values.Text = "Show Apply";
            // 
            // chkAllowVectorFonts
            // 
            chkAllowVectorFonts.Location = new System.Drawing.Point(4, 120);
            chkAllowVectorFonts.Name = "chkAllowVectorFonts";
            chkAllowVectorFonts.Size = new System.Drawing.Size(152, 24);
            chkAllowVectorFonts.TabIndex = 4;
            chkAllowVectorFonts.Values.Text = "Allow Vector Fonts";
            // 
            // chkAllowSimulations
            // 
            chkAllowSimulations.Location = new System.Drawing.Point(4, 90);
            chkAllowSimulations.Name = "chkAllowSimulations";
            chkAllowSimulations.Size = new System.Drawing.Size(145, 24);
            chkAllowSimulations.TabIndex = 3;
            chkAllowSimulations.Values.Text = "Allow Simulations";
            // 
            // chkAllowScriptChange
            // 
            chkAllowScriptChange.Location = new System.Drawing.Point(3, 60);
            chkAllowScriptChange.Name = "chkAllowScriptChange";
            chkAllowScriptChange.Size = new System.Drawing.Size(161, 24);
            chkAllowScriptChange.TabIndex = 2;
            chkAllowScriptChange.Values.Text = "Allow Script Change";
            // 
            // chkShowColour
            // 
            chkShowColour.Checked = true;
            chkShowColour.CheckState = System.Windows.Forms.CheckState.Checked;
            chkShowColour.Location = new System.Drawing.Point(4, 30);
            chkShowColour.Name = "chkShowColour";
            chkShowColour.Size = new System.Drawing.Size(111, 24);
            chkShowColour.TabIndex = 1;
            chkShowColour.Values.Text = "Show Colour";
            // 
            // chkShowHelp
            // 
            chkShowHelp.Location = new System.Drawing.Point(4, 0);
            chkShowHelp.Name = "chkShowHelp";
            chkShowHelp.Size = new System.Drawing.Size(98, 24);
            chkShowHelp.TabIndex = 0;
            chkShowHelp.Values.Text = "Show Help";
            // 
            // kryptonGroupBox1
            // 
            kryptonGroupBox1.Location = new System.Drawing.Point(12, 153);
            kryptonGroupBox1.Name = "kryptonGroupBox1";
            kryptonGroupBox1.Size = new System.Drawing.Size(348, 164);
            kryptonGroupBox1.TabIndex = 20;
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
            // kryptonListBox1
            // 
            kryptonListBox1.Items.AddRange(new object[] { "Font 1", "Font 2", "Font 1Font 1Font 1Font 1" });
            kryptonListBox1.Location = new System.Drawing.Point(4, 29);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new System.Drawing.Size(120, 96);
            kryptonListBox1.TabIndex = 1;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.CornerRoundingRadius = -1F;
            kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            kryptonComboBox1.DropDownWidth = 121;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Items.AddRange(new object[] { "Microsoft Sans Serif" });
            kryptonComboBox1.Location = new System.Drawing.Point(4, 4);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new System.Drawing.Size(146, 25);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 0;
            kryptonComboBox1.Text = "Microsoft Sans Serif";
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new System.Drawing.Point(156, 4);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new System.Drawing.Size(152, 24);
            kryptonCheckBox1.TabIndex = 2;
            kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new System.Drawing.Point(156, 29);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new System.Drawing.Size(134, 27);
            kryptonTextBox1.TabIndex = 6;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new System.Drawing.Point(156, 65);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(90, 25);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonNumericUpDown1
            // 
            kryptonNumericUpDown1.Location = new System.Drawing.Point(156, 97);
            kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            kryptonNumericUpDown1.Size = new System.Drawing.Size(90, 26);
            kryptonNumericUpDown1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(594, 410);
            Controls.Add(kryptonPanel1);
            Name = "Form1";
            Text = "KryptonFileDialog Example";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonThemeComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2.Panel).EndInit();
            kryptonGroupBox2.Panel.ResumeLayout(false);
            kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonButton buttonFileOpenDialog;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonCheckBox chkShowHelp;
        private Krypton.Toolkit.KryptonCheckBox chkShowColour;
        private Krypton.Toolkit.KryptonCheckBox chkShowEffects;
        private Krypton.Toolkit.KryptonCheckBox chkShowApply;
        private Krypton.Toolkit.KryptonCheckBox chkAllowVectorFonts;
        private Krypton.Toolkit.KryptonCheckBox chkAllowSimulations;
        private Krypton.Toolkit.KryptonCheckBox chkAllowScriptChange;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonNumericUpDown kryptonNumericUpDown1;
        private Krypton.Toolkit.KryptonThemeComboBox kryptonThemeComboBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}

