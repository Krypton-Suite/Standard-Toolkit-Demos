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

        private void ButtonShowFontDialog_Click(object sender, EventArgs e)
        {
         /*   using var kfd = new KryptonOpenFileDialog
                {
                    AddExtension = true,
                    AutoUpgradeEnabled = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "exe",
                    DereferenceLinks = true,
                    //FileName = "",
                    Filter = @"Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF",
                    //FilterIndex = 0,
                    //InitialDirectory = "",
                    //Container = {  },
                    //CustomPlaces = {  },
                    //Multiselect = true,
                    // ReadOnlyChecked = true, // Get only
                    //RestoreDirectory = true,
                    ShowHelp = true,
                    ShowPreview = true,
                    ShowReadOnly = true,
                    //Site = ISite,
                    //SupportMultiDottedExtensions = true,
                    //Tag = "",
                    Title = @"Select a File to Open",
                    //ValidateNames = true
                    // Icon = this.Icon
                    };
            // And also take into account other options that are currently missing in early .net FW's
            // https://github.com/dotnet/winforms/issues/5405
            // And take into account open positioning, so that it is similar to Tooltip positioning:
            // https://stackoverflow.com/questions/1256130/setting-the-start-position-for-openfiledialog-savefiledialog


            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.FileName, @"File chosen is");
            }*/
        }
    }
}
