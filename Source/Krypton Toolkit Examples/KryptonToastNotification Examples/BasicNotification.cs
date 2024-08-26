using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonToastNotificationExamples
{
    public partial class BasicNotification : KryptonForm
    {
        #region Instance Fields

        private bool _showCloseBox;
        private bool _topMost;
        private bool _useFade;
        private bool _reportLocation;
        private ContentAlignment _titleAlignment;
        private Color _borderColor1;
        private Color _borderColor2;
        private Font _contentFont;
        private Font _titleFont;
        private int _countDownSeconds;
        private KryptonToastNotificationIcon _notificationIcon;
        private string _notificationTitleText;
        private string _notificationContentText;

        #endregion
        
        public BasicNotification()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set defaults
            _showCloseBox = false;
            _topMost = true;
            _useFade = false;
            _reportLocation = false;
            _titleAlignment = ContentAlignment.MiddleCenter;
            _borderColor1 = Color.Empty;
            _borderColor2 = Color.Empty;
            _contentFont = null;
            _titleFont = null;
            _countDownSeconds = 60;
            _notificationIcon = KryptonToastNotificationIcon.Information;
            _notificationTitleText = ktxtToastTitle.Text;
            _notificationContentText = ktxtToastContent.Text;

            kcbBorderColor1.SelectedColor = Color.Empty;
            kcbBorderColor2.SelectedColor = Color.Empty;

            foreach (var value in Enum.GetValues(typeof(KryptonToastNotificationIcon)))
            {
                kcmbToastIcon.Items.Add(value.ToString());
            }

            kcmbToastIcon.SelectedIndex = 8;

            foreach (var value in Enum.GetValues(typeof(ContentAlignment)))
            {
                kcmbToastTitleAlignment.Items.Add(value.ToString());
            }

            kcmbToastTitleAlignment.SelectedIndex = 4;
        }

        private void ktxtToastTitle_TextChanged(object sender, EventArgs e)
        {
            _notificationTitleText = ktxtToastTitle.Text;
        }

        private void ktxtToastContent_TextChanged(object sender, EventArgs e)
        {
            _notificationContentText = ktxtToastContent.Text;
        }

        private void kcmbToastIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            _notificationIcon =
                (KryptonToastNotificationIcon)Enum.Parse(typeof(KryptonToastNotificationIcon), kcmbToastIcon.Text);
        }

        private void kcmbToastTitleAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            _titleAlignment = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), kcmbToastTitleAlignment.Text);
        }

        private void kbtnContentFont_Click(object sender, EventArgs e)
        {
            KryptonFontDialog contentFontDialog = new KryptonFontDialog();

            if (contentFontDialog.ShowDialog() == DialogResult.OK)
            {
                _contentFont = contentFontDialog.Font;
            }
        }

        private void kbtnTitleFont_Click(object sender, EventArgs e)
        {
            KryptonFontDialog titleFontDialog = new KryptonFontDialog();

            if (titleFontDialog.ShowDialog() == DialogResult.OK)
            {
                _titleFont = titleFontDialog.Font;
            }
        }

        private void knudCountdownSeconds_ValueChanged(object sender, EventArgs e)
        {
            _countDownSeconds = (int)knudCountdownSeconds.Value;
        }

        private void kbtnShow_Click(object sender, EventArgs e)
        {
            KryptonBasicToastNotificationData notificationData = new KryptonBasicToastNotificationData() {
                CountDownSeconds = _countDownSeconds,
                CustomImage = null,
                NotificationContent = _notificationContentText,
                NotificationTitle = _notificationTitleText,
                NotificationContentFont = _contentFont,
                NotificationTitleFont = _titleFont,
                NotificationIcon = _notificationIcon,
                NotificationLocation = null,
                NotificationTitleAlignment = _titleAlignment,
                TopMost = _topMost,
                UseFade = _useFade,
                ShowCloseBox = _showCloseBox,
                ReportToastLocation = _reportLocation,
                BorderColor1 = _borderColor1,
                BorderColor2 = _borderColor2
            };

            if (kchkShowProgressBar.Checked)
            {
                KryptonToastNotification.ShowBasicProgressBarNotification(notificationData);
            }
            else
            {
                KryptonToastNotification.ShowBasicNotification(notificationData);
            }
        }

        private void kchkUseFade_CheckedChanged(object sender, EventArgs e)
        {
            _useFade = kchkUseFade.Checked;
        }

        private void kchkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            _topMost = kchkTopMost.Checked;
        }

        private void kchkShowCloseBox_CheckedChanged(object sender, EventArgs e)
        {
            _showCloseBox = kchkShowCloseBox.Checked;
        }

        private void kchkReportLocation_CheckedChanged(object sender, EventArgs e)
        {
            _reportLocation = kchkReportLocation.Checked;
        }
    }
}
