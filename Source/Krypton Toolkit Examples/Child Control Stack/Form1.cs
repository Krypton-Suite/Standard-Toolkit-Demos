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

using Krypton.Toolkit;

namespace ChildControlStack
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxFiller.Focus();
            textBoxFiller.SelectionStart = 0;
            textBoxFiller.SelectionLength = 0;
        }

        private void kryptonCheckSet_CheckedButtonChanged(object sender, EventArgs e) =>
            // Put the name for the checkbutton into the header
            kryptonHeader.Values.Heading = kryptonCheckSet.CheckedButton.Values.Text;

        private void toolOffice2010_Click(object sender, EventArgs e)
        {
            if (!toolOffice2010.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = true;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
            }
        }

        private void toolOffice2007_Click(object sender, EventArgs e)
        {
            if (!toolOffice2007.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = true;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = false;
            }
        }

        private void toolSystem_Click(object sender, EventArgs e)
        {
            if (!toolSystem.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = true;
                toolSparkle.Checked = menuSparkle.Checked = false;
            }
        }

        private void toolSparkle_Click(object sender, EventArgs e)
        {
           if (!toolSparkle.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                toolOffice2010.Checked = menuOffice2010.Checked = false;
                toolOffice2007.Checked = menuOffice2007.Checked = false;
                toolSystem.Checked = menuSystem.Checked = false;
                toolSparkle.Checked = menuSparkle.Checked = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
