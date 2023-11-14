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

using Krypton.Toolkit;

namespace MDIRibbon
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) 
            {
                // Remember to unhook from static event, otherwise 
                // this object cannot be garbage collected later on
                KryptonManager.GlobalPaletteChanged -= OnPaletteChanged;

                components?.Dispose();
            }
            base.Dispose(disposing);
        }       

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set correct initial radio button setting
            UpdateRadioButtons();

            // Hook into changes in the global palette
            KryptonManager.GlobalPaletteChanged += OnPaletteChanged;
        }

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSystem.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
            }
        }

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2003.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003;
            }
        }

        private void radio2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2010Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;
            }
        }

        private void radio2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2010Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;
            }
        }

        private void radio2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2010Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;
            }
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;
            }
        }

        private void radioSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSilver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver;
            }
        }

        private void radioBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlack.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black;
            }
        }

        private void radioSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleBlue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
            }
        }

        private void radioSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleOrange.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;
            }
        }

        private void radioSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparklePurple.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple;
            }
        }

        private void OnPaletteChanged(object sender, EventArgs e)
        {
            // Update buttons to reflect the new palette setting
            UpdateRadioButtons();
        }

        private void UpdateRadioButtons()
        {
            switch(kryptonManager.GlobalPaletteMode)
            {
                case PaletteMode.ProfessionalSystem:
                    radioSystem.Checked = true;
                    break;
                case PaletteMode.ProfessionalOffice2003:
                    radioOffice2003.Checked = true;
                    break;
                case PaletteMode.Office2007Blue:
                    radioBlue.Checked = true;
                    break;
                case PaletteMode.Office2007Silver:
                    radioSilver.Checked = true;
                    break;
                case PaletteMode.Office2007Black:
                    radioBlack.Checked = true;
                    break;
                case PaletteMode.SparkleBlue:
                    radioSparkleBlue.Checked = true;
                    break;
                case PaletteMode.SparkleOrange:
                    radioSparkleOrange.Checked = true;
                    break;
                case PaletteMode.SparklePurple:
                    radioSparklePurple.Checked = true;
                    break;
                case PaletteMode.Office2010Blue:
                    radio2010Blue.Checked = true;
                    break;
                case PaletteMode.Office2010Silver:
                    radio2010Silver.Checked = true;
                    break;
                case PaletteMode.Office2010Black:
                    radio2010Black.Checked = true;
                    break;
            }
        }
    }
}
