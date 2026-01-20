#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonJumpListExample
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            SetupExamples();
            SetupPropertyGrid();
            CheckCommandLineArguments();

            // Initialize jump list once handle is created (required for jump list to work)
            HandleCreated += JumpListTest_HandleCreated;
            // Also refresh when form is shown to ensure jump list is updated
            Shown += JumpListTest_Shown;
        }

        private void JumpListTest_HandleCreated(object? sender, EventArgs e)
        {
            // Now that handle exists, set up the jump list configuration
            if (JumpListValues == null || JumpList == null)
            {
                return;
            }

            // Set AppID for proper Windows integration
            JumpListValues.AppId = "Krypton.Toolkit.TestForm.JumpListDemo";

            // Setup user tasks
            SetupUserTasks();

            // Setup custom categories
            SetupCustomCategories();

            // Configure known categories
            JumpListValues.ShowRecentCategory = true;
            JumpListValues.ShowFrequentCategory = false;
        }

        private void JumpListTest_Shown(object? sender, EventArgs e)
        {
            // Enable and refresh jump list when form is shown
            if (JumpListValues == null || JumpList == null || !IsHandleCreated || IsDisposed)
            {
                return;
            }

            // Ensure AppId is set before enabling
            if (string.IsNullOrEmpty(JumpListValues.AppId))
            {
                JumpListValues.AppId = "Krypton.Toolkit.TestForm.JumpListDemo";
            }

            // Enable the jump list (this will trigger refresh via property changed event)
            // But wait a moment for Windows to be ready
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 100 };
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();

                if (JumpListValues != null && JumpList != null && IsHandleCreated && !IsDisposed)
                {
                    // Set enabled (triggers refresh)
                    JumpListValues.Enabled = true;

                    // Force PropertyGrid refresh
                    propertyGrid.Refresh();

                    // Also explicitly refresh to ensure it updates
                    JumpList.Refresh();

                    UpdateStatus("Jump list initialized. Right-click the taskbar icon to see it!");
                }
            };
            timer.Start();
        }

        private void SetupUserTasks()
        {
            var userTasks = JumpListValues.UserTasks;

            // Task 1: New Document
            var newDoc = new KryptonJumpListItem("New Document", Application.ExecutablePath, "/new");
            newDoc.Description = "Create a new document";
            newDoc.IconPath = Application.ExecutablePath;
            userTasks.Add(newDoc);

            // Task 2: Open File
            var openFile = new KryptonJumpListItem("Open File", Application.ExecutablePath, "/open");
            openFile.Description = "Open an existing file";
            openFile.IconPath = Application.ExecutablePath;
            userTasks.Add(openFile);

            // Task 3: Settings
            var settings = new KryptonJumpListItem("Settings", Application.ExecutablePath, "/settings");
            settings.Description = "Open application settings";
            settings.IconPath = Application.ExecutablePath;
            userTasks.Add(settings);

            // Task 4: Help
            var help = new KryptonJumpListItem("Help", Application.ExecutablePath, "/help");
            help.Description = "View help documentation";
            help.IconPath = Application.ExecutablePath;
            userTasks.Add(help);
        }

        private void SetupCustomCategories()
        {
            if (JumpList == null)
            {
                return;
            }

            // Category 1: Recent Projects
            var recentProjects = new KryptonJumpListItems();
            recentProjects.Add(new KryptonJumpListItem("Project Alpha", Application.ExecutablePath, "/project:alpha") {
                Description = "Open Project Alpha",
                IconPath = Application.ExecutablePath
            });
            recentProjects.Add(new KryptonJumpListItem("Project Beta", Application.ExecutablePath, "/project:beta") {
                Description = "Open Project Beta",
                IconPath = Application.ExecutablePath
            });
            recentProjects.Add(new KryptonJumpListItem("Project Gamma", Application.ExecutablePath, "/project:gamma") {
                Description = "Open Project Gamma",
                IconPath = Application.ExecutablePath
            });

            JumpList.AddCustomCategory("Recent Projects", recentProjects);

            // Category 2: Quick Actions
            var quickActions = new KryptonJumpListItems();
            quickActions.Add(new KryptonJumpListItem("Export Data", Application.ExecutablePath, "/export") {
                Description = "Export data to file",
                IconPath = Application.ExecutablePath
            });
            quickActions.Add(new KryptonJumpListItem("Import Data", Application.ExecutablePath, "/import") {
                Description = "Import data from file",
                IconPath = Application.ExecutablePath
            });

            JumpList.AddCustomCategory("Quick Actions", quickActions);
        }

        private void SetupExamples()
        {
            // Example 1: Enable/Disable
            lblExample1.Text = "Example 1: Enable or disable the jump list";
            btnEnableJumpList.Text = "Enable";
            btnDisableJumpList.Text = "Disable";
            btnEnableJumpList.Click += (s, e) =>
            {
                JumpListValues.Enabled = true;
                UpdateStatus("Jump list enabled");
            };
            btnDisableJumpList.Click += (s, e) =>
            {
                JumpListValues.Enabled = false;
                UpdateStatus("Jump list disabled");
            };

            // Example 2: Add/Remove User Tasks
            lblExample2.Text = "Example 2: Dynamically add or remove user tasks";
            btnAddTask.Text = "Add Task";
            btnRemoveTask.Text = "Remove Last Task";
            btnAddTask.Click += BtnAddTask_Click;
            btnRemoveTask.Click += BtnRemoveTask_Click;

            // Example 3: Toggle Recent/Frequent
            lblExample3.Text = "Example 3: Toggle Recent and Frequent categories";
            btnToggleRecent.Text = "Toggle Recent";
            btnToggleFrequent.Text = "Toggle Frequent";
            btnToggleRecent.Click += (s, e) =>
            {
                JumpListValues.ShowRecentCategory = !JumpListValues.ShowRecentCategory;
                UpdateStatus($"Recent category: {(JumpListValues.ShowRecentCategory ? "Enabled" : "Disabled")}");
            };
            btnToggleFrequent.Click += (s, e) =>
            {
                JumpListValues.ShowFrequentCategory = !JumpListValues.ShowFrequentCategory;
                UpdateStatus($"Frequent category: {(JumpListValues.ShowFrequentCategory ? "Enabled" : "Disabled")}");
            };

            // Example 4: Refresh Jump List
            lblExample4.Text = "Example 4: Manually refresh the jump list";
            btnRefresh.Text = "Refresh Jump List";
            btnRefresh.Click += (s, e) =>
            {
                JumpList?.Refresh();
                UpdateStatus("Jump list refreshed");
            };

            // Example 5: Clear Jump List
            lblExample5.Text = "Example 5: Clear all jump list items";
            btnClear.Text = "Clear Jump List";
            btnClear.Click += (s, e) =>
            {
                JumpList?.Clear();
                UpdateStatus("Jump list cleared");
            };

            // Example 6: Add Custom Category
            lblExample6.Text = "Example 6: Add a custom category dynamically";
            btnAddCategory.Text = "Add Category";
            btnAddCategory.Click += BtnAddCategory_Click;
        }

        private void SetupPropertyGrid()
        {
            propertyGrid.SelectedObject = JumpListValues;
            lblPropertyGrid.Text = "Property Grid: Configure JumpListValues properties";
        }

        private void CheckCommandLineArguments()
        {
            // Check if application was launched from a jump list item
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                string argument = args[1];
                HandleJumpListItemClick(argument);
            }
        }

        private void HandleJumpListItemClick(string argument)
        {
            string message = $"Jump list item clicked!\n\nArgument: {argument}\n\n";

            // Handle different jump list actions
            switch (argument.ToLower())
            {
                case "/new":
                    message += "Action: Create new document";
                    break;
                case "/open":
                    message += "Action: Open file dialog";
                    break;
                case "/settings":
                    message += "Action: Open settings";
                    break;
                case "/help":
                    message += "Action: Show help";
                    break;
                case "/export":
                    message += "Action: Export data";
                    break;
                case "/import":
                    message += "Action: Import data";
                    break;
                default:
                    if (argument.StartsWith("/project:", StringComparison.OrdinalIgnoreCase))
                    {
                        string projectName = argument.Substring(9);
                        message += $"Action: Open project '{projectName}'";
                    }
                    else
                    {
                        message += "Action: Unknown";
                    }
                    break;
            }

            KryptonMessageBox.Show(this, message, "Jump List Item Clicked", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            UpdateStatus($"Handled jump list action: {argument}");
        }

        private void BtnAddTask_Click(object? sender, EventArgs e)
        {
            var taskNumber = JumpListValues.UserTasks.Count + 1;
            var newTask = new KryptonJumpListItem($"Dynamic Task {taskNumber}", Application.ExecutablePath, $"/task{taskNumber}") {
                Description = $"This is dynamically added task #{taskNumber}",
                IconPath = Application.ExecutablePath
            };
            JumpListValues.UserTasks.Add(newTask);
            JumpList?.Refresh();
            UpdateStatus($"Added task: {newTask.Title}");
        }

        private void BtnRemoveTask_Click(object? sender, EventArgs e)
        {
            if (JumpListValues.UserTasks.Count > 0)
            {
                var removedTask = JumpListValues.UserTasks[JumpListValues.UserTasks.Count - 1];
                JumpListValues.UserTasks.RemoveAt(JumpListValues.UserTasks.Count - 1);
                JumpList?.Refresh();
                UpdateStatus($"Removed task: {removedTask.Title}");
            }
            else
            {
                UpdateStatus("No tasks to remove");
            }
        }

        private void BtnAddCategory_Click(object? sender, EventArgs e)
        {
            if (JumpList == null)
            {
                return;
            }

            var categoryNumber = JumpListValues.UserTasks.Count + 1;
            var categoryName = $"Dynamic Category {categoryNumber}";
            var categoryItems = new KryptonJumpListItems();

            categoryItems.Add(new KryptonJumpListItem($"Item 1", Application.ExecutablePath, $"/category{categoryNumber}/item1") {
                Description = "First item in dynamic category",
                IconPath = Application.ExecutablePath
            });

            categoryItems.Add(new KryptonJumpListItem($"Item 2", Application.ExecutablePath, $"/category{categoryNumber}/item2") {
                Description = "Second item in dynamic category",
                IconPath = Application.ExecutablePath
            });

            JumpList.AddCustomCategory(categoryName, categoryItems);
            JumpList.Refresh();
            UpdateStatus($"Added category: {categoryName}");
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = $"Status: {message}";
            lblStatus.Refresh();
        }
    }
}
