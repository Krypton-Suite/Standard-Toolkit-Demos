// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  Created by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2018 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-Toolkit-Suite-NET-Core)
//  Version 5.550.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;

namespace PaletteUpgradeTool
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
            Application.Run(new UI.PaletteUpgradeTool());
        }
    }
}
