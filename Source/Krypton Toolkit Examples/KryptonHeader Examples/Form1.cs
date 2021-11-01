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

namespace KryptonHeaderExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this header
            propertyGrid.SelectedObject = new KryptonHeaderProxy(office1);

        private void header_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this header
            propertyGrid.SelectedObject = new KryptonHeaderProxy(sender as KryptonHeader);

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonHeaderProxy
    {
        private KryptonHeader _header;

        public KryptonHeaderProxy(KryptonHeader header) => _header = header;

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        [DefaultValue(false)]
        public bool AllowButtonSpecToolTips
        {
            get => _header.AllowButtonSpecToolTips;
            set => _header.AllowButtonSpecToolTips = value;
        }

        [Category("Visuals")]
        [Description("Header style.")]
        [DefaultValue(typeof(HeaderStyle), "Primary")]
        public HeaderStyle HeaderStyle
        {
            get => _header.HeaderStyle;
            set => _header.HeaderStyle = value;
        }

        [Category("Visuals")]
        [Description("Header values")]
        public HeaderValues Values => _header.Values;

        [Category("Visuals")]
        [Description("Overrides for defining common header appearance that other states can override.")]
        public PaletteTripleRedirect StateCommon => _header.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled header appearance.")]
        public PaletteTriple StateDisabled => _header.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal header appearance.")]
        public PaletteTriple StateNormal => _header.StateNormal;

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KryptonHeader.HeaderButtonSpecCollection ButtonSpecs => _header.ButtonSpecs;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        [DefaultValue(typeof(VisualOrientation), "Top")]
        public VisualOrientation Orientation
        {
            get => _header.Orientation;
            set => _header.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get => _header.PaletteMode;
            set => _header.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        [DefaultValue(false)]
        public bool AutoSize
        {
            get => _header.AutoSize;
            set => _header.AutoSize = value;
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        [DefaultValue(typeof(AutoSizeMode), "GrowOnly")]
        public AutoSizeMode AutoSizeMode
        {
            get => _header.AutoSizeMode;
            set => _header.AutoSizeMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _header.Size;
            set => _header.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _header.Location;
            set => _header.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _header.Enabled;
            set => _header.Enabled = value;
        }
    }
}
