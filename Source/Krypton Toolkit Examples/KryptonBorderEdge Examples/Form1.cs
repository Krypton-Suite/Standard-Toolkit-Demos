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

namespace KryptonBorderEdgeExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this border edge
            propertyGrid.SelectedObject = new KryptonBorderEdgeProxy(borderEdgeH1);

        private void buttonOffice2010Blue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalCustomPalette = kryptonPaletteOffice2010Blue;
            propertyGrid.SelectedObject = kryptonPaletteOffice2010Blue;
        }

        private void buttonOffice2007Blue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalCustomPalette = kryptonPaletteOffice2007Blue;
            propertyGrid.SelectedObject = kryptonPaletteOffice2007Blue;
        }

        private void buttonSparkle_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalCustomPalette = kryptonPaletteSparkle;
            propertyGrid.SelectedObject = kryptonPaletteSparkle;
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalCustomPalette = kryptonPaletteSystem;
            propertyGrid.SelectedObject = kryptonPaletteSystem;
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalCustomPalette = kryptonPaletteCustom;
            propertyGrid.SelectedObject = kryptonPaletteCustom;
        }

        private void button_Enter(object sender, EventArgs e) =>
            // Setup the property grid to edit this button
            propertyGrid.SelectedObject = new KryptonButtonProxy(sender as KryptonButton);

        private void checkButton_Enter(object sender, EventArgs e) =>
            // Setup the property grid to edit this check button
            propertyGrid.SelectedObject = new KryptonCheckButtonProxy(sender as KryptonCheckButton);

        private void borderEdge_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this border edge
            propertyGrid.SelectedObject = new KryptonBorderEdgeProxy(sender as KryptonBorderEdge);

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonButtonProxy
    {
        private KryptonButton _button;

        public KryptonButtonProxy(KryptonButton button) => _button = button;

        [Category("Visuals")]
        [Description("Button style.")]
        [DefaultValue(ButtonStyle.Standalone)]
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
        [DefaultValue(VisualOrientation.Top)]
        public VisualOrientation Orientation
        {
            get => _button.Orientation;
            set => _button.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(PaletteMode.Global)]
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
        [DefaultValue(AutoSizeMode.GrowOnly)]
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

    public class KryptonBorderEdgeProxy
    {
        private KryptonBorderEdge _borderEdge;

        public KryptonBorderEdgeProxy(KryptonBorderEdge borderEdge) => _borderEdge = borderEdge;

        [Category("Visuals")]
        [Description("Border style.")]
        [DefaultValue(PaletteBorderStyle.ControlClient)]
        public PaletteBorderStyle BorderStyle
        {
            get => _borderEdge.BorderStyle;
            set => _borderEdge.BorderStyle = value;
        }

        [Category("Visuals")]
        [Description("Overrides for defining common border edge appearance that other states can override.")]
        public PaletteBorderEdgeRedirect StateCommon => _borderEdge.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled border edge appearance.")]
        public PaletteBorderEdge StateDisabled => _borderEdge.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal border edge appearance.")]
        public PaletteBorderEdge StateNormal => _borderEdge.StateNormal;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        [DefaultValue(Orientation.Horizontal)]
        public Orientation Orientation
        {
            get => _borderEdge.Orientation;
            set => _borderEdge.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(PaletteMode.Global)]
        public PaletteMode PaletteMode
        {
            get => _borderEdge.PaletteMode;
            set => _borderEdge.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        [DefaultValue(false)]
        public bool AutoSize
        {
            get => _borderEdge.AutoSize;
            set => _borderEdge.AutoSize = value;
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        [DefaultValue(AutoSizeMode.GrowOnly)]
        public AutoSizeMode AutoSizeMode
        {
            get => _borderEdge.AutoSizeMode;
            set => _borderEdge.AutoSizeMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _borderEdge.Size;
            set => _borderEdge.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _borderEdge.Location;
            set => _borderEdge.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _borderEdge.Enabled;
            set => _borderEdge.Enabled = value;
        }
    }
}
