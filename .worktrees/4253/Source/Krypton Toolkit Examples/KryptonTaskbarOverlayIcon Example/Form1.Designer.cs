namespace KryptonTaskbarOverlayIconExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                ShellValues.OverlayIconValues.Icon?.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBasicExamples = new Krypton.Toolkit.KryptonGroupBox();
            this.btnExample1 = new Krypton.Toolkit.KryptonButton();
            this.lblExample1 = new Krypton.Toolkit.KryptonLabel();
            this.grpColorExamples = new Krypton.Toolkit.KryptonGroupBox();
            this.btnExample2Orange = new Krypton.Toolkit.KryptonButton();
            this.btnExample2Blue = new Krypton.Toolkit.KryptonButton();
            this.btnExample2Green = new Krypton.Toolkit.KryptonButton();
            this.btnExample2Red = new Krypton.Toolkit.KryptonButton();
            this.lblExample2 = new Krypton.Toolkit.KryptonLabel();
            this.grpInteractiveExamples = new Krypton.Toolkit.KryptonGroupBox();
            this.btnClearNotifications = new Krypton.Toolkit.KryptonButton();
            this.btnDecrementNotifications = new Krypton.Toolkit.KryptonButton();
            this.btnIncrementNotifications = new Krypton.Toolkit.KryptonButton();
            this.lblNotificationCount = new Krypton.Toolkit.KryptonLabel();
            this.lblExample3 = new Krypton.Toolkit.KryptonLabel();
            this.btnToggleOverlay = new Krypton.Toolkit.KryptonButton();
            this.lblToggleStatus = new Krypton.Toolkit.KryptonLabel();
            this.lblExample4 = new Krypton.Toolkit.KryptonLabel();
            this.grpSystemIcons = new Krypton.Toolkit.KryptonGroupBox();
            this.btnSystemQuestion = new Krypton.Toolkit.KryptonButton();
            this.btnSystemInfo = new Krypton.Toolkit.KryptonButton();
            this.btnSystemWarning = new Krypton.Toolkit.KryptonButton();
            this.btnSystemError = new Krypton.Toolkit.KryptonButton();
            this.lblExample5 = new Krypton.Toolkit.KryptonLabel();
            this.grpStatusExamples = new Krypton.Toolkit.KryptonGroupBox();
            this.btnSyncing = new Krypton.Toolkit.KryptonButton();
            this.btnStatusOffline = new Krypton.Toolkit.KryptonButton();
            this.btnStatusOnline = new Krypton.Toolkit.KryptonButton();
            this.lblExample6 = new Krypton.Toolkit.KryptonLabel();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.lblPropertyGrid = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grpBasicExamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBasicExamples.Panel)).BeginInit();
            this.grpBasicExamples.Panel.SuspendLayout();
            this.grpBasicExamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpColorExamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpColorExamples.Panel)).BeginInit();
            this.grpColorExamples.Panel.SuspendLayout();
            this.grpColorExamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInteractiveExamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInteractiveExamples.Panel)).BeginInit();
            this.grpInteractiveExamples.Panel.SuspendLayout();
            this.grpInteractiveExamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSystemIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSystemIcons.Panel)).BeginInit();
            this.grpSystemIcons.Panel.SuspendLayout();
            this.grpSystemIcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpStatusExamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpStatusExamples.Panel)).BeginInit();
            this.grpStatusExamples.Panel.SuspendLayout();
            this.grpStatusExamples.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBasicExamples
            // 
            this.grpBasicExamples.Location = new System.Drawing.Point(10, 10);
            // 
            // grpBasicExamples.Panel
            // 
            this.grpBasicExamples.Panel.Controls.Add(this.btnExample1);
            this.grpBasicExamples.Panel.Controls.Add(this.lblExample1);
            this.grpBasicExamples.Size = new System.Drawing.Size(326, 104);
            this.grpBasicExamples.TabIndex = 0;
            this.grpBasicExamples.Values.Heading = "Basic Examples";
            // 
            // btnExample1
            // 
            this.btnExample1.Location = new System.Drawing.Point(13, 43);
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Size = new System.Drawing.Size(137, 30);
            this.btnExample1.TabIndex = 1;
            this.btnExample1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExample1.Values.Text = "Set Red Badge";
            // 
            // lblExample1
            // 
            this.lblExample1.Location = new System.Drawing.Point(13, 17);
            this.lblExample1.Name = "lblExample1";
            this.lblExample1.Size = new System.Drawing.Size(310, 20);
            this.lblExample1.TabIndex = 0;
            this.lblExample1.Values.Text = "Example 1: Simple overlay icon (red notification badge)";
            // 
            // grpColorExamples
            // 
            this.grpColorExamples.Location = new System.Drawing.Point(10, 120);
            // 
            // grpColorExamples.Panel
            // 
            this.grpColorExamples.Panel.Controls.Add(this.btnExample2Orange);
            this.grpColorExamples.Panel.Controls.Add(this.btnExample2Blue);
            this.grpColorExamples.Panel.Controls.Add(this.btnExample2Green);
            this.grpColorExamples.Panel.Controls.Add(this.btnExample2Red);
            this.grpColorExamples.Panel.Controls.Add(this.lblExample2);
            this.grpColorExamples.Size = new System.Drawing.Size(326, 125);
            this.grpColorExamples.TabIndex = 1;
            this.grpColorExamples.Values.Heading = "Color Examples";
            // 
            // btnExample2Orange
            // 
            this.btnExample2Orange.Location = new System.Drawing.Point(171, 61);
            this.btnExample2Orange.Name = "btnExample2Orange";
            this.btnExample2Orange.Size = new System.Drawing.Size(137, 30);
            this.btnExample2Orange.TabIndex = 4;
            this.btnExample2Orange.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExample2Orange.Values.Text = "Orange";
            // 
            // btnExample2Blue
            // 
            this.btnExample2Blue.Location = new System.Drawing.Point(13, 61);
            this.btnExample2Blue.Name = "btnExample2Blue";
            this.btnExample2Blue.Size = new System.Drawing.Size(137, 30);
            this.btnExample2Blue.TabIndex = 3;
            this.btnExample2Blue.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExample2Blue.Values.Text = "Blue";
            // 
            // btnExample2Green
            // 
            this.btnExample2Green.Location = new System.Drawing.Point(171, 26);
            this.btnExample2Green.Name = "btnExample2Green";
            this.btnExample2Green.Size = new System.Drawing.Size(137, 30);
            this.btnExample2Green.TabIndex = 2;
            this.btnExample2Green.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExample2Green.Values.Text = "Green";
            // 
            // btnExample2Red
            // 
            this.btnExample2Red.Location = new System.Drawing.Point(13, 26);
            this.btnExample2Red.Name = "btnExample2Red";
            this.btnExample2Red.Size = new System.Drawing.Size(137, 30);
            this.btnExample2Red.TabIndex = 1;
            this.btnExample2Red.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExample2Red.Values.Text = "Red";
            // 
            // lblExample2
            // 
            this.lblExample2.Location = new System.Drawing.Point(13, 4);
            this.lblExample2.Name = "lblExample2";
            this.lblExample2.Size = new System.Drawing.Size(157, 20);
            this.lblExample2.TabIndex = 0;
            this.lblExample2.Values.Text = "Example 2: Color variations";
            // 
            // grpInteractiveExamples
            // 
            this.grpInteractiveExamples.Location = new System.Drawing.Point(9, 251);
            // 
            // grpInteractiveExamples.Panel
            // 
            this.grpInteractiveExamples.Panel.Controls.Add(this.btnClearNotifications);
            this.grpInteractiveExamples.Panel.Controls.Add(this.btnDecrementNotifications);
            this.grpInteractiveExamples.Panel.Controls.Add(this.btnIncrementNotifications);
            this.grpInteractiveExamples.Panel.Controls.Add(this.lblNotificationCount);
            this.grpInteractiveExamples.Panel.Controls.Add(this.lblExample3);
            this.grpInteractiveExamples.Panel.Controls.Add(this.btnToggleOverlay);
            this.grpInteractiveExamples.Panel.Controls.Add(this.lblToggleStatus);
            this.grpInteractiveExamples.Panel.Controls.Add(this.lblExample4);
            this.grpInteractiveExamples.Size = new System.Drawing.Size(326, 249);
            this.grpInteractiveExamples.TabIndex = 2;
            this.grpInteractiveExamples.Values.Heading = "Interactive Examples";
            // 
            // btnClearNotifications
            // 
            this.btnClearNotifications.Location = new System.Drawing.Point(227, 104);
            this.btnClearNotifications.Name = "btnClearNotifications";
            this.btnClearNotifications.Size = new System.Drawing.Size(81, 26);
            this.btnClearNotifications.TabIndex = 7;
            this.btnClearNotifications.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClearNotifications.Values.Text = "Clear";
            // 
            // btnDecrementNotifications
            // 
            this.btnDecrementNotifications.Location = new System.Drawing.Point(120, 104);
            this.btnDecrementNotifications.Name = "btnDecrementNotifications";
            this.btnDecrementNotifications.Size = new System.Drawing.Size(81, 26);
            this.btnDecrementNotifications.TabIndex = 6;
            this.btnDecrementNotifications.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDecrementNotifications.Values.Text = "Decrement";
            // 
            // btnIncrementNotifications
            // 
            this.btnIncrementNotifications.Location = new System.Drawing.Point(13, 104);
            this.btnIncrementNotifications.Name = "btnIncrementNotifications";
            this.btnIncrementNotifications.Size = new System.Drawing.Size(81, 26);
            this.btnIncrementNotifications.TabIndex = 5;
            this.btnIncrementNotifications.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnIncrementNotifications.Values.Text = "Increment";
            // 
            // lblNotificationCount
            // 
            this.lblNotificationCount.Location = new System.Drawing.Point(13, 78);
            this.lblNotificationCount.Name = "lblNotificationCount";
            this.lblNotificationCount.Size = new System.Drawing.Size(124, 20);
            this.lblNotificationCount.TabIndex = 4;
            this.lblNotificationCount.Values.Text = "Notification Count: 5";
            // 
            // lblExample3
            // 
            this.lblExample3.Location = new System.Drawing.Point(13, 17);
            this.lblExample3.Name = "lblExample3";
            this.lblExample3.Size = new System.Drawing.Size(181, 20);
            this.lblExample3.TabIndex = 0;
            this.lblExample3.Values.Text = "Example 3: Notification counter";
            // 
            // btnToggleOverlay
            // 
            this.btnToggleOverlay.Location = new System.Drawing.Point(13, 170);
            this.btnToggleOverlay.Name = "btnToggleOverlay";
            this.btnToggleOverlay.Size = new System.Drawing.Size(137, 30);
            this.btnToggleOverlay.TabIndex = 2;
            this.btnToggleOverlay.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnToggleOverlay.Values.Text = "Toggle Overlay";
            // 
            // lblToggleStatus
            // 
            this.lblToggleStatus.Location = new System.Drawing.Point(163, 177);
            this.lblToggleStatus.Name = "lblToggleStatus";
            this.lblToggleStatus.Size = new System.Drawing.Size(98, 20);
            this.lblToggleStatus.TabIndex = 3;
            this.lblToggleStatus.Values.Text = "Overlay: Hidden";
            // 
            // lblExample4
            // 
            this.lblExample4.Location = new System.Drawing.Point(13, 152);
            this.lblExample4.Name = "lblExample4";
            this.lblExample4.Size = new System.Drawing.Size(199, 20);
            this.lblExample4.TabIndex = 1;
            this.lblExample4.Values.Text = "Example 4: Toggle overlay visibility";
            // 
            // grpSystemIcons
            // 
            this.grpSystemIcons.Location = new System.Drawing.Point(341, 10);
            // 
            // grpSystemIcons.Panel
            // 
            this.grpSystemIcons.Panel.Controls.Add(this.btnSystemQuestion);
            this.grpSystemIcons.Panel.Controls.Add(this.btnSystemInfo);
            this.grpSystemIcons.Panel.Controls.Add(this.btnSystemWarning);
            this.grpSystemIcons.Panel.Controls.Add(this.btnSystemError);
            this.grpSystemIcons.Panel.Controls.Add(this.lblExample5);
            this.grpSystemIcons.Size = new System.Drawing.Size(326, 130);
            this.grpSystemIcons.TabIndex = 3;
            this.grpSystemIcons.Values.Heading = "System Icon Examples";
            // 
            // btnSystemQuestion
            // 
            this.btnSystemQuestion.Location = new System.Drawing.Point(171, 61);
            this.btnSystemQuestion.Name = "btnSystemQuestion";
            this.btnSystemQuestion.Size = new System.Drawing.Size(137, 30);
            this.btnSystemQuestion.TabIndex = 4;
            this.btnSystemQuestion.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSystemQuestion.Values.Text = "Question";
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(13, 61);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(137, 30);
            this.btnSystemInfo.TabIndex = 3;
            this.btnSystemInfo.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSystemInfo.Values.Text = "Information";
            // 
            // btnSystemWarning
            // 
            this.btnSystemWarning.Location = new System.Drawing.Point(171, 26);
            this.btnSystemWarning.Name = "btnSystemWarning";
            this.btnSystemWarning.Size = new System.Drawing.Size(137, 30);
            this.btnSystemWarning.TabIndex = 2;
            this.btnSystemWarning.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSystemWarning.Values.Text = "Warning";
            // 
            // btnSystemError
            // 
            this.btnSystemError.Location = new System.Drawing.Point(13, 26);
            this.btnSystemError.Name = "btnSystemError";
            this.btnSystemError.Size = new System.Drawing.Size(137, 30);
            this.btnSystemError.TabIndex = 1;
            this.btnSystemError.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSystemError.Values.Text = "Error";
            // 
            // lblExample5
            // 
            this.lblExample5.Location = new System.Drawing.Point(13, 4);
            this.lblExample5.Name = "lblExample5";
            this.lblExample5.Size = new System.Drawing.Size(206, 20);
            this.lblExample5.TabIndex = 0;
            this.lblExample5.Values.Text = "Example 5: System icons as overlays";
            // 
            // grpStatusExamples
            // 
            this.grpStatusExamples.Location = new System.Drawing.Point(341, 146);
            // 
            // grpStatusExamples.Panel
            // 
            this.grpStatusExamples.Panel.Controls.Add(this.btnSyncing);
            this.grpStatusExamples.Panel.Controls.Add(this.btnStatusOffline);
            this.grpStatusExamples.Panel.Controls.Add(this.btnStatusOnline);
            this.grpStatusExamples.Panel.Controls.Add(this.lblExample6);
            this.grpStatusExamples.Size = new System.Drawing.Size(326, 129);
            this.grpStatusExamples.TabIndex = 4;
            this.grpStatusExamples.Values.Heading = "Status Indicator Examples";
            // 
            // btnSyncing
            // 
            this.btnSyncing.Location = new System.Drawing.Point(171, 61);
            this.btnSyncing.Name = "btnSyncing";
            this.btnSyncing.Size = new System.Drawing.Size(137, 30);
            this.btnSyncing.TabIndex = 3;
            this.btnSyncing.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSyncing.Values.Text = "Syncing";
            // 
            // btnStatusOffline
            // 
            this.btnStatusOffline.Location = new System.Drawing.Point(13, 61);
            this.btnStatusOffline.Name = "btnStatusOffline";
            this.btnStatusOffline.Size = new System.Drawing.Size(137, 30);
            this.btnStatusOffline.TabIndex = 2;
            this.btnStatusOffline.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnStatusOffline.Values.Text = "Offline";
            // 
            // btnStatusOnline
            // 
            this.btnStatusOnline.Location = new System.Drawing.Point(92, 26);
            this.btnStatusOnline.Name = "btnStatusOnline";
            this.btnStatusOnline.Size = new System.Drawing.Size(137, 30);
            this.btnStatusOnline.TabIndex = 1;
            this.btnStatusOnline.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnStatusOnline.Values.Text = "Online";
            // 
            // lblExample6
            // 
            this.lblExample6.Location = new System.Drawing.Point(13, 4);
            this.lblExample6.Name = "lblExample6";
            this.lblExample6.Size = new System.Drawing.Size(162, 20);
            this.lblExample6.TabIndex = 0;
            this.lblExample6.Values.Text = "Example 6: Status indicators";
            // 
            // propertyGrid
            // 
            this.propertyGrid.Location = new System.Drawing.Point(672, 35);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(300, 503);
            this.propertyGrid.TabIndex = 5;
            // 
            // lblPropertyGrid
            // 
            this.lblPropertyGrid.Location = new System.Drawing.Point(672, 10);
            this.lblPropertyGrid.Name = "lblPropertyGrid";
            this.lblPropertyGrid.Size = new System.Drawing.Size(347, 20);
            this.lblPropertyGrid.TabIndex = 6;
            this.lblPropertyGrid.Values.Text = "Property Grid (TaskbarOverlayIcon properties are expandable)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.lblPropertyGrid);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.grpStatusExamples);
            this.Controls.Add(this.grpSystemIcons);
            this.Controls.Add(this.grpInteractiveExamples);
            this.Controls.Add(this.grpColorExamples);
            this.Controls.Add(this.grpBasicExamples);
            this.Name = "Form1";
            this.Text = "Taskbar Overlay Icon Test - KryptonForm";
            ((System.ComponentModel.ISupportInitialize)(this.grpBasicExamples.Panel)).EndInit();
            this.grpBasicExamples.Panel.ResumeLayout(false);
            this.grpBasicExamples.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBasicExamples)).EndInit();
            this.grpBasicExamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpColorExamples.Panel)).EndInit();
            this.grpColorExamples.Panel.ResumeLayout(false);
            this.grpColorExamples.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpColorExamples)).EndInit();
            this.grpColorExamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpInteractiveExamples.Panel)).EndInit();
            this.grpInteractiveExamples.Panel.ResumeLayout(false);
            this.grpInteractiveExamples.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInteractiveExamples)).EndInit();
            this.grpInteractiveExamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSystemIcons.Panel)).EndInit();
            this.grpSystemIcons.Panel.ResumeLayout(false);
            this.grpSystemIcons.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSystemIcons)).EndInit();
            this.grpSystemIcons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpStatusExamples.Panel)).EndInit();
            this.grpStatusExamples.Panel.ResumeLayout(false);
            this.grpStatusExamples.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpStatusExamples)).EndInit();
            this.grpStatusExamples.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox grpBasicExamples;
        private Krypton.Toolkit.KryptonButton btnExample1;
        private Krypton.Toolkit.KryptonLabel lblExample1;
        private Krypton.Toolkit.KryptonGroupBox grpColorExamples;
        private Krypton.Toolkit.KryptonButton btnExample2Orange;
        private Krypton.Toolkit.KryptonButton btnExample2Blue;
        private Krypton.Toolkit.KryptonButton btnExample2Green;
        private Krypton.Toolkit.KryptonButton btnExample2Red;
        private Krypton.Toolkit.KryptonLabel lblExample2;
        private Krypton.Toolkit.KryptonGroupBox grpInteractiveExamples;
        private Krypton.Toolkit.KryptonButton btnClearNotifications;
        private Krypton.Toolkit.KryptonButton btnDecrementNotifications;
        private Krypton.Toolkit.KryptonButton btnIncrementNotifications;
        private Krypton.Toolkit.KryptonLabel lblNotificationCount;
        private Krypton.Toolkit.KryptonLabel lblExample3;
        private Krypton.Toolkit.KryptonButton btnToggleOverlay;
        private Krypton.Toolkit.KryptonLabel lblToggleStatus;
        private Krypton.Toolkit.KryptonLabel lblExample4;
        private Krypton.Toolkit.KryptonGroupBox grpSystemIcons;
        private Krypton.Toolkit.KryptonButton btnSystemQuestion;
        private Krypton.Toolkit.KryptonButton btnSystemInfo;
        private Krypton.Toolkit.KryptonButton btnSystemWarning;
        private Krypton.Toolkit.KryptonButton btnSystemError;
        private Krypton.Toolkit.KryptonLabel lblExample5;
        private Krypton.Toolkit.KryptonGroupBox grpStatusExamples;
        private Krypton.Toolkit.KryptonButton btnSyncing;
        private Krypton.Toolkit.KryptonButton btnStatusOffline;
        private Krypton.Toolkit.KryptonButton btnStatusOnline;
        private Krypton.Toolkit.KryptonLabel lblExample6;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private Krypton.Toolkit.KryptonLabel lblPropertyGrid;
    }
}
