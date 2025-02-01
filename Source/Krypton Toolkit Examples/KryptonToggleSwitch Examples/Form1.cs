// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV) & Giduac 2025 - 2025. All rights reserved.
// *****************************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

using KryptonToggleSwitchExamples.Properties;

namespace KryptonToggleSwitchExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            using (var ms = new System.IO.MemoryStream(Resources.Krypton))
            {
                Icon = new Icon(ms);
            }
        }

        private void ktsTest_CheckedChanged(object sender, EventArgs e) => kryptonWrapLabel1.Text = $@"Is toggle switch checked: {ktsTest.Checked}";

        private void Form1_Load(object sender, EventArgs e)
        {
            kryptonWrapLabel1.Text = $@"Is toggle switch checked: {ktsTest.Checked}";
        }

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
