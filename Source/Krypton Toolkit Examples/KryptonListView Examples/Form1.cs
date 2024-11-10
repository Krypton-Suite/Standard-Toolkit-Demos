// *****************************************************************************
// BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
// *****************************************************************************

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonListViewExamples
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewTypeChanged(object sender, System.EventArgs e)
        {
            RadioButton? rb = (RadioButton)sender;
            if (!rb.Checked)
            {
                return;
            }

            View view = View.Details;
            viewCheckBox.Enabled = true;
            switch (rb.Text)
            {
                case @"Large Icon":
                    view = View.LargeIcon;
                    break;
                case @"Details":
                    view = View.Details;
                    break;
                case @"List":
                    view = View.List;
                    break;
                case @"Small Icon":
                    view = View.SmallIcon;
                    break;
                case @"Tile":
                    view = View.Tile;
                    viewCheckBox.Checked = false;
                    viewCheckBox.Enabled = false;
                    break;
            }
            listWinform.View = view;
            try
            {
                listKrypton.View = view;
            }
            catch (Exception exception)
            {
                KryptonMessageBox.Show(this, exception.Message, @"Not Supported", 
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
            }
        }

        private void ViewCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            listWinform.CheckBoxes = viewCheckBox.Checked;
            listKrypton.CheckBoxes = viewCheckBox.Checked;
        }

        private void chkDisabled_CheckStateChanged(object sender, EventArgs e)
        {
            listWinform.Enabled = !chkDisabled.Checked;
            listKrypton.Enabled = !chkDisabled.Checked;
            kryptonTextBox1.Enabled = !chkDisabled.Checked;
        }
    }
}
