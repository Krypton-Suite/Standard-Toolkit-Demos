#region BSD License
/*
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using Krypton.Toolkit;

using KryptonToolkitHub.Classes;

namespace KryptonToolkitHub.UX
{
    public partial class SplashWindow : KryptonForm
    {
        public SplashWindow()
        {
            InitializeComponent();
        }

        private void SplashWindow_Load(object sender, EventArgs e)
        {
            _fadeEffects.FadeInWindow(this);
#if DEBUG
            klblTitle.Values.ExtraText = $"Debug (Build: {_applicationVersion.Build})";
            tmrSplash.Enabled = false;
            _io.DisplayApplicationExecutablePath();
            tmrSplash.Enabled = true;
#endif
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            pbProgress.Increment(20);

            //if (TaskbarManager.IsPlatformSupported)
            //{
            //    TaskbarManager.Instance.SetProgressValue(pbProgress.Value, pbProgress.Maximum);

            //    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
            //}

            if (pbProgress.Value == 25)
            {
                //if (_settingsManager.GetFirstLaunch())
                //{
                //    if (_io.DoesFileExist(_fileDatabasePath))
                //    {
                //        _io.CreateFileList(Application.ExecutablePath, _fileDatabasePath);
                //    }
                //    else
                //    {
                //        _io.CreateFile(_fileDatabasePath);

                //        _io.CreateFileList(Application.ExecutablePath, _fileDatabasePath);
                //    }
                //}
            }
            else if (pbProgress.Value == pbProgress.Maximum)
            {
                MainWindow mainWindow = new();
                mainWindow.Closed += (o, args) => Close();

                _fadeEffects.FadeOutWindow(this, mainWindow);

                tmrSplash.Enabled = false;
            }
        }

        private void SplashWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        #region Variables

        private readonly IOOperations _io = new();
        public FadeEffects _fadeEffects = new();
        private readonly Version _applicationVersion = Assembly.GetExecutingAssembly().GetName().Version;

        private string _fileDatabasePath = Directory.GetParent(Application.ExecutablePath) + @"\\Files",
            _fileName = @"\\File List.kfdb";

        #endregion
    }
}