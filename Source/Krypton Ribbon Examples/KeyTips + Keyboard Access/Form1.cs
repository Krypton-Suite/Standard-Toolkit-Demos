#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 */
#endregion

using System;
using System.Windows.Forms;

using Krypton.Ribbon;
using Krypton.Toolkit;

namespace KeyTipsAndKeyboardAccess
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkSetPalette.CheckedButton = this.buttonOffice2010Black;
        }

        private void checkSetPalette_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSetPalette.CheckedButton == buttonOffice2007Blue)
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;
            else if (checkSetPalette.CheckedButton == buttonOffice2007Silver)
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver;
            else if (checkSetPalette.CheckedButton == buttonOffice2007Black)
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black;
            else if (checkSetPalette.CheckedButton == buttonProfessional2003)
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003;
            else if (checkSetPalette.CheckedButton == buttonProfessionalSystem)
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
            else if (checkSetPalette.CheckedButton == buttonSparkleBlue)
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
            else if (checkSetPalette.CheckedButton == buttonSparkleOrange)
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;
            else if (checkSetPalette.CheckedButton == buttonSparklePurple)
                kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple;
            else if (checkSetPalette.CheckedButton == buttonOffice2010Blue)
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;
            else if (checkSetPalette.CheckedButton == buttonOffice2010Silver)
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;
            else if (checkSetPalette.CheckedButton == buttonOffice2010Black)
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;
            else if (checkSetPalette.CheckedButton == buttonOffice365Black)
                kryptonManager.GlobalPaletteMode = PaletteMode.Microsoft365Black;
        }

        private void OnDialogBoxLauncherClick(object sender, EventArgs e)
        {
            KryptonRibbonGroup group = (KryptonRibbonGroup)sender;

            MessageBox.Show(this,
                            "You selected the '" + group.TextLine1 + "' group dialog box launcher.",
                            "Dialog Box Launcher");
        }

        private void OnQATButtonClick(object sender, EventArgs e)
        {
            KryptonRibbonQATButton button = (KryptonRibbonQATButton)sender;

            MessageBox.Show(this,
                            "You selected the '" + button.Text + "' quick access toolbar button.",
                            "QAT Button");
        }

        private void OnGroupButtonClick(object sender, EventArgs e)
        {
            KryptonRibbonGroupButton button = (KryptonRibbonGroupButton)sender;

            var text = button.TextLine1;
            if (!string.IsNullOrEmpty(button.TextLine2))
                text += " " + button.TextLine2;

            MessageBox.Show(this,
                            "You selected the '" + text + "' button.",
                            "Button");
        }

        private void OnGroupClusterButtonClick(object sender, EventArgs e)
        {
            KryptonRibbonGroupClusterButton button = (KryptonRibbonGroupClusterButton)sender;

            MessageBox.Show(this,
                            "You selected the '" + button.TextLine + "' button.",
                            "Button");
        }

        private void appMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
