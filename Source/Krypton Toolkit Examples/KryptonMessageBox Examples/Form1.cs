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
    public partial class Form1 : KryptonForm
    {
        private MessageBoxIcon _mbIcon = MessageBoxIcon.Warning;
        private KryptonMessageBoxIcon _kmbIcon = KryptonMessageBoxIcon.Warning;
        private MessageBoxButtons _mbButtons = MessageBoxButtons.OKCancel;
        private MessageBoxOptions _options = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void palette_CheckedChanged(object sender, EventArgs e)
        {
            if (kradOffice2010Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
            else if (kradOffice2010Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            }
            else if (kradOffice2010Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            }
            else if (kradOffice2007Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
            else if (kradOffice2007Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            }
            else if (kradOffice2007Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            }
            else if (kradSparkleBlue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
            else if (kradSparkleOrange.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            }
            else if (kradSparklePurple.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
            }
            else if (kradOffice2003.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
            }
            else if (kradSystem.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            }
            else if (kradOffice365Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Microsoft365Blue;
            }

        }

        private void icon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNone.Checked)
            {
                _mbIcon = MessageBoxIcon.None;
                _kmbIcon = KryptonMessageBoxIcon.None;
            }
            else if (kradError.Checked)
            {
                _mbIcon = MessageBoxIcon.Error;
                _kmbIcon = KryptonMessageBoxIcon.Error;
            }
            else if (kradQuestion.Checked)
            {
                _mbIcon = MessageBoxIcon.Question;
                _kmbIcon = KryptonMessageBoxIcon.Question;
            }
            else if (kradWarning.Checked)
            {
                _mbIcon = MessageBoxIcon.Warning;
                _kmbIcon = KryptonMessageBoxIcon.Warning;
            }
            else if (kradInformation.Checked)
            {
                _mbIcon = MessageBoxIcon.Information;
                _kmbIcon = KryptonMessageBoxIcon.Information;
            }
        }

        private void buttons_CheckedChanged(object sender, EventArgs e)
        {
            if (kradOK.Checked)
            {
                _mbButtons = MessageBoxButtons.OK;
            }
            else if (kradOKCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.OKCancel;
            }
            else if (kradRetryCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.RetryCancel;
            }
            else if (kradAbortRetryIgnore.Checked)
            {
                _mbButtons = MessageBoxButtons.AbortRetryIgnore;
            }
            else if (kradYesNo.Checked)
            {
                _mbButtons = MessageBoxButtons.YesNo;
            }
            else if (kradYesNoCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.YesNoCancel;
            }
#if NET60_OR_GREATER
            else if (kradCancelTryContinue.Checked)
            {
                _mbButtons = MessageBoxButtons.CancelTryContinue;
            }
#endif
        }

        private void ChkRightAlign_CheckedChanged(object sender, EventArgs e)
        {
            if (kchkRightAlign.Checked)
            {
                _options |= MessageBoxOptions.RightAlign;
            }
            else
            {
                _options &= ~MessageBoxOptions.RightAlign;
            }
        }

        private void ChkRtlReading_CheckedChanged(object sender, EventArgs e)
        {
            if (kchkRtlReading.Checked)
            {
                _options |= MessageBoxOptions.RtlReading;
            }
            else
            {
                _options &= ~MessageBoxOptions.RtlReading;
            }
        }

        private void kbtnShow_Click(object sender, EventArgs e)
        {
            if (kradWinLogo.Checked)
            {
                KryptonMessageBox.Show(this, textBoxMessage.Text, textBoxCaption.Text, _mbButtons, KryptonMessageBoxIcon.WindowsLogo, options: _options);
            }
            else
            {
                MessageBox.Show(textBoxMessage.Text, textBoxCaption.Text, _mbButtons, _mbIcon, MessageBoxDefaultButton.Button1, _options);

                KryptonMessageBox.Show(this, textBoxMessage.Text, textBoxCaption.Text, _mbButtons, _kmbIcon,
                    options: _options);
            }
        }
    }
}
