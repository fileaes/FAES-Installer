
namespace FileAES_Installer
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.uninstallPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Label();
            this.detectedToolsGroup = new System.Windows.Forms.GroupBox();
            this.detectedToolsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.tipLabel = new System.Windows.Forms.Label();
            this.verLabel = new System.Windows.Forms.Label();
            this.uninstallPanel.SuspendLayout();
            this.detectedToolsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uninstallPanel
            // 
            this.uninstallPanel.Controls.Add(this.titlePanel);
            this.uninstallPanel.Controls.Add(this.verLabel);
            this.uninstallPanel.Controls.Add(this.detectedToolsGroup);
            this.uninstallPanel.Controls.Add(this.groupBox1);
            this.uninstallPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uninstallPanel.Location = new System.Drawing.Point(0, 0);
            this.uninstallPanel.Name = "uninstallPanel";
            this.uninstallPanel.Padding = new System.Windows.Forms.Padding(8);
            this.uninstallPanel.Size = new System.Drawing.Size(484, 314);
            this.uninstallPanel.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(11, 8);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(461, 37);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.Text = "Welcome to the FileAES Setup";
            // 
            // detectedToolsGroup
            // 
            this.detectedToolsGroup.Controls.Add(this.detectedToolsLabel);
            this.detectedToolsGroup.Location = new System.Drawing.Point(11, 71);
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
            this.groupBox1.Controls.Add(this.optionsPanel);
            this.groupBox1.Location = new System.Drawing.Point(11, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.installButton);
            this.optionsPanel.Controls.Add(this.uninstallButton);
            this.optionsPanel.Controls.Add(this.tipLabel);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(3, 16);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Padding = new System.Windows.Forms.Padding(8);
            this.optionsPanel.Size = new System.Drawing.Size(456, 120);
            this.optionsPanel.TabIndex = 0;
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(11, 11);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(430, 32);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Run Installer";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(11, 49);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(430, 32);
            this.uninstallButton.TabIndex = 1;
            this.uninstallButton.Text = "Run Uninstaller";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.Location = new System.Drawing.Point(11, 84);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Padding = new System.Windows.Forms.Padding(8);
            this.tipLabel.Size = new System.Drawing.Size(430, 35);
            this.tipLabel.TabIndex = 2;
            this.tipLabel.Text = "Rerun the installer if you need to fix a broken install.";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // verLabel
            // 
            this.verLabel.Location = new System.Drawing.Point(11, 45);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(290, 23);
            this.verLabel.TabIndex = 5;
            this.verLabel.Text = "v0.0.0";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 314);
            this.Controls.Add(this.uninstallPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Setup";
            this.Text = "FileAES: Setup";
            this.uninstallPanel.ResumeLayout(false);
            this.detectedToolsGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uninstallPanel;
        private System.Windows.Forms.Label titlePanel;
        private System.Windows.Forms.GroupBox detectedToolsGroup;
        private System.Windows.Forms.Label detectedToolsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel optionsPanel;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label verLabel;
    }
}