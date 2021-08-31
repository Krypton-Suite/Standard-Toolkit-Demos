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
using System.Windows.Forms;
using Krypton.Toolkit;

namespace KryptonMessageBoxExamples
{
    public partial class Form1 : Form
    {
        private MessageBoxIcon _mbIcon = MessageBoxIcon.Warning;
        private MessageBoxButtons _mbButtons = MessageBoxButtons.OKCancel;

        public Form1() => InitializeComponent();

        private void palette_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOffice2010Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
            else if (radioButtonOffice2010Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            }
            else if (radioButtonOffice2010Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            }
            else if (radioButtonOffice2007Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
            else if (radioButtonOffice2007Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            }
            else if (radioButtonOffice2007Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            }
            else if (radioButtonSparkleBlue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
            else if (radioButtonSparkleOrange.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            }
            else if (radioButtonSparklePurple.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
            }
            else if (radioButtonOffice2003.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
            }
            else if (radioButtonSystem.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            }
        }

        private void icon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNone.Checked)
            {
                _mbIcon = MessageBoxIcon.None;
            }
            else if (radioButtonError.Checked)
            {
                _mbIcon = MessageBoxIcon.Error;
            }
            else if (radioButtonQuestion.Checked)
            {
                _mbIcon = MessageBoxIcon.Question;
            }
            else if (radioButtonWarning.Checked)
            {
                _mbIcon = MessageBoxIcon.Warning;
            }
            else if (radioButtonInformation.Checked)
            {
                _mbIcon = MessageBoxIcon.Information;
            }
        }

        private void buttons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOK.Checked)
            {
                _mbButtons = MessageBoxButtons.OK;
            }
            else if (radioButtonOKCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.OKCancel;
            }
            else if (radioButtonRetryCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.RetryCancel;
            }
            else if (radioButtonAbortRetryIgnore.Checked)
            {
                _mbButtons = MessageBoxButtons.AbortRetryIgnore;
            }
            else if (radioButtonYesNo.Checked)
            {
                _mbButtons = MessageBoxButtons.YesNo;
            }
            else if (radioButtonYesNoCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.YesNoCancel;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e) => KryptonMessageBox.Show(textBoxMessage.Text, textBoxCaption.Text, _mbButtons, _mbIcon);
    }
}
