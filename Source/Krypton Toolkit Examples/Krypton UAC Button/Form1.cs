using System;

using Krypton.Toolkit;

namespace KryptonUACButton
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void kchkShowUACShield_CheckedChanged(object sender, EventArgs e) => kbtnTest.UseAsUACElevationButton = kchkShowUACShield.Checked;

        private void kbtnTest_Click(object sender, EventArgs e) => 
            KryptonMessageBox.Show("UAC elevation requires developer input.", "UAC Button Example", 
                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Shield);
    }
}
