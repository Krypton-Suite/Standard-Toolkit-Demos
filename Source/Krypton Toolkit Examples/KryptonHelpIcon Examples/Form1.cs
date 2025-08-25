// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2021 - 2025. All rights reserved.
// *****************************************************************************

using System;

using Krypton.Toolkit;

namespace KryptonHelpIconExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            bsHelpIcon.Click += BsHelpIcon_Click;
        }

        private void BsHelpIcon_Click(object? sender, EventArgs e) =>
            KryptonMessageBox.Show("You have requested help... Please enter your code here.", "Help Demo",
                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
