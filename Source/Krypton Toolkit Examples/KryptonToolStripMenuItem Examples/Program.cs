// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
// By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV), tobitege 2025 - 2025. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;

namespace KryptonToolStripMenuItemExamples
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuToolBarStatusStripTest());
        }
    }
}