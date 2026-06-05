// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2024 - 2024. All rights reserved.
// *****************************************************************************

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonToastNotificationExamples;

public partial class UserInputNotification : KryptonForm
{
    #region Instance Fields

    /// <summary>Gets or sets the use fade.</summary>
    /// <value>The use fade.</value>
    private bool _useFade;

    /// <summary>Gets or sets the top most.</summary>
    /// <value>The top most.</value>
    private bool? _topMost;

    /// <summary>Gets or sets the show close box.</summary>
    /// <value>The show close box.</value>
    private bool? _showCloseBox;

    /// <summary>Gets or sets the show do not show again option.</summary>
    /// <value>The show do not show again option.</value>
    private bool? _showDoNotShowAgainOption;

    /// <summary>Gets or sets the state of the use do not show again option three.</summary>
    /// <value>The state of the use do not show again option three.</value>
    private bool? _useDoNotShowAgainOptionThreeState;

    /// <summary>Gets or sets the do not show again option checked value.</summary>
    /// <value>The do not show again option checked value.</value>
    private bool _isDoNotShowAgainOptionChecked;

    /// <summary>Gets or sets the report toast location. Use this for development purposes only.</summary>
    /// <value>Reports the toast location.</value>
    private bool _reportToastLocation;

    /// <summary>Gets or sets a value indicating whether [use RTL reading].</summary>
    /// <value><c>true</c> if [use RTL reading]; otherwise, <c>false</c>.</value>
    private bool _useRtlReading;

    /// <summary>Gets or sets the state of the do not show again option check.</summary>
    /// <value>The state of the do not show again option check.</value>
    private CheckState? _doNotShowAgainOptionCheckState;

    /// <summary>Gets or sets the focus on user input area.</summary>
    /// <value>The focus on user input area.</value>
    private bool? _focusOnUserInputArea;

    /// <summary>Gets or sets the notification title alignment.</summary>
    /// <value>The notification title alignment.</value>
    private ContentAlignment? _notificationTitleAlignment;

    /// <summary>Gets or sets the user input ComboBox style.</summary>
    /// <value>The user input ComboBox style.</value>
    private ComboBoxStyle? _userInputComboBoxStyle;

    /// <summary>Gets or sets the first border color.</summary>
    /// <value>The first border color.</value>
    private Color? _borderColor1;

    /// <summary>Gets or sets the second border color.</summary>
    /// <value>The second border color.</value>
    private Color? _borderColor2;

    /// <summary>Gets or sets the minimum date time value.</summary>
    /// <value>The minimum date time value.</value>
    private DateTime? _minimumDateTimeValue;

    /// <summary>Gets or sets the maximum date time value.</summary>
    /// <value>The maximum date time value.</value>
    private DateTime? _maximumDateTimeValue;

    /// <summary>Gets or sets the initial date time value.</summary>
    /// <value>The initial date time value.</value>
    private DateTime? _initialDateTimeValue;

    /// <summary>Gets or sets the notification content font.</summary>
    /// <value>The notification content font.</value>
    private Font? _notificationContentFont;

    /// <summary>Gets or sets the notification title font.</summary>
    /// <value>The notification title font.</value>
    private Font? _notificationTitleFont;

    /// <summary>Gets or sets the count-down seconds.</summary>
    /// <value>The count-down seconds.</value>
    private int? _countDownSeconds;

    /// <summary>Gets or sets the count-down timer interval.</summary>
    /// <value>The count-down timer interval.</value>
    private int? _countDownTimerInterval;

    /// <summary>Gets or sets the content of the notification.</summary>
    /// <value>The content of the notification.</value>
    private string? _notificationContent;

    /// <summary>Gets or sets the notification title.</summary>
    /// <value>The notification title.</value>
    private string? _notificationTitle;

    /// <summary>Gets or sets the toast host.</summary>
    /// <value>The toast host.</value>
    private IWin32Window? _toastHost;

    /// <summary>Gets or sets the notification icon.</summary>
    /// <value>The notification icon.</value>
    private KryptonToastIcon? _notificationIcon;

    /// <summary>Gets or sets the type of the notification input area.</summary>
    /// <value>The type of the notification input area.</value>
    private KryptonToastInputAreaType? _notificationInputAreaType;

    /// <summary>Gets or sets the toast notification cue text.</summary>
    /// <value>The toast notification cue text.</value>
    private string? _toastNotificationCueText;

    /// <summary>Gets or sets the color of the toast notification cue.</summary>
    /// <value>The color of the toast notification cue.</value>
    private Color? _toastNotificationCueColor;

    #endregion

    #region Identity

    public UserInputNotification()
    {
        InitializeComponent();

        Setup();
    }

    #endregion

    #region Implementation

    private void Setup()
    {
        foreach (var item in Enum.GetValues(typeof(ComboBoxStyle)))
        {
            kcmbDropDownStyle.Items.Add(item);
        }

        kcmbDropDownStyle.SelectedIndex = 0;

        foreach (var icon in Enum.GetValues(typeof(KryptonToastIcon)))
        {
            kcmbToastIcon.Items.Add(icon);
        }

        kcmbToastIcon.SelectedIndex = 0;

        foreach (var value in Enum.GetValues(typeof(KryptonToastInputAreaType)))
        {
            kcmbNotificationInputStyle.Items.Add(value);
        }

        foreach (var state in Enum.GetValues(typeof(CheckState)))
        {
            kcmbDoNotShowAgainOptionCheckState.Items.Add(state);
        }

        kcmbDoNotShowAgainOptionCheckState.SelectedIndex = 0;

        foreach (var alignment in Enum.GetValues(typeof(ContentAlignment)))
        {
            kcmbNotificationContentAlignment.Items.Add(alignment);

            kcmbNotificationTitleAlignment.Items.Add(alignment);
        }

        foreach (var control in Controls)
        {
            kcmbOwner.Items.Add(control);
        }

        kcmbNotificationContentAlignment.SelectedIndex = 0;

        kcmbNotificationTitleAlignment.SelectedIndex = 0;

        kcmbNotificationInputStyle.SelectedIndex = 0;

        kdtpInitialDate.Value = DateTime.Now;

        kdtpMaximumDate.Value = DateTime.MaxValue;

        kdtpMinimumDate.Value = DateTime.MinValue;

        Rectangle workingArea = GetPrimaryWorkingArea();

        knudXAxis.Maximum = workingArea.Width;

        knudYAxis.Maximum = workingArea.Height;

        _topMost = kchkTopMost.Checked;
        _showCloseBox = kchkShowCloseBox.Checked;
        _useFade = kchkUseFade.Checked;
        _reportToastLocation = kchkReportLocation.Checked;
        _notificationContent = ktxtToastContent.Text;
        _notificationTitle = ktxtToastTitle.Text;
        _toastNotificationCueText = ktxtInputCueText.Text;
        _toastNotificationCueColor = kcolCueColor.SelectedColor;
        _borderColor1 = kcbtnBorderColor1.SelectedColor;
        _borderColor2 = kcbtnBorderColor2.SelectedColor;
        _countDownSeconds = Convert.ToInt32(knudCountdownSeconds.Value);
        _countDownTimerInterval = Convert.ToInt32(knudCountDownInterval.Value);
        _maximumDateTimeValue = kdtpMaximumDate.Value;
        _minimumDateTimeValue = kdtpMinimumDate.Value;
        _initialDateTimeValue = kdtpInitialDate.Value;
    }

    private ArrayList CreateUserInputList() => [.. krtxtItemList.Lines];

    private static Rectangle GetPrimaryWorkingArea() => Screen.PrimaryScreen?.WorkingArea ?? Screen.FromPoint(Point.Empty).WorkingArea;

    private Point GetLocation() => new Point(Convert.ToInt32(knudXAxis.Value), Convert.ToInt32(knudYAxis.Value));

    private void ktxtToastTitle_TextChanged(object sender, EventArgs e) => _notificationTitle = ktxtToastTitle.Text;

    private void ktxtToastContent_TextChanged(object sender, EventArgs e) => _notificationContent = ktxtToastContent.Text;

    private void kcmbToastIcon_SelectedIndexChanged(object sender, EventArgs e) =>
        _notificationIcon =
            (KryptonToastIcon)Enum.Parse(typeof(KryptonToastIcon), kcmbToastIcon.Text);

    private void kcmbNotificationInputStyle_SelectedIndexChanged(object sender, EventArgs e) =>
        _notificationInputAreaType =
            (KryptonToastInputAreaType)Enum.Parse(typeof(KryptonToastInputAreaType),
                kcmbNotificationInputStyle.Text);

    private void kcmbDropDownStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        _userInputComboBoxStyle = (ComboBoxStyle)Enum.Parse(typeof(ComboBoxStyle), kcmbDropDownStyle.Text);
    }

    private void ktxtInputCueText_TextChanged(object sender, EventArgs e) => _toastNotificationCueText = ktxtInputCueText.Text;

    private void kcolCueColor_SelectedColorChanged(object sender, ColorEventArgs e) => _toastNotificationCueColor = kcolCueColor.SelectedColor;

    private void krtxtItemList_TextChanged(object sender, EventArgs e)
    {
        //foreach (string line in krtxtItemList.Lines)
        //{
        //    _comboBoxItems.Add(line);
        //}
    }

    private void kchkUseFade_CheckedChanged(object sender, EventArgs e) => _useFade = kchkUseFade.Checked;

    private void kchkShowCloseBox_CheckedChanged(object sender, EventArgs e) => _showCloseBox = kchkShowCloseBox.Checked;

    private void kchkReportLocation_CheckedChanged(object sender, EventArgs e) => _reportToastLocation = kchkReportLocation.Checked;

    private void knudCountdownSeconds_ValueChanged(object sender, EventArgs e) => _countDownSeconds = Convert.ToInt32(knudCountdownSeconds.Value);

    private void kdtpMaximumDate_ValueChanged(object sender, EventArgs e) => _maximumDateTimeValue = kdtpMaximumDate.Value;

    private void kdtpMinimumDate_ValueChanged(object sender, EventArgs e) => _minimumDateTimeValue = kdtpMinimumDate.Value;

    private void kdtpInitialDate_ValueChanged(object sender, EventArgs e) => _initialDateTimeValue = kdtpInitialDate.Value;

    private void kchkTopMost_CheckedChanged(object sender, EventArgs e) => _topMost = kchkTopMost.Checked;

    private void kchkShowDoNotShowAgainOption_CheckedChanged(object sender, EventArgs e) => _showDoNotShowAgainOption = kchkShowDoNotShowAgainOption.Checked;

    private void kchkFocusOnUserInputArea_CheckedChanged(object sender, EventArgs e) => _focusOnUserInputArea = kchkFocusOnUserInputArea.Checked;

    private void kchkUseDoNotShowAgainOptionThreeState_CheckedChanged(object sender, EventArgs e) => _useDoNotShowAgainOptionThreeState = kchkUseDoNotShowAgainOptionThreeState.Checked;

    private void kchkIsDoNotShowAgainOptionChecked_CheckedChanged(object sender, EventArgs e) => _isDoNotShowAgainOptionChecked = kchkIsDoNotShowAgainOptionChecked.Checked;

    private void kchkUseRTLReading_CheckedChanged(object sender, EventArgs e) => _useRtlReading = kchkUseRTLReading.Checked;

    private void kcmbDoNotShowAgainOptionCheckState_SelectedIndexChanged(object sender, EventArgs e) =>
        _doNotShowAgainOptionCheckState =
            (CheckState)Enum.Parse(typeof(CheckState), kcmbDoNotShowAgainOptionCheckState.Text);

    #endregion

    private void kcmbNotificationTitleAlignment_SelectedIndexChanged(object sender, EventArgs e) =>
        _notificationTitleAlignment =
            (ContentAlignment)Enum.Parse(typeof(ContentAlignment), kcmbNotificationTitleAlignment.Text);

    private void kcmbNotificationContentAlignment_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void kcbtnBorderColor1_SelectedColorChanged(object sender, ColorEventArgs e) => _borderColor1 = kcbtnBorderColor1.SelectedColor;

    private void kcbtnBorderColor2_SelectedColorChanged(object sender, ColorEventArgs e) => _borderColor2 = kcbtnBorderColor2.SelectedColor;

    private void kbtnNotificationContentFont_Click(object sender, EventArgs e)
    {
        KryptonFontDialog contentFontDialog = new KryptonFontDialog() {
            Font = new Font("Segoe UI", 9F),
            ShowColor = false
        };

        if (contentFontDialog.ShowDialog() == DialogResult.OK)
        {
            _notificationContentFont = contentFontDialog.Font;
        }
    }

    private void kbtnNotificationTitleFont_Click(object sender, EventArgs e)
    {
        KryptonFontDialog titleFontDialog = new KryptonFontDialog() {
            Font = new Font("Segoe UI", 13.5F, FontStyle.Bold),
            ShowColor = false
        };

        if (titleFontDialog.ShowDialog() == DialogResult.OK)
        {
            _notificationTitleFont = titleFontDialog.Font;
        }
    }

    private void knudCountDownInterval_ValueChanged(object sender, EventArgs e) => _countDownTimerInterval = Convert.ToInt32(knudCountDownInterval.Value);

    private void kcmbOwner_SelectedIndexChanged(object sender, EventArgs e) => _toastHost = this; //(IWin32Window)kcmbOwner.Text;

    private void kbtnShow_Click(object sender, EventArgs e)
    {
        KryptonUserInputToastData notificationData = new KryptonUserInputToastData()
        {
            UseFade = _useFade,
            TopMost = _topMost,
            ShowCloseBox = _showCloseBox,
            ShowDoNotShowAgainOption = _showDoNotShowAgainOption,
            UseDoNotShowAgainOptionThreeState = _useDoNotShowAgainOptionThreeState,
            DoNotShowAgainOptionChecked = _isDoNotShowAgainOptionChecked,
            ReportToastLocation = _reportToastLocation,
            UseRtlReading = _useRtlReading,
            DoNotShowAgainOptionCheckState = _doNotShowAgainOptionCheckState,
            FocusOnUserInputArea = _focusOnUserInputArea,
            NotificationTitleAlignment = _notificationTitleAlignment,
            UserInputComboBoxStyle = _userInputComboBoxStyle,
            BorderColor1 = _borderColor1,
            BorderColor2 = _borderColor2,
            MinimumDateTimeValue = _minimumDateTimeValue,
            MaximumDateTimeValue = _maximumDateTimeValue,
            InitialDateTimeValue = _initialDateTimeValue,
            NotificationContentFont = _notificationContentFont,
            NotificationTitleFont = _notificationTitleFont,
            CountDownSeconds = _countDownSeconds,
            CountDownTimerInterval = _countDownTimerInterval,
            NotificationContent = _notificationContent,
            NotificationTitle = _notificationTitle,
            NotificationLocation = kchkUseDefaultLocation.Checked ? null : GetLocation(),
            ApplicationIcon = Icon ?? SystemIcons.Application,
            ToastHost = _toastHost,
            NotificationIcon = _notificationIcon,
            NotificationInputAreaType = _notificationInputAreaType,
            ToastNotificationCueText = _toastNotificationCueText,
            UserInputList = CreateUserInputList(),
            ToastNotificationCueColor = _toastNotificationCueColor
        };

        if (kchkShowWithProgressBar.Checked)
        {
            KryptonToast.ShowNotificationWithProgressBar(notificationData);
        }
        else
        {
            KryptonToast.ShowNotification(notificationData);
        }
    }

    private void kchkUseDefaultLocation_CheckedChanged(object sender, EventArgs e)
    {
        if (kchkUseDefaultLocation.Checked)
        {
            Rectangle workingArea = GetPrimaryWorkingArea();

            knudXAxis.Value = workingArea.Width - 5;

            knudYAxis.Value = workingArea.Height - 5;
        }
    }
}
