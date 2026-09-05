// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonFontDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
            var kfd = new Krypton.Toolkit.KryptonFontDialog {
                ShowColor = chkShowColour.Checked,
                ShowHelp = chkShowHelp.Checked,
                AllowScriptChange = chkAllowScriptChange.Checked,
                AllowSimulations = chkAllowSimulations.Checked,
                AllowVectorFonts = chkAllowVectorFonts.Checked,
                ShowApply = chkShowApply.Checked,
                ShowEffects = chkShowEffects.Checked

            };
            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.Font.ToString(), @"Font chosen is");
            }
        }
    }
}
