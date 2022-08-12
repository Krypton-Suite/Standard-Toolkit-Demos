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

namespace KryptonListBoxExamples
{
    public partial class Form1 : Form
    {
        private int _next = 1;
        private Random _rand = new Random();

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = kryptonListBox;

            // Add some initial entries
            kryptonListBox.Items.Add(CreateNewItem());
            kryptonListBox.Items.Add(CreateNewItem());
            kryptonListBox.Items.Add(CreateNewItem());
            kryptonListBox.Items.Add(CreateNewItem());
            kryptonListBox.Items.Add(CreateNewItem());

            // Select the first entry
            kryptonListBox.SelectedIndex = 0;
        }

        private object CreateNewItem()
        {
            KryptonListItem item = new KryptonListItem
            {
                ShortText = $"Item {(_next++)}",
                LongText = $"({_rand.Next(Int32.MaxValue)})",
                Image = imageList.Images[_rand.Next(imageList.Images.Count - 1)]
            };
            return item;
        }

        private void kryptonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonInsert.Enabled = (kryptonListBox.SelectedIndex >= 0);
            buttonRemove.Enabled = (kryptonListBox.SelectedIndex >= 0);
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            kryptonListBox.Items.Add(CreateNewItem());

            // If nothing currently selected, then select the new one
            if (kryptonListBox.SelectedIndex == -1)
            {
                kryptonListBox.SelectedIndex = 0;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Can only insert if something is already selected
            if (kryptonListBox.SelectedIndex >= 0)
            {
                kryptonListBox.Items.Insert(kryptonListBox.SelectedIndex, CreateNewItem());
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Can only remove if something is selected
            if (kryptonListBox.SelectedIndex >= 0)
            {
                // Find the new index to select
                int index = kryptonListBox.SelectedIndex;
                if (index == (kryptonListBox.Items.Count - 1))
                {
                    index--;
                }

                // Remove entry
                kryptonListBox.Items.RemoveAt(kryptonListBox.SelectedIndex);

                // Select the new item
                if (index < kryptonListBox.Items.Count)
                {
                    kryptonListBox.SelectedIndex = index;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) => kryptonListBox.Items.Clear();

        private void kryptonCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            if (kryptonCheckSet.CheckedButton == check2007Blue)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
            else if (kryptonCheckSet.CheckedButton == check2010Blue)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
            else if (kryptonCheckSet.CheckedButton == checkSparkle)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
            else if (kryptonCheckSet.CheckedButton == checkSystem)
            {
                kryptonManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();

        private void kryptonListBox_DoubleClick(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("You've invoked the double click event.", "Double Click", MessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information);
        }
    }
}
