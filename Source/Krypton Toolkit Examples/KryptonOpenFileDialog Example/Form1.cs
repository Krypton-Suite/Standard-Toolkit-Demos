using System;
using System.ComponentModel;
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
                // ShowHelp = true, // TODO Ookii ??
                // ShowPreview = true, // TODO Ookii ??
                // ShowReadOnly = true,// TODO Ookii ??
                // Site = ISite, // N/A
                SupportMultiDottedExtensions = true,
                // Tag = "",// N/A
                Title = @"Select a File to Open",
                ValidateNames = true,
                Icon = this.Icon
            };

            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.FileName, @"File chosen is");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
