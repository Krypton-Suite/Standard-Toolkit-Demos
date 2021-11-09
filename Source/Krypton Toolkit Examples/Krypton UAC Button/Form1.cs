using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonUACButton
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kchkShowUACShield_CheckedChanged(object sender, EventArgs e)
        {
            kbtnTest.UseAsUACElevationButton = kchkShowUACShield.Checked;
        }

        private void kbtnTest_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("UAC elevation requires developer input.", "UAC Button Example", MessageBoxButtons.OK, KryptonMessageBoxIcon.SHIELD);
        }
    }
}
