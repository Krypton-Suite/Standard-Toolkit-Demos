#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved. 
 *  
 */
#endregion
using System;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;

namespace DockingPersistence
{
    public partial class Form1 : KryptonForm
    {
        private int _count = 1;
        private byte[] _array1;
        private byte[] _array2;
        private byte[] _array3;

        public Form1()
        {
            InitializeComponent();
        }

        private KryptonPage NewDocument()
        {
            KryptonPage page = NewPage("Document ", 0, new ContentDocument());

            // Document pages cannot be docked or auto hidden
            page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden | KryptonPageFlags.DockingAllowDocked);

            return page;
        }

        private KryptonPage NewInput() => NewPage("Input ", 1, new ContentInput());

        private KryptonPage NewPropertyGrid() => NewPage("Properties ", 2, new ContentPropertyGrid());

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingWorkspace w = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace);
            kryptonDockingManager.ManageControl(kryptonPanel, w);
            kryptonDockingManager.ManageFloating(this);

            // Add docking pages
            kryptonDockingManager.AddDockspace(@"Control", DockingEdge.Left, new[] { NewPropertyGrid() });
            kryptonDockingManager.AddDockspace(@"Control", DockingEdge.Bottom, new[] { NewInput(), NewInput() });
            kryptonDockingManager.AddAutoHiddenGroup(@"Control", DockingEdge.Right, new[] { NewPropertyGrid() });
            kryptonDockingManager.AddToWorkspace("Workspace", new[] { NewDocument(), NewDocument(), NewDocument() });
        }

        private void buttonSaveArray1_Click(object sender, EventArgs e)
        {
            _array1 = kryptonDockingManager.SaveConfigToArray();
            buttonLoadArray1.Enabled = true;
        }

        private void buttonSaveArray2_Click(object sender, EventArgs e)
        {
            _array2 = kryptonDockingManager.SaveConfigToArray();
            buttonLoadArray2.Enabled = true;
        }

        private void buttonSaveArray3_Click(object sender, EventArgs e)
        {
            _array3 = kryptonDockingManager.SaveConfigToArray();
            buttonLoadArray3.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                kryptonDockingManager.SaveConfigToFile(saveFileDialog.FileName);
            }
        }

        private void buttonLoadArray1_Click(object sender, EventArgs e)
        {
            kryptonDockingManager.LoadConfigFromArray(_array1);
        }

        private void buttonLoadArray2_Click(object sender, EventArgs e)
        {
            kryptonDockingManager.LoadConfigFromArray(_array2);
        }

        private void buttonLoadArray3_Click(object sender, EventArgs e)
        {
            kryptonDockingManager.LoadConfigFromArray(_array3);
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                kryptonDockingManager.LoadConfigFromFile(openFileDialog.FileName);
            }
        }


        private void buttonHideAll_Click(object sender, EventArgs e)
        {
            kryptonDockingManager.HideAllPages();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            kryptonDockingManager.ShowAllPages();
        }

        private void kryptonDockingManager_GlobalSaving(object sender, DockGlobalSavingEventArgs e)
        {
            // Example code showing how to save extra data into the global config
            e.XmlWriter.WriteStartElement("CustomGlobalData");
            e.XmlWriter.WriteAttributeString(@"SavedTime", DateTime.Now.ToString(@"u"));
            e.XmlWriter.WriteEndElement();
        }

        private void kryptonDockingManager_GlobalLoading(object sender, DockGlobalLoadingEventArgs e)
        {
            // Example code showing how to reload the extra data that was saved into the global config
            e.XmlReader.Read();
            Console.WriteLine("GlobalConfig was saved at {0}", e.XmlReader.GetAttribute(@"SavedTime"));
            e.XmlReader.Read();
        }

        private void kryptonDockingManager_PageSaving(object sender, DockPageSavingEventArgs e)
        {
            // Example code showing how to save extra data into the page config
            e.XmlWriter.WriteStartElement("CustomPageData");
            e.XmlWriter.WriteAttributeString(@"SavedMilliseconds", DateTime.Now.Millisecond.ToString());
            e.XmlWriter.WriteEndElement();
        }

        private void kryptonDockingManager_PageLoading(object sender, DockPageLoadingEventArgs e)
        {
            // Example code showing how to reload the extra data that was saved into the page config
            e.XmlReader.Read();
            Console.WriteLine("PageConfig was saved at {0}", e.XmlReader.GetAttribute(@"SavedMilliseconds"));
            e.XmlReader.Read();
        }

        private void kryptonContextMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
