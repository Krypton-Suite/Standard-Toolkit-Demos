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

namespace PerTabButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addContext_Click(this, EventArgs.Empty);
            kryptonNavigator.SelectedIndex = 1;
            addArrow_Click(this, EventArgs.Empty);
            kryptonNavigator.SelectedIndex = 2;
            addText_Click(this, EventArgs.Empty);
            kryptonNavigator.SelectedIndex = 0;

            UpdateControlsFromNavigator();
        }

        private void UpdateControlsFromNavigator()
        {
            // Update Mode
            radioModeTabs.Checked = (kryptonNavigator.NavigatorMode == NavigatorMode.BarTabGroup);
            radioModeRibbonTabs.Checked = (kryptonNavigator.NavigatorMode == NavigatorMode.BarRibbonTabGroup);
            radioModesCheckButton.Checked = (kryptonNavigator.NavigatorMode == NavigatorMode.BarCheckButtonGroupOutside);
            radioModesStack.Checked = (kryptonNavigator.NavigatorMode == NavigatorMode.StackCheckButtonGroup);
            radioModesOutlook.Checked = (kryptonNavigator.NavigatorMode == NavigatorMode.OutlookFull);

            // Set mode specific properties
            switch (kryptonNavigator.NavigatorMode)
            {
                case NavigatorMode.BarRibbonTabGroup:
                case NavigatorMode.BarRibbonTabOnly:
                    kryptonNavigator.PageBackStyle = PaletteBackStyle.ControlRibbon;
                    kryptonNavigator.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon;
                    kryptonNavigator.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon;
                    break;
                default:
                    kryptonNavigator.PageBackStyle = PaletteBackStyle.ControlClient;
                    kryptonNavigator.Group.GroupBackStyle = PaletteBackStyle.ControlClient;
                    kryptonNavigator.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient;
                    break;
            }
        }

        private void radioModeTabs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModeTabs.Checked)
            {
                kryptonNavigator.NavigatorMode = NavigatorMode.BarTabGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModeRibbonTabs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModeRibbonTabs.Checked)
            {
                kryptonNavigator.NavigatorMode = NavigatorMode.BarRibbonTabGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModesCheckButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModesCheckButton.Checked)
            {
                kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModesStack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModesStack.Checked)
            {
                kryptonNavigator.NavigatorMode = NavigatorMode.StackCheckButtonGroup;
                UpdateControlsFromNavigator();
            }
        }

        private void radioModesOutlook_CheckedChanged(object sender, EventArgs e)
        {
            if (radioModesOutlook.Checked)
            {
                kryptonNavigator.NavigatorMode = NavigatorMode.OutlookFull;
                UpdateControlsFromNavigator();
            }
        }

        private void addContext_Click(object sender, EventArgs e)
        {
            if (kryptonNavigator.SelectedPage != null)
            {
                ButtonSpecAny bsa = new ButtonSpecAny();
                bsa.Type = PaletteButtonSpecStyle.Context;
                bsa.Style = PaletteButtonStyle.Standalone;
                bsa.KryptonContextMenu = kryptonContextMenu;
                bsa.Tag = kryptonNavigator.SelectedPage;
                kryptonNavigator.SelectedPage.ButtonSpecs.Add(bsa);
            }
        }

        private void addText_Click(object sender, EventArgs e)
        {
            if (kryptonNavigator.SelectedPage != null)
            {
                ButtonSpecAny bsa = new ButtonSpecAny();
                bsa.Style = PaletteButtonStyle.Standalone;
                bsa.Text = DateTime.Now.Millisecond.ToString();
                bsa.Tag = kryptonNavigator.SelectedPage;
                kryptonNavigator.SelectedPage.ButtonSpecs.Add(bsa);
            }
        }

        private void addArrow_Click(object sender, EventArgs e)
        {
            if (kryptonNavigator.SelectedPage != null)
            {
                ButtonSpecAny bsa = new ButtonSpecAny();
                bsa.Style = PaletteButtonStyle.Alternate;
                bsa.Type = PaletteButtonSpecStyle.ArrowRight;
                bsa.Tag = kryptonNavigator.SelectedPage;
                kryptonNavigator.SelectedPage.ButtonSpecs.Add(bsa);
            }
        }

        private void clearButtons_Click(object sender, EventArgs e)
        {
            if (kryptonNavigator.SelectedPage != null)
                kryptonNavigator.SelectedPage.ButtonSpecs.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
