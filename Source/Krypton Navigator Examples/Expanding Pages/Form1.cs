#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
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

namespace ExpandingPages
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTopArrow_Click(object sender, EventArgs e)
        {
            // For the top navigator instance we will toggle the showing of 
            // the client area below the check button area. We also toggle 
            // the direction of the button spec arrow.

            if (navigatorTop.NavigatorMode == NavigatorMode.HeaderBarCheckButtonGroup)
            {
                navigatorTop.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly;
                buttonTopArrow.TypeRestricted = PaletteNavButtonSpecStyle.ArrowDown;
            }
            else
            {
                navigatorTop.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup;
                buttonTopArrow.TypeRestricted = PaletteNavButtonSpecStyle.ArrowUp;
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            // For the left navigator instance we will toggle the showing of 
            // the client area to the right of the check button area. We also 
            // toggle the direction of the button spec arrow.

            if (navigatorLeft.NavigatorMode == NavigatorMode.HeaderBarCheckButtonGroup)
            {
                navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly;
                buttonLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight;
            }
            else
            {
                navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup;
                buttonLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft;
            }
        }

        private void kryptonPaletteButtons_Click(object sender, EventArgs e)
        {
            // When the user presses one of the palette buttons we need to ensure
            // that if the containing page is showing as a popup that the popup
            // is then removed from display. So call DismissPopupPage to remove
            // the page from view. If the page is not showing as a popup then
            // the call does nothing.
            navigatorLeft.DismissPopups();
        }

        private void kryptonPalettes_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Change the palette depending on the selected button
            switch (kryptonPalettes.CheckedIndex)
            {
                case 0:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue;
                    break;
                case 1:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver;
                    break;
                case 2:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Black;
                    break;
                case 3:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
                    break;
                case 4:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003;
                    break;
                case 5:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue;
                    break;
                case 6:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Black;
                    break;
                case 7:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Silver;
                    break;
                case 8:
                    kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue;
                    break;

            }
        }
    }
}
