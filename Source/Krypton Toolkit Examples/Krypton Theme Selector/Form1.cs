using Krypton.Toolkit;

namespace KryptonThemeSelector
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void kbtnUseListBox_Click(object sender, System.EventArgs e)
        {
            KryptonThemeBrowser.Show();
        }
    }
}