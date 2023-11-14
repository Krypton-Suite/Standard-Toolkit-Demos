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

namespace KryptonCheckBoxExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => propertyGrid.SelectedObject = new KryptonCheckBoxProxy(kryptonCheckBox13);

        private void CheckButtonEnter(object sender, EventArgs e) => propertyGrid.SelectedObject = new KryptonCheckBoxProxy(sender as KryptonCheckBox);

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonCheckBoxProxy
    {
        private KryptonCheckBox _checkBox;

        public KryptonCheckBoxProxy(KryptonCheckBox button) => _checkBox = button;

        [Category("Appearance")]
        [Description("Indicates if the component is in the checked state.")]
        public bool Checked
        {
            get => _checkBox.Checked;
            set => _checkBox.Checked = value;
        }

        [Category("Appearance")]
        [Description("Indicates the checked state of the component.")]
        public CheckState CheckState
        {
            get => _checkBox.CheckState;
            set => _checkBox.CheckState = value;
        }

        [Category("Behavior")]
        [Description("Causes the check box to automatically change state when clicked.")]
        public bool AutoCheck
        {
            get => _checkBox.AutoCheck;
            set => _checkBox.AutoCheck = value;
        }

        [Category("Behavior")]
        [Description("Indicates if the component allows three states instead of two.")]
        public bool ThreeState
        {
            get => _checkBox.ThreeState;
            set => _checkBox.ThreeState = value;
        }

        [Category("Visuals")]
        [Description("Visual position of the check box.")]
        public virtual VisualOrientation CheckPosition
        {
            get => _checkBox.CheckPosition;
            set => _checkBox.CheckPosition = value;
        }

        [Category("Visuals")]
        [Description("Image value overrides.")]
        public CheckBoxImages Images => _checkBox.Images;

        [Category("Visuals")]
		[Description("Label style.")]
		public LabelStyle LabelStyle
        {
            get => _checkBox.LabelStyle;
            set => _checkBox.LabelStyle = value;
        }

        [Category("Visuals")]
        [Description("Label values")]
        public LabelValues Values => _checkBox.Values;

        [Category("Visuals")]
        [Description("Overrides for defining common label appearance that other states can override.")]
        public PaletteContent StateCommon => _checkBox.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled label appearance.")]
        public PaletteContent StateDisabled => _checkBox.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal label appearance.")]
        public PaletteContent StateNormal => _checkBox.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining label appearance when it has focus.")]
        public PaletteContent OverrideFocus => _checkBox.OverrideFocus;

        [Category("Visuals")]
        [Description("Visual orientation of the control.")]
        [DefaultValue(VisualOrientation.Top)]
        public VisualOrientation Orientation
        {
            get => _checkBox.Orientation;
            set => _checkBox.Orientation = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(PaletteMode.Global)]
        public PaletteMode PaletteMode
        {
            get => _checkBox.PaletteMode;
            set => _checkBox.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("Specifies whether a control will automatically size itself to fit its contents.")]
        [DefaultValue(false)]
        public bool AutoSize
        {
            get => _checkBox.AutoSize;
            set => _checkBox.AutoSize = value;
        }

        [Category("Layout")]
        [Description("Specifies if the control grows and shrinks to fit the contents exactly.")]
        [DefaultValue(AutoSizeMode.GrowOnly)]
        public AutoSizeMode AutoSizeMode
        {
            get => _checkBox.AutoSizeMode;
            set => _checkBox.AutoSizeMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _checkBox.Size;
            set => _checkBox.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _checkBox.Location;
            set => _checkBox.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _checkBox.Enabled;
            set => _checkBox.Enabled = value;
        }
    }
}
