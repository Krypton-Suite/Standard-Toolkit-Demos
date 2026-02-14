#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Utilities;

namespace KryptonBugReportingDialogExample;

public partial class Form1 : KryptonForm
{
    private readonly KryptonErrorProvider _errorProvider;

    public Form1()
    {
        InitializeComponent();

        _errorProvider = new KryptonErrorProvider
        {
            ContainerControl = this,
            BlinkStyle = KryptonErrorBlinkStyle.BlinkIfDifferentError
        };

        LoadDefaultEmailConfig();
    }

    private void LoadDefaultEmailConfig()
    {
        ktbSmtpServer.Text = @"smtp.example.com";
        ktbSmtpPort.Text = @"587";
        kchkUseSsl.Checked = true;
        ktbFromEmail.Text = @"app@example.com";
        ktbToEmail.Text = @"bugs@example.com";
        ktbUsername.Text = @"app@example.com";
        ktbPassword.Text = string.Empty;
    }

    private BugReportEmailConfig GetEmailConfig()
    {
        if (!int.TryParse(ktbSmtpPort.Text, out var port))
        {
            port = 587;
        }

        return new BugReportEmailConfig
        {
            SmtpServer = ktbSmtpServer.Text,
            SmtpPort = port,
            UseSsl = kchkUseSsl.Checked,
            FromEmail = ktbFromEmail.Text,
            ToEmail = ktbToEmail.Text,
            Username = ktbUsername.Text,
            Password = ktbPassword.Text
        };
    }

    private bool ValidateEmailConfig()
    {
        bool isValid = true;

        if (string.IsNullOrWhiteSpace(ktbSmtpServer.Text))
        {
            _errorProvider.SetError(ktbSmtpServer, @"Please enter SMTP server address.");
            isValid = false;
        }
        else
        {
            _errorProvider.SetError(ktbSmtpServer, string.Empty);
        }

        if (string.IsNullOrWhiteSpace(ktbToEmail.Text))
        {
            _errorProvider.SetError(ktbToEmail, @"Please enter recipient email address.");
            isValid = false;
        }
        else
        {
            _errorProvider.SetError(ktbToEmail, string.Empty);
        }

        return isValid;
    }

    private void ValidateSmtpServer() =>
        _errorProvider.SetError(ktbSmtpServer,
            string.IsNullOrWhiteSpace(ktbSmtpServer.Text) ? @"Please enter SMTP server address." : string.Empty);

    private void ValidateToEmail() =>
        _errorProvider.SetError(ktbToEmail,
            string.IsNullOrWhiteSpace(ktbToEmail.Text) ? @"Please enter recipient email address." : string.Empty);

    private void kbtnShowBugReport_Click(object sender, EventArgs e)
    {
        if (!ValidateEmailConfig())
        {
            return;
        }

        var emailConfig = GetEmailConfig();
        var result = KryptonBugReportingDialog.Show(emailConfig);

        if (result == DialogResult.OK)
        {
            KryptonMessageBox.Show(@"Bug report sent successfully!", @"Success", KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information);
        }
    }

    private void kbtnShowBugReportWithException_Click(object sender, EventArgs e)
    {
        if (!ValidateEmailConfig())
        {
            return;
        }

        try
        {
            throw new InvalidOperationException(@"This is a test exception for bug reporting.");
        }
        catch (Exception ex)
        {
            var emailConfig = GetEmailConfig();
            var result = KryptonBugReportingDialog.Show(ex, emailConfig);

            if (result == DialogResult.OK)
            {
                KryptonMessageBox.Show(@"Bug report with exception sent successfully!", @"Success",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }
    }

    private void kbtnShowExceptionWithBugReporting_Click(object sender, EventArgs e)
    {
        if (!ValidateEmailConfig())
        {
            return;
        }

        try
        {
            throw new ArgumentOutOfRangeException(@"testParameter", 100,
                @"This is a test exception to demonstrate integrated bug reporting.");
        }
        catch (Exception ex)
        {
            var emailConfig = GetEmailConfig();
            BugReportingHelper.ShowExceptionWithBugReporting(
                ex,
                emailConfig,
                highlightColor: Color.Orange,
                showCopyButton: true,
                showSearchBox: true
            );
        }
    }

    private void kbtnTestEmailConfig_Click(object sender, EventArgs e)
    {
        if (!ValidateEmailConfig())
        {
            return;
        }

        var emailConfig = GetEmailConfig();
        var service = new BugReportEmailService();

        kbtnTestEmailConfig.Enabled = false;
        kbtnTestEmailConfig.Text = @"Testing...";
        Application.DoEvents();

        try
        {
            var success = service.SendBugReport(
                emailConfig,
                "Test Email - Bug Reporting Configuration",
                $"This is a test email sent at {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n" +
                "If you receive this email, your SMTP configuration is working correctly.",
                null
            );

            if (success)
            {
                KryptonMessageBox.Show(
                    "Email configuration test successful!\n\n" +
                    "Please check the recipient email inbox to confirm receipt.",
                    "Test Successful",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Information
                );
            }
            else
            {
                KryptonMessageBox.Show(
                    "Email configuration test failed.\n\n" +
                    "Please check:\n" +
                    "- SMTP server address and port\n" +
                    "- Username and password (if authentication is required)\n" +
                    "- SSL/TLS settings\n" +
                    "- Firewall and network connectivity",
                    "Test Failed",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error
                );
            }
        }
        catch (Exception ex)
        {
            KryptonMessageBox.Show(
                $@"Error testing email configuration:\n\n{ex.Message}",
                @"Test Error",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Error
            );
        }
        finally
        {
            kbtnTestEmailConfig.Enabled = true;
            kbtnTestEmailConfig.Text = @"Test Email Configuration";
        }
    }

    private void kbtnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ktbSmtpServer_TextChanged(object sender, EventArgs e)
    {
        ValidateSmtpServer();
    }

    private void ktbToEmail_TextChanged(object sender, EventArgs e)
    {
        ValidateToEmail();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        _errorProvider?.Clear();
        _errorProvider?.Dispose();
    }
}