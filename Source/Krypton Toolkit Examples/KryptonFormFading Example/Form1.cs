using Krypton.Toolkit;

namespace KryptonFormFadingExample
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kbtnTest_Click(object sender, System.EventArgs e)
        {
            Form2 testForm = new Form2();

            testForm.FadeValues.Owner = testForm;

            testForm.FadeValues.FadeDuration = FadeValues.FadeDuration;

            testForm.FadeValues.FadeSpeed = FadeValues.FadeSpeed;

            testForm.FadeValues.FadeSpeedChoice = FadeValues.FadeSpeedChoice;

            testForm.FadeValues.FadingEnabled = FadeValues.FadingEnabled;

            testForm.FadeValues.ShouldCloseOnFadeOut = FadeValues.ShouldCloseOnFadeOut;

            testForm.ShowDialog();
        }
    }
}
