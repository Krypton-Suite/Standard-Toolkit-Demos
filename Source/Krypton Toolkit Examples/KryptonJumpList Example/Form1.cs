#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2026 - 2026. All rights reserved.
 *
 */
#endregion

using System;
using System.Collections.Generic;
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
            if (JumpList == null)
            {
                return;
            }

            // Set AppID for proper Windows integration
            JumpList.AppId = "Krypton.Toolkit.TestForm.JumpListDemo";

            // Setup user tasks
            SetupUserTasks();

            // Setup custom categories
            SetupCustomCategories();

            // Configure known categories
            JumpList.ShowRecentCategory = true;
            JumpList.ShowFrequentCategory = false;
        }

        private void JumpListTest_Shown(object? sender, EventArgs e)
        {
            // Refresh jump list when form is shown
            if (JumpList == null || !IsHandleCreated || IsDisposed)
            {
                return;
            }

            // Ensure AppId is set before enabling
            if (string.IsNullOrEmpty(JumpList.AppId))
            {
                JumpList.AppId = "Krypton.Toolkit.TestForm.JumpListDemo";
            }

            // Wait a moment for Windows to be ready then trigger a jump list update
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 100 };
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();

                if (JumpList != null && IsHandleCreated && !IsDisposed)
                {
                    // Force PropertyGrid refresh
                    propertyGrid.Refresh();

                    // Trigger a jump list update by touching a property
                    JumpList.ShowRecentCategory = JumpList.ShowRecentCategory;

                    UpdateStatus("Jump list initialized. Right-click the taskbar icon to see it!");
                }
            };
            timer.Start();
        }

        private void SetupUserTasks()
        {
            var userTasks = JumpList.UserTasks;

            // Task 1: New Document
            var newDoc = new JumpListItem { Title = "New Document", Path = Application.ExecutablePath, Arguments = "/new", Description = "Create a new document", IconPath = Application.ExecutablePath };
            userTasks.Add(newDoc);

            // Task 2: Open File
            var openFile = new JumpListItem { Title = "Open File", Path = Application.ExecutablePath, Arguments = "/open", Description = "Open an existing file", IconPath = Application.ExecutablePath };
            userTasks.Add(openFile);

            // Task 3: Settings
            var settings = new JumpListItem { Title = "Settings", Path = Application.ExecutablePath, Arguments = "/settings", Description = "Open application settings", IconPath = Application.ExecutablePath };
            userTasks.Add(settings);

            // Task 4: Help
            var help = new JumpListItem { Title = "Help", Path = Application.ExecutablePath, Arguments = "/help", Description = "View help documentation", IconPath = Application.ExecutablePath };
            userTasks.Add(help);
        }

        private void SetupCustomCategories()
        {
            if (JumpList == null)
            {
                return;
            }

            // Category 1: Recent Projects
            var recentProjects = new List<JumpListItem>
            {
                new JumpListItem { Title = "Project Alpha", Path = Application.ExecutablePath, Arguments = "/project:alpha", Description = "Open Project Alpha", IconPath = Application.ExecutablePath },
                new JumpListItem { Title = "Project Beta", Path = Application.ExecutablePath, Arguments = "/project:beta", Description = "Open Project Beta", IconPath = Application.ExecutablePath },
                new JumpListItem { Title = "Project Gamma", Path = Application.ExecutablePath, Arguments = "/project:gamma", Description = "Open Project Gamma", IconPath = Application.ExecutablePath }
            };

            JumpList.AddCategory("Recent Projects", recentProjects);

            // Category 2: Quick Actions
            var quickActions = new List<JumpListItem>
            {
                new JumpListItem { Title = "Export Data", Path = Application.ExecutablePath, Arguments = "/export", Description = "Export data to file", IconPath = Application.ExecutablePath },
                new JumpListItem { Title = "Import Data", Path = Application.ExecutablePath, Arguments = "/import", Description = "Import data from file", IconPath = Application.ExecutablePath }
            };

            JumpList.AddCategory("Quick Actions", quickActions);
        }

        private void SetupExamples()
        {
            // Example 1: Enable/Disable
            lblExample1.Text = "Example 1: Configure the jump list AppId";
            btnEnableJumpList.Text = "Set AppId";
            btnDisableJumpList.Text = "Clear AppId";
            btnEnableJumpList.Click += (s, e) =>
            {
                JumpList.AppId = "Krypton.Toolkit.TestForm.JumpListDemo";
                UpdateStatus("Jump list AppId set");
            };
            btnDisableJumpList.Click += (s, e) =>
            {
                JumpList.AppId = string.Empty;
                UpdateStatus("Jump list AppId cleared");
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
                JumpList.ShowRecentCategory = !JumpList.ShowRecentCategory;
                UpdateStatus($"Recent category: {(JumpList.ShowRecentCategory ? "Enabled" : "Disabled")}");
            };
            btnToggleFrequent.Click += (s, e) =>
            {
                JumpList.ShowFrequentCategory = !JumpList.ShowFrequentCategory;
                UpdateStatus($"Frequent category: {(JumpList.ShowFrequentCategory ? "Enabled" : "Disabled")}");
            };

            // Example 4: Refresh Jump List
            lblExample4.Text = "Example 4: Trigger a jump list refresh";
            btnRefresh.Text = "Refresh Jump List";
            btnRefresh.Click += (s, e) =>
            {
                // Trigger refresh by toggling a property value
                JumpList.ShowRecentCategory = JumpList.ShowRecentCategory;
                UpdateStatus("Jump list refresh triggered");
            };

            // Example 5: Clear Jump List
            lblExample5.Text = "Example 5: Clear all jump list items";
            btnClear.Text = "Clear Jump List";
            btnClear.Click += (s, e) =>
            {
                JumpList.Reset();
                UpdateStatus("Jump list cleared");
            };

            // Example 6: Add Custom Category
            lblExample6.Text = "Example 6: Add a custom category dynamically";
            btnAddCategory.Text = "Add Category";
            btnAddCategory.Click += BtnAddCategory_Click;
        }

        private void SetupPropertyGrid()
        {
            propertyGrid.SelectedObject = JumpList;
            lblPropertyGrid.Text = "Property Grid: Configure JumpList properties";
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
            var taskNumber = JumpList.UserTasks.Count + 1;
            var newTask = new JumpListItem
            {
                Title = $"Dynamic Task {taskNumber}",
                Path = Application.ExecutablePath,
                Arguments = $"/task{taskNumber}",
                Description = $"This is dynamically added task #{taskNumber}",
                IconPath = Application.ExecutablePath
            };
            JumpList.UserTasks.Add(newTask);
            UpdateStatus($"Added task: {newTask.Title}");
        }

        private void BtnRemoveTask_Click(object? sender, EventArgs e)
        {
            if (JumpList.UserTasks.Count > 0)
            {
                var removedTask = JumpList.UserTasks[JumpList.UserTasks.Count - 1];
                JumpList.UserTasks.RemoveAt(JumpList.UserTasks.Count - 1);
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

            var categoryNumber = JumpList.Categories.Count + 1;
            var categoryName = $"Dynamic Category {categoryNumber}";
            var categoryItems = new List<JumpListItem>
            {
                new JumpListItem
                {
                    Title = "Item 1",
                    Path = Application.ExecutablePath,
                    Arguments = $"/category{categoryNumber}/item1",
                    Description = "First item in dynamic category",
                    IconPath = Application.ExecutablePath
                },
                new JumpListItem
                {
                    Title = "Item 2",
                    Path = Application.ExecutablePath,
                    Arguments = $"/category{categoryNumber}/item2",
                    Description = "Second item in dynamic category",
                    IconPath = Application.ExecutablePath
                }
            };

            JumpList.AddCategory(categoryName, categoryItems);
            UpdateStatus($"Added category: {categoryName}");
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = $"Status: {message}";
            lblStatus.Refresh();
        }
    }
}
