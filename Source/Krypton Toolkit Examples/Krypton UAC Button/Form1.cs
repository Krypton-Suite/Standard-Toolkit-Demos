using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonUACButton
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kchkShowShield_CheckedChanged(object sender, EventArgs e)
        {
            kbtnRun.UseAsUACElevationButton = kchkShowShield.Checked;
        }

        private void kbtnRun_Click(object sender, EventArgs e)
        {
            Process.Start(ktxtProcessPath.Text);
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { };

            if (ofd.ShowDialog() == DialogResult.Yes)
            {
                ktxtProcessPath.Text = Path.GetFullPath(ofd.FileName);
            }
        }
    }
}
