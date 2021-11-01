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
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using Krypton.Toolkit;
using Krypton.Navigator;

namespace NavigatorPalettes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateFromNavigator();
        }

        private void radioOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Blue.Checked)
            {
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.Office2010Blue;
                UpdateFromNavigator();
            }
        }

        private void radioOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Silver.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.Office2010Silver;
                UpdateFromNavigator();
            }
        }

        private void radioOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Black.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.Office2010Black;
                UpdateFromNavigator();
            }
        }

        private void radioOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Blue.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.Office2007Blue;
                UpdateFromNavigator();
            }
        }

        private void radioOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Silver.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Black.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.Office2007Silver;
                UpdateFromNavigator();
            }
        }

        private void radioOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Black.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.Office2007Black;
                UpdateFromNavigator();
            }
        }

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSystem.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.ProfessionalSystem;
                UpdateFromNavigator();
            }
        }

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2003.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioSystem.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.ProfessionalOffice2003;
                UpdateFromNavigator();
            }
        }

        private void radioSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleBlue.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioSystem.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                radioOffice2003.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.SparkleBlue;
                UpdateFromNavigator();
            }
        }

        private void radioSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleOrange.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioSystem.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                radioLightweight.Checked = false;
                radioOffice2003.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.SparkleOrange;
                UpdateFromNavigator();
            }
        }

        private void radioSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparklePurple.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioSystem.Checked = false;
                radioBlogger.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioLightweight.Checked = false;
                radioOffice2003.Checked = false;
                kryptonNavigator1.PaletteMode = PaletteMode.SparklePurple;
                UpdateFromNavigator();
            }
        }

        private void radioBlogger_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlogger.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioSystem.Checked = false;
                radioOffice2003.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioLightweight.Checked = false;
                kryptonNavigator1.Palette = kryptonPaletteBlogger;
                UpdateFromNavigator();
            }
        }

        private void radioLightweight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLightweight.Checked)
            {
                radioOffice2010Blue.Checked = false;
                radioOffice2010Silver.Checked = false;
                radioOffice2010Black.Checked = false;
                radioOffice2007Blue.Checked = false;
                radioOffice2007Silver.Checked = false;
                radioOffice2007Black.Checked = false;
                radioSystem.Checked = false;
                radioSparkleBlue.Checked = false;
                radioSparkleOrange.Checked = false;
                radioSparklePurple.Checked = false;
                radioBlogger.Checked = false;
                kryptonNavigator1.Palette = kryptonPaletteLightweight;
                UpdateFromNavigator();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateFromNavigator()
        {
            switch (kryptonNavigator1.PaletteMode)
            {
                case PaletteMode.ProfessionalSystem:
                    radioSystem.Checked = true;
                    break;
                case PaletteMode.Global:
                case PaletteMode.ProfessionalOffice2003:
                    radioOffice2003.Checked = true;
                    break;
                case PaletteMode.Custom:
                    if (kryptonNavigator1.Palette == kryptonPaletteBlogger)
                        radioBlogger.Checked = true;
                    else if (kryptonNavigator1.Palette == kryptonPaletteLightweight)
                        radioLightweight.Checked = true;
                    break;
            }
        }
    }
}
