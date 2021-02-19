// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 5.550.0  www.ComponentFactory.com
//
// *****************************************************************************

using System;
using System.Windows.Forms;

namespace StandardDocking
{
    public partial class ContentDocument : UserControl
    {
        public ContentDocument()
        {
            InitializeComponent();
        }

        private void ContentDocument_Load(object sender, EventArgs e)
        {
            Console.WriteLine("ContentDocument_Load");
        }
    }
}
