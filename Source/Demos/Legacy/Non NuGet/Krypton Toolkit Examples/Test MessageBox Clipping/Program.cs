﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2020, All rights reserved.
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 5.550.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace TestMessageBoxClipping
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KryptonMessageBox.Show("Test without an owner,\nand before KyptonManager has Loaded", null);
            KryptonMessageBox.Show((string)null, "Test without no Text");
            Application.Run(new Form1());
        }
    }
}
