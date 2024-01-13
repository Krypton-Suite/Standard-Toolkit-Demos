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

using Krypton.Ribbon;
using Krypton.Toolkit;

namespace KryptonGalleryExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioSmallList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSmallList.Checked)
            {
                kryptonGallery1.ImageList = imageListSmall;
            }
        }

        private void radioMediumList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMediumList.Checked)
            {
                kryptonGallery1.ImageList = imageListMedium;
            }
        }

        private void radioLargeList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLargeList.Checked)
            {
                kryptonGallery1.ImageList = imageListLarge;
            }
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            kryptonGallery1.PreferredItemSize = kryptonGallery1.PreferredItemSize with { Width = Convert.ToInt32(numericWidth.Value) };
        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {
            kryptonGallery1.PreferredItemSize = kryptonGallery1.PreferredItemSize with { Height = Convert.ToInt32(numericHeight.Value) };
        }

        private void checkBoxGroupImages_CheckedChanged(object sender, EventArgs e)
        {
            kryptonGallery1.DropButtonRanges.Clear();
            if (checkBoxGroupImages.Checked)
            {
                kryptonGallery1.DropButtonRanges.Add(kryptonGalleryRange1);
                kryptonGallery1.DropButtonRanges.Add(kryptonGalleryRange2);
                kryptonGallery1.DropButtonRanges.Add(kryptonGalleryRange3);
            }
        }

        private void kryptonGallery1_GalleryDropMenu(object sender, GalleryDropMenuEventArgs e)
        {
            if (checkBoxAddCustomItems.Checked)
            {
                KryptonContextMenuHeading h = new KryptonContextMenuHeading
                {
                    Text = "Customize Drop Menu"
                };

                KryptonContextMenuItems items1 = new KryptonContextMenuItems();
                KryptonContextMenuItem item1 = new KryptonContextMenuItem
                {
                    Text = "Custom Entry 1"
                };
                KryptonContextMenuItem item2 = new KryptonContextMenuItem
                {
                    Text = "Custom Entry 2",
                    Checked = true
                };
                items1.Items.Add(item1);
                items1.Items.Add(item2);

                KryptonContextMenuItems items2 = new KryptonContextMenuItems();
                KryptonContextMenuItem item3 = new KryptonContextMenuItem
                {
                    Text = "Custom Entry 3"
                };
                KryptonContextMenuItem item4 = new KryptonContextMenuItem
                {
                    Text = "Custom Entry 4",
                    CheckState = CheckState.Indeterminate
                };
                items2.Items.Add(item3);
                items2.Items.Add(item4);

                e.KryptonContextMenu.Items.Insert(0, new KryptonContextMenuSeparator());
                e.KryptonContextMenu.Items.Insert(0, items1);
                e.KryptonContextMenu.Items.Insert(0, h);
                e.KryptonContextMenu.Items.Add(new KryptonContextMenuSeparator());
                e.KryptonContextMenu.Items.Add(items2);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
