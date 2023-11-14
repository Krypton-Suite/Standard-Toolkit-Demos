﻿#region BSD License
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

namespace CustomControlUsingRenderers
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void kryptonCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Switch to using a different global palette
            switch (kryptonCheckSet.CheckedIndex)
            {
                case 0:
                    kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
                    break;
                case 1:
                    kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
                    break;
                case 2:
                    kryptonManager.GlobalPalette = kryptonPaletteCustom;
                    break;
                case 3:
                    kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;
                    break;
                case 4:
                    kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;
                    break;
            }
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            // Update orientation of the MyUserControl to match radio buttons
            if (radioTop.Checked)
            {
                myUserControl1.Orientation = VisualOrientation.Top;
            }
            else if (radioBottom.Checked)
            {
                myUserControl1.Orientation = VisualOrientation.Bottom;
            }
            else if (radioLeft.Checked)
            {
                myUserControl1.Orientation = VisualOrientation.Left;
            }
            else if (radioRight.Checked)
            {
                myUserControl1.Orientation = VisualOrientation.Right;
            }
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e) =>
            // Toggle the enabled state of the custom control instance
            myUserControl1.Enabled = !myUserControl1.Enabled;

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }
}
