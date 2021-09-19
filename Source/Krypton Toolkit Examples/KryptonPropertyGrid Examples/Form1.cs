using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;
using System.Windows.Forms;

namespace KryptonPropertyGridExamples
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

        private void kbtnTest_Click(object sender, EventArgs e)
        {
            kpg.SelectedObject = kbtnTest;
        }

        private void kcbTest_Click(object sender, EventArgs e)
        {
            kpg.SelectedObject = kcbTest;
        }

        private void kcbtnTest_SelectedColorChanged(object sender, ColorEventArgs e)
        {

        }

        private void kcbtnTest_Click(object sender, EventArgs e)
        {
            kpg.SelectedObject = kcbTest;
        }

        private void kcmbTest_Click(object sender, EventArgs e)
        {
            kpg.SelectedObject = kcmbTest;
        }

        private void kdbtnTest_Click(object sender, EventArgs e)
        {
            kpg.SelectedObject = kdbtnTest;
        }

        private void ktxtTest_Click(object sender, EventArgs e)
        {
            kpg.SelectedObject = ktxtTest;
        }
    }
}
