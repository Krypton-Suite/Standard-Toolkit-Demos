using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonAboutToolkitExample
{
    public partial class Form1 : KryptonForm
    {
        private ToolkitType _toolkitType;

        public Form1()
        {
            InitializeComponent();

            _toolkitType = ToolkitType.Stable;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kbtnShow_Click(object sender, EventArgs e)
        {
            KryptonAboutToolkitData data = new KryptonAboutToolkitData();

            data.CurrentThemeText = ktxtCurrentThemeText.Text;

            data.DiscordText = ktxtJoinDiscordText.Text;

            data.HeaderText = ktxtAboutText.Text;

            data.GeneralInformationLearnMoreText = ktxtLearnMoreText.Text;

            data.GeneralInformationLicenseText = ktxtLicenseText.Text;

            data.GeneralInformationWelcomeText = ktxtWelcomeText.Text;

            data.RepositoryInformationText = ktxtRepositoryInformationText.Text;

            data.DownloadDemosText = ktxtDownloadDemosText.Text;

            data.DownloadDocumentationText = ktxtDownloadDocumentationText.Text;

            data.FileNameColumnHeaderText = ktxtFileNameColumnHeaderText.Text;

            data.VersionColumnHeaderText = ktxtVersionColumnHeaderText.Text;

            data.ToolBarDeveloperInformationText = ktxtToolBarDeveloperInformationText.Text;

            data.ToolBarDiscordText = ktxtToolBarDiscordText.Text;

            data.ToolBarDeveloperInformationText = ktxtToolBarDeveloperInformationText.Text;

            data.ToolBarGeneralInformationText = ktxtToolBarGeneralInformationText.Text;

            data.ToolBarVersionInformationText = ktxtToolBarVersionInformationText.Text;

            data.ShowDeveloperInformationButton = kcbShowDeveloperInformationButton.Checked;

            data.ShowDiscordButton = kcbShowDiscordButton.Checked;

            data.ShowSystemInformationButton = kcbShowSystemInformationButton.Checked;

            data.ShowThemeOptions = kcbShowThemeOptions.Checked;

            data.ShowVersionInformationButton = kcbShowVersionInformationButton.Checked;

            data.ToolkitType = _toolkitType;

            data.DiscordLinkArea = new LinkArea((int)knumLinkAreaDiscordStart.Value, (int)knumLinkAreaDiscordEnd.Value);

            data.DocumentationLinkArea = new LinkArea((int)knumLinkAreaDownloadDocumentationStart.Value, (int)knumLinkAreaDownloadDocumentationEnd.Value);

            data.DownloadDemosLinkArea = new LinkArea((int)knumLinkAreaDownloadDemosStart.Value, (int)knumLinkAreaDowenloadDemosEnd.Value);

            data.LearnMoreLinkArea = new LinkArea((int)knumLinkAreaLearnMoreStart.Value, (int)knumLinkAreaLearnMoreEnd.Value);

            data.RepositoryInformationLinkArea = new LinkArea((int)knumLinkAreaRepositoryInformationStart.Value, (int)knumLinkAreaRepositoryInformationEnd.Value);

            KryptonAboutToolkit.Show(data);
        }

        private void ToolkitType_CheckedChanged(object sender, EventArgs e)
        {
            if (krbCanary.Checked)
            {
                _toolkitType = ToolkitType.Canary;
            }

            if (krbNightly.Checked)
            {
                _toolkitType = ToolkitType.Nightly;
            }

            if (krbStable.Checked)
            {
                _toolkitType = ToolkitType.Stable;
            }
        }
    }
}