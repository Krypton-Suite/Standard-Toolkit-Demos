#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion

using System;

using Krypton.Toolkit;

namespace OutlookMailClone
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formatPlainText_Click(object sender, EventArgs e)
        {
            // If it has become checked, then ensure other options are no
            // longer in the checked state. If we are clicked to make unchecked
            // then override that behavior by forcing outself back to checked.
            if (formatPlainText.Checked)
            {
                formatHTML.Checked = false;
                formatRichText.Checked = false;
            }
            else
                formatPlainText.Checked = true;
        }

        private void formatHTML_Click(object sender, EventArgs e)
        {
            // If it has become checked, then ensure other options are no
            // longer in the checked state. If we are clicked to make unchecked
            // then override that behavior by forcing outself back to checked.
            if (formatHTML.Checked)
            {
                formatPlainText.Checked = false;
                formatRichText.Checked = false;
            }
            else
                formatHTML.Checked = true;
        }

        private void formatRichText_Click(object sender, EventArgs e)
        {
            // If it has become checked, then ensure other options are no
            // longer in the checked state. If we are clicked to make unchecked
            // then override that behavior by forcing outself back to checked.
            if (formatRichText.Checked)
            {
                formatPlainText.Checked = false;
                formatHTML.Checked = false;
            }
            else
                formatRichText.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
