using System.IO;
using System.Reflection;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonAboutBoxExample
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kbtnShow_Click(object sender, System.EventArgs e)
        {
            Assembly? currentAssembly = null;

            if (!string.IsNullOrEmpty(ktxtAssemblyLocation.Text))
            {
                currentAssembly = Assembly.LoadFrom(ktxtAssemblyLocation.Text);
            }
            else
            {
                currentAssembly = Assembly.GetExecutingAssembly();
            }

            KryptonAboutBoxData data = new KryptonAboutBoxData() { CurrentAssembly = currentAssembly };

            KryptonAboutBox.Show(data);
        }

        private void kcBrowseForAssembly_Execute(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(ktxtAssemblyLocation.Text))
            {

            }

            KryptonOpenFileDialog dialog = new KryptonOpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ktxtAssemblyLocation.Text = Path.GetFullPath(dialog.FileName);
            }
        }
    }
}
