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
using System.Drawing;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonInputBoxExamples
{
    public partial class Form1 : KryptonForm
    {
        private Font _cueTypeface;

        public Form1()
        {
            InitializeComponent();

            _cueTypeface = new Font("Microsoft Sans Serif", 8f);
        }

        private void kbtnCueTypeface_Click(object sender, EventArgs e)
        {
            FontDialog cueTypeface = new FontDialog();

            if (cueTypeface.ShowDialog() == DialogResult.OK)
            {
                _cueTypeface = cueTypeface.Font;
            }
        }

        private void kbtnShow_Click(object sender, EventArgs e)
        {
            KryptonInputBox.Show(ktxtPromptText.Text, ktxtCaptionText.Text, ktxtDefaultResponseText.Text, ktxtCueText.Text, kcbCueTextColour.SelectedColor, _cueTypeface, kchkUsePasswordOption.Checked);
        }
    }
}
