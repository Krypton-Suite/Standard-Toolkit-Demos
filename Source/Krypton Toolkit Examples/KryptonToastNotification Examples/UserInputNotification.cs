using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonToastNotificationExamples
{
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

        /// <summary>Gets or sets the custom image.</summary>
        /// <value>The custom image.</value>
        private Bitmap? _customImage;

        /// <summary>Gets or sets the notification location.</summary>
        /// <value>The notification location.</value>
        private Point? _notificationLocation;

        /// <summary>Gets or sets the application icon.</summary>
        /// <value>The application icon.</value>
        private Icon _applicationIcon;

        /// <summary>Gets or sets the toast host.</summary>
        /// <value>The toast host.</value>
        private IWin32Window? _toastHost;

        /// <summary>Gets or sets the notification icon.</summary>
        /// <value>The notification icon.</value>
        private KryptonToastNotificationIcon? _notificationIcon;

        /// <summary>Gets or sets the type of the notification input area.</summary>
        /// <value>The type of the notification input area.</value>
        private KryptonToastNotificationInputAreaType? _notificationInputAreaType;

        /// <summary>Gets or sets the toast notification cue text.</summary>
        /// <value>The toast notification cue text.</value>
        private string? _toastNotificationCueText;

        /// <summary>Gets or sets the optional CheckBox text.</summary>
        /// <value>The optional CheckBox text.</value>
        private string? _optionalCheckBoxText;

        /// <summary>Gets or sets the user input list.</summary>
        /// <value>The user input list.</value>
        private ArrayList _userInputList;

        /// <summary>Gets or sets the index of the selected user input.</summary>
        /// <value>The index of the selected user input.</value>
        private int? _selectedIndex;

        /// <summary>Gets or sets the date time format.</summary>
        /// <value>The date time format.</value>
        private DateTimePickerFormat? _dateTimeFormat;

        /// <summary>Gets or sets the custom date time format.</summary>
        /// <value>The custom date time format.</value>
        private string? _customDateTimeFormat;

        /// <summary>Gets or sets the color of the toast notification cue.</summary>
        /// <value>The color of the toast notification cue.</value>
        private Color? _toastNotificationCueColor;

        /// <summary>Gets or sets the initial numeric up down value.</summary>
        /// <value>The initial numeric up down value.</value>
        private int? _initialNumericUpDownValue;

        /// <summary>Gets or sets the maximum numeric up down value.</summary>
        /// <value>The maximum numeric up down value.</value>
        private int? _maximumNumericUpDownValue;

        /// <summary>Gets or sets the minimum numeric up down value.</summary>
        /// <value>The minimum numeric up down value.</value>
        private int? _minimumNumericUpDownValue;

        /// <summary>Gets or sets the drop-down style.</summary>
        /// <value>The drop-down style.</value>
        private ComboBoxStyle? _dropDownStyle;

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

            foreach (var icon in Enum.GetValues(typeof(KryptonToastNotificationIcon)))
            {
                kcmbToastIcon.Items.Add(icon);
            }

            kcmbToastIcon.SelectedIndex = 0;

            foreach (var value in Enum.GetValues(typeof(KryptonToastNotificationInputAreaType)))
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

            knudXAxis.Maximum = Screen.PrimaryScreen.WorkingArea.Height;

            knudYAxis.Maximum = Screen.PrimaryScreen.WorkingArea.Width;
        }

        private ArrayList CreateUserInputList()
        {
            _userInputList = [.. krtxtItemList.Lines];

            return _userInputList;
        }

        private Point GetLocation() => new Point(Convert.ToInt32(knudXAxis.Value), Convert.ToInt32(knudYAxis.Value));

        private void ktxtToastTitle_TextChanged(object sender, EventArgs e) => _notificationTitle = ktxtToastTitle.Text;

        private void ktxtToastContent_TextChanged(object sender, EventArgs e) => _notificationContent = ktxtToastContent.Text;

        private void kcmbToastIcon_SelectedIndexChanged(object sender, EventArgs e) =>
            _notificationIcon =
                (KryptonToastNotificationIcon)Enum.Parse(typeof(KryptonToastNotificationIcon), kcmbToastIcon.Text);

        private void kcmbNotificationInputStyle_SelectedIndexChanged(object sender, EventArgs e) =>
            _notificationInputAreaType =
                (KryptonToastNotificationInputAreaType)Enum.Parse(typeof(KryptonToastNotificationInputAreaType),
                    kcmbNotificationInputStyle.Text);

        private void kcmbDropDownStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dropDownStyle = (ComboBoxStyle)Enum.Parse(typeof(ComboBoxStyle), kcmbDropDownStyle.Text);

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
            KryptonUserInputToastNotificationData notificationData = new KryptonUserInputToastNotificationData() { };

            if (kchkShowWithProgressBar.Checked)
            {
                KryptonToastNotification.ShowNotificationWithProgressBar(notificationData);
            }
            else
            {
                KryptonToastNotification.ShowNotification(notificationData);
            }
        }

        private void kchkUseDefaultLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (kchkUseDefaultLocation.Checked)
            {
                knudXAxis.Value = Screen.PrimaryScreen.WorkingArea.Height - 5;

                knudYAxis.Value = Screen.PrimaryScreen.WorkingArea.Width - 5;
            }
        }
    }
}
