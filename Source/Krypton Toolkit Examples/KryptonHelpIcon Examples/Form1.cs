using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonHelpIconExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            bsHelpIcon.Click += BsHelpIcon_Click;
        }

        private void BsHelpIcon_Click(object sender, EventArgs e) =>
            KryptonMessageBox.Show("You have requested help... Please enter your code here.", "Help Demo",
                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
