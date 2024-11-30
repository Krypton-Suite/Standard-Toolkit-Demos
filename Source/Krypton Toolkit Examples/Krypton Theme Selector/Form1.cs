// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2022 - 2024. All rights reserved.
// *****************************************************************************

using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonThemeSelector
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void kbtnUseListBox_Click(object sender, System.EventArgs e)
        {
            var themeBrowserData = new KryptonThemeBrowserData() {
                ShowImportButton = true,
                ShowSilentOption = true,
                StartIndex = 0,
                StartPosition = FormStartPosition.CenterScreen,
                WindowTitle = string.Empty
            };

            KryptonThemeBrowser.Show(themeBrowserData);
        }
    }
}