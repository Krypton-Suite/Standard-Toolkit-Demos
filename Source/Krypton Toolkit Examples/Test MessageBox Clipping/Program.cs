// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace TestMessageBoxClipping
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KryptonMessageBox.Show("Test without an owner,\nand before KyptonManager has Loaded");
            KryptonMessageBox.Show((string)null, "Test without no Text");
            Application.Run(new Form1());
        }
    }
}
