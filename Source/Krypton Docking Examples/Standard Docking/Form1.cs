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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Toolkit;
using Krypton.Workspace;

namespace StandardDocking
{
    public partial class Form1 : KryptonForm
    {
        private int _count = 1;
        private KryptonPage _props3;

        public Form1()
        {
            InitializeComponent();
        }

        private KryptonPage NewDocument()
        {
            KryptonPage page = NewPage(@"Document ", 0, new ContentDocument());

            // Document pages cannot be docked or auto hidden
            page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden | KryptonPageFlags.DockingAllowDocked);
            
            return page;
        }

        private KryptonPage NewInput() => NewPage(@"Input ", 1, new ContentInput(), null);

        private KryptonPage NewPropertyGrid() => NewPage(@"Properties ", 2, new ContentPropertyGrid(), new Size(300, 300));

        private KryptonPage NewPage(string name, int image, Control content, Size ?autoHiddenSizeHint = null)
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

            _count++;
            if (autoHiddenSizeHint.HasValue)
            {
                p.AutoHiddenSlideSize = autoHiddenSizeHint.Value;
            }
            return p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup docking functionality
            KryptonDockingWorkspace w = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace);
            kryptonDockingManager.ManageControl(kryptonPanel, w);
            kryptonDockingManager.ManageFloating(this);

            // Add initial docking pages
            kryptonDockingManager.AddToWorkspace(@"Workspace", new[] { NewDocument(), NewDocument() });
            _props3 = NewPropertyGrid();
            kryptonDockingManager.AddDockspace(@"Control", DockingEdge.Right, new[] { _props3, NewInput() });
            kryptonDockingManager.AddDockspace(@"Control", DockingEdge.Bottom, new[] { NewInput(), NewPropertyGrid() });

            // Set correct initial ribbon palette buttons
            UpdatePaletteButtons();
        }

        private void buttonDocumentSingle_Click(object sender, EventArgs e)
        {
            // Get access to current active cell or create new cell if none are present
            KryptonWorkspaceCell cell = kryptonDockableWorkspace.ActiveCell;
            if (cell == null)
            {
                cell = new KryptonWorkspaceCell();
                kryptonDockableWorkspace.Root.Children.Add(cell);
            }

            // Create new document to be added into workspace
            KryptonPage page = NewDocument();
            cell.Pages.Add(page);

            // Make the new page the selected page
            cell.SelectedPage = page;
        }

        private void buttonDocumentTabbed_Click(object sender, EventArgs e)
        {
            // Add a new cell with three pages into the root sequence of the workspace
            KryptonWorkspaceCell cell = new KryptonWorkspaceCell();
            cell.Pages.AddRange(new[] { NewDocument(), NewDocument(), NewDocument() });
            kryptonDockableWorkspace.Root.Children.Add(cell);
        }

        private void buttonFloatingSingle_Click(object sender, EventArgs e) =>
            // Add a new floating window with a single page
            kryptonDockingManager.AddFloatingWindow(@"Floating", new[] { NewInput() });

        private void buttonFloatingTabbed_Click(object sender, EventArgs e) =>
            // Add a new floating window with two pages
            kryptonDockingManager.AddFloatingWindow(@"Floating", new[] { NewPropertyGrid(), NewDocument() });

        private void buttonFloatingComplex_Click(object sender, EventArgs e)
        {
            // Add single page to a new floating window
            KryptonDockingFloatingWindow window = kryptonDockingManager.AddFloatingWindow(@"Floating", 
                                                                                          new[] { NewInput() }, 
                                                                                          new Size(500, 400));

            // Create a sequence that contains two cells, with a page in each cell
            KryptonWorkspaceSequence seq = new KryptonWorkspaceSequence(Orientation.Vertical);
            KryptonWorkspaceCell cell1 = new KryptonWorkspaceCell();
            KryptonWorkspaceCell cell2 = new KryptonWorkspaceCell();
            seq.Children.AddRange(new Component[] { cell1, cell2 });
            cell1.Pages.Add(NewPropertyGrid()); 
            cell2.Pages.Add(NewDocument());

            // Add new sequence into the floating window
            window.FloatspaceElement.FloatspaceControl.Root.Children.Add(seq);
        }

        private void buttonLeftAutoHidden_Click(object sender, EventArgs e) =>
            // Add new auto hidden group to left edge of the panel
            kryptonDockingManager.AddAutoHiddenGroup(@"Control", 
                DockingEdge.Left, 
                new[] { NewInput(), NewPropertyGrid() });

        private void buttonRightAutoHidden_Click(object sender, EventArgs e) =>
            // Add new auto hidden group to right edge of the panel
            kryptonDockingManager.AddAutoHiddenGroup(@"Control", 
                DockingEdge.Right, 
                new[] { NewInput(), NewPropertyGrid() });

        private void buttonBottomAutoHidden_Click(object sender, EventArgs e) =>
            // Add new auto hidden group to bottom edge of the panel
            kryptonDockingManager.AddAutoHiddenGroup(@"Control", 
                DockingEdge.Bottom, 
                new[] { NewInput(), NewPropertyGrid(), NewDocument() });

        private void buttonLeftDockedSingle_Click(object sender, EventArgs e) =>
            // Add page to left edge of the panel
            kryptonDockingManager.AddDockspace(@"Control", 
                DockingEdge.Left, 
                new[] { NewInput() });

        private void buttonLeftDockedTabbed_Click(object sender, EventArgs e) =>
            // Add three tabbed pages to left edge of the panel
            kryptonDockingManager.AddDockspace(@"Control", 
                DockingEdge.Left, 
                new[] { NewInput(), NewPropertyGrid(), NewDocument() });

        private void buttonLeftDockedStack_Click(object sender, EventArgs e) =>
            // Add three vertical-stacked pages to left edge of the panel
            kryptonDockingManager.AddDockspace(@"Control", 
                DockingEdge.Left, 
                new[] { NewDocument() }, 
                new[] { NewDocument() }, 
                new[] { NewDocument() });

        private void buttonRightDockedSingle_Click(object sender, EventArgs e) =>
            // Add page to right edge of the panel
            kryptonDockingManager.AddDockspace(@"Control", 
                DockingEdge.Right, 
                new[] { NewInput() });

        private void buttonTopDockedTabbed_Click(object sender, EventArgs e) =>
            // Add three tabbed pages to top edge of the panel
            kryptonDockingManager.AddDockspace(@"Control", 
                DockingEdge.Top, 
                new[] { NewInput(), NewPropertyGrid(), NewDocument() });

        private void buttonBottomDockedStack_Click(object sender, EventArgs e) =>
            // Add three horizontal-stacked pages to bottom edge of the panel
            kryptonDockingManager.AddDockspace(@"Control", 
                DockingEdge.Bottom, 
                new[] { NewDocument() }, 
                new[] { NewDocument() }, 
                new[] { NewDocument() });

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            kryptonDockingManager.RemoveAllPages(true);
            kryptonDockingManager.ClearAllStoredPages();
        }

        private void buttonDeleteDocked_Click(object sender, EventArgs e)
        {
            KryptonPage[] pages = kryptonDockingManager.PagesDocked;
            kryptonDockingManager.RemovePages(pages, true);
            kryptonDockingManager.ClearStoredPages(pages);
        }

        private void buttonDeleteAutoHidden_Click(object sender, EventArgs e)
        {
            KryptonPage[] pages = kryptonDockingManager.PagesAutoHidden;
            kryptonDockingManager.RemovePages(pages, true);
            kryptonDockingManager.ClearStoredPages(pages);
        }

        private void buttonDeleteFloating_Click(object sender, EventArgs e)
        {
            KryptonPage[] pages = kryptonDockingManager.PagesFloating;
            kryptonDockingManager.RemovePages(pages, true);
            kryptonDockingManager.ClearStoredPages(pages);
        }

        private void buttonHideAll_Click(object sender, EventArgs e) => kryptonDockingManager.HideAllPages();

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            kryptonDockingManager.ShowAllPages();
            kryptonDockableWorkspace.ShowAllPages();
        }

        private void button2010Blue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;
            UpdatePaletteButtons();
        }

        private void button2010Silver_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;
            UpdatePaletteButtons();
        }

        private void button2010Black_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;
            UpdatePaletteButtons();
        }

        private void button2007Blue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;
            UpdatePaletteButtons();
        }

        private void button2007Silver_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver;
            UpdatePaletteButtons();
        }

        private void button2007Black_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black;
            UpdatePaletteButtons();
        }

        private void buttonSparkleBlue_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue;
            UpdatePaletteButtons();
        }

        private void buttonSparkleOrange_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;
            UpdatePaletteButtons();
        }

        private void buttonSparklePurple_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple;
            UpdatePaletteButtons();
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;
            UpdatePaletteButtons();
        }

        private void kryptonDockableWorkspace_WorkspaceCellAdding(object sender, WorkspaceCellEventArgs e)
        {
            //e.Cell.Button.CloseButtonAction = CloseButtonAction.HidePage;
            //e.Cell.Button.CloseButtonAction = CloseButtonAction.RemovePage;
            e.Cell.Button.CloseButtonAction = CloseButtonAction.RemovePageAndDispose;
        }

        private void UpdatePaletteButtons()
        {
            button2010Blue.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.Office2010Blue);
            button2010Silver.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.Office2010Silver);
            button2010Black.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.Office2010Black);
            button2007Blue.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.Office2007Blue);
            button2007Silver.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.Office2007Silver);
            button2007Black.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.Office2007Black);
            buttonSparkleBlue.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.SparkleBlue);
            buttonSparkleOrange.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.SparkleOrange);
            buttonSparklePurple.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.SparklePurple);
            buttonSystem.Checked = (kryptonManager.GlobalPaletteMode == PaletteMode.ProfessionalSystem);
        }

        private void ribbonAppButtonExit_Click(object sender, EventArgs e) => Close();

        private void btnHideProps3_Click(object sender, EventArgs e) => kryptonDockingManager.HidePage(_props3);

        private void btnShowProps3_Click(object sender, EventArgs e) => kryptonDockingManager.ShowPage(_props3);
    }
}
