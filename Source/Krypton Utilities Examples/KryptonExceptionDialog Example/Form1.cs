#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Krypton.Toolkit;
using Krypton.Toolkit.Utilities;

namespace KryptonExceptionDialogExample;

public partial class Form1 : KryptonForm
{
    public Form1()
    {
        InitializeComponent();
    }

    private void kbtnTriggerException_Click(object sender, EventArgs e)
    {
        try
        {
            // Intentionally trigger a divide by zero exception
            int zero = 0;
            int result = 10 / zero;
        }
        catch (Exception ex)
        {
            // Show the exception dialog using KryptonExceptionDialog
            KryptonExceptionDialog.Show(ex, kcbtnHighlightColor.SelectedColor, kchkShowCopyButton.Checked, kchkShowCopyButton.Checked, kchkShowSearchItems.Checked, (exception) =>
            {
                // Example bug report callback
                KryptonMessageBox.Show("Bug report submitted for exception: " + exception.Message);
            });
        }
    }
}