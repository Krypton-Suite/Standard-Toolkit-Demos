using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonOpenFileDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void ButtonShowFileDialog_Click(object sender, EventArgs e)
        {
            using KryptonOpenFileDialog kfd = new() {
                AddExtension = chkAddExtension.Checked,
                //AutoUpgradeEnabled = true, // N/A
                CheckFileExists = chkCheckFileExists.Checked,
                CheckPathExists = chkCheckPathExists.Checked,
                DefaultExt = "PNG",
                DereferenceLinks = chkDereferenceLinks.Checked,
                //FileName = "",
                Filter = @"Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF",
                FilterIndex = 0,
                InitialDirectory = "",
                //Container = {  },
                //CustomPlaces = {  },
                Multiselect = chkMultiselect.Checked,
                ReadOnlyChecked = chkReadOnlyChecked.Checked, // Get only
                RestoreDirectory = chkRestoreDirectory.Checked,
                SupportMultiDottedExtensions = true,
                Title = @"Select a File to Open",
                ValidateNames = true,
                Icon = this.Icon
            };

            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.FileName, @"File chosen is");
            }
        }
    }
}
