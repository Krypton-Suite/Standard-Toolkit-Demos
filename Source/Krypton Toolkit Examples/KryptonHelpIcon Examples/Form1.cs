using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonHelpIconExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            bsHelpIcon.Click += BsHelpIcon_Click;
        }

        private void BsHelpIcon_Click(object sender, EventArgs e) =>
            KryptonMessageBox.Show("You have requested help... Please enter your code here.", "Help Demo",
                MessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

        private void Form1_Load(object sender, EventArgs e) => palette365Blue.Checked = true;

        private void ChangePalette(PaletteModeManager mode) => kryptonManager.GlobalPaletteMode = mode;

        private void paletteProfessional_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.ProfessionalSystem);

        private void paletteOffice2003_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.ProfessionalOffice2003);

        private void palette2007Black_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007Black);

        private void palette2007BlackDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007BlackDarkMode);

        private void palette2007Blue_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007Blue);

        private void palette2007BlueDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007BlueDarkMode);

        private void palette2007BlueLightMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007BlueLightMode);

        private void palette2007Silver_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007Silver);

        private void palette2007SilverDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007SilverDarkMode);

        private void palette2007SilverLightMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007SilverLightMode);

        private void palette2007White_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2007White);

        private void palette2010Black_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010Black);

        private void palette2010BlackDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010BlackDarkMode);

        private void palette2010Blue_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010Blue);

        private void palette2010BlueDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010BlueDarkMode);

        private void palette2010BlueLightMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010BlueLightMode);

        private void palette2010Silver_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010Silver);

        private void palette2010SilverDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010SilverDarkMode);

        private void palette2010SilverLightMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010SilverLightMode);

        private void palette2010White_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2010White);

        private void paletteOffice2013White_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office2013White);

        private void palette365Black_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365Black);

        private void palette365BlackDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365BlackDarkMode);

        private void palette365Blue_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365Blue);

        private void palette365BlueDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365BlueDarkMode);

        private void palette365BlueLightMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365BlueLightMode);

        private void palette365Silver_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365Silver);

        private void palette365SilverDarkMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365SilverDarkMode);

        private void palette365SilverLightMode_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365SilverLightMode);

        private void palette365White_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.Office365White);

        private void paletteSparkleBlue_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.SparkleBlue);

        private void paletteSparkleOrange_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.SparkleOrange);

        private void paletteSparklePurple_CheckedChanged(object sender, EventArgs e) => ChangePalette(PaletteModeManager.SparklePurple);
    }
}
