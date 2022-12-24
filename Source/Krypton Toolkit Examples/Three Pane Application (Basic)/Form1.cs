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

namespace ThreePaneApplication
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void kryptonOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2010Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;
            }
        }

        private void kryptonOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2010Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;
            }
        }

        private void kryptonOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2010Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;
            }
        }

        private void kryptonOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2007Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;
            }
        }

        private void kryptonOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2007Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver;
            }
        }

        private void kryptonOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2007Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black;
            }
        }

        private void kryptonOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2003.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003;
            }
        }

        private void kryptonSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSystem.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
            }
        }

        private void kryptonSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSparkleBlue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
            }
        }

        private void kryptonSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSparkleOrange.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;
            }
        }

        private void kryptonSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonSparklePurple.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple;
            }
        }

        private void kryptonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCustom.Checked)
            {
                kryptonManager.GlobalPalette = kryptonPaletteCustom;
            }
        }

        private void kryptonOffice2013White_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2013White.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2013White;
            }
        }
    }
}
