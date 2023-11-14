using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonExplorer
{
    public partial class HelpFileLocator : KryptonForm
    {
        private Properties.Settings _settings = new();

        public HelpFileLocator()
        {
            InitializeComponent();
        }

        private void kcmdBrowseForFile_Execute(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = @"Browse for Help File:",
                Filter = @"Compiled HTML Help Files|*.chm"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ktxtHelpFilePath.Text = Path.GetFullPath(ofd.FileName);
            }
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ktxtHelpFilePath.Text))
            {
                _settings.HelpFileLocation = ktxtHelpFilePath.Text;

                _settings.Save();
            }
        }
    }
}
