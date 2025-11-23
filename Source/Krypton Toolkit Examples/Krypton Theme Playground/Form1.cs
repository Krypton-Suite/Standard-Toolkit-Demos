// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2022 - 2024. All rights reserved.
// *****************************************************************************

using System;

using Krypton.Toolkit;

namespace KryptonThemePlayground
{
    public partial class Form1 : KryptonForm
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonCheckedListBox1_SelectedIndexChanged(object sender, EventArgs e) => kpg.SelectedObject = kryptonCheckedListBox1;
    }
}
