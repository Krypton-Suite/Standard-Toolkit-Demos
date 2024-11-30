// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2024 - 2024. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonToastNotificationExamples
{
    public partial class MainForm : KryptonForm
    {
        public MainForm() => InitializeComponent();

        private void kbtnCreateBasicNotification_Click(object sender, EventArgs e)
        {
            BasicNotification basicNotification = new BasicNotification();

            basicNotification.Show();
        }

        private void kbtnCreateUserInputNotification_Click(object sender, EventArgs e)
        {
            UserInputNotification userInputNotification = new UserInputNotification();

            userInputNotification.Show();
        }

        private void kbtnCancel_Click(object sender, EventArgs e) => Application.Exit();
    }
}
