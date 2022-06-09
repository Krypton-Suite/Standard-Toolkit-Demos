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
using System.Windows.Forms;
using Krypton.Toolkit;

namespace KryptonCommandExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void buttonAttach_Click(object sender, EventArgs e) => AssignCommand(kryptonCommand);

        private void buttonUnattach_Click(object sender, EventArgs e) => AssignCommand(null);

        private void AssignCommand(KryptonCommand command)
        {
            buttonSpecAny1.KryptonCommand = command;
            kryptonButton1.KryptonCommand = command;
            kryptonCheckButton1.KryptonCommand = command;
            kryptonDropButton1.KryptonCommand = command;
            kryptonColorButton1.KryptonCommand = command;
            kryptonLabel1.KryptonCommand = command;
            kryptonLinkLabel1.KryptonCommand = command;
            kryptonCheckBox1.KryptonCommand = command;
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }
}
