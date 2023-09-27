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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonMessageBoxExamples
{
    public partial class Form1 : KryptonForm
    {
        private const string SEED_TEXT =
            @"// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2016, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2023. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************
";

        private MessageBoxIcon _mbIcon = MessageBoxIcon.Warning;
        private KryptonMessageBoxIcon _kmbIcon = KryptonMessageBoxIcon.Warning;
        private KryptonMessageBoxButtons _mbButtons = KryptonMessageBoxButtons.OKCancel;
        private MessageBoxOptions _options = 0;
        private MessageBoxContentAreaType _contentAreaType = MessageBoxContentAreaType.Normal;
        private ContentAlignment _messageTextAlignment = ContentAlignment.MiddleLeft;

        public Form1()
        {
            InitializeComponent();

            // Handle the HelpRequested event for the following message.
            HelpRequested += Form1_HelpRequested;   // https://github.com/Krypton-Suite/Standard-Toolkit/issues/868
        }

        private void icon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNone.Checked)
            {
                _mbIcon = MessageBoxIcon.None;
                _kmbIcon = KryptonMessageBoxIcon.None;
            }
            else if (kradError.Checked)
            {
                _mbIcon = MessageBoxIcon.Error;
                _kmbIcon = KryptonMessageBoxIcon.Error;
            }
            else if (kradQuestion.Checked)
            {
                _mbIcon = MessageBoxIcon.Question;
                _kmbIcon = KryptonMessageBoxIcon.Question;
            }
            else if (kradWarning.Checked)
            {
                _mbIcon = MessageBoxIcon.Warning;
                _kmbIcon = KryptonMessageBoxIcon.Warning;
            }
            else if (kradInformation.Checked)
            {
                _mbIcon = MessageBoxIcon.Information;
                _kmbIcon = KryptonMessageBoxIcon.Information;
            }
            else if (rbShield.Checked)
            {
                _mbIcon = MessageBoxIcon.None;
                _kmbIcon = KryptonMessageBoxIcon.Shield;
            }
            else if (!kradWinLogo.Checked)
            {
                _mbIcon = MessageBoxIcon.None;
                _kmbIcon = KryptonMessageBoxIcon.WindowsLogo;
            }
        }

        private void buttons_CheckedChanged(object sender, EventArgs e)
        {
            if (kradOK.Checked)
            {
                _mbButtons = KryptonMessageBoxButtons.OK;
            }
            else if (kradOKCancel.Checked)
            {
                _mbButtons = KryptonMessageBoxButtons.OKCancel;
            }
            else if (kradRetryCancel.Checked)
            {
                _mbButtons = KryptonMessageBoxButtons.RetryCancel;
            }
            else if (kradAbortRetryIgnore.Checked)
            {
                _mbButtons = KryptonMessageBoxButtons.AbortRetryIgnore;
            }
            else if (kradYesNo.Checked)
            {
                _mbButtons = KryptonMessageBoxButtons.YesNo;
            }
            else if (kradYesNoCancel.Checked)
            {
                _mbButtons = KryptonMessageBoxButtons.YesNoCancel;
            }
            else if (kradCancelTryContinue.Checked)
            {
                _mbButtons = KryptonMessageBoxButtons.CancelTryContinue;
            }
        }

        private void ChkRightAlign_CheckedChanged(object sender, EventArgs e)
        {
            if (kchkRightAlign.Checked)
            {
                _options |= MessageBoxOptions.RightAlign;
            }
            else
            {
                _options &= ~MessageBoxOptions.RightAlign;
            }
        }

        private void ChkRtlReading_CheckedChanged(object sender, EventArgs e)
        {
            if (kchkRtlReading.Checked)
            {
                _options |= MessageBoxOptions.RtlReading;
            }
            else
            {
                _options &= ~MessageBoxOptions.RtlReading;
            }
        }

        private void kbtnShow_Click(object sender, EventArgs e)
        {
            if (!kradWinLogo.Checked
                && !rbShield.Checked
#if NET6_0_OR_GREATER
#else
                && !kradCancelTryContinue.Checked
#endif
               )
            {
                MessageBox.Show(textBoxMessage.Text, textBoxCaption.Text,
                    (MessageBoxButtons)_mbButtons,
                    _mbIcon, MessageBoxDefaultButton.Button1,
                    _options,
                    chkShowHelp.Checked);
            }

            var res = KryptonMessageBox.Show(this, textBoxMessage.Text, textBoxCaption.Text,
                _mbButtons,
                _kmbIcon,
                options: _options,
                showHelpButton: chkShowHelp.Checked, contentAreaType: _contentAreaType,
                contentLinkArea: new LinkArea(decimal.ToInt32(knudLinkAreaStart.Value), decimal.ToInt32(knudLinkAreaEnd.Value)),
                linkAreaCommand: kcmdTest,
                messageTextAlignment: _messageTextAlignment);

            textBoxMessage.Text = $@"Krypton DialogResult = {res}";
        }

        /// <summary>
        /// Based on code from https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox.show?view=windowsdesktop-7.0#system-windows-forms-messagebox-show(system-string-system-string-system-windows-forms-messageboxbuttons-system-windows-forms-messageboxicon-system-windows-forms-messageboxdefaultbutton-system-windows-forms-messageboxoptions-system-boolean)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="hlpEvent"></param>
        private void Form1_HelpRequested(object sender, HelpEventArgs hlpEvent)
        {
            // Create a custom Help window in response to the HelpRequested event.
            using Form helpForm = new() {
                // Set up the form position, size, and title caption.
                StartPosition = FormStartPosition.Manual,
                Size = new Size(200, 400),
                DesktopLocation = new Point(DesktopBounds.X + Size.Width, DesktopBounds.Top),
                Text = @"Help Form"
            };

            // Create a label to contain the Help text.
            Label helpLabel = new Label();

            // Add the label to the form and set its text.
            helpForm.Controls.Add(helpLabel);
            helpLabel.Dock = DockStyle.Fill;

            // Use the sender parameter to identify the context of the Help request.
            // The parameter must be cast to the Control type to get the Tag property.
            Control senderControl = sender as Control;

            helpLabel.Text = $@"Help information shown in response to user action on the '{(string)senderControl.Tag}' message.";

            // Set the Help form to be owned by the main form. This helps
            // to ensure that the Help form is disposed of.
            AddOwnedForm(helpForm);

            // Show the custom Help window.
            helpForm.Show();

            // Indicate that the HelpRequested event is handled.
            hlpEvent.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string value in Enum.GetNames(typeof(KryptonMessageBoxIcon)))
            {
                kcmbIcons.Items.Add(value);
            }

            foreach (string value in Enum.GetNames(typeof(MessageBoxContentAreaType)))
            {
                kcmbContentAreaType.Items.Add(value);
            }

            foreach (string value in Enum.GetNames(typeof(ContentAlignment)))
            {
                kcmbMessageTextAlignment.Items.Add(value);
            }

            knudLinkAreaStart.Maximum = textBoxMessage.Text.Length;

            knudLinkAreaEnd.Maximum = textBoxMessage.Text.Length;

            knudLinkAreaEnd.Value = textBoxMessage.Text.Length;

            kcmbContentAreaType.SelectedIndex = 0;

            kcmbMessageTextAlignment.SelectedIndex = 3;
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            knudLinkAreaStart.Maximum = textBoxMessage.Text.Length;

            knudLinkAreaEnd.Maximum = textBoxMessage.Text.Length;

            knudLinkAreaEnd.Value = textBoxMessage.Text.Length;
        }

        private void kcmbIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _kmbIcon = (KryptonMessageBoxIcon)Enum.Parse(typeof(KryptonMessageBoxIcon), kcmbIcons.Text);
        }

        private void kcmbContentAreaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kcmbContentAreaType.SelectedIndex == 0)
            {
                _contentAreaType = MessageBoxContentAreaType.Normal;

                ToggleContentAreaControls(false);
            }
            else
            {
                _contentAreaType = MessageBoxContentAreaType.LinkLabel;

                ToggleContentAreaControls(true);
            }
        }

        private void kcmdTest_Execute(object sender, EventArgs e)
        {
            try
            {
                Process.Start(ktxtResourcePath.Text);
            }
            catch (Exception exception)
            {
                KryptonMessageBox.Show(exception.Message);
            }
        }

        private void bsaBrowse_Click(object sender, EventArgs e)
        {
            KryptonOpenFileDialog ofd = new() { Title = @"Browse for file:" };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ktxtResourcePath.Text = Path.GetFullPath(ofd.FileName);
            }
        }

        private void ToggleContentAreaControls(bool enabled)
        {
            klblLinkAreaStart.Enabled = enabled;

            klblLinkAreaEnd.Enabled = enabled;

            knudLinkAreaStart.Enabled = enabled;

            knudLinkAreaEnd.Enabled = enabled;

            ktxtResourcePath.Enabled = enabled;
        }

        private void kcmbMessageTextAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            _messageTextAlignment = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), kcmbMessageTextAlignment.Text);
        }

        private void kbtnDummyText_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = string.Empty;

            textBoxMessage.Text = SEED_TEXT;
        }
    }
}
