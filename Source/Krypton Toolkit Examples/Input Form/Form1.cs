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

namespace InputForm
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void office2010_Click(object sender, EventArgs e)
        {
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue;
            toolStripOffice2010.Checked = true;
            toolStripOffice2007.Checked = false;
            toolStripSystem.Checked = false;
            toolStripSparkle.Checked = false;
            office2010MenuItem.Checked = true;
            office2007MenuItem.Checked = false;
            systemMenuItem.Checked = false;
            sparkleMenuItem.Checked = false;
        }

        private void office2007_Click(object sender, EventArgs e)
        {
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue;
            toolStripOffice2010.Checked = false;
            toolStripOffice2007.Checked = true;
            toolStripSystem.Checked = false;
            toolStripSparkle.Checked = false;
            office2010MenuItem.Checked = false;
            office2007MenuItem.Checked = true;
            systemMenuItem.Checked = false;
            sparkleMenuItem.Checked = false;
        }

        private void sparkle_Click(object sender, EventArgs e)
        {
            kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue;
            toolStripOffice2010.Checked = false;
            toolStripOffice2007.Checked = false;
            toolStripSystem.Checked = false;
            toolStripSparkle.Checked = true;
            office2010MenuItem.Checked = false;
            office2007MenuItem.Checked = false;
            systemMenuItem.Checked = false;
            sparkleMenuItem.Checked = true;
        }

        private void system_Click(object sender, EventArgs e)
        {
            kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
            toolStripOffice2010.Checked = false;
            toolStripOffice2007.Checked = false;
            toolStripSystem.Checked = true;
            toolStripSparkle.Checked = false;
            office2010MenuItem.Checked = false;
            office2007MenuItem.Checked = false;
            systemMenuItem.Checked = true;
            sparkleMenuItem.Checked = false;
        }

        private void clearTelephone_Click(object sender, EventArgs e) => maskedTextBoxTelephone.Text = string.Empty;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
