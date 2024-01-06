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

namespace KryptonGroupBoxExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this header group
            propertyGrid.SelectedObject = new KryptonGroupBoxProxy(kryptonGroupBox1);

        private void groupBox_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this header group
            propertyGrid.SelectedObject = new KryptonGroupBoxProxy(sender as KryptonGroupBox);

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            // Setup the property grid to edit this panel parent header group
            Control c = sender as Control;
            propertyGrid.SelectedObject = new KryptonGroupBoxProxy(c.Parent as KryptonGroupBox);
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonGroupBoxProxy
    {
        private KryptonGroupBox _groupBox;

        public KryptonGroupBoxProxy(KryptonGroupBox groupBox) => _groupBox = groupBox;

        [Category("Visuals")]
        [Description("Edge position of the caption.")]
        public VisualOrientation CaptionEdge
        {
            get => _groupBox.CaptionEdge;
            set => _groupBox.CaptionEdge = value;
        }
        
        [Category("Visuals")]
        [Description("Orientation of the caption.")]
        public ButtonOrientation CaptionOrientation
        {
            get => _groupBox.CaptionOrientation;
            set => _groupBox.CaptionOrientation = value;
        }
        
        [Category("Visuals")]
        [Description("The percentage the caption should overlap the group area.")]
        [TypeConverter(typeof(OpacityConverter))]
        public double CaptionOverlap
        {
            get => _groupBox.CaptionOverlap;
            set => _groupBox.CaptionOverlap = value;
        }
        
        [Category("Visuals")]
        [Description("Caption style.")]
        public LabelStyle CaptionStyle
        {
            get => _groupBox.CaptionStyle;
            set => _groupBox.CaptionStyle = value;
        }
        
        [Category("Visuals")]
        [Description("Caption visibility.")]
        public bool CaptionVisible
        {
            get => _groupBox.CaptionVisible;
            set => _groupBox.CaptionVisible = value;
        }
        
        [Category("Visuals")]
        [Description("Background style.")]
        public PaletteBackStyle GroupBackStyle
        {
            get => _groupBox.GroupBackStyle;
            set => _groupBox.GroupBackStyle = value;
        }
        
        [Description("Border style.")]
        [Category("Visuals")]
        public PaletteBorderStyle GroupBorderStyle
        {
            get => _groupBox.GroupBorderStyle;
            set => _groupBox.GroupBorderStyle = value;
        }

        [Category("Appearance")]
        [Description("The internal panel that contains group content.")]
        public KryptonGroupPanel Panel => _groupBox.Panel;

        [Category("Visuals")]
        [Description("Overrides for defining common header group appearance that other states can override.")]
        public PaletteGroupBoxRedirect StateCommon => _groupBox.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled header group appearance.")]
        public PaletteGroupBox StateDisabled => _groupBox.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal header group appearance.")]
        public PaletteGroupBox StateNormal => _groupBox.StateNormal;

        [Category("Visuals")]
        [Description("Caption values")]
        public CaptionValues Values => _groupBox.Values;

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(PaletteMode.Global)]
        public PaletteMode PaletteMode
        {
            get => _groupBox.PaletteMode;
            set => _groupBox.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _groupBox.Size;
            set => _groupBox.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _groupBox.Location;
            set => _groupBox.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _groupBox.Enabled;
            set => _groupBox.Enabled = value;
        }
    }
}
