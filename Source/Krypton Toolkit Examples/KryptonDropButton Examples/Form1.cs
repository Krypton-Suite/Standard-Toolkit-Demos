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
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Krypton.Toolkit;

namespace KryptonDropButtonExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this drop down
            propertyGrid.SelectedObject = new KryptonDropButtonProxy(splitterPosRight);

        private void dropButtonEnter(object sender, EventArgs e) =>
            // Setup the property grid to edit this drop down
            propertyGrid.SelectedObject = new KryptonDropButtonProxy(sender as KryptonDropButton);

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonDropButtonProxy
    {
        private KryptonDropButton _dropDown;

        public KryptonDropButtonProxy(KryptonDropButton comboBox) => _dropDown = comboBox;

        [Category("Appearance")]
        [Description("Text for display inside the control.")]
        public string Text
        {
            get => _dropDown.Text;
            set => _dropDown.Text = value;
        }


        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _dropDown.Size;
            set => _dropDown.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _dropDown.Location;
            set => _dropDown.Location = value;
        }

        [Category("Behavior")]
        [Description("The shortcut menu to show when the user right-clicks the page.")]
        public KryptonContextMenu KryptonContextMenu => _dropDown.KryptonContextMenu;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        public VisualOrientation ButtonOrientation
        {
            get => _dropDown.ButtonOrientation;
            set => _dropDown.ButtonOrientation = value;
        }

        [Category("Visuals")]
        [Description("Position of the drop arrow within the button.")]
        public VisualOrientation DropDownPosition
        {
            get => _dropDown.DropDownPosition;
            set => _dropDown.DropDownPosition = value;
        }

        [Category("Visuals")]
        [Description("Orientation of the drop arrow within the button.")]
        public VisualOrientation DropDownOrientation
        {
            get => _dropDown.DropDownOrientation;
            set => _dropDown.DropDownOrientation = value;
        }

        [Category("Visuals")]
        [Description("Determine if button acts as a splitter or just a drop down.")]
        public bool Splitter
        {
            get => _dropDown.Splitter;
            set => _dropDown.Splitter = value;
        }

        [Category("Visuals")]
        [Description("Button style.")]
        public ButtonStyle ButtonStyle
        {
            get => _dropDown.ButtonStyle;
            set => _dropDown.ButtonStyle = value;
        }

        [Category("Visuals")]
        [Description("Button values")]
        public ButtonValues Values => _dropDown.Values;

        [Category("Visuals")]
        [Description("Image value overrides.")]
        public DropDownButtonImages Images => _dropDown.Images;

        [Category("Visuals")]
        [Description("Overrides for defining common button appearance that other states can override.")]
        public PaletteTripleRedirect StateCommon => _dropDown.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled button appearance.")]
        public PaletteTriple StateDisabled => _dropDown.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance.")]
        public PaletteTriple StateNormal => _dropDown.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining hot tracking button appearance.")]
        public PaletteTriple StateTracking => _dropDown.StateTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed button appearance.")]
        public PaletteTriple StatePressed => _dropDown.StatePressed;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance when default.")]
        public PaletteTripleRedirect OverrideDefault => _dropDown.OverrideDefault;

        [Category("Visuals")]
        [Description("Overrides for defining button appearance when it has focus.")]
        public PaletteTripleRedirect OverrideFocus => _dropDown.OverrideFocus;
    }
}
