using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonFontDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            fontLast = Font;
        }

        private void Palette2010Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;

        private void Palette2010Silver_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;

        private void Palette2010Black_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;

        private void Palette2007Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;

        private void PaletteSparkleOrange_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;

        private void PaletteProfessional_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private Font fontLast;
        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
            var kfd = new KryptonFontDialog {
                ShowColor = chkShowColour.Checked,
                ShowHelp = chkShowHelp.Checked,
                AllowScriptChange = chkAllowScriptChange.Checked,
                AllowSimulations = chkAllowSimulations.Checked,
                AllowVectorFonts = chkAllowVectorFonts.Checked,
                ShowApply = chkShowApply.Checked,
                ShowEffects = chkShowEffects.Checked,
                Font = fontLast,
                Title = @"Test Font Dialog being set",
                DisplayIsPrinterFontDescription = true,
                DisplayExtendedColorsButton = chklShowExtendedColours.Checked,
                ShowIcon = chkShowIcon.Checked
           };
            kfd.Color = Color.DarkOliveGreen;
            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.Font.ToString(), @"Font chosen is");
                fontLast = kfd.Font;
            }
        }

        private void KryptonColorButton1_SelectedColorChanged(object sender, ColorEventArgs e)
        {

        }
    }
}
