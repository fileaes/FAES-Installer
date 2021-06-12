
namespace FileAES_Installer
{
    partial class Uninstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uninstaller));
            this.installerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.navPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.uninstallPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Label();
            this.uninstallMessageLabel = new System.Windows.Forms.Label();
            this.detectedToolsGroup = new System.Windows.Forms.GroupBox();
            this.detectedToolsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteUserDataCheckBox = new System.Windows.Forms.CheckBox();
            this.installerPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.uninstallPanel.SuspendLayout();
            this.detectedToolsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.navPanel.Controls.Add(this.uninstallButton);
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
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(317, 13);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(75, 23);
            this.uninstallButton.TabIndex = 1;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.uninstallPanel);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(484, 291);
            this.viewPanel.TabIndex = 1;
            // 
            // uninstallPanel
            // 
            this.uninstallPanel.Controls.Add(this.titlePanel);
            this.uninstallPanel.Controls.Add(this.uninstallMessageLabel);
            this.uninstallPanel.Controls.Add(this.detectedToolsGroup);
            this.uninstallPanel.Controls.Add(this.groupBox1);
            this.uninstallPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uninstallPanel.Location = new System.Drawing.Point(0, 0);
            this.uninstallPanel.Name = "uninstallPanel";
            this.uninstallPanel.Padding = new System.Windows.Forms.Padding(8);
            this.uninstallPanel.Size = new System.Drawing.Size(484, 291);
            this.uninstallPanel.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(11, 8);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(461, 54);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.Text = "Welcome to the FileAES Uninstaller";
            // 
            // uninstallMessageLabel
            // 
            this.uninstallMessageLabel.Location = new System.Drawing.Point(11, 62);
            this.uninstallMessageLabel.Name = "uninstallMessageLabel";
            this.uninstallMessageLabel.Size = new System.Drawing.Size(462, 33);
            this.uninstallMessageLabel.TabIndex = 0;
            this.uninstallMessageLabel.Text = "Are you sure you want to uninstall FileAES and its various tools?";
            // 
            // detectedToolsGroup
            // 
            this.detectedToolsGroup.Controls.Add(this.detectedToolsLabel);
            this.detectedToolsGroup.Location = new System.Drawing.Point(11, 98);
            this.detectedToolsGroup.Name = "detectedToolsGroup";
            this.detectedToolsGroup.Size = new System.Drawing.Size(462, 87);
            this.detectedToolsGroup.TabIndex = 2;
            this.detectedToolsGroup.TabStop = false;
            this.detectedToolsGroup.Text = "Detected Tools";
            // 
            // detectedToolsLabel
            // 
            this.detectedToolsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detectedToolsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectedToolsLabel.Location = new System.Drawing.Point(3, 16);
            this.detectedToolsLabel.Name = "detectedToolsLabel";
            this.detectedToolsLabel.Size = new System.Drawing.Size(456, 68);
            this.detectedToolsLabel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteUserDataCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // deleteUserDataCheckBox
            // 
            this.deleteUserDataCheckBox.AutoSize = true;
            this.deleteUserDataCheckBox.Location = new System.Drawing.Point(7, 20);
            this.deleteUserDataCheckBox.Name = "deleteUserDataCheckBox";
            this.deleteUserDataCheckBox.Size = new System.Drawing.Size(108, 17);
            this.deleteUserDataCheckBox.TabIndex = 0;
            this.deleteUserDataCheckBox.Text = "Delete User Data";
            this.deleteUserDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // Uninstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.installerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Uninstaller";
            this.Text = "FileAES: Uninstaller";
            this.installerPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.uninstallPanel.ResumeLayout(false);
            this.detectedToolsGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel installerPanel;
        private System.Windows.Forms.FlowLayoutPanel navPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.FlowLayoutPanel uninstallPanel;
        private System.Windows.Forms.Label uninstallMessageLabel;
        private System.Windows.Forms.Label titlePanel;
        private System.Windows.Forms.GroupBox detectedToolsGroup;
        private System.Windows.Forms.Label detectedToolsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox deleteUserDataCheckBox;
    }
}