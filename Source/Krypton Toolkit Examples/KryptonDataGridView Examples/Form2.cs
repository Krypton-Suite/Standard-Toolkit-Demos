
using Krypton.Toolkit;

namespace KryptonDataGridViewExamples
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();
            kryptonDataGridView1.Rows.Add(@"1", @"Test But", true);
        }
    }
}
