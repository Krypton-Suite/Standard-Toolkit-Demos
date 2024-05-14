using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonToastNotificationExamples
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

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

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
