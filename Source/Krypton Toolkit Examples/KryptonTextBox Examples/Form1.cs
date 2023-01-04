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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonTextBoxExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this text box
            propertyGrid.SelectedObject = new KryptonTextBoxProxy(kryptonTextBox1Blue);

        private void kryptonTextBox1Blue_Enter(object sender, EventArgs e) =>
            // Setup the property grid to edit this text box
            propertyGrid.SelectedObject = new KryptonTextBoxProxy(sender as KryptonTextBox);

        private void buttonSpecAny1_Click(object sender, EventArgs e) => kryptonTextBox2Blue.Text = string.Empty;

        private void buttonSpecAny3_Click(object sender, EventArgs e) => kryptonTextBox5System.Text = string.Empty;

        private void fixedText1_Click(object sender, EventArgs e)
        {
            kryptonTextBox9Custom.Text = "Fixed Text 1";
            kryptonTextBox9Custom.TextBox.Focus();
        }

        private void fixedText2_Click(object sender, EventArgs e)
        {
            kryptonTextBox9Custom.Text = "Fixed Text 2";
            kryptonTextBox9Custom.TextBox.Focus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            kryptonTextBox9Custom.Text = string.Empty;
            kryptonTextBox9Custom.TextBox.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonTextBoxProxy
    {
        private KryptonTextBox _textBox;

        public KryptonTextBoxProxy(KryptonTextBox textBox) => _textBox = textBox;

        [Category("Appearance")]
        [Description("Text for display inside the control.")]
        public string Text
        {
            get => _textBox.Text;
            set => _textBox.Text = value;
        }

        [Category("Visuals")]
        [Description("Determines if the control is always active or only when the mouse is over the control or has focus.")]
        public bool AlwaysActive
        {
            get => _textBox.AlwaysActive;
            set => _textBox.AlwaysActive = value;
        }

        [Category("Appearance")]
        [Description("Indicates, for multiline edit controls, which scroll bars will be shown for this control.")]
        public ScrollBars ScrollBars
        {
            get => _textBox.ScrollBars;
            set => _textBox.ScrollBars = value;
        }

        [Category("Appearance")]
        [Description("Indicates how the text should be aligned for edit controls.")]
        public HorizontalAlignment TextAlign
        {
            get => _textBox.TextAlign;
            set => _textBox.TextAlign = value;
        }

        [Category("Behavior")]
        [Description("Indicates if lines are automatically word-wrapped for multiline edit controls.")]
        public bool WordWrap
        {
            get => _textBox.WordWrap;
            set => _textBox.WordWrap = value;
        }

        [Category("Behavior")]
        [Description("Control whether the text in the control can span more than one line.")]
        public bool Multiline
        {
            get => _textBox.Multiline;
            set => _textBox.Multiline = value;
        }

        [Category("Behavior")]
        [Description("Indicates if return characters are accepted as input for multiline edit controls.")]
        public bool AcceptsReturn
        {
            get => _textBox.AcceptsReturn;
            set => _textBox.AcceptsReturn = value;
        }

        [Category("Behavior")]
        [Description("Indicates if tab characters are accepted as input for multiline edit controls.")]
        public bool AcceptsTab
        {
            get => _textBox.AcceptsTab;
            set => _textBox.AcceptsTab = value;
        }

        [Category("Behavior")]
        [Description("Indicates if all the characters should be left alone or converted to uppercase or lowercase.")]
        public CharacterCasing CharacterCasing
        {
            get => _textBox.CharacterCasing;
            set => _textBox.CharacterCasing = value;
        }

        [Category("Behavior")]
        [Description("Indicates that the selection should be hidden when the edit control loses focus.")]
        public bool HideSelection
        {
            get => _textBox.HideSelection;
            set => _textBox.HideSelection = value;
        }

        [Category("Behavior")]
        [Description("Specifies the maximum number of characters that can be entered into the edit control.")]
        public int MaxLength
        {
            get => _textBox.MaxLength;
            set => _textBox.MaxLength = value;
        }

        [Category("Behavior")]
        [Description("Controls whether the text in the edit control can be changed or not.")]
        public bool ReadOnly
        {
            get => _textBox.ReadOnly;
            set => _textBox.ReadOnly = value;
        }

        [Category("Behavior")]
        [Description("Indicates the character to display for password input for single-line edit controls.")]
        public char PasswordChar
        {
            get => _textBox.PasswordChar;
            set => _textBox.PasswordChar = value;
        }

        [Category("Behavior")]
        [Description("Indicates if the text in the edit control should appear as the default password character.")]
        public bool UseSystemPasswordChar
        {
            get => _textBox.UseSystemPasswordChar;
            set => _textBox.UseSystemPasswordChar = value;
        }

        [Category("Visuals")]
        [Description("Input control style.")]
        public InputControlStyle InputControlStyle
        {
            get => _textBox.InputControlStyle;
            set => _textBox.InputControlStyle = value;
        }

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        public bool AllowButtonSpecToolTips
        {
            get => _textBox.AllowButtonSpecToolTips;
            set => _textBox.AllowButtonSpecToolTips = value;
        }

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KryptonTextBox.TextBoxButtonSpecCollection ButtonSpecs => _textBox.ButtonSpecs;

        [Category("Visuals")]
        [Description("Initialize a new instance of the PaletteCueHintText class.")]
        public PaletteCueHintText CueHintText => _textBox.CueHint;

        [Category("Visuals")]
        [Description("Overrides for defining common textbox appearance that other states can override.")]
        public PaletteInputControlTripleRedirect StateCommon => _textBox.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled textbox appearance.")]
        public PaletteInputControlTripleStates StateDisabled => _textBox.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal textbox appearance.")]
        public PaletteInputControlTripleStates StateNormal => _textBox.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining active textbox appearance.")]
        public PaletteInputControlTripleStates StateActive => _textBox.StateActive;

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _textBox.Size;
            set => _textBox.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _textBox.Location;
            set => _textBox.Location = value;
        }
    }
}
