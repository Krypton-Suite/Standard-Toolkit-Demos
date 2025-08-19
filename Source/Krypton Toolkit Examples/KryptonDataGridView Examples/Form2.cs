// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
// By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2021 - 2025. All rights reserved.
// *****************************************************************************

using Krypton.Toolkit;

namespace KryptonDataGridViewExamples
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();
            kryptonDataGridView1.Rows.Add(@"1", @"Test Btn", true);

            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));

            var iconSpec1 = new Krypton.Toolkit.IconSpec
            {
                Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Right,
                Icon = resources.GetObject("iconSpec1.Icon") as System.Drawing.Image
            };

            Button.IconSpecs.Add(iconSpec1);

        }
    }
}
