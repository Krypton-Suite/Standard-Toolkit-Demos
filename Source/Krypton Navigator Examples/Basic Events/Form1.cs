﻿#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved. 
 *  
 */
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Navigator;
using Krypton.Toolkit;

namespace BasicEvents
{
    public partial class Form1 : Form
    {
        private int _count = 3;


        public Form1()
        {
            InitializeComponent();

            // Monitor changes in the pages collection
            kryptonNavigator1.Pages.Inserted += new TypedHandler<KryptonPage>(OnPageInsertRemove);
            kryptonNavigator1.Pages.Removed += new TypedHandler<KryptonPage>(OnPageInsertRemove);
            kryptonNavigator1.Pages.Cleared += new EventHandler(OnPagesCleared);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial state of the buttons
            UpdateButtonState();
        }

        private void kryptonButtonAdd_Click(object sender, EventArgs e)
        {
            // Create a new krypton page
            KryptonPage newPage = new KryptonPage();

            // Populate with text and image
            newPage.Text = "Page " + _count.ToString();
            newPage.TextTitle = "Page " + _count.ToString() + " Title";
            newPage.TextDescription = "Page " + _count.ToString() + " Description";
            newPage.ImageSmall = (Bitmap)imageList1.Images[_count % imageList1.Images.Count];
            _count++;

            // Append to end of the pages collection
            kryptonNavigator1.Pages.Add(newPage);

            // Select the new page
            kryptonNavigator1.SelectedPage = newPage;
        }

        private void kryptonButtonRemove_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.Pages.Remove(kryptonNavigator1.SelectedPage);
        }

        private void kryptonButtonClear_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.Pages.Clear();
        }

        private void kryptonButtonEnable_Click(object sender, EventArgs e)
        {
            kryptonNavigator1.SelectedPage.Enabled = !kryptonNavigator1.SelectedPage.Enabled;
            UpdateButtonState();
        }

        void OnPagesCleared(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        void OnPageInsertRemove(object sender, TypedCollectionEventArgs<KryptonPage> e)
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            // Can only remove if a page is selected
            kryptonButtonRemove.Enabled = (kryptonNavigator1.SelectedPage != null);

            // Can only clear if there is at least one page in collection
            kryptonButtonClear.Enabled = (kryptonNavigator1.Pages.Count > 0);

            // Can only change enabled state if a button is selected
            kryptonButtonEnable.Enabled = (kryptonNavigator1.SelectedPage != null);

            // Only update the enabled button text if the button is itself enabled
            if (kryptonButtonEnable.Enabled)
            {
                // Give text to indicate the enabled state will be toggled
                if (kryptonNavigator1.SelectedPage.Enabled)
                    kryptonButtonEnable.Text = "Disable";
                else
                    kryptonButtonEnable.Text = "Enable";
            }
        }

        private void kryptonNavigator1_Deselected(object sender, KryptonPageEventArgs e)
        {
            AddOutput("Deselected \t\t '" + e.Item.Text + "'");
        }

        private void kryptonNavigator1_Deselecting(object sender, KryptonPageCancelEventArgs e)
        {
            AddOutput("Deselecting \t\t '" + e.Item.Text + "'");
        }

        private void kryptonNavigator1_Selected(object sender, KryptonPageEventArgs e)
        {
            AddOutput("Selected \t\t '" + e.Item.Text + "'");
        }

        private void kryptonNavigator1_Selecting(object sender, KryptonPageCancelEventArgs e)
        {
            AddOutput("Selecting \t\t '" + e.Item.Text + "'");
        }

        private void kryptonNavigator1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (kryptonNavigator1.SelectedPage == null)
                AddOutput("SelectedPageChanged \t (null)");
            else
                AddOutput("SelectedPageChanged \t '" + kryptonNavigator1.SelectedPage.Text + "'");

            UpdateButtonState();
        }

        private void kryptonNavigator1_CloseAction(object sender, CloseActionEventArgs e)
        {
            AddOutput("CloseAction");
        }

        private void kryptonNavigator1_ContextAction(object sender, ContextActionEventArgs e)
        {
            AddOutput("ContextAction");
        }

        private void kryptonNavigator1_NextAction(object sender, DirectionActionEventArgs e)
        {
            AddOutput("NextAction");
        }

        private void kryptonNavigator1_PreviousAction(object sender, DirectionActionEventArgs e)
        {
            AddOutput("PreviousAction");
        }

        private void buttonClearEventList_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
        }

        private void AddOutput(string output)
        {
            listBoxEvents.Items.Add(output);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
