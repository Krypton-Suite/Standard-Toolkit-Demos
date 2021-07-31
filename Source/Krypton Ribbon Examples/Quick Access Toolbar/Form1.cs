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
using System.Drawing;

using Krypton.Ribbon;
using Krypton.Toolkit;

namespace QuickAccessToolbar
{
    public partial class Form1 : KryptonForm
    {
        private int _count = 0;

        private Image[] _images = new Image[]{  global::QuickAccessToolbar.Properties.Resources.flag_australia,
                                                global::QuickAccessToolbar.Properties.Resources.flag_cameroon,
                                                global::QuickAccessToolbar.Properties.Resources.flag_canada,
                                                global::QuickAccessToolbar.Properties.Resources.flag_czech_republic,
                                                global::QuickAccessToolbar.Properties.Resources.flag_egypt,
                                                global::QuickAccessToolbar.Properties.Resources.flag_france,
                                                global::QuickAccessToolbar.Properties.Resources.flag_hong_kong,
                                                global::QuickAccessToolbar.Properties.Resources.flag_italy,
                                                global::QuickAccessToolbar.Properties.Resources.flag_lithuania,
                                                global::QuickAccessToolbar.Properties.Resources.flag_new_zealand,
                                                global::QuickAccessToolbar.Properties.Resources.flag_peru,
                                                global::QuickAccessToolbar.Properties.Resources.flag_wales  };

        private string[] _names = new string[]{ "Australia", "Cameroon", "Canada",
                                                "Czech Republic", "Egypt", "France",
                                                "Hong Kong", "Italy", "Lithuania",
                                                "New Zealand", "Peru", "Wales" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonAdd_Click(this, EventArgs.Empty);
            buttonAdd_Click(this, EventArgs.Empty);
            buttonAdd_Click(this, EventArgs.Empty);
        }

        private void checkSetQATPosition_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSetQATPosition.CheckedButton == checkButtonAbove)
                kryptonRibbon.QATLocation = QATLocation.Above;
            else if (checkSetQATPosition.CheckedButton == checkButtonBelow)
                kryptonRibbon.QATLocation = QATLocation.Below;
            else if (checkSetQATPosition.CheckedButton == checkButtonHidden)
                kryptonRibbon.QATLocation = QATLocation.Hidden;
        }

        private void checkSetQATUserChange_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (checkSetQATUserChange.CheckedButton == checkButtonAllowUserChanges)
                kryptonRibbon.QATUserChange = true;
            else if (checkSetQATUserChange.CheckedButton == checkButtonDisallowUserChanges)
                kryptonRibbon.QATUserChange = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            KryptonRibbonQATButton qatButton = new KryptonRibbonQATButton();
            qatButton.Text = _names[_count];
            qatButton.Image = _images[_count];
            _count = (++_count % 12);
            kryptonRibbon.QATButtons.Add(qatButton);

            UpdateButtons();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (kryptonRibbon.QATButtons.Count > 0)
                kryptonRibbon.QATButtons.RemoveAt(0);

            UpdateButtons();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            kryptonRibbon.QATButtons.Clear();
            UpdateButtons();
        }
        
        private void UpdateButtons()
        {
            bool enable = (kryptonRibbon.QATButtons.Count > 0);
            buttonRemove.Enabled = enable;
            buttonClear.Enabled = enable;
        }

        private void appMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
