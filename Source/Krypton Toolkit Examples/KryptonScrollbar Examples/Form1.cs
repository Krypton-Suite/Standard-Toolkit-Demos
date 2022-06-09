using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace KryptonScrollbarExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ksbVertical_Scroll(object sender, ScrollEventArgs e)
        {
            knudVertical.Value = ksbVertical.Value;

            pbVertical.Value = ksbVertical.Value;
        }

        private void ksbHorizontal_Scroll(object sender, ScrollEventArgs e)
        {
            knudHorizontal.Value = ksbHorizontal.Value;

            pbHorizontal.Value = ksbHorizontal.Value;
        }

        private void knudHorizontal_ValueChanged(object sender, EventArgs e)
        {
            ksbHorizontal.Value = (int)knudHorizontal.Value;

            pbHorizontal.Value = ksbHorizontal.Value;
        }

        private void knudVertical_ValueChanged(object sender, EventArgs e)
        {
            ksbVertical.Value = (int)knudVertical.Value;

            pbVertical.Value = ksbVertical.Value;
        }
    }
}
