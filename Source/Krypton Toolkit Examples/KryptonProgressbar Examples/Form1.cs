using System;

using Krypton.Toolkit;

namespace KryptonScrollbarExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void knudHorizontal_ValueChanged(object sender, EventArgs e)
        {
            pbHorizontal.Value = (int)knudHorizontal.Value;
            pbHorizontal.Text = pbHorizontal.Value.ToString();
            pbVertical.Value = (int)knudHorizontal.Value;
            kryptonProgressBar1.Value = (int)knudHorizontal.Value;
            kryptonProgressBar2.Value = (int)knudHorizontal.Value;
            kryptonProgressBarToolStripItem1.Value = (int)knudHorizontal.Value;
        }
    }
}
