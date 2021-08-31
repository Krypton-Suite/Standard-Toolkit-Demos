using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ktxtProcessPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kbtnRun.ProcessToElevate = ktxtProcessPath.Text;
            }
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Open a Executable:",
                Filter = "Windows Executables|*.exe"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ktxtProcessPath.Text = Path.GetFullPath(ofd.FileName);
            }
        }

        private void kchkElevateProcess_CheckedChanged(object sender, EventArgs e) => kbtnRun.UseAsUACElevationButton = kchkElevateProcess.Checked;

        private void kbtnRun_Click(object sender, EventArgs e)
        {
            kbtnRun.ProcessToElevate = ktxtProcessPath.Text;

            if (!kbtnRun.UseAsADialogButton)
            {
                Process.Start(ktxtProcessPath.Text);
            }
        }
    }
}
