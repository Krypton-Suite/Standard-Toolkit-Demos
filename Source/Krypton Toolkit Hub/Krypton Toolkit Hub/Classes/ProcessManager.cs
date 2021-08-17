#region BSD License
/*
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonToolkitHub.Classes
{
    public class ProcessManager
    {
        #region Variables

        #endregion

        #region Constructor

        #endregion

        #region Properties

        public static string ProcessFilePath { get; set; } = string.Empty;

        #endregion

        #region Methods

        /// <summary>
        ///     Launches the process.
        /// </summary>
        /// <param name="processName">Name of the process.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void LaunchProcess(string processName, bool useFullPath = false)
        {
            try
            {
                if (File.Exists(processName))
                {
                    Process.Start(processName);

                    SetProcessFilePath(processName, useFullPath);
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An error has occurred: {exc.Message}", "Unexpected Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Setters & Getters

        /// <summary>
        ///     Sets the process file path.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="useFullPath">if set to <c>true</c> [use full path].</param>
        public static void SetProcessFilePath(string value, bool useFullPath = false)
        {
            if (useFullPath)
                ProcessFilePath = Path.GetFullPath(value);
            else
                ProcessFilePath = Path.GetFileName(value);
        }

        /// <summary>
        ///     Gets the process file path.
        /// </summary>
        /// <returns></returns>
        public static string GetProcessFilePath()
        {
            if (ProcessFilePath != string.Empty)
                return ProcessFilePath;
            return "NULL STRING";
        }

        #endregion
    }
}