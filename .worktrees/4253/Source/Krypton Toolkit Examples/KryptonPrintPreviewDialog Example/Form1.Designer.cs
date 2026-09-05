namespace KryptonPrintPreviewDialogExample
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.grpBasicExamples = new System.Windows.Forms.GroupBox();
            this.btnSimpleText = new Krypton.Toolkit.KryptonButton();
            this.btnMultiPage = new Krypton.Toolkit.KryptonButton();
            this.grpThemedExamples = new System.Windows.Forms.GroupBox();
            this.btnThemedDocument = new Krypton.Toolkit.KryptonButton();
            this.grpGraphicsExamples = new System.Windows.Forms.GroupBox();
            this.btnGraphicsDocument = new Krypton.Toolkit.KryptonButton();
            this.btnComplexDocument = new Krypton.Toolkit.KryptonButton();
            this.btnTableDocument = new Krypton.Toolkit.KryptonButton();
            this.grpAdvancedExamples = new System.Windows.Forms.GroupBox();
            this.btnWithCustomIcon = new Krypton.Toolkit.KryptonButton();
            this.btnMaximizedWindow = new Krypton.Toolkit.KryptonButton();
            this.grpAntiAliasExamples = new System.Windows.Forms.GroupBox();
            this.btnAntiAliasOff = new Krypton.Toolkit.KryptonButton();
            this.btnAntiAliasOn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.grpBasicExamples.SuspendLayout();
            this.grpThemedExamples.SuspendLayout();
            this.grpGraphicsExamples.SuspendLayout();
            this.grpAdvancedExamples.SuspendLayout();
            this.grpAntiAliasExamples.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(900, 650);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonPanel2);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(900, 650);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "KryptonPrintPreviewDialog Comprehensive Demo";
            this.kryptonGroupBox1.Values.Description = "Demonstrates various features and usage scenarios of KryptonPrintPreviewDialog";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.AutoScroll = true;
            this.kryptonPanel2.Controls.Add(this.grpAntiAliasExamples);
            this.kryptonPanel2.Controls.Add(this.grpAdvancedExamples);
            this.kryptonPanel2.Controls.Add(this.grpGraphicsExamples);
            this.kryptonPanel2.Controls.Add(this.grpThemedExamples);
            this.kryptonPanel2.Controls.Add(this.grpBasicExamples);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel2.Size = new System.Drawing.Size(894, 604);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // grpBasicExamples
            // 
            this.grpBasicExamples.Controls.Add(this.btnMultiPage);
            this.grpBasicExamples.Controls.Add(this.btnSimpleText);
            this.grpBasicExamples.Location = new System.Drawing.Point(13, 10);
            this.grpBasicExamples.Name = "grpBasicExamples";
            this.grpBasicExamples.Size = new System.Drawing.Size(860, 90);
            this.grpBasicExamples.TabIndex = 0;
            this.grpBasicExamples.TabStop = false;
            this.grpBasicExamples.Text = "Basic Examples";
            // 
            // btnSimpleText
            // 
            this.btnSimpleText.Location = new System.Drawing.Point(15, 30);
            this.btnSimpleText.Name = "btnSimpleText";
            this.btnSimpleText.Size = new System.Drawing.Size(200, 40);
            this.btnSimpleText.TabIndex = 0;
            this.btnSimpleText.Values.Text = "Simple Text Document";
            // 
            // btnMultiPage
            // 
            this.btnMultiPage.Location = new System.Drawing.Point(230, 30);
            this.btnMultiPage.Name = "btnMultiPage";
            this.btnMultiPage.Size = new System.Drawing.Size(200, 40);
            this.btnMultiPage.TabIndex = 1;
            this.btnMultiPage.Values.Text = "Multi-Page Document";
            // 
            // grpThemedExamples
            // 
            this.grpThemedExamples.Controls.Add(this.btnThemedDocument);
            this.grpThemedExamples.Location = new System.Drawing.Point(13, 110);
            this.grpThemedExamples.Name = "grpThemedExamples";
            this.grpThemedExamples.Size = new System.Drawing.Size(860, 90);
            this.grpThemedExamples.TabIndex = 1;
            this.grpThemedExamples.TabStop = false;
            this.grpThemedExamples.Text = "Themed Examples";
            // 
            // btnThemedDocument
            // 
            this.btnThemedDocument.Location = new System.Drawing.Point(15, 30);
            this.btnThemedDocument.Name = "btnThemedDocument";
            this.btnThemedDocument.Size = new System.Drawing.Size(200, 40);
            this.btnThemedDocument.TabIndex = 0;
            this.btnThemedDocument.Values.Text = "Themed Document";
            // 
            // grpGraphicsExamples
            // 
            this.grpGraphicsExamples.Controls.Add(this.btnTableDocument);
            this.grpGraphicsExamples.Controls.Add(this.btnComplexDocument);
            this.grpGraphicsExamples.Controls.Add(this.btnGraphicsDocument);
            this.grpGraphicsExamples.Location = new System.Drawing.Point(13, 210);
            this.grpGraphicsExamples.Name = "grpGraphicsExamples";
            this.grpGraphicsExamples.Size = new System.Drawing.Size(860, 90);
            this.grpGraphicsExamples.TabIndex = 2;
            this.grpGraphicsExamples.TabStop = false;
            this.grpGraphicsExamples.Text = "Graphics & Layout Examples";
            // 
            // btnGraphicsDocument
            // 
            this.btnGraphicsDocument.Location = new System.Drawing.Point(15, 30);
            this.btnGraphicsDocument.Name = "btnGraphicsDocument";
            this.btnGraphicsDocument.Size = new System.Drawing.Size(200, 40);
            this.btnGraphicsDocument.TabIndex = 0;
            this.btnGraphicsDocument.Values.Text = "Graphics Document";
            // 
            // btnComplexDocument
            // 
            this.btnComplexDocument.Location = new System.Drawing.Point(230, 30);
            this.btnComplexDocument.Name = "btnComplexDocument";
            this.btnComplexDocument.Size = new System.Drawing.Size(200, 40);
            this.btnComplexDocument.TabIndex = 1;
            this.btnComplexDocument.Values.Text = "Complex Document";
            // 
            // btnTableDocument
            // 
            this.btnTableDocument.Location = new System.Drawing.Point(445, 30);
            this.btnTableDocument.Name = "btnTableDocument";
            this.btnTableDocument.Size = new System.Drawing.Size(200, 40);
            this.btnTableDocument.TabIndex = 2;
            this.btnTableDocument.Values.Text = "Table Document";
            // 
            // grpAdvancedExamples
            // 
            this.grpAdvancedExamples.Controls.Add(this.btnMaximizedWindow);
            this.grpAdvancedExamples.Controls.Add(this.btnWithCustomIcon);
            this.grpAdvancedExamples.Location = new System.Drawing.Point(13, 310);
            this.grpAdvancedExamples.Name = "grpAdvancedExamples";
            this.grpAdvancedExamples.Size = new System.Drawing.Size(860, 90);
            this.grpAdvancedExamples.TabIndex = 3;
            this.grpAdvancedExamples.TabStop = false;
            this.grpAdvancedExamples.Text = "Advanced Examples";
            // 
            // btnWithCustomIcon
            // 
            this.btnWithCustomIcon.Location = new System.Drawing.Point(15, 30);
            this.btnWithCustomIcon.Name = "btnWithCustomIcon";
            this.btnWithCustomIcon.Size = new System.Drawing.Size(200, 40);
            this.btnWithCustomIcon.TabIndex = 0;
            this.btnWithCustomIcon.Values.Text = "Custom Icon";
            // 
            // btnMaximizedWindow
            // 
            this.btnMaximizedWindow.Location = new System.Drawing.Point(230, 30);
            this.btnMaximizedWindow.Name = "btnMaximizedWindow";
            this.btnMaximizedWindow.Size = new System.Drawing.Size(200, 40);
            this.btnMaximizedWindow.TabIndex = 1;
            this.btnMaximizedWindow.Values.Text = "Maximized Window";
            // 
            // grpAntiAliasExamples
            // 
            this.grpAntiAliasExamples.Controls.Add(this.btnAntiAliasOn);
            this.grpAntiAliasExamples.Controls.Add(this.btnAntiAliasOff);
            this.grpAntiAliasExamples.Location = new System.Drawing.Point(13, 410);
            this.grpAntiAliasExamples.Name = "grpAntiAliasExamples";
            this.grpAntiAliasExamples.Size = new System.Drawing.Size(860, 90);
            this.grpAntiAliasExamples.TabIndex = 4;
            this.grpAntiAliasExamples.TabStop = false;
            this.grpAntiAliasExamples.Text = "Anti-Aliasing Examples";
            // 
            // btnAntiAliasOff
            // 
            this.btnAntiAliasOff.Location = new System.Drawing.Point(15, 30);
            this.btnAntiAliasOff.Name = "btnAntiAliasOff";
            this.btnAntiAliasOff.Size = new System.Drawing.Size(200, 40);
            this.btnAntiAliasOff.TabIndex = 0;
            this.btnAntiAliasOff.Values.Text = "Anti-Alias OFF";
            // 
            // btnAntiAliasOn
            // 
            this.btnAntiAliasOn.Location = new System.Drawing.Point(230, 30);
            this.btnAntiAliasOn.Name = "btnAntiAliasOn";
            this.btnAntiAliasOn.Size = new System.Drawing.Size(200, 40);
            this.btnAntiAliasOn.TabIndex = 1;
            this.btnAntiAliasOn.Values.Text = "Anti-Alias ON";
            // 
            // PrintPreviewDialogTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "PrintPreviewDialogTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Preview Dialog Test";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.grpBasicExamples.ResumeLayout(false);
            this.grpThemedExamples.ResumeLayout(false);
            this.grpGraphicsExamples.ResumeLayout(false);
            this.grpAdvancedExamples.ResumeLayout(false);
            this.grpAntiAliasExamples.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.GroupBox grpBasicExamples;
        private Krypton.Toolkit.KryptonButton btnSimpleText;
        private Krypton.Toolkit.KryptonButton btnMultiPage;
        private System.Windows.Forms.GroupBox grpThemedExamples;
        private Krypton.Toolkit.KryptonButton btnThemedDocument;
        private System.Windows.Forms.GroupBox grpGraphicsExamples;
        private Krypton.Toolkit.KryptonButton btnGraphicsDocument;
        private Krypton.Toolkit.KryptonButton btnComplexDocument;
        private Krypton.Toolkit.KryptonButton btnTableDocument;
        private System.Windows.Forms.GroupBox grpAdvancedExamples;
        private Krypton.Toolkit.KryptonButton btnWithCustomIcon;
        private Krypton.Toolkit.KryptonButton btnMaximizedWindow;
        private System.Windows.Forms.GroupBox grpAntiAliasExamples;
        private Krypton.Toolkit.KryptonButton btnAntiAliasOff;
        private Krypton.Toolkit.KryptonButton btnAntiAliasOn;
    }
}
