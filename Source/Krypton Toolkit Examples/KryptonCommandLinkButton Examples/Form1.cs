using Krypton.Toolkit;

namespace KryptonCommandLinkButtonExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, System.EventArgs e) => kpgButtons.SelectedObject = kryptonAlternateCommandLinkButton1;

        private void kryptonAlternateCommandLinkButton1_Click(object sender, System.EventArgs e) => kpgButtons.SelectedObject = kryptonAlternateCommandLinkButton1;

        private void kryptonCommandLinkButton1_Click(object sender, System.EventArgs e) => kpgButtons.SelectedObject = kryptonCommandLinkButton1;

        private void kryptonCommandLinkButton2_Click(object sender, System.EventArgs e) => kpgButtons.SelectedObject = kryptonCommandLinkButton2;

        private void kryptonCommandLinkButton3_Click(object sender, System.EventArgs e) => kpgButtons.SelectedObject = kryptonCommandLinkButton3;

        private void kryptonCommandLinkButton4_Click(object sender, System.EventArgs e) => kpgButtons.SelectedObject = kryptonCommandLinkButton4;

        private void kryptonCommandLinkButton5_Click(object sender, System.EventArgs e) => kpgButtons.SelectedObject = kryptonCommandLinkButton5;

        private void kbtOk_Click(object sender, System.EventArgs e) => Close();
    }
}
