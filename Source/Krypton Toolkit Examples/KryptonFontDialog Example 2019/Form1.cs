using Krypton.Toolkit;
using Krypton.Toolkit.Controls_Toolkit;

using System;

namespace KryptonFontDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Palette2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
        }

        private void Palette2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
        }

        private void Palette2010Black_CheckedChanged(object sender, EventArgs e)
        {
            KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
        }

        private void Palette2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
        }

        private void PaletteSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            KryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
        }

        private void PaletteProfessional_CheckedChanged(object sender, EventArgs e)
        {
            KryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
            var kfd = new KryptonFontDialog 
            {
                ShowColor = chkShowColour.Checked,
                ShowHelp = chkShowHelp.Checked,
                AllowScriptChange = chkAllowScriptChange.Checked,
                AllowSimulations = chkAllowSimulations.Checked,
                AllowVectorFonts = chkAllowVectorFonts.Checked,
                ShowApply = chkShowApply.Checked,
                ShowEffects = chkShowEffects.Checked
                
            };
            kfd.ShowDialog(this);
        }
    }
}
