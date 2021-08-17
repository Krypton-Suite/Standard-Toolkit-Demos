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

namespace MDIRibbon
{
    public partial class Form1 : KryptonForm
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start by creating three MDI child windows
            AddMDIChildWindow();
            AddMDIChildWindow();
            AddMDIChildWindow();
        }

        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            // Add another MDI child window
            AddMDIChildWindow();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            // Close just the active child
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void buttonCloseAllWindows_Click(object sender, EventArgs e)
        {
            // Keep closing active children until all gone
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void buttonCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void buttonTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void buttonTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void buttonSpecHelp_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void AddMDIChildWindow()
        {
            Form2 f = new Form2();
            f.Text = "Child " + (_count++).ToString();
            f.MdiParent = this;
            f.Show();
        }

        private void appMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
