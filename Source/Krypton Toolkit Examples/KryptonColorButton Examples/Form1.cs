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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonColorButtonExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this color button
            propertyGrid.SelectedObject = new KryptonColorButtonProxy(blueSplitter);

        private void colorButtonEnter(object sender, EventArgs e) =>
            // Setup the property grid to edit this color button
            propertyGrid.SelectedObject = new KryptonColorButtonProxy(sender as KryptonColorButton);

        private void buttonClose_Click(object sender, EventArgs e) => Close();

        private void KryptonColorButton5_Click(object sender, EventArgs e)
        {
            if (KryptonMessageBox.Show(this,
                @"Do you want to perform the normal colourButtonAction ?",
                @"Launch what you want",
                KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) == DialogResult.Yes)
            {
                kryptonColorButton5.PerformDropDown();
            }
        }

        private void blueRight_Click(object sender, EventArgs e)
        {
            blueRight.AddUpdateRecentColors(new[] 
                { 
                    Color.Yellow, 
                    Color.YellowGreen, 
                    Color.GreenYellow, 
                    Color.LightGoldenrodYellow, 
                    Color.LightYellow, 
                    Color.PaleGoldenrod, 
                    Color.Gold, 
                    Color.Goldenrod 
                });
            blueRight.PerformDropDown();
        }
    }

    public class KryptonColorButtonProxy
    {
        private KryptonColorButton _colorButton;

        public KryptonColorButtonProxy(KryptonColorButton comboBox) => _colorButton = comboBox;

        [Category("Appearance")]
        [Description("Text for display inside the control.")]
        public string Text
        {
            get => _colorButton.Text;
            set => _colorButton.Text = value;
        }


        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _colorButton.Size;
            set => _colorButton.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _colorButton.Location;
            set => _colorButton.Location = value;
        }

        [Category("Behavior")]
        [Description("Determine the maximum number of recent colors to store and display.")]
        public int MaxRecentColors
        {
            get => _colorButton.MaxRecentColors;
            set => _colorButton.MaxRecentColors = value;
        }

        [Category("Behavior")]
        [Description("Determine the visible state of the themes color set.")]
        public bool VisibleThemes
        {
            get => _colorButton.VisibleThemes;
            set => _colorButton.VisibleThemes = value;
        }

        [Category("Behavior")]
        [Description("Determine the visible state of the standard color set.")]
        public bool VisibleStandard
        {
            get => _colorButton.VisibleStandard;
            set => _colorButton.VisibleStandard = value;
        }

        [Category("Behavior")]
        [Description("Determine the visible state of the recent color set.")]
        public bool VisibleRecent
        {
            get => _colorButton.VisibleRecent;
            set => _colorButton.VisibleRecent = value;
        }

        [Category("Behavior")]
        [Description("Determine if the 'No Color' menu item is used.")]
        public bool VisibleNoColor
        {
            get => _colorButton.VisibleNoColor;
            set => _colorButton.VisibleNoColor = value;
        }

        [Category("Behavior")]
        [Description("Determine if the 'More Colors...' menu item is used.")]
        public bool VisibleMoreColors
        {
            get => _colorButton.VisibleMoreColors;
            set => _colorButton.VisibleMoreColors = value;
        }

        [Category("Behavior")]
        [Description("Should recent colors be automatically updated.")]
        public bool AutoRecentColors
        {
            get => _colorButton.AutoRecentColors;
            set => _colorButton.AutoRecentColors = value;
        }

        [Category("Behavior")]
        [Description("Color scheme to use for the themes color set.")]
        public ColorScheme SchemeThemes
        {
            get => _colorButton.SchemeThemes;
            set => _colorButton.SchemeThemes = value;
        }

        [Category("Behavior")]
        [Description("Color scheme to use for the standard color set.")]
        public ColorScheme SchemeStandard
        {
            get => _colorButton.SchemeStandard;
            set => _colorButton.SchemeStandard = value;
        }

        [Category("Appearance")]
        [Description("Selected color.")]
        public Color SelectedColor
        {
            get => _colorButton.SelectedColor;
            set => _colorButton.SelectedColor = value;
        }

        [Category("Appearance")]
        [Description("Border color of selected block when selected color is empty.")]
        public Color EmptyBorderColor
        {
            get => _colorButton.EmptyBorderColor;
            set => _colorButton.EmptyBorderColor = value;
        }

        [Category("Appearance")]
        [Description("Selected color drawing rectangle.")]
        public Rectangle SelectedRect
        {
            get => _colorButton.SelectedRect;
            set => _colorButton.SelectedRect = value;
        }

        [Category("Visuals")]
        [Description("Context menu display strings.")]
        public PaletteColorButtonStrings Strings => _colorButton.Strings;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        public VisualOrientation ButtonOrientation
        {
            get => _colorButton.ButtonOrientation;
            set => _colorButton.ButtonOrientation = value;
        }

        [Category("Visuals")]
        [Description("Position of the drop arrow within the button.")]
        public VisualOrientation DropDownPosition
        {
            get => _colorButton.DropDownPosition;
            set => _colorButton.DropDownPosition = value;
        }

        [Category("Visuals")]
        [Description("Orientation of the drop arrow within the button.")]
        public VisualOrientation DropDownOrientation
        {
            get => _colorButton.DropDownOrientation;
            set => _colorButton.DropDownOrientation = value;
        }

        [Category("Visuals")]
        [Description("Determine if button acts as a splitter or just a drop down.")]
        public bool Splitter
        {
            get => _colorButton.Splitter;
            set => _colorButton.Splitter = value;
        }

        [Category("Visuals")]
        [Description("Button style.")]
        public ButtonStyle ButtonStyle
        {
            get => _colorButton.ButtonStyle;
            set => _colorButton.ButtonStyle = value;
        }

        [Category("Visuals")]
        [Description("Button values")]
        public ColorButtonValues Values => _colorButton.Values;

        [Category("Visuals")]
        [Description("Image value overrides.")]
        public DropDownButtonImages Images => _colorButton.Images;

        [Category("Visuals")]
        [Description("Overrides for defining common button appearance that other states can override.")]
        public PaletteTripleRedirect StateCommon => _colorButton.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled button appearance.")]
        public PaletteTriple StateDisabled => _colorButton.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance.")]
        public PaletteTriple StateNormal => _colorButton.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining hot tracking button appearance.")]
        public PaletteTriple StateTracking => _colorButton.StateTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed button appearance.")]
        public PaletteTriple StatePressed => _colorButton.StatePressed;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance when default.")]
        public PaletteTripleRedirect OverrideDefault => _colorButton.OverrideDefault;

        [Category("Visuals")]
        [Description("Overrides for defining button appearance when it has focus.")]
        public PaletteTripleRedirect OverrideFocus => _colorButton.OverrideFocus;
    }
}
