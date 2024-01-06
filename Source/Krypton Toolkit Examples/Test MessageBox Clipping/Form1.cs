// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace TestMessageBoxClipping
{
    public partial class Form1 : KryptonForm
    {
        private const string SEED_TEXT =
            @"// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2016, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2024. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************
";
        public Form1() => InitializeComponent();

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

        private void kryptonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonCustom.Checked)
            {
                kryptonManager.GlobalCustomPalette = kryptonPaletteCustom;
            }
        }

        private void kryptonOffice2013White_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonOffice2013White.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2013White;
            }
        }

        private void btnSingleLines_Click(object sender, EventArgs e)
        {
            string localText = SEED_TEXT.Replace(Environment.NewLine, "");
            MessageBox.Show(this, localText + localText, localText);
            KryptonMessageBox.Show(this, localText + localText, localText);
        }

        private void btnCarriageReturns_Click(object sender, EventArgs e)
        {
            string localText = SEED_TEXT;
            MessageBox.Show(this, localText + localText, localText);
            KryptonMessageBox.Show(this, localText + localText, localText);
        }

        private void btnStackTrace_Click(object sender, EventArgs e)
        {
            try
            {
                void InfiniteLoopIt(int howDeep)
                {
                    if (howDeep > 50)
                    {
                        throw new InsufficientExecutionStackException();
                    }

                    InfiniteLoopIt(++howDeep);
                }

                InfiniteLoopIt(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, ex.Message);
                KryptonMessageBox.Show(this, ex.StackTrace, ex.Message);
                KryptonTaskDialog.Show(ex.Message, "MinInstruction", ex.StackTrace, KryptonMessageBoxIcon.Stop,
                    TaskDialogButtons.Close, null);
            }
        }

        private void btnLongTitle_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "ex.StackTrace", ex.Message);
                KryptonMessageBox.Show(this, "ex.StackTrace", ex.Message);
            }
        }

        private void btnLongContents_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                KryptonMessageBox.Show(this, ex.StackTrace, "ex.Message", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Stop);
            }
        }

        private void btnLongTitleNoOwner_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.StackTrace", ex.Message);
                KryptonMessageBox.Show("ex.StackTrace", ex.Message);
            }
        }

        private void btnLongContentsNoOwner_Click(object sender, EventArgs e)
        {
            try
            {
                throw new InsufficientExecutionStackException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                KryptonMessageBox.Show(ex.StackTrace, "ex.Message", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Stop);
            }
        }
    }
}
