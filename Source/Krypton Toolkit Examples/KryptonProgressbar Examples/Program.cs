// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
// By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2023 - 2025. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;

namespace KryptonProgressBarExamples
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
