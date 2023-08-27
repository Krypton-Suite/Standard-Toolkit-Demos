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

namespace KryptonSplitContainerExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this split container
            propertyGrid.SelectedObject = new KryptonSplitContainerProxy(splitContainer1Office);

        private void splitContainer_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this split container
            propertyGrid.SelectedObject = new KryptonSplitContainerProxy(sender as KryptonSplitContainer);

        private void splitContainerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            KryptonPanel panel = (KryptonPanel)sender;

            // Setup the property grid to edit this panels parent split container
            propertyGrid.SelectedObject = new KryptonSplitContainerProxy(panel.Parent as KryptonSplitContainer);
        }

        private void splitContainerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            KryptonLabel label = (KryptonLabel)sender;
            KryptonPanel panel = (KryptonPanel)label.Parent;

            // Setup the property grid to edit this panels parent split container
            propertyGrid.SelectedObject = new KryptonSplitContainerProxy(panel.Parent as KryptonSplitContainer);
        }

        private void splitContainerGroupLabel_MouseDown(object sender, MouseEventArgs e)
        {
            KryptonLabel label = (KryptonLabel)sender;
            KryptonPanel panel = (KryptonPanel)label.Parent;

            // Setup the property grid to edit this panels parent split container
            propertyGrid.SelectedObject = new KryptonSplitContainerProxy(panel.Parent.Parent.Parent as KryptonSplitContainer);
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonSplitContainerProxy
    {
        private KryptonSplitContainer _splitContainer;

        public KryptonSplitContainerProxy(KryptonSplitContainer splitContainer) => _splitContainer = splitContainer;

        [Category("Visuals")]
        [Description("Container background style.")]
        [DefaultValue(PaletteBackStyle.PanelClient)]
        public PaletteBackStyle ContainerBackStyle
        {
            get => _splitContainer.ContainerBackStyle;
            set => _splitContainer.ContainerBackStyle = value;
        }

        [Category("Visuals")]
        [Description("Separator style.")]
        [DefaultValue(SeparatorStyle.LowProfile)]
        public SeparatorStyle SeparatorStyle
        {
            get => _splitContainer.SeparatorStyle;
            set => _splitContainer.SeparatorStyle = value;
        }

        [Category("Visuals")]
        [Description("Overrides for defining common split container appearance that other states can override.")]
        public PaletteSplitContainerRedirect StateCommon => _splitContainer.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled split container appearance.")]
        public PaletteSplitContainer StateDisabled => _splitContainer.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal split container appearance.")]
        public PaletteSplitContainer StateNormal => _splitContainer.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining hot tracking separator appearance.")]
        public PaletteSeparatorPadding StateTracking => _splitContainer.StateTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed separator appearance.")]
        public PaletteSeparatorPadding StatePressed => _splitContainer.StatePressed;

        [Category("Layout")]
        [Description("Determines the minimum distance of pixels of the splitter from the left or top edge of Panel1.")]
        [Localizable(true)]
        [DefaultValue(25)]
        public int Panel1MinSize
        {
            get => _splitContainer.Panel1MinSize;
            set => _splitContainer.Panel1MinSize = value;
        }

        [Category("Layout")]
        [Description("Determines if Panel1 is collapsed.")]
        [DefaultValue(false)]
        public bool Panel1Collapsed
        {
            get => _splitContainer.Panel1Collapsed;
            set => _splitContainer.Panel1Collapsed = value;
        }

        [Category("Layout")]
        [Description("Determines the minimum distance of pixels of the splitter from the right or bottom edge of Panel2.")]
        [Localizable(true)]
        [DefaultValue(25)]
        public int Panel2MinSize
        {
            get => _splitContainer.Panel2MinSize;
            set => _splitContainer.Panel2MinSize = value;
        }

        [Category("Layout")]
        [Description("Determines if Panel2 is collapsed.")]
        [DefaultValue(false)]
        public bool Panel2Collapsed
        {
            get => _splitContainer.Panel2Collapsed;
            set => _splitContainer.Panel2Collapsed = value;
        }

        [Category("Layout")]
        [Description("Determines if the splitter is fixed.")]
        [Localizable(true)]
        [DefaultValue(false)]
        public bool IsSplitterFixed
        {
            get => _splitContainer.IsSplitterFixed;
            set => _splitContainer.IsSplitterFixed = value;
        }

        [Category("Layout")]
        [Description("Indicates the panel to keep the same size when resizing.")]
        [DefaultValue(FixedPanel.None)]
        public FixedPanel FixedPanel
        {
            get => _splitContainer.FixedPanel;
            set => _splitContainer.FixedPanel = value;
        }

        [Category("Layout")]
        [Description("Determines pixel distance of the splitter from the left or top edge.")]
        [Localizable(true)]
        [SettingsBindable(true)]
        [DefaultValue(50)]
        public int SplitterDistance
        {
            get => _splitContainer.SplitterDistance;
            set => _splitContainer.SplitterDistance = value;
        }

        [Category("Layout")]
        [Description("Determines the thickness of the splitter.")]
        [Localizable(true)]
        [DefaultValue(4)]
        public int SplitterWidth
        {
            get => _splitContainer.SplitterWidth;
            set => _splitContainer.SplitterWidth = value;
        }

        [Category("Layout")]
        [Description("Determines the number of pixels the splitter moves in increments.")]
        [Localizable(true)]
        [DefaultValue(1)]
        public int SplitterIncrement
        {
            get => _splitContainer.SplitterIncrement;
            set => _splitContainer.SplitterIncrement = value;
        }

        [Category("Behavior")]
        [Description("Determines if the splitter is vertical or horizontal.")]
        [Localizable(true)]
        [DefaultValue(Orientation.Vertical)]
        public Orientation Orientation
        {
            get => _splitContainer.Orientation;
            set => _splitContainer.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(PaletteMode.Global)]
        public PaletteMode PaletteMode
        {
            get => _splitContainer.PaletteMode;
            set => _splitContainer.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _splitContainer.Size;
            set => _splitContainer.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _splitContainer.Location;
            set => _splitContainer.Location = value;
        }
    }
}
