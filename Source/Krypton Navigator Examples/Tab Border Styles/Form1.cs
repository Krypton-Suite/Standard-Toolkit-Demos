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
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using Krypton.Toolkit;
using Krypton.Navigator;

namespace TabBorderStyles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabBorderStyles_CheckedChanged(object sender, EventArgs e)
        {
            // Cast to correct type
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                TabBorderStyle enumVal = (TabBorderStyle)Enum.Parse(typeof(TabBorderStyle), rb.Tag.ToString());
                kryptonNavigator.Bar.TabBorderStyle = enumVal;
            }
        }

        private void tabStyles_CheckedChanged(object sender, EventArgs e)
        {
            // Cast to correct type
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                TabStyle enumVal = (TabStyle)Enum.Parse(typeof(TabStyle), rb.Tag.ToString());
                kryptonNavigator.Bar.TabStyle = enumVal;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
