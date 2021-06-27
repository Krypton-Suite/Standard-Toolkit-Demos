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
            ThemeManager.PropagateThemeSelector(cmbTheme);
        }

        private void CmbTheme_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ThemeManager.SetTheme(cmbTheme.Text, kryptonManager1);
        }

        private void ViewTypeChanged(object sender, System.EventArgs e)
        {
            var rb = sender as RadioButton;
            if (!rb.Checked)
                return;
            var view = View.Details;
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
                KryptonMessageBox.Show(this, exception.Message, @"Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ViewCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            listWinform.CheckBoxes = viewCheckBox.Checked;
            listKrypton.CheckBoxes = viewCheckBox.Checked;
        }

        private void GroupBox3_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
