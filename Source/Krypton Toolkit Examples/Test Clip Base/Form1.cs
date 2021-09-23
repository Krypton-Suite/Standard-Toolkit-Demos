// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved.
// *****************************************************************************

using System.Windows.Forms;

namespace Test_Clip_Base
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KryptonButton1_Click(object sender, System.EventArgs e)
        {
            kryptonButton1.Text = @"Changed";
            using var fm2 = new Form2();
            fm2.ShowDialog(this);
        }
    }
}
