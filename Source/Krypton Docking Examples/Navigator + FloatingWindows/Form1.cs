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

namespace NavigatorAndFloatingWindows
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _count = 1;
        private KryptonPage NewPage(string name, int image, Control content)
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

        private KryptonPage NewDocument()
        {
            KryptonPage page = NewPage("Document ", 0, new ContentDocument());

            // Do not allow the document pages to be closed or made auto hidden/docked
            page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden |
                            KryptonPageFlags.DockingAllowDocked |
                            KryptonPageFlags.DockingAllowClose);

            return page;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingNavigator n = kryptonDockingManager.ManageNavigator(kryptonDockableNavigator);
            kryptonDockingManager.ManageFloating(this);

            // Add initial floating window and navigator documents
            kryptonDockingManager.AddFloatingWindow("Floating", new KryptonPage[] { NewDocument(), NewDocument() });
            kryptonDockingManager.AddToNavigator("Navigator", new KryptonPage[] { NewDocument(), NewDocument(), NewDocument() });
        }
    }
}
