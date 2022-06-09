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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

using KryptonGroupExamples;

namespace KryptonPanelExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this panel
            propertyGrid.SelectedObject = new KryptonPanelProxy(panel1Office);

        private void kryptonPanel_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this panel
            propertyGrid.SelectedObject = new KryptonPanelProxy(sender as KryptonPanel);

        private void buttonClose_Click(object sender, EventArgs e) => Close();

        private void Button1_Click(object sender, EventArgs e)
        {
            using var colouredForm = new ColouredForm();
            colouredForm.ShowDialog(this);
        }
    }

    public class KryptonPanelProxy
    {
        private KryptonPanel _panel;

        public KryptonPanelProxy(KryptonPanel panel) => _panel = panel;

        [Category("Visuals")]
        [Description("Panel style.")]
        [DefaultValue(typeof(PaletteBackStyle), "PanelClient")]
        public PaletteBackStyle PanelBackStyle
        {
            get => _panel.PanelBackStyle;
            set => _panel.PanelBackStyle = value;
        }

        [Category("Visuals")]
        [Description("Overrides for defining common panel appearance that other states can override.")]
        public PaletteBack StateCommon => _panel.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled panel appearance.")]
        public PaletteBack StateDisabled => _panel.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal panel appearance.")]
        public PaletteBack StateNormal => _panel.StateNormal;

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get => _panel.PaletteMode;
            set => _panel.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _panel.Size;
            set => _panel.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _panel.Location;
            set => _panel.Location = value;
        }
    }
}
