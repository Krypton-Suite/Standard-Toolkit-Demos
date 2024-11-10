using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonThemeSelector
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void kbtnUseListBox_Click(object sender, System.EventArgs e)
        {
            KryptonThemeBrowserData themeBrowserData = new KryptonThemeBrowserData() {
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