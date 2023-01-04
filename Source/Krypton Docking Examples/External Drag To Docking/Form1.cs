#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 */
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;

namespace ExternalDragToDocking
{
    public partial class Form1 : KryptonForm
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        public KryptonPage NewDocument() => NewPage("Document ", 0, new ContentDocument());

        public KryptonPage NewInput() => NewPage("Input ", 1, new ContentInput());

        public KryptonPage NewPropertyGrid() => NewPage("Properties ", 2, new ContentPropertyGrid());

        public KryptonPage NewTreeView() => NewPage("TreeView ", 3, new ContentTreeView(this));

        public KryptonPage NewPage(string name, int image, Control content)
        {
            // Create new page with title and image
            KryptonPage p = new KryptonPage
            {
                Text = name + _count.ToString(),
                TextTitle = name + _count.ToString(),
                TextDescription = name + _count.ToString()
            };
            p.UniqueName = p.Text;
            p.ImageSmall = (Bitmap)imageListSmall.Images[image];

            // Add the control for display inside the page
            content.Dock = DockStyle.Fill;
            p.Controls.Add(content);

            _count++;
            return p;
        }

        public KryptonDockingManager DockingManager => kryptonDockingManager;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingWorkspace w = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace);
            kryptonDockingManager.ManageControl(kryptonPanel, w);
            kryptonDockingManager.ManageFloating(this);

            // Add initial docking pages
            kryptonDockingManager.AddDockspace(@"Control", DockingEdge.Left, new[] { NewTreeView() });
            kryptonDockingManager.AddToWorkspace("Workspace", new[] { NewDocument() });
        }
    }
}
