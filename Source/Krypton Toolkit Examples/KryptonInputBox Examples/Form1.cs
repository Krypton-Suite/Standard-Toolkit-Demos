// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 5.550.0 	www.ComponentFactory.com
// *****************************************************************************

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
