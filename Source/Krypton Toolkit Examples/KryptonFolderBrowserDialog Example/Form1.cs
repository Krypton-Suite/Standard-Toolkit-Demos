using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonFolderBrowserDialog_Example_2019
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void ButtonShowFileDialog_Click(object sender, EventArgs e)
        {
            using KryptonFolderBrowserDialog kfd = new() {
                Icon = this.Icon,
                // RootFolder = 
                // SelectedPath = 
                Title = @"Select a folder to use"
            };

            if (kfd.ShowDialog(this) == DialogResult.OK)
            {
                KryptonMessageBox.Show(this, kfd.SelectedPath, @"Directory chosen is");
            }
        }
    }

}
