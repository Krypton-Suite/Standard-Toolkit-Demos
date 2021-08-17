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

namespace KryptonFormExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonCheckSetPalettes_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Recalc the non client size to reflect new border style
            RecalcNonClient();

            kryptonManager.GlobalPaletteMode = kryptonCheckSetPalettes.CheckedIndex switch {
                0 => PaletteModeManager.ProfessionalSystem,
                1 => PaletteModeManager.Office2007Black,
                2 => PaletteModeManager.Office2007Silver,
                3 => PaletteModeManager.Office2007Blue,
                4 => PaletteModeManager.ProfessionalOffice2003,
                5 => PaletteModeManager.SparkleBlue,
                6 => PaletteModeManager.SparkleOrange,
                7 => PaletteModeManager.Office2010Black,
                8 => PaletteModeManager.Office2010Silver,
                9 => PaletteModeManager.Office2010Blue,
                _ => kryptonManager.GlobalPaletteMode
            };
        }

        private void kryptonCheckSetStyles_CheckedButtonChanged(object sender, EventArgs e)
        {
            FormBorderStyle = kryptonCheckSetStyles.CheckedIndex switch {
                0 => FormBorderStyle.Sizable,
                1 => FormBorderStyle.FixedToolWindow,
                2 => FormBorderStyle.SizableToolWindow,
                3 => FormBorderStyle.FixedDialog,
                4 => FormBorderStyle.Fixed3D,
                5 => FormBorderStyle.FixedSingle,
                6 => FormBorderStyle.None,
                _ => FormBorderStyle
            };

            // Recalc the non client size to reflect new border style
            RecalcNonClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set correct initial checked button
            if (KryptonManager.CurrentGlobalPalette == KryptonManager.PaletteOffice2007Black)
            {
                kryptonCheckSetPalettes.CheckedIndex = 1;
            }

            // Setup the property grid to edit this form
            propertyGrid.SelectedObject = new KryptonFormProxy(this);
        }
    }

    public class KryptonFormProxy
    {
        private KryptonForm _form;

        public KryptonFormProxy(KryptonForm form)
        {
            _form = form;
        }

        [Category("Appearance")]
        [Description("The text associated with the control.")]
        [DefaultValue("")]
        public string Text
        {
            get { return _form.Text; }
            set { _form.Text = value; }
        }

        [Category("Appearance")]
        [Description("The extra text associated with the control.")]
        [DefaultValue("")]
        public string TextExtra
        {
            get { return _form.TextExtra; }
            set { _form.TextExtra = value; }
        }

        [Category("Appearance")]
        [Description("The icon associated with the control.")]
        [DefaultValue("")]
        public Icon Icon
        {
            get { return _form.Icon; }
            set { _form.Icon = value; }
        }

        [Category("Visuals")]
        [Description("Should custom chrome be allowed for this KryptonForm instance.")]
        [DefaultValue(true)]
        public bool AllowFormChrome
        {
            get { return _form.AllowFormChrome; }
            set { _form.AllowFormChrome = value; }
        }

        [Category("Visuals")]
        [Description("Should the form status strip be considered for merging into chrome.")]
        [DefaultValue(true)]
        public bool AllowStatusStripMerge
        {
            get { return _form.AllowStatusStripMerge; }
            set { _form.AllowStatusStripMerge = value; }
        }

        [Category("Visuals")]
        [Description("Header style for a main form.")]
        [DefaultValue(typeof(HeaderStyle), "Form")]
        public HeaderStyle HeaderStyle
        {
            get { return _form.HeaderStyle; }
            set { _form.HeaderStyle = value; }
        }

        [Category("Visuals")]
        [Description("Chrome group border style.")]
        [DefaultValue(typeof(PaletteBorderStyle), "FormMain")]
        public PaletteBorderStyle GroupBorderStyle
        {
            get { return _form.GroupBorderStyle; }
            set { _form.GroupBorderStyle = value; }
        }

        [Category("Visuals")]
        [Description("Chrome group background style.")]
        [DefaultValue(typeof(PaletteBackStyle), "FormMain")]
        public PaletteBackStyle GroupBackStyle
        {
            get { return _form.GroupBackStyle; }
            set { _form.GroupBackStyle = value; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining common form appearance that other states can override.")]
        public PaletteFormRedirect StateCommon
        {
            get { return _form.StateCommon; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining inactive form appearance.")]
        public PaletteForm StateInactive
        {
            get { return _form.StateInactive; }
        }

        [Category("Visuals")]
        [Description("Overrides for defining active form appearance.")]
        public PaletteForm StateActive
        {
            get { return _form.StateActive; }
        }

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KryptonForm.FormButtonSpecCollection ButtonSpecs
        {
            get { return _form.ButtonSpecs; }
        }

        [Category("Window Style")]
        [DefaultValue(true)]
        public bool ControlBox
        {
            get { return _form.ControlBox; }
            set { _form.ControlBox = value; }
        }

        [Category("Window Style")]
        [DefaultValue(true)]
        public bool MaximizeBox
        {
            get { return _form.MaximizeBox; }
            set { _form.MaximizeBox = value; }
        }

        [Category("Window Style")]
        [DefaultValue(true)]
        public bool MinimizeBox
        {
            get { return _form.MinimizeBox; }
            set { _form.MinimizeBox = value; }
        }

        [Category("Window Style")]
        [DefaultValue(true)]
        public bool ShowIcon
        {
            get { return _form.ShowIcon; }
            set { _form.ShowIcon = value; }
        }

    }
}
