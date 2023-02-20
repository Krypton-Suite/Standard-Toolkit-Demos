
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
            groupBoxPalette = new Krypton.Toolkit.KryptonGroupBox();
            buttonShowFontDialog = new Krypton.Toolkit.KryptonButton();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            chkShowEffects = new Krypton.Toolkit.KryptonCheckBox();
            chkShowApply = new Krypton.Toolkit.KryptonCheckBox();
            chkAllowVectorFonts = new Krypton.Toolkit.KryptonCheckBox();
            chkAllowSimulations = new Krypton.Toolkit.KryptonCheckBox();
            chkAllowScriptChange = new Krypton.Toolkit.KryptonCheckBox();
            chkShowColour = new Krypton.Toolkit.KryptonCheckBox();
            chkShowHelp = new Krypton.Toolkit.KryptonCheckBox();
            kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonNumericUpDown1 = new Krypton.Toolkit.KryptonNumericUpDown();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonCheckBox1 = new Krypton.Toolkit.KryptonCheckBox();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)groupBoxPalette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupBoxPalette.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2.Panel).BeginInit();
            kryptonGroupBox2.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).BeginInit();
            kryptonGroupBox1.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPalette
            // 
            groupBoxPalette.Location = new System.Drawing.Point(12, 12);
            groupBoxPalette.Name = "groupBoxPalette";
            groupBoxPalette.Size = new System.Drawing.Size(353, 135);
            groupBoxPalette.TabIndex = 18;
            groupBoxPalette.Values.Heading = "Palette";
            // 
            // buttonShowFontDialog
            // 
            buttonShowFontDialog.CornerRoundingRadius = -1F;
            buttonShowFontDialog.Location = new System.Drawing.Point(264, 323);
            buttonShowFontDialog.Name = "buttonShowFontDialog";
            buttonShowFontDialog.Size = new System.Drawing.Size(307, 59);
            buttonShowFontDialog.TabIndex = 19;
            buttonShowFontDialog.UACShieldIconSize = Krypton.Toolkit.UACShieldIconSize.ExtraSmall;
            buttonShowFontDialog.Values.Text = "Show FontDialog";
            buttonShowFontDialog.Click += ButtonShowFontDialog_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonGroupBox2);
            kryptonPanel1.Controls.Add(kryptonGroupBox1);
            kryptonPanel1.Controls.Add(groupBoxPalette);
            kryptonPanel1.Controls.Add(buttonShowFontDialog);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(594, 410);
            kryptonPanel1.TabIndex = 20;
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
            // 
            // 
            // 
            kryptonGroupBox1.Panel.Controls.Add(kryptonTextBox1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonNumericUpDown1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonButton1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonCheckBox1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonListBox1);
            kryptonGroupBox1.Panel.Controls.Add(kryptonComboBox1);
            kryptonGroupBox1.Size = new System.Drawing.Size(348, 164);
            kryptonGroupBox1.TabIndex = 20;
            kryptonGroupBox1.Values.Heading = "Style to match:";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new System.Drawing.Point(156, 29);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new System.Drawing.Size(134, 27);
            kryptonTextBox1.TabIndex = 6;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonNumericUpDown1
            // 
            kryptonNumericUpDown1.Location = new System.Drawing.Point(156, 97);
            kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            kryptonNumericUpDown1.Size = new System.Drawing.Size(90, 26);
            kryptonNumericUpDown1.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new System.Drawing.Point(156, 65);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(90, 25);
            kryptonButton1.TabIndex = 4;
            kryptonButton1.UACShieldIconSize = Krypton.Toolkit.UACShieldIconSize.ExtraSmall;
            kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // kryptonCheckBox1
            // 
            kryptonCheckBox1.Location = new System.Drawing.Point(156, 4);
            kryptonCheckBox1.Name = "kryptonCheckBox1";
            kryptonCheckBox1.Size = new System.Drawing.Size(152, 24);
            kryptonCheckBox1.TabIndex = 2;
            kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
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
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(594, 410);
            Controls.Add(kryptonPanel1);
            Name = "Form1";
            Text = "KryptonFontDialog Example";
            ((System.ComponentModel.ISupportInitialize)groupBoxPalette.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupBoxPalette).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2.Panel).EndInit();
            kryptonGroupBox2.Panel.ResumeLayout(false);
            kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1.Panel).EndInit();
            kryptonGroupBox1.Panel.ResumeLayout(false);
            kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonGroupBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
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
    }
}

