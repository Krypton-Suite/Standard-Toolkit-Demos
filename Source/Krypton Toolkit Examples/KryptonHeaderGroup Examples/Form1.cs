﻿#region BSD License
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

namespace KryptonHeaderGroupExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this header group
            propertyGrid.SelectedObject = new KryptonHeaderGroupProxy(headerGroup1Office);

        private void headerGroup_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this header group
            propertyGrid.SelectedObject = new KryptonHeaderGroupProxy(sender as KryptonHeaderGroup);

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            // Setup the property grid to edit this panel parent header group
            propertyGrid.SelectedObject = new KryptonHeaderGroupProxy(c.Parent as KryptonHeaderGroup);
        }

        private void rtb_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            // Setup the property grid to edit this richt text box parent header group
            propertyGrid.SelectedObject = new KryptonHeaderGroupProxy(c.Parent.Parent as KryptonHeaderGroup);
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonHeaderGroupProxy
    {
        private KryptonHeaderGroup _headerGroup;

        public KryptonHeaderGroupProxy(KryptonHeaderGroup headerGroup) => _headerGroup = headerGroup;

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        [DefaultValue(false)]
        public bool AllowButtonSpecToolTips
        {
            get => _headerGroup.AllowButtonSpecToolTips;
            set => _headerGroup.AllowButtonSpecToolTips = value;
        }

        [Category("Visuals")]
        [Description("Clicking an arrow button spec should toggle collapse state.")]
        [DefaultValue(true)]
        public bool AutoCollapseArrow
        {
            get => _headerGroup.AutoCollapseArrow;
            set => _headerGroup.AutoCollapseArrow = value;
        }

        [Category("Visuals")]
        [Description("Specifies if the appearance is collapsed.")]
        [DefaultValue(false)]
        public bool Collapsed
        {
            get => _headerGroup.Collapsed;
            set => _headerGroup.Collapsed = value;
        }

        [Category("Visuals")]
        [Description("Specifies how to collapsed the appearance when entering collapse mode.")]
        [DefaultValue(typeof(HeaderGroupCollapsedTarget), "Collapse to Primary Header")]
        public HeaderGroupCollapsedTarget CollapseTarget
        {
            get => _headerGroup.CollapseTarget;
            set => _headerGroup.CollapseTarget = value;
        }

		[Category("Visuals")]
		[Description("Border style.")]
		[DefaultValue(typeof(PaletteBorderStyle), "Control - Client")]
		public PaletteBorderStyle GroupBorderStyle
		{
			get => _headerGroup.GroupBorderStyle;
            set => _headerGroup.GroupBorderStyle = value;
        }

		/// <summary>
		/// Gets and sets the background style.
		/// </summary>
        [Category("Visuals")]
        [Description("Background style.")]
        [DefaultValue(typeof(PaletteBackStyle), "Control - Client")]
        public PaletteBackStyle GroupBackStyle
        {
            get => _headerGroup.GroupBackStyle;
            set => _headerGroup.GroupBackStyle = value;
        }

		[Category("Visuals")]
		[Description("Primary header style.")]
		[DefaultValue(typeof(HeaderStyle), "Primary")]
		public HeaderStyle HeaderStylePrimary
		{
			get => _headerGroup.HeaderStylePrimary;
            set => _headerGroup.HeaderStylePrimary = value;
        }

		[Category("Visuals")]
		[Description("Secondary header style.")]
		[DefaultValue(typeof(HeaderStyle), "Secondary")]
		public HeaderStyle HeaderStyleSecondary
		{
            get => _headerGroup.HeaderStyleSecondary;
            set => _headerGroup.HeaderStyleSecondary = value;
        }

		[Category("Visuals")]
		[Description("Edge position of the primary header.")]
		[DefaultValue(typeof(VisualOrientation), "Top")]
		public VisualOrientation HeaderPositionPrimary
		{
			get => _headerGroup.HeaderPositionPrimary;
            set => _headerGroup.HeaderPositionPrimary = value;
        }

        [Category("Visuals")]
        [Description("Edge position of the secondary header.")]
        [DefaultValue(typeof(VisualOrientation), "Bottom")]
        public VisualOrientation HeaderPositionSecondary
        {
            get => _headerGroup.HeaderPositionSecondary;
            set => _headerGroup.HeaderPositionSecondary = value;
        }

        [Category("Visuals")]
        [Description("Primary header visibility.")]
        [DefaultValue(true)]
        public bool HeaderVisiblePrimary
        {
            get => _headerGroup.HeaderVisiblePrimary;
            set => _headerGroup.HeaderVisiblePrimary = value;
        }

        [Category("Visuals")]
        [Description("Secondary header visibility.")]
        [DefaultValue(true)]
        public bool HeaderVisibleSecondary
        {
            get => _headerGroup.HeaderVisibleSecondary;
            set => _headerGroup.HeaderVisibleSecondary = value;
        }

        [Category("Visuals")]
        [Description("Overrides for defining common header group appearance that other states can override.")]
        public PaletteHeaderGroupRedirect StateCommon => _headerGroup.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled header group appearance.")]
        public PaletteHeaderGroup StateDisabled => _headerGroup.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal header group appearance.")]
        public PaletteHeaderGroup StateNormal => _headerGroup.StateNormal;

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KryptonHeaderGroup.HeaderGroupButtonSpecCollection ButtonSpecs => _headerGroup.ButtonSpecs;

        [Category("Visuals")]
		[Description("Primary header values")]
        public HeaderGroupValuesPrimary ValuesPrimary => _headerGroup.ValuesPrimary;

        [Category("Visuals")]
		[Description("Secondary header values")]
        public HeaderGroupValuesSecondary ValuesSecondary => _headerGroup.ValuesSecondary;

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get => _headerGroup.PaletteMode;
            set => _headerGroup.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _headerGroup.Size;
            set => _headerGroup.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _headerGroup.Location;
            set => _headerGroup.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _headerGroup.Enabled;
            set => _headerGroup.Enabled = value;
        }
    }
}
