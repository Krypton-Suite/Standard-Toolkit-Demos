#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;
using RibbonControls.Properties;

namespace RibbonControls
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            miscCmbTheme.ComboBox.StateCommon.ComboBox.Content.Font =
                new Font(@"Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            miscCmbTheme.ComboBox.StateCommon.Item.Content.ShortText.Font =
                miscCmbTheme.ComboBox.StateCommon.ComboBox.Content.Font;
            // Hook into changes in the global palette
            ThemeManager.PropagateThemeSelector(miscCmbTheme.ComboBox);
            miscCmbTheme.Text = ThemeManager.ReturnPaletteModeManagerAsString(KryptonManager.GlobalPaletteMode);
        }

        private LinkLabel CreateLinkLabel(string text)
        {
            LinkLabel ll = new LinkLabel();
            ll.BackColor = Color.Transparent;
            ll.Text = text;
            return ll;
        }

        private NumericUpDown CreateNumericUpDown(decimal value)
        {
            NumericUpDown nud = new NumericUpDown();
            nud.Value = value;
            return nud;
        }

        private ProgressBar CreateProgressBar(int value)
        {
            ProgressBar pb = new ProgressBar();
            pb.Value = value;
            return pb;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the rich text box with RTF
            richTextBox1.RichTextBox.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\colortbl ;\red0\green0\blue255;\red0\green128\blue0;\red255\green0\blue0;}{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\cf1\f0\fs20 RichTextBox\cf0  with \cf2 Multiline\cf0  set to \cf3 True\cf0 .\par}";
            richTextBox1.RichTextBox.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\colortbl ;\red0\green0\blue255;\red0\green128\blue0;\red255\green0\blue0;}{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\cf1\f0\fs20 RichTextBox\cf0  with \cf2 Multiline\cf0  set to \cf3 True\cf0 .\par}";

            // Hook into the button spec buttons
            textBox3.ButtonSpecs[0].Click += new EventHandler(OnTextBox3Clear);
            comboBox3.ButtonSpecs[0].Click += new EventHandler(OnComboBox3Clear);
            dateTimePicker3.ButtonSpecs[0].Click += new EventHandler(OnDateTimePicker3Clear);
            maskedTextBox3.ButtonSpecs[0].Click += new EventHandler(OnMaskedTextBox3Clear);
            numericUpDown2.ButtonSpecs[0].Click += new EventHandler(OnNumericUpDown2Clear);
            
            // Create and associate various controls
            custom9.CustomControl = CreateLinkLabel("LinkLabel Control");
            custom10.CustomControl = CreateNumericUpDown(50);
            custom11.CustomControl = CreateProgressBar(75);

            // Set initial focus to the palette selection radio button
            rbOffice2007Blue.Focus();
        }

        private void OnTextBox3Clear(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
        }

        private void OnComboBox3Clear(object sender, EventArgs e)
        {
            comboBox3.Text = "Windows Vista";
        }

        private void OnMaskedTextBox3Clear(object sender, EventArgs e)
        {
            maskedTextBox3.Text = string.Empty;
        }

        private void OnDateTimePicker3Clear(object sender, EventArgs e)
        {
            dateTimePicker3.Value = DateTime.Now;
        }

        private void OnNumericUpDown2Clear(object sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown2.Minimum;
        }

        private void rbOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void rbOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void rbOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void rbOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void rbOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
        }

        private void rbOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
        }

        private void rbOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
        }

        private void rbSystem_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void rbSparkle_CheckedChanged(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }

        private void appMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool defaultRibbonCheckBox = Settings.Default.RibbonCheckBox;
            Settings.Default.Save();
        }
    }
}
