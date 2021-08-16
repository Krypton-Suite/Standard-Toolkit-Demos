using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace FolderBrowserDialog_Example
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void Palette2010Blue_CheckedChanged(object sender, EventArgs e) => KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;

        private void Palette2010Silver_CheckedChanged(object sender, EventArgs e) => KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;

        private void Palette2010Black_CheckedChanged(object sender, EventArgs e) => KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;

        private void Palette2007Blue_CheckedChanged(object sender, EventArgs e) => KryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;

        private void PaletteSparkleOrange_CheckedChanged(object sender, EventArgs e) => KryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;

        private void PaletteProfessional_CheckedChanged(object sender, EventArgs e) => KryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;

        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
            var kfd = new KryptonFolderBrowserDialog {
                ShowNewFolderButton = chkShowNewFolderBut.Checked
                // For .Netcore3.1 onwards
                , UseDescriptionForTitle = chkUseDescriptionForTitle.Checked
                , UsePreVistaStyle = chkUseOldStyle.Checked
            };
            if (!string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                kfd.Description = txtDescription.Text;
            }

            if (!string.IsNullOrWhiteSpace(txtRootFolder.Text))
            {
                kfd.RootFolder = (Environment.SpecialFolder)Enum.Parse(typeof(Environment.SpecialFolder), txtRootFolder.Text);
            }

            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.SelectedPath, @"Selected path chosen is");
            }
        }
    }
}
