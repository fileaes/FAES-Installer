
namespace FileAES_Installer
{
    partial class Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            this.installerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.navPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.errorPanel = new FileAES_Installer.Views.Error();
            this.completedPanel = new FileAES_Installer.Views.Completed();
            this.installPanel = new FileAES_Installer.Views.Install();
            this.optionsPanel = new FileAES_Installer.Views.Options();
            this.welcomePanel = new FileAES_Installer.Views.Welcome();
            this.licencePanel = new FileAES_Installer.Views.Licence();
            this.installerPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // installerPanel
            // 
            this.installerPanel.ColumnCount = 1;
            this.installerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.installerPanel.Controls.Add(this.navPanel, 0, 1);
            this.installerPanel.Controls.Add(this.viewPanel, 0, 0);
            this.installerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installerPanel.Location = new System.Drawing.Point(0, 0);
            this.installerPanel.Name = "installerPanel";
            this.installerPanel.RowCount = 2;
            this.installerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.installerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.installerPanel.Size = new System.Drawing.Size(484, 341);
            this.installerPanel.TabIndex = 0;
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.cancelButton);
            this.navPanel.Controls.Add(this.nextButton);
            this.navPanel.Controls.Add(this.backButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.navPanel.Location = new System.Drawing.Point(0, 291);
            this.navPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.navPanel.Size = new System.Drawing.Size(484, 50);
            this.navPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(398, 13);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(317, 13);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(236, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.errorPanel);
            this.viewPanel.Controls.Add(this.completedPanel);
            this.viewPanel.Controls.Add(this.installPanel);
            this.viewPanel.Controls.Add(this.optionsPanel);
            this.viewPanel.Controls.Add(this.welcomePanel);
            this.viewPanel.Controls.Add(this.licencePanel);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(484, 291);
            this.viewPanel.TabIndex = 1;
            // 
            // errorPanel
            // 
            this.errorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorPanel.Location = new System.Drawing.Point(0, 0);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(484, 291);
            this.errorPanel.TabIndex = 5;
            // 
            // completedPanel
            // 
            this.completedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completedPanel.Location = new System.Drawing.Point(0, 0);
            this.completedPanel.Name = "completedPanel";
            this.completedPanel.Size = new System.Drawing.Size(484, 291);
            this.completedPanel.TabIndex = 4;
            // 
            // installPanel
            // 
            this.installPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installPanel.Location = new System.Drawing.Point(0, 0);
            this.installPanel.Name = "installPanel";
            this.installPanel.Size = new System.Drawing.Size(484, 291);
            this.installPanel.TabIndex = 3;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(484, 291);
            this.optionsPanel.TabIndex = 2;
            // 
            // welcomePanel
            // 
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(484, 291);
            this.welcomePanel.TabIndex = 0;
            // 
            // licencePanel
            // 
            this.licencePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licencePanel.Location = new System.Drawing.Point(0, 0);
            this.licencePanel.Name = "licencePanel";
            this.licencePanel.Size = new System.Drawing.Size(484, 291);
            this.licencePanel.TabIndex = 1;
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.installerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Installer";
            this.Text = "FileAES: Installer";
            this.installerPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel installerPanel;
        private System.Windows.Forms.FlowLayoutPanel navPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel viewPanel;
        private Views.Welcome welcomePanel;
        private Views.Licence licencePanel;
        private Views.Options optionsPanel;
        private Views.Install installPanel;
        private Views.Completed completedPanel;
        private Views.Error errorPanel;
    }
}