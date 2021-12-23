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

using Krypton.Docking;
using Krypton.Navigator;

namespace MultiControlDocking
{
    public partial class Form1 : Form
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private KryptonPage NewInput() => NewPage(@"Input ", 1, new ContentInput());

        private KryptonPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = name + _count.ToString(),
                TextTitle = name + _count.ToString(),
                TextDescription = name + _count.ToString(),
                ImageSmall = (Bitmap)imageListSmall.Images[image]
            };

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);
            p.MinimumSize = content.MinimumSize;

            _count++;
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add docking to the two panels and allow floating windows
            kryptonDockingManager.ManageControl(@"Control1", kryptonPanel2);
            kryptonDockingManager.ManageControl(@"Control2", kryptonPanel3);
            kryptonDockingManager.ManageFloating(this);


            // Add docking pages
            kryptonDockingManager.AddDockspace(@"Control1", DockingEdge.Left, new KryptonPage[] { NewInput(), NewInput() });
            kryptonDockingManager.AddDockspace(@"Control1", DockingEdge.Bottom, new KryptonPage[] { NewInput(), NewInput() });
            kryptonDockingManager.AddDockspace(@"Control2", DockingEdge.Bottom, new KryptonPage[] { NewInput(), NewInput() });
            kryptonDockingManager.AddAutoHiddenGroup(@"Control2", DockingEdge.Right, new KryptonPage[] { NewInput(), NewInput() });
        }
    }
}
