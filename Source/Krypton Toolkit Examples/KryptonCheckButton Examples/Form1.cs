#region BSD License
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
using System.ComponentModel;
using Krypton.Toolkit;

namespace KryptonCheckButtonExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this button
            propertyGrid.SelectedObject = new KryptonCheckButtonProxy(button1Sparkle);

        private void checkButton_Enter(object sender, EventArgs e) =>
            // Setup the property grid to edit this button
            propertyGrid.SelectedObject = new KryptonCheckButtonProxy(sender as KryptonCheckButton);

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonCheckButtonProxy
    {
        private KryptonCheckButton _checkButton;

        public KryptonCheckButtonProxy(KryptonCheckButton checkButton) => _checkButton = checkButton;

        [Category("Visuals")]
        [Description("Button style.")]
        [DefaultValue(ButtonStyle.Standalone)]
        public ButtonStyle ButtonStyle
        {
            get => _checkButton.ButtonStyle;
            set => _checkButton.ButtonStyle = value;
        }

        [Category("Visuals")]
        [Description("Button values")]
        public ButtonValues Values => _checkButton.Values;

        [Category("Visuals")]
        [Description("Overrides for defining common button appearance that other states can override.")]
        public PaletteTripleRedirect StateCommon => _checkButton.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled button appearance.")]
        public PaletteTriple StateDisabled => _checkButton.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance.")]
        public PaletteTriple StateNormal => _checkButton.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining hot tracking button appearance.")]
        public PaletteTriple StateTracking => _checkButton.StateTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed button appearance.")]
        public PaletteTriple StatePressed => _checkButton.StatePressed;

        [Category("Visuals")]
        [Description("Overrides for defining normal checked button appearance.")]
        public PaletteTriple StateCheckedNormal => _checkButton.StateCheckedNormal;

        [Category("Visuals")]
        [Description("Overrides for defining hot tracking checked button appearance.")]
        public PaletteTriple StateCheckedTracking => _checkButton.StateCheckedTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed checked button appearance.")]
        public PaletteTriple StateCheckedPressed => _checkButton.StateCheckedPressed;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance when default.")]
        public PaletteTripleRedirect OverrideDefault => _checkButton.OverrideDefault;

        [Category("Visuals")]
        [Description("Overrides for defining button appearance when it has focus.")]
        public PaletteTripleRedirect OverrideFocus => _checkButton.OverrideFocus;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        [DefaultValue(VisualOrientation.Top)]
        public VisualOrientation Orientation
        {
            get => _checkButton.Orientation;
            set => _checkButton.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(PaletteMode.Global)]
        public PaletteMode PaletteMode
        {
            get => _checkButton.PaletteMode;
            set => _checkButton.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        [DefaultValue(false)]
        public bool AutoSize
        {
            get => _checkButton.AutoSize;
            set => _checkButton.AutoSize = value;
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        [DefaultValue(AutoSizeMode.GrowOnly)]
        public AutoSizeMode AutoSizeMode
        {
            get => _checkButton.AutoSizeMode;
            set => _checkButton.AutoSizeMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _checkButton.Size;
            set => _checkButton.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _checkButton.Location;
            set => _checkButton.Location = value;
        }

        [Category("Appearance")]
        [Description("Indicates whether the control is in the checked state.")]
        public bool Checked
        {
            get => _checkButton.Checked;
            set => _checkButton.Checked = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _checkButton.Enabled;
            set => _checkButton.Enabled = value;
        }
    }
}
