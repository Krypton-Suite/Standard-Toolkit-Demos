using System;
using System.Windows.Forms;

using Krypton.Toolkit;

using KryptonColorDialog.Properties;

namespace KryptonFontDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            Icon = Resources.Krypton;

        }

        private void Palette2010Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;

        private void Palette2010Silver_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;

        private void Palette2010Black_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;

        private void Palette2007Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;

        private void PaletteSparkleOrange_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;

        private void PaletteProfessional_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;

        private int[] customColors;
        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
            var kfd = new Krypton.Toolkit.KryptonColorDialog 
            {
                AllowFullOpen = chkAllowFullOpen.Checked,
                ShowHelp = chkShowHelp.Checked,
                AnyColor = chkAnyColor.Checked,
                FullOpen = chkFullOPen.Checked,
                SolidColorOnly = chkSolidColorOnly.Checked,
                CustomColors = customColors,
                Title = @"Test Colour Dialog being set",
                ShowIcon = chkShowIcon.Checked,
                //Icon = Icon
            };
            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.Color.ToString(), @"Color chosen is");
                customColors = kfd.CustomColors;
            }
        }
    }
}
