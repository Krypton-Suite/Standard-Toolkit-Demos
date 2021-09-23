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
using System.Windows.Forms;
using System.ComponentModel;
using Krypton.Toolkit;

namespace KryptonButtonExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this button
            propertyGrid.SelectedObject = new KryptonButtonProxy(button1Sparkle);

        private void button_Enter(object sender, EventArgs e)
        {
            // Setup the property grid to edit this button
            if (sender is KryptonButton kb )
                propertyGrid.SelectedObject = new KryptonButtonProxy(kb);
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonButtonProxy
    {
        private KryptonButton _button;

        public KryptonButtonProxy(KryptonButton button) => _button = button;

        [Category("Visuals")]
        [Description("Button style.")]
        [DefaultValue(typeof(ButtonStyle), "Standalone")]
        public ButtonStyle ButtonStyle
        {
            get => _button.ButtonStyle;
            set => _button.ButtonStyle = value;
        }

        [Category("Visuals")]
        [Description("Button values")]
        public ButtonValues Values => _button.Values;

        [Category("Visuals")]
        [Description("Overrides for defining common button appearance that other states can override.")]
        public PaletteTripleRedirect StateCommon => _button.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled button appearance.")]
        public PaletteTriple StateDisabled => _button.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance.")]
        public PaletteTriple StateNormal => _button.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining hot tracking button appearance.")]
        public PaletteTriple StateTracking => _button.StateTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed button appearance.")]
        public PaletteTriple StatePressed => _button.StatePressed;

        [Category("Visuals")]
        [Description("Overrides for defining normal button appearance when default.")]
        public PaletteTripleRedirect OverrideDefault => _button.OverrideDefault;

        [Category("Visuals")]
        [Description("Overrides for defining button appearance when it has focus.")]
        public PaletteTripleRedirect OverrideFocus => _button.OverrideFocus;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        [DefaultValue(typeof(VisualOrientation), "Top")]
        public VisualOrientation Orientation
        {
            get => _button.Orientation;
            set => _button.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get => _button.PaletteMode;
            set => _button.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        [DefaultValue(false)]
        public bool AutoSize
        {
            get => _button.AutoSize;
            set => _button.AutoSize = value;
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        [DefaultValue(typeof(AutoSizeMode), "GrowOnly")]
        public AutoSizeMode AutoSizeMode
        {
            get => _button.AutoSizeMode;
            set => _button.AutoSizeMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _button.Size;
            set => _button.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _button.Location;
            set => _button.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _button.Enabled;
            set => _button.Enabled = value;
        }
    }
}
