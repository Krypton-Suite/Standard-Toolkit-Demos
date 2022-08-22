
using Krypton.Toolkit;

namespace KryptonDataGridViewExamples
{
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            InitializeComponent();
            kryptonDataGridView1.Rows.Add(@"1", @"Test But", true);

            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));

            var iconSpec1 = new Krypton.Toolkit.IconSpec 
            {
                Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Right, 
                Icon = ((System.Drawing.Image)(resources.GetObject("iconSpec1.Icon")))
            };

            Button.IconSpecs.Add(iconSpec1);

        }
    }
}
