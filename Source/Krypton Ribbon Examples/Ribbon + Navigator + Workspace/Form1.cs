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

using Krypton.Navigator;
using Krypton.Toolkit;
using Krypton.Workspace;

namespace RibbonAndNavigatorAndWorkspace
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            ButtonSpecClose.Enabled = false;
        }

        private void buttonSpecExpandCollapse_Click(object sender, EventArgs e)
        {
            // Are we currently showing fully expanded?
            if (navigatorOutlook.NavigatorMode == NavigatorMode.OutlookFull)
            {
                // Switch to mini mode and reverse direction of arrow
                navigatorOutlook.NavigatorMode = NavigatorMode.OutlookMini;
                buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight;
            }
            else
            {
                // Switch to full mode and reverse direction of arrow
                navigatorOutlook.NavigatorMode = NavigatorMode.OutlookFull;
                buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft;
            }
        }


        private void radioOffice2010Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Blue.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;
            }
        }

        private void radioOffice2010Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Silver.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;
            }
        }

        private void radioOffice2010Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2010Black.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;
            }
        }

        private void radioOffice2007Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Blue.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;
            }
        }

        private void radioOffice2007Silver_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Silver.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver;
            }
        }

        private void radioOffice2007Black_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2007Black.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black;
            }
        }

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOffice2003.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003;
            }
        }

        private void radioSparkleBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleBlue.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
            }
        }

        private void radioSparkleOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparkleOrange.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;
            }
        }

        private void radioSparklePurple_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSparklePurple.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple;
            }
        }

        private void radioSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSystem.Checked)
            {
                navigatorOutlook.DismissPopups();
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
            }
        }

        private void OnWorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            // Remove the close and context menu buttons from the navigator cell
            e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide;
            e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide;
            e.Cell.Button.CloseButtonAction = CloseButtonAction.None;

            // Update with currently requested mode
            UpdateCell(e.Cell);
        }

        private void OnDocumentModeChanged(object sender, EventArgs e)
        {
            // Kill any showing outlook poup page
            navigatorOutlook.DismissPopups();

            // Update each workspace cell
            KryptonWorkspaceCell cell = kryptonWorkspace.FirstCell();
            while (cell != null)
            {
                UpdateCell(cell);
                cell = kryptonWorkspace.NextCell(cell);
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }
        
        private void UpdateCell(KryptonWorkspaceCell cell)
        {
            NavigatorMode newMode = NavigatorMode.BarTabGroup;

            if (checkSetDocMode.CheckedButton == buttonTabs)
                newMode = NavigatorMode.BarTabGroup;
            else if (checkSetDocMode.CheckedButton == buttonRibbonTabs)
                newMode = NavigatorMode.BarRibbonTabGroup;
            else if (checkSetDocMode.CheckedButton == buttonCheckButtons)
                newMode = NavigatorMode.BarCheckButtonGroupOutside;
            else if (checkSetDocMode.CheckedButton == buttonHeaderGroup)
                newMode = NavigatorMode.HeaderGroup;
            else if (checkSetDocMode.CheckedButton == buttonHeaderBar)
                newMode = NavigatorMode.HeaderBarCheckButtonHeaderGroup;
            else if (checkSetDocMode.CheckedButton == buttonStack)
                newMode = NavigatorMode.StackCheckButtonGroup;

            cell.NavigatorMode = newMode;

            // Set mode specific properties
            switch (newMode)
            {
                case NavigatorMode.BarRibbonTabGroup:
                case NavigatorMode.BarRibbonTabOnly:
                    cell.PageBackStyle = PaletteBackStyle.ControlRibbon;
                    cell.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon;
                    cell.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon;
                    break;
                default:
                    cell.PageBackStyle = PaletteBackStyle.ControlClient;
                    cell.Group.GroupBackStyle = PaletteBackStyle.ControlClient;
                    cell.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient;
                    break;
            }
        }
    }
}
