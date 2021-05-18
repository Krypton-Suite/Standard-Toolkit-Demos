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

#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 *  Modified: Tuesday 18th May, 2021 @ 12:15 GMT
 *
 */
#endregion

using System;

using Krypton.Toolkit;

namespace KryptonInputBoxExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kbtnShow_Click(object sender, EventArgs e)
        {
            KryptonInputBox.Show(this, ktxtUserPrompt.Text, ktxtCaption.Text, ktxtDefaultResponse.Text, kcbCueColour.SelectedColor, fdCueTypeface.Font, ktxtCueText.Text);
        }

        private void kbtnCueTypeface_Click(object sender, EventArgs e)
        {
            fdCueTypeface.ShowDialog();
        }
    }
}
