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

namespace KryptonLinkLabelExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this label
            propertyGrid.SelectedObject = new KryptonLinkLabelProxy(label2Professional);

        private void kryptonLabel_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this label
            propertyGrid.SelectedObject = new KryptonLinkLabelProxy(sender as KryptonLinkLabel);

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonLinkLabelProxy
    {
        private KryptonLinkLabel _label;

        public KryptonLinkLabelProxy(KryptonLinkLabel label) => _label = label;

        [Category("Visuals")]
        [Description("Label style.")]
        public LabelStyle LabelStyle
        {
            get => _label.LabelStyle;
            set => _label.LabelStyle = value;
        }

        [Category("Visuals")]
        [Description("Header values")]
        public LabelValues Values => _label.Values;

        [Category("Visuals")]
        [Description("Overrides for defining common label appearance that other states can override.")]
        public PaletteContent StateCommon => _label.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled label appearance.")]
        public PaletteContent StateDisabled => _label.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal label appearance.")]
        public PaletteContent StateNormal => _label.StateNormal;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        public VisualOrientation Orientation
        {
            get => _label.Orientation;
            set => _label.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        public PaletteMode PaletteMode
        {
            get => _label.PaletteMode;
            set => _label.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        public bool AutoSize
        {
            get => _label.AutoSize;
            set => _label.AutoSize = value;
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        public AutoSizeMode AutoSizeMode
        {
            get => _label.AutoSizeMode;
            set => _label.AutoSizeMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _label.Size;
            set => _label.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _label.Location;
            set => _label.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _label.Enabled;
            set => _label.Enabled = value;
        }
    }
}
