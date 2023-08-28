using System;
using System.Windows.Forms;

namespace KryptonPropertyGridExample
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void SetSelectedObject(object obj)
        {
            kryptonPropertyGrid1.SelectedObject = obj;
            kryptonPropertyGrid2.SelectedObject = obj;
        }

        private void kryptonButton1_Click(object sender, EventArgs e) => SetSelectedObject(kryptonButton1);

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e) => SetSelectedObject(kryptonCheckBox1);

        private void kryptonCheckedListBox1_Click(object sender, EventArgs e) => SetSelectedObject(kryptonCheckedListBox1);

        private void kryptonDateTimePicker1_Click(object sender, EventArgs e) => SetSelectedObject(kryptonDateTimePicker1);

        private void kryptonMonthCalendar1_DateChanged(object sender, DateRangeEventArgs e) => SetSelectedObject(kryptonMonthCalendar1);

    }
}
