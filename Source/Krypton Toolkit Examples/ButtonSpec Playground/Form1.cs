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
using System.Windows.Forms;

using Krypton.Toolkit;

namespace ButtonSpecPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButtonAdd_Click(object sender, EventArgs e)
        {
            // Create a new button spec entry
            ButtonSpecHeaderGroup spec = new ButtonSpecHeaderGroup();
            spec.Type = PaletteButtonSpecStyle.Close;

            // Need to know when button is selected
            spec.Click += new EventHandler(OnButtonSelected);
            
            // Add to end of the collection of button specs
            kryptonHeaderGroup1.ButtonSpecs.Add(spec);

            // Make it the selected button spec
            propertyGrid.SelectedObject = spec;

            UpdateActionButtons();
        }

        private void kryptonButtonRemove_Click(object sender, EventArgs e)
        {
            // Get access to the selected button spec
            ButtonSpecHeaderGroup spec = (ButtonSpecHeaderGroup)propertyGrid.SelectedObject;

            // Remove just the selected button spec
            kryptonHeaderGroup1.ButtonSpecs.Remove(spec);

            // Nothing selected in the property grid
            propertyGrid.SelectedObject = null;

            UpdateActionButtons();
        }

        private void kryptonButtonClear_Click(object sender, EventArgs e)
        {
            // Remove all the button specifications
            kryptonHeaderGroup1.ButtonSpecs.Clear();

            // Nothing selected in the property grid
            propertyGrid.SelectedObject = null;

            UpdateActionButtons();
        }

        private void kryptonButtonTopP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Top;
        }

        private void kryptonButtonLeftP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Left;
        }

        private void kryptonButtonRightP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Right;
        }

        private void kryptonButtonBottomP_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Bottom;
        }

        private void kryptonButtonTopS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Top;
        }

        private void kryptonButtonLeftS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Left;
        }

        private void kryptonButtonRightS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Right;
        }

        private void kryptonButtonBottomS_Click(object sender, EventArgs e)
        {
            kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Bottom;
        }

        private void OnButtonSelected(object sender, EventArgs e)
        {
            // Cast to correct type
            ButtonSpecHeaderGroup spec = (ButtonSpecHeaderGroup)sender;

            // Make it the selected button spec
            propertyGrid.SelectedObject = spec;

            UpdateActionButtons();
        }
        
        private void UpdateActionButtons()
        {
            kryptonButtonRemove.Enabled = (propertyGrid.SelectedObject != null);
            kryptonButtonClear.Enabled = (kryptonHeaderGroup1.ButtonSpecs.Count > 0);
        }
    }
}
