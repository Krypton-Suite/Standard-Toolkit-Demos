#region BSD License
/*
 *
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Text;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonTaskDialogExamples;

public partial class Form1 : Form
{
    public Form1() => InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
        comboBoxIcon.Text = "Information";
        comboBoxFooterIcon.Text = "Warning";
    }

    private static KryptonTaskDialogIconType ParseTaskDialogIcon(string text) =>
        text switch
        {
            "Error" => KryptonTaskDialogIconType.ShieldError,
            "Question" => KryptonTaskDialogIconType.ShieldHelp,
            "Warning" => KryptonTaskDialogIconType.ShieldWarning,
            "Information" => KryptonTaskDialogIconType.ShieldInformation,
            _ => KryptonTaskDialogIconType.None
        };

    private void palette2010Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;

    private void palette2010Silver_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;

    private void palette2010Black_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;

    private void palette2007Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;

    private void paletteSparkleOrange_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;

    private void paletteProfessional_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;

    private void buttonShowTaskDialog_Click(object sender, EventArgs e)
    {
        KryptonTaskDialogCommonButtonTypes commonButtons = KryptonTaskDialogCommonButtonTypes.None;
        if (checkBoxOK.Checked)
        {
            commonButtons |= KryptonTaskDialogCommonButtonTypes.OK;
        }

        if (checkBoxYes.Checked)
        {
            commonButtons |= KryptonTaskDialogCommonButtonTypes.Yes;
        }

        if (checkBoxNo.Checked)
        {
            commonButtons |= KryptonTaskDialogCommonButtonTypes.No;
        }

        if (checkBoxCancel.Checked)
        {
            commonButtons |= KryptonTaskDialogCommonButtonTypes.Cancel;
        }

        if (checkBoxClose.Checked)
        {
            commonButtons |= KryptonTaskDialogCommonButtonTypes.Cancel;
        }

        if (checkBoxRetry.Checked)
        {
            commonButtons |= KryptonTaskDialogCommonButtonTypes.Retry;
        }

        kryptonTaskDialog.CommandLinkButtons.Buttons.Clear();
        if (checkBoxCommandButtons.Checked)
        {
            kryptonTaskDialog.CommandLinkButtons.Buttons.Add(kryptonTaskDialogCommandLinkButton1);
            kryptonTaskDialog.CommandLinkButtons.Buttons.Add(kryptonTaskDialogCommandLinkButton2);
            kryptonTaskDialog.CommandLinkButtons.Buttons.Add(kryptonTaskDialogCommandLinkButton3);
        }

        kryptonTaskDialog.CommandLinkButtons.Visible = checkBoxCommandButtons.Checked;

        kryptonTaskDialog.FreeWheeler1.FlowLayoutPanel.Controls.Clear();
        if (checkBoxRadioButtons.Checked)
        {
            kryptonTaskDialog.FreeWheeler1.FlowLayoutPanel.Controls.Add(kryptonTaskDialogRadioButton1);
            kryptonTaskDialog.FreeWheeler1.FlowLayoutPanel.Controls.Add(kryptonTaskDialogRadioButton2);
            kryptonTaskDialog.FreeWheeler1.FlowLayoutPanel.Controls.Add(kryptonTaskDialogRadioButton3);
            kryptonTaskDialog.FreeWheeler1.ElementHeight = 36;
        }

        kryptonTaskDialog.FreeWheeler1.Visible = checkBoxRadioButtons.Checked;

        kryptonTaskDialog.Dialog.Form.Text = textBoxCaption.Text;
        kryptonTaskDialog.Heading.Text = textBoxMainInstructions.Text;
        kryptonTaskDialog.Heading.IconType = ParseTaskDialogIcon(comboBoxIcon.Text);
        kryptonTaskDialog.Heading.Visible = true;
        kryptonTaskDialog.Content.Text = textBoxContent.Text;
        kryptonTaskDialog.Content.Visible = true;
        kryptonTaskDialog.CheckBox.Text = textBoxCheckBoxText.Text;
        kryptonTaskDialog.CheckBox.Checked = checkBoxInitialState.Checked;
        kryptonTaskDialog.CheckBox.Visible = !string.IsNullOrWhiteSpace(textBoxCheckBoxText.Text);
        kryptonTaskDialog.FooterBar.Footer.FootNoteText = textBoxFooterText.Text;
        kryptonTaskDialog.FooterBar.Footer.IconType = ParseTaskDialogIcon(comboBoxFooterIcon.Text);
        kryptonTaskDialog.FooterBar.Footer.EnableExpanderControls = false;
        kryptonTaskDialog.FooterBar.CommonButtons.Buttons = commonButtons;
        kryptonTaskDialog.FooterBar.CommonButtons.AcceptButton = commonButtons.HasFlag(KryptonTaskDialogCommonButtonTypes.OK)
            ? KryptonTaskDialogCommonButtonTypes.OK
            : KryptonTaskDialogCommonButtonTypes.None;
        kryptonTaskDialog.FooterBar.CommonButtons.CancelButton = commonButtons.HasFlag(KryptonTaskDialogCommonButtonTypes.Cancel)
            ? KryptonTaskDialogCommonButtonTypes.Cancel
            : KryptonTaskDialogCommonButtonTypes.None;
        kryptonTaskDialog.FooterBar.Visible = true;
        kryptonTaskDialog.ShowDialog(this);
    }

    private void buttonFill_Click(object sender, EventArgs e)
    {
        var s = "The quick brown fox jumps over the lazy dog";
        var e1 = new Random().Next(50, 400);
        var sb = new StringBuilder().Append(s);
        for (var i = 0; i < e1; ++i)
        {
            sb.AppendFormat("\r\n\r\n{0}", s);
            if (i % 10 == 0)
            {
                var e2 = new Random().Next(1, 10);
                for (var j = 0; j < e2; ++j)
                {
                    sb.AppendFormat(". {0}", s);
                }

                sb.Append("\r\n");
            }
        }
        textBoxContent.Text = sb.ToString();
    }
}
