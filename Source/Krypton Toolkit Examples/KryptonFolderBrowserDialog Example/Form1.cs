using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonFontDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
            var kfd = new Krypton.Toolkit.KryptonFontDialog
            {
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
