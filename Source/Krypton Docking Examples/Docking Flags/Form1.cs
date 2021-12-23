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
using Krypton.Toolkit;

namespace DockingFlags
{
    public partial class Form1 : KryptonForm
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private KryptonPage NewDocument()
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = "Document " + _count.ToString()
            };
            p.TextTitle = p.Text;
            p.TextDescription = p.Text;
            p.UniqueName = p.Text;
            p.ImageSmall = (Bitmap)imageListSmall.Images[0];

            // Add the control for display inside the page
            ContentDocument contentDoc = new ContentDocument
            {
                Dock = DockStyle.Fill
            };
            p.Controls.Add(contentDoc);

            _count++;
            return p;
        }

        private KryptonPage NewFlags()
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = "Flags " + _count.ToString()
            };
            p.TextTitle = p.Text;
            p.TextDescription = p.Text;
            p.UniqueName = p.Text;
            p.ImageSmall = (Bitmap)imageListSmall.Images[1];

            // Add the control for display inside the page
            ContentFlags contentFlags = new ContentFlags(p)
            {
                Dock = DockStyle.Fill
            };
            p.Controls.Add(contentFlags);

            _count++;
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingWorkspace w = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace);
            kryptonDockingManager.ManageControl(kryptonPanel, w);
            kryptonDockingManager.ManageFloating(this);

            // Add docking pages
            kryptonDockingManager.AddDockspace(@"Control", DockingEdge.Left, new KryptonPage[] { NewFlags(), NewFlags() });
            kryptonDockingManager.AddDockspace(@"Control", DockingEdge.Bottom, new KryptonPage[] { NewDocument() });
            kryptonDockingManager.AddToWorkspace("Workspace", new KryptonPage[] { NewFlags(), NewFlags() });
        }
    }
}
