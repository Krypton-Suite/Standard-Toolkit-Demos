using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace KryptonScrollBars
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ksbVertical_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            knudVertical.Value = ksbVertical.Value;
        }

        private void ksbHorizontal_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            knudHorizontal.Value = ksbHorizontal.Value;
        }

        private void knudVertical_ValueChanged(object sender, EventArgs e)
        {
            ksbVertical.Value = (int)knudVertical.Value;
        }

        private void knudHorizontal_ValueChanged(object sender, EventArgs e)
        {
            ksbHorizontal.Value = (int)knudHorizontal.Value;
        }
    }
}
