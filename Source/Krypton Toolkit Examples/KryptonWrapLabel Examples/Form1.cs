#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 */
#endregion

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonWrapLabelExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => propertyGrid.SelectedObject = kryptonWrapLabel;

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            kryptonWrapLabel.LabelStyle = LabelStyle.NormalControl;
            propertyGrid.SelectedObject = kryptonWrapLabel;
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            kryptonWrapLabel.LabelStyle = LabelStyle.TitleControl;
            propertyGrid.SelectedObject = kryptonWrapLabel;
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();

        private void klwlblTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KryptonMessageBox.Show(@"Hello world!", @"Test", KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information);
        }
    }
}
