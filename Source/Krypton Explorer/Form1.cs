#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 */
#endregion

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
//using System.Net.Http;
using System.Windows.Forms;

using Krypton.Toolkit;

using KryptonExplorer.Properties;

namespace KryptonExplorer
{
    public partial class Form1 : KryptonForm
    {
        #region Variables

        private Version _currentVersion = new(80, int.Parse(DateTime.Now.ToString("yy")), 08, 230);

        private Settings _settings = new();

        private string _documentationDownloadLocation;

        #endregion

        public Form1()
        {
            InitializeComponent();

            kryptonNavigator.SelectedIndex = 0;
            kryptonNavigatorToolkit.SelectedIndex = 0;
        }

        #region Links

        private void linkKryptonBorderEdge_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Border Edge Examples");

        private void linkKryptonButton_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Button Examples");

        private void linkKryptonCheckBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton CheckBox Examples");

        private void linkKryptonCheckButton_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton CheckButton Examples");

        private void linkKryptonDropButton_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton DropButton Examples");

        private void linkKryptonColorButton_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton ColorButton Examples");

        private void linkKryptonCheckSet_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton CheckSet Examples");

        private void linkKryptonContextMenu_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Context Menu Examples");

        private void linkKryptonDataGridView_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Data GridView Examples");

        private void linkKryptonForm_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Form Examples");

        private void linkKryptonGroup_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Group Examples");

        private void linkKryptonGroupBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton GroupBox Examples");

        private void linkKryptonHeader_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Header Examples");

        private void linkKryptonHeaderGroup_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Header Group Examples");

        private void linkKryptonLabel_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Label Examples");

        private void linkKryptonWrapLabel_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Wrap Label Examples");

        private void linkKryptonCommand_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Command Examples");

        private void linkKryptonLinkLabel_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Link Label Examples");

        private void linkKryptonListBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton ListBox Examples");

        private void linkKryptonCheckedListBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Checked ListBox Examples");

        private void linkKryptonMaskedTextBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Masked TextBox Examples");

        private void linkKryptonPalette_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Palette Examples");

        private void linkKryptonPanel_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Panel Examples");

        private void linkKryptonSeparator_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Separator Examples");

        private void linkKryptonRadioButton_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton RadioButton Examples");

        private void linkKryptonTrackBar_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton TrackBar Examples");

        private void linkKryptonSplitContainer_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Split Container Examples");

        private void linkKryptonComboBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton ComboBox Examples");

        private void linkKryptonTextBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton TextBox Examples");

        private void linkKryptonRichTextBox_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Rich TextBox Examples");

        private void linkKryptonNumericUpDown_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Numeric UpDown Examples");

        private void linkKryptonDomainUpDown_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Domain UpDown Examples");

        private void linkKryptonBreadCrumb_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Bread Crumb Examples");

        private void linkKryptonDateTimePicker_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton DateTimePicker Examples");

        private void linkKryptonMonthCalendar_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Krypton Month Calendar Examples");
        }

        private void linkKryptonInputBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Krypton InputBox Examples");
        }

        private void linkKryptonMessageBox_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Krypton MessageBox Examples");
        }

        private void linkKryptonTaskDialog_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Krypton TaskDialog Examples");
        }

        private void linkKryptonTreeView_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Krypton TreeView Examples");
        }

        private void linkInputForm_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Input Form Examples");
        }

        private void linkThreePaneApplicationBasic_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Three Pane Application Basic");
        }

        private void linkThreePaneApplicationExtended_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Three Pane Application Extended");
        }

        private void linkMDIApplication_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"MDI Application");
        }

        private void linkCustomControlUsingPalettes_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Custom Control Using Palettes");
        }

        private void linkCustomControlUsingRenderers_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Custom Control Using Renderers");
        }

        private void linkExpandingSplitters_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Expanding Header Groups Splitters Examples");
        }

        private void linkExpandingDockStyle_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Expanding Header Groups DockStyle Examples");
        }

        private void linkExpandingHeaderStack_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Expanding Header Groups Stack Examples");
        }

        private void linkChildControlStack_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Child Control Stack");
        }

        private void linkLabelButtonSpecPlayground_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Button Spec Playground");
        }

        private void linkNavigatorModes_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Navigator Modes");
        }

        private void linkNavigatorPalettes_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Navigator Palettes");
        }

        private void linkOrientationAndAlignment_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Orientation Plus Alignment");
        }

        private void linkSinglelineAndMultiline_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Singleline Plus Multiline");
        }

        private void linkTabBorderStyles_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Tab Border Styles");
        }

        private void linkNavigatorPopupPages_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Popup Pages");
        }

        private void linkNavigatorPerTabButtons_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Per Tab Buttons");
        }

        private void linkNavigatorTooltips_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Navigator Tool Tips");
        }

        private void linkNavigatorContextMenus_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Navigator Context Menus");
        }

        private void linkNavigatorPlayground_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Navigator Playground");
        }

        private void linkContextualTabs_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Contextual Tabs");
        }

        private void linkKeyTipsTabs_LinkClicked(object sender, EventArgs e)
        {
            LaunchApplication(@"Key Tips And Keyboard Access");
        }

        private void labelAutoShrinkingGroups_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Auto Shrinking Groups");

        private void labelQuickAccessToolbar_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Quick Access Toolbar");

        private void linkRibbonGallery_LinkClicked(object sender, EventArgs e) => LaunchApplication(@"Ribbon Gallery");

        private void linkRibbonToolTips_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Ribbon Tool Tips");

        private void linkRibbonControls_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Ribbon Controls");

        private void linkKryptonGallery_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Gallery Examples");

        private void linkApplicationMenu_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Application Menu");

        private void linkOutlookMailClone_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Outlook Mail Clone");

        private void linkRibbonAndNavigator_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Ribbon And Navigator And Workspace");

        private void linkMDIRibbon_LinkClicked(object sender, EventArgs e) => LaunchApplication(@"MDI Ribbon");

        private void linkExpandingPages_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Expanding Pages");

        private void linkNavigatorBasicEvents_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Basic Events");

        private void linkNavigatorUserPageCreation_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"User Page Creation");

        private void linkNavigatorOneNoteTabs_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"OneNote Tabs");

        private void linkNavigatorOutlookMockup_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Outlook Mockup");

        private void linkWorkspaceCellModes_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Workspace Cell Modes");

        private void linkWorkspaceCellLayout_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Workspace Cell Layout");

        private void linkWorkspacePersistence_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"WorkspacePersistence");

        private void linkCellMaximizeAndRestore_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Cell Maximize And Restore");

        private void linkBasicPageDragAndDrop_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Basic Page Drag And Drop");

        private void linkAdvancedPageDragAndDrop_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Advanced Page Drag And Drop");

        private void memoEditor_Clicked(object sender, EventArgs e) => LaunchApplication(@"Memo Editor");

        private void linkStandardDocking_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Standard Docking");

        private void linkMultiControlDocking_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Multi Control Docking");

        private void linkExternalDragToDocking_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"External Drag To Docking");


        private void linkNavigatorAndFloatingWindows_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Navigator And Floating Windows");

        private void linkDockingPersistence_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Docking Persistence");

        private void linkDockingFlags_LinkClicked(object sender, EventArgs e) => LaunchApplication(@"Docking Flags");

        private void linkDockingCustomized_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Docking Customized");

        private void linkPaletteDesigner_LinkClicked(object sender, EventArgs e) => LaunchPaletteDesignerApplication();

        private void linkPaletteUpgradeTool_LinkClicked(object sender, EventArgs e) =>
            LaunchPaletteUpgradeToolApplication();

        #endregion

        private void kryptonButtonClose_Click(object sender, EventArgs e) => Close();

        private void Form1_Load(object sender, EventArgs e)
        {
            FileVersionInfo fvi =
                FileVersionInfo.GetVersionInfo(
                    $@"{Path.GetDirectoryName(Application.ExecutablePath)}\Krypton.Toolkit.dll");

            kryptonManager1.GlobalPaletteMode = _settings.Theme;


            kcmbTheme.SelectedIndex = _settings.ThemeSelectedIndex;

            kcmbTheme.Text = ThemeManager.ReturnPaletteModeAsString(_settings.Theme);

            //tsslBuildDate.Text = $"Build Date: {GeneralToolkitUtilities.GetLinkerTimestampUtc(Assembly.GetExecutingAssembly())} ";

            tsslBuildDate.Text = $@"Build Date: {_settings.BuildDate.ToShortDateString()}";

            tslVersion.Text = $@"Krypton Explorer Version: {_currentVersion} - Toolkit Version: {fvi.FileVersion}";
        }

        private void kbtnOpenApplicationPath_Click(object sender, EventArgs e) =>
            Process.Start(Application.ExecutablePath); //@"explorer.exe", @"\{Application.ExecutablePath}");

        private void kllKryptonScrollBars_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Scrollbar Examples");

        private void kllKryptonWebBrowser_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton WebBrowser Example");

        private void kllKryptonHelpIcon_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Help Icon Examples");

        private void kllColourDialog_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Color Dialog Example");

        private void LaunchApplication(string exampleName)
        {
            try
            {
                Cursor = Cursors.AppStarting;
                Process.Start($@".\{exampleName}.exe");
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(this, $@"Error: {ex.Message}", @"Explorer", KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LaunchPaletteDesignerApplication()
        {
            try
            {
                Cursor = Cursors.AppStarting;

                if (File.Exists(@".\Palette Designer.exe"))
                {
                    LaunchApplication(@"Palette Designer");
                }
                else
                {
                    KryptonMessageBox.Show(
                        "The Palette Designer is not currently installed. Please download the latest installation package from:\nhttps://github.com/Krypton-Suite/Theme-Palettes/releases",
                        @"Application Not Installed", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                KryptonMessageBox.Show(this, e.Message, @"Explorer", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LaunchPaletteUpgradeToolApplication()
        {
            try
            {
                Cursor = Cursors.AppStarting;

                if (File.Exists(@".\Palette Upgrade Tool.exe"))
                {
                    LaunchApplication(@"Palette Upgrade Tool");
                }
                else
                {
                    KryptonMessageBox.Show(
                        "The Palette Upgrade Tool is not currently installed. Please download the latest installation package from:\nhttps://github.com/Krypton-Suite/Theme-Palettes/releases",
                        @"Application Not Installed", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                KryptonMessageBox.Show(this, e.Message, @"Explorer", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void kllFontDialog_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Font Dialog Example");

        private void kcmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.ThemeSelectedIndex = kcmbTheme.SelectedIndex;

            _settings.Theme = ThemeManager.GetPaletteMode(kcmbTheme.Manager);

            _settings.Save();
        }

        private void kbtnRestoreTheme_Click(object sender, EventArgs e)
        {
            kcmbTheme.SelectedIndex = 33;

            _settings.Theme = PaletteMode.Microsoft365Blue;

            _settings.HelpFileLocation = @"";

            _settings.Save();
        }

        private void klblPrintDialog_LinkClicked(object sender, EventArgs e) =>
            LaunchApplication(@"Krypton Print Dialog Example");

        private void kbtnKryptonToolkitPackage_Click(object sender, EventArgs e) =>
            Process.Start(@"https://www.nuget.org/profiles/Krypton_Suite");

        private void kbtnViewLatestReleaseNotes_Click(object sender, EventArgs e) => Process.Start(@"https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/Documents/Help/Changelog.md");

        private void kbtnViewLatestCanaryReleaseNotes_Click(object sender, EventArgs e) => Process.Start(@"https://github.com/Krypton-Suite/Standard-Toolkit/blob/canary/Documents/Help/Changelog.md");

        private void kbtnViewLatestNightlyReleaseNotes_Click(object sender, EventArgs e) => Process.Start(@"https://github.com/Krypton-Suite/Standard-Toolkit/blob/alpha/Documents/Help/Changelog.md");

        private void kbtnDownloadLatestDocumentation_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                Title = @"Download documentation installer to:",
                Filter = @"Windows Executables|*.exe",
                FileName = @"Standard Toolkit Documentation Installer"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WebClient client = new();

                _documentationDownloadLocation = Path.GetFullPath(sfd.FileName);

                tspbDownloadStatus.Visible = true;

                client.DownloadFile(@"https://tinyurl.com/mvksw89c", _documentationDownloadLocation);

                tspbDownloadStatus.Text = $@"Downloading: {Path.GetFileName(_documentationDownloadLocation)}";

                client.DownloadProgressChanged += DownloadProgressChanged;

                client.DownloadFileCompleted += DownloadFileCompleted;
            }
        }

        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                DialogResult result = KryptonMessageBox.Show(@"Download completed. Install now?",
                    @"Download Successful",
                    KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Process.Start(_documentationDownloadLocation);
                }
            }
            catch (Exception exception)
            {
                KryptonMessageBox.Show($"Error: {exception}");
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            tspbDownloadStatus.Maximum = (int)e.TotalBytesToReceive / 100;

            tspbDownloadStatus.Value = (int)e.BytesReceived / 100;
        }

        private async void bgwDownloadDocumentation_DoWork(object sender, DoWorkEventArgs e)
        {
            //HttpClient client = new();

            WebClient client = new();

            tspbDownloadStatus.Text = $@"Downloading: {Path.GetFileName(_documentationDownloadLocation)}";

            if (!string.IsNullOrEmpty(_documentationDownloadLocation))
            {
                //var downladContent = await client.GetStreamAsync(@"https://tinyurl.com/mvksw89c");

                //using (var fs = File.Create(_documentationDownladLocation))
                //{
                //    downladContent.CopyTo(fs);
                //}

                client.DownloadFile(@"https://tinyurl.com/mvksw89c", _documentationDownloadLocation);
            }
        }

        private void bgwDownloadDocumentation_ProgressChanged(object sender, ProgressChangedEventArgs e) =>
            tspbDownloadStatus.Value = e.ProgressPercentage;

        private void bgwDownloadDocumentation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult result = KryptonMessageBox.Show(@"Download completed. Install now?", @"Download Successful",
                KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Process.Start(_documentationDownloadLocation);
            }
        }

        private void kbtnLaunchHelp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_settings.HelpFileLocation))
                {
                    if (File.Exists(_settings.HelpFileLocation))
                    {
                        Process.Start(_settings.HelpFileLocation);
                    }
                    else
                    {
                        HelpFileLocator locator = new HelpFileLocator();

                        locator.Show();
                    }
                }
                else
                {
                    HelpFileLocator locator = new HelpFileLocator();

                    locator.Show();
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($@"Error: {exc}", @"Unexpected Error", KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error);
            }
        }

        private void kllPropertyGrid_LinkClicked(object sender, EventArgs e) => LaunchApplication(@"Krypton Property Grid Example");

        private void kllblIntegratedToolbar_LinkClicked(object sender, EventArgs e) => LaunchApplication(@"Integrated Toolbar Example");

        private void kllProgressBar_LinkClicked(object sender, EventArgs e) => LaunchApplication(@"Krypton ProgressBar Examples");

        private void kllKryptonThemeSelector_LinkClicked(object sender, EventArgs e) => LaunchApplication(@"Krypton Theme Selector");
    }
}