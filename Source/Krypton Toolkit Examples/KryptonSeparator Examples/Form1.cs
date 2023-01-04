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

namespace KryptonSeparatorExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) => propertyGrid.SelectedObject = new KryptonSeparatorProxy(kryptonSeparator1);

        private void separator_MouseDown(object sender, MouseEventArgs e) => propertyGrid.SelectedObject = new KryptonSeparatorProxy(sender as KryptonSeparator);

        private void separator_MoveRect(object sender, SplitterMoveRectMenuArgs e)
        {
            // Allow the splitter to move 50 pixels in each direction
            e.MoveRect = new Rectangle(e.MoveRect.X - 50,
                                       e.MoveRect.Y - 50,
                                       e.MoveRect.Width + 100,
                                       e.MoveRect.Height + 100);

            Output("MoveRect " + e.MoveRect.ToString());
        }

        private void separator_Moving(object sender, SplitterCancelEventArgs e) =>
            Output("Moving" +
                   " SplitX:" + e.SplitX.ToString() +
                   " SplitY:" + e.SplitY.ToString() +
                   " MouseX:" + e.MouseCursorX.ToString() +
                   " MouseY:" + e.MouseCursorY.ToString());

        private void separator_Moved(object sender, SplitterEventArgs e) =>
            Output("Moved" +
                   " SplitX:" + e.SplitX.ToString() +
                   " SplitY:" + e.SplitY.ToString());

        private void separator_NotMoved(object sender, EventArgs e) => Output("Not Moved");

        private void Output(string str)
        {
            string newText = richTextBox1.Text;
            
            if (newText.Length > 10000)
            {
                newText = string.Empty;
            }

            richTextBox1.Text = str + "\n" + newText;
        }

        private void office2010Blue_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue;

        private void office2010Silver_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Silver;

        private void office2010Black_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Black;

        private void office2007Blue_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue;

        private void office2007Silver_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver;

        private void office2007Black_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Black;

        private void sparkleBlue_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue;

        private void office2003_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003;

        private void system_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem;

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonSeparatorProxy
    {
        private KryptonSeparator _separator;

        public KryptonSeparatorProxy(KryptonSeparator separator) => _separator = separator;

        #region Public
        [Category("Visuals")]
        [Description("Separator background style.")]
        public PaletteBackStyle ContainerBackStyle
        {
            get => _separator.ContainerBackStyle;
            set => _separator.ContainerBackStyle = value;
        }

        [Category("Visuals")]
        [Description("Separator style.")]
        public SeparatorStyle SeparatorStyle
        {
            get => _separator.SeparatorStyle;
            set => _separator.SeparatorStyle = value;
        }

        [Category("Visuals")]
        [Description("Overrides for defining common separator appearance that other states can override.")]
        public PaletteSplitContainerRedirect StateCommon => _separator.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled separator appearance.")]
        public PaletteSplitContainer StateDisabled => _separator.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal separator appearance.")]
        public PaletteSplitContainer StateNormal => _separator.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining hot tracking separator appearance.")]
        public PaletteSeparatorPadding StateTracking => _separator.StateTracking;

        [Category("Visuals")]
        [Description("Overrides for defining pressed separator appearance.")]
        public PaletteSeparatorPadding StatePressed => _separator.StatePressed;

        [Category("Layout")]
        [Description("Determines the increment used for moving.")]
        public int SplitterIncrements
        {
            get => _separator.SplitterIncrements;
            set => _separator.SplitterIncrements = value;
        }

        [Category("Layout")]
        [Description("Determines if the separator is vertical or horizontal.")]
        public Orientation Orientation
        {
            get => _separator.Orientation;
            set => _separator.Orientation = value;
        }

        [Category("Behavior")]
        [Description("Determines if the separator is allowed to notify a move.")]
        public bool AllowMove
        {
            get => _separator.AllowMove;
            set => _separator.AllowMove = value;
        }

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get => _separator.PaletteMode;
            set => _separator.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _separator.Size;
            set => _separator.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _separator.Location;
            set => _separator.Location = value;
        }

        [Category("Behavior")]
        [Description("Indicates whether the control is enabled.")]
        public bool Enabled
        {
            get => _separator.Enabled;
            set => _separator.Enabled = value;
        }
        #endregion
    }
}
