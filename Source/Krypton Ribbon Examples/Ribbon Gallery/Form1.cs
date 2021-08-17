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

using Krypton.Ribbon;
using Krypton.Toolkit;

namespace RibbonGallery
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void galleryCustom_GalleryDropMenu(object sender, GalleryDropMenuEventArgs e)
        {
            KryptonContextMenuHeading h = new KryptonContextMenuHeading();
            h.Text = "Customize Drop Menu";

            KryptonContextMenuItems items1 = new KryptonContextMenuItems();
            KryptonContextMenuItem item1 = new KryptonContextMenuItem();
            item1.Text = "Custom Entry 1";
            KryptonContextMenuItem item2 = new KryptonContextMenuItem();
            item2.Text = "Custom Entry 2";
            item2.Checked = true;
            items1.Items.Add(item1);
            items1.Items.Add(item2);

            KryptonContextMenuItems items2 = new KryptonContextMenuItems();
            KryptonContextMenuItem item3 = new KryptonContextMenuItem();
            item3.Text = "Custom Entry 3";
            KryptonContextMenuItem item4 = new KryptonContextMenuItem();
            item4.Text = "Custom Entry 4";
            item4.CheckState = CheckState.Indeterminate;
            items2.Items.Add(item3);
            items2.Items.Add(item4);

            e.KryptonContextMenu.Items.Insert(0, new KryptonContextMenuSeparator());
            e.KryptonContextMenu.Items.Insert(0, items1);
            e.KryptonContextMenu.Items.Insert(0, h);
            e.KryptonContextMenu.Items.Add(new KryptonContextMenuSeparator());
            e.KryptonContextMenu.Items.Add(items2);
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            if (kryptonRibbonGroupButton1.Checked)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                kryptonRibbonGroupButton2.Checked = false;
                kryptonRibbonGroupButton3.Checked = false;
            }
        }

        private void kryptonRibbonGroupButton2_Click(object sender, EventArgs e)
        {
            if (kryptonRibbonGroupButton2.Checked)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                kryptonRibbonGroupButton1.Checked = false;
                kryptonRibbonGroupButton3.Checked = false;
            }
        }

        private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
        {
            if (kryptonRibbonGroupButton3.Checked)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                kryptonRibbonGroupButton1.Checked = false;
                kryptonRibbonGroupButton2.Checked = false;
            }
        }

        private void kryptonContextMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
