namespace FileAES_Installer
{
    partial class LegacyInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegacyInstaller));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.installDir = new System.Windows.Forms.TextBox();
            this.browseInstallDir = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.tosTextbox = new System.Windows.Forms.TextBox();
            this.passAccept = new System.Windows.Forms.RadioButton();
            this.failAccept = new System.Windows.Forms.RadioButton();
            this.installOptionsBox = new System.Windows.Forms.GroupBox();
            this.devInfo = new System.Windows.Forms.GroupBox();
            this.devInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addToContext = new System.Windows.Forms.CheckBox();
            this.addToStartMenu = new System.Windows.Forms.CheckBox();
            this.fileAssociation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.defaultToolComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolInstallFileAESCLI = new System.Windows.Forms.CheckBox();
            this.toolInstallFileAESLegacy = new System.Windows.Forms.CheckBox();
            this.toolInstallFileAES = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.installOptionsBox.SuspendLayout();
            this.devInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Install Location:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // installDir
            // 
            this.installDir.Location = new System.Drawing.Point(86, 22);
            this.installDir.Name = "installDir";
            this.installDir.Size = new System.Drawing.Size(318, 20);
            this.installDir.TabIndex = 1;
            // 
            // browseInstallDir
            // 
            this.browseInstallDir.Location = new System.Drawing.Point(410, 20);
            this.browseInstallDir.Name = "browseInstallDir";
            this.browseInstallDir.Size = new System.Drawing.Size(64, 23);
            this.browseInstallDir.TabIndex = 2;
            this.browseInstallDir.Text = "Browse...";
            this.browseInstallDir.UseVisualStyleBackColor = true;
            // 
            // installButton
            // 
            this.installButton.Enabled = false;
            this.installButton.Location = new System.Drawing.Point(317, 169);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(75, 23);
            this.installButton.TabIndex = 3;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // tosTextbox
            // 
            this.tosTextbox.Location = new System.Drawing.Point(12, 97);
            this.tosTextbox.MaxLength = 0;
            this.tosTextbox.Multiline = true;
            this.tosTextbox.Name = "tosTextbox";
            this.tosTextbox.ReadOnly = true;
            this.tosTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tosTextbox.Size = new System.Drawing.Size(469, 141);
            this.tosTextbox.TabIndex = 5;
            this.tosTextbox.TabStop = false;
            this.tosTextbox.Text = resources.GetString("tosTextbox.Text");
            // 
            // passAccept
            // 
            this.passAccept.AutoSize = true;
            this.passAccept.Location = new System.Drawing.Point(13, 244);
            this.passAccept.Name = "passAccept";
            this.passAccept.Size = new System.Drawing.Size(110, 17);
            this.passAccept.TabIndex = 6;
            this.passAccept.Text = "I accept the terms";
            this.passAccept.UseVisualStyleBackColor = true;
            this.passAccept.CheckedChanged += new System.EventHandler(this.passAccept_CheckedChanged);
            // 
            // failAccept
            // 
            this.failAccept.AutoSize = true;
            this.failAccept.Checked = true;
            this.failAccept.Location = new System.Drawing.Point(13, 267);
            this.failAccept.Name = "failAccept";
            this.failAccept.Size = new System.Drawing.Size(143, 17);
            this.failAccept.TabIndex = 7;
            this.failAccept.TabStop = true;
            this.failAccept.Text = "I do not accept the terms";
            this.failAccept.UseVisualStyleBackColor = true;
            this.failAccept.CheckedChanged += new System.EventHandler(this.failAccept_CheckedChanged);
            // 
            // installOptionsBox
            // 
            this.installOptionsBox.Controls.Add(this.devInfo);
            this.installOptionsBox.Controls.Add(this.groupBox2);
            this.installOptionsBox.Controls.Add(this.label3);
            this.installOptionsBox.Controls.Add(this.defaultToolComboBox);
            this.installOptionsBox.Controls.Add(this.groupBox1);
            this.installOptionsBox.Controls.Add(this.label2);
            this.installOptionsBox.Controls.Add(this.branchComboBox);
            this.installOptionsBox.Controls.Add(this.cancelButton);
            this.installOptionsBox.Controls.Add(this.label1);
            this.installOptionsBox.Controls.Add(this.installDir);
            this.installOptionsBox.Controls.Add(this.browseInstallDir);
            this.installOptionsBox.Controls.Add(this.installButton);
            this.installOptionsBox.Location = new System.Drawing.Point(7, 290);
            this.installOptionsBox.Name = "installOptionsBox";
            this.installOptionsBox.Size = new System.Drawing.Size(478, 199);
            this.installOptionsBox.TabIndex = 8;
            this.installOptionsBox.TabStop = false;
            // 
            // devInfo
            // 
            this.devInfo.Controls.Add(this.devInfoTextBox);
            this.devInfo.Location = new System.Drawing.Point(279, 48);
            this.devInfo.Name = "devInfo";
            this.devInfo.Size = new System.Drawing.Size(193, 110);
            this.devInfo.TabIndex = 18;
            this.devInfo.TabStop = false;
            this.devInfo.Text = "Developer";
            this.devInfo.Visible = false;
            // 
            // devInfoTextBox
            // 
            this.devInfoTextBox.Location = new System.Drawing.Point(6, 19);
            this.devInfoTextBox.Name = "devInfoTextBox";
            this.devInfoTextBox.ReadOnly = true;
            this.devInfoTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.devInfoTextBox.Size = new System.Drawing.Size(181, 85);
            this.devInfoTextBox.TabIndex = 0;
            this.devInfoTextBox.TabStop = false;
            this.devInfoTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addToContext);
            this.groupBox2.Controls.Add(this.addToStartMenu);
            this.groupBox2.Controls.Add(this.fileAssociation);
            this.groupBox2.Location = new System.Drawing.Point(144, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 90);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tool Options";
            // 
            // addToContext
            // 
            this.addToContext.AutoSize = true;
            this.addToContext.Checked = true;
            this.addToContext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addToContext.Location = new System.Drawing.Point(7, 65);
            this.addToContext.Name = "addToContext";
            this.addToContext.Size = new System.Drawing.Size(97, 17);
            this.addToContext.TabIndex = 2;
            this.addToContext.Text = "Context Menus";
            this.addToContext.UseVisualStyleBackColor = true;
            // 
            // addToStartMenu
            // 
            this.addToStartMenu.AutoSize = true;
            this.addToStartMenu.Checked = true;
            this.addToStartMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addToStartMenu.Location = new System.Drawing.Point(7, 43);
            this.addToStartMenu.Name = "addToStartMenu";
            this.addToStartMenu.Size = new System.Drawing.Size(121, 17);
            this.addToStartMenu.TabIndex = 1;
            this.addToStartMenu.Text = "Start Menu Shortcut";
            this.addToStartMenu.UseVisualStyleBackColor = true;
            // 
            // fileAssociation
            // 
            this.fileAssociation.AutoSize = true;
            this.fileAssociation.Checked = true;
            this.fileAssociation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileAssociation.Location = new System.Drawing.Point(7, 20);
            this.fileAssociation.Name = "fileAssociation";
            this.fileAssociation.Size = new System.Drawing.Size(99, 17);
            this.fileAssociation.TabIndex = 0;
            this.fileAssociation.Text = "File Association";
            this.fileAssociation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Default Tool:";
            // 
            // defaultToolComboBox
            // 
            this.defaultToolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultToolComboBox.FormattingEnabled = true;
            this.defaultToolComboBox.Items.AddRange(new object[] {
            "FileAES",
            "FileAES-Legacy",
            "FileAES-CLI"});
            this.defaultToolComboBox.Location = new System.Drawing.Point(80, 170);
            this.defaultToolComboBox.Name = "defaultToolComboBox";
            this.defaultToolComboBox.Size = new System.Drawing.Size(193, 21);
            this.defaultToolComboBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolInstallFileAESCLI);
            this.groupBox1.Controls.Add(this.toolInstallFileAESLegacy);
            this.groupBox1.Controls.Add(this.toolInstallFileAES);
            this.groupBox1.Location = new System.Drawing.Point(9, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 90);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools to Install";
            // 
            // toolInstallFileAESCLI
            // 
            this.toolInstallFileAESCLI.AutoSize = true;
            this.toolInstallFileAESCLI.Checked = true;
            this.toolInstallFileAESCLI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolInstallFileAESCLI.Location = new System.Drawing.Point(7, 66);
            this.toolInstallFileAESCLI.Name = "toolInstallFileAESCLI";
            this.toolInstallFileAESCLI.Size = new System.Drawing.Size(82, 17);
            this.toolInstallFileAESCLI.TabIndex = 2;
            this.toolInstallFileAESCLI.Text = "FileAES-CLI";
            this.toolInstallFileAESCLI.UseVisualStyleBackColor = true;
            this.toolInstallFileAESCLI.CheckedChanged += new System.EventHandler(this.toolInstall_CheckedChanged);
            // 
            // toolInstallFileAESLegacy
            // 
            this.toolInstallFileAESLegacy.AutoSize = true;
            this.toolInstallFileAESLegacy.Checked = true;
            this.toolInstallFileAESLegacy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolInstallFileAESLegacy.Location = new System.Drawing.Point(7, 43);
            this.toolInstallFileAESLegacy.Name = "toolInstallFileAESLegacy";
            this.toolInstallFileAESLegacy.Size = new System.Drawing.Size(101, 17);
            this.toolInstallFileAESLegacy.TabIndex = 1;
            this.toolInstallFileAESLegacy.Text = "FileAES-Legacy";
            this.toolInstallFileAESLegacy.UseVisualStyleBackColor = true;
            this.toolInstallFileAESLegacy.CheckedChanged += new System.EventHandler(this.toolInstall_CheckedChanged);
            // 
            // toolInstallFileAES
            // 
            this.toolInstallFileAES.AutoSize = true;
            this.toolInstallFileAES.Checked = true;
            this.toolInstallFileAES.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolInstallFileAES.Location = new System.Drawing.Point(7, 20);
            this.toolInstallFileAES.Name = "toolInstallFileAES";
            this.toolInstallFileAES.Size = new System.Drawing.Size(63, 17);
            this.toolInstallFileAES.TabIndex = 0;
            this.toolInstallFileAES.Text = "FileAES";
            this.toolInstallFileAES.UseVisualStyleBackColor = true;
            this.toolInstallFileAES.CheckedChanged += new System.EventHandler(this.toolInstall_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Install Branch:";
            // 
            // branchComboBox
            // 
            this.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Items.AddRange(new object[] {
            "Stable",
            "Beta",
            "Development"});
            this.branchComboBox.Location = new System.Drawing.Point(86, 48);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(131, 21);
            this.branchComboBox.TabIndex = 14;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(398, 169);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(97, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(180, 26);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "FileAES: Installer";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(99, 39);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(46, 13);
            this.versionLabel.TabIndex = 11;
            this.versionLabel.Text = "v0.0.0.0";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(99, 66);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(141, 13);
            this.copyrightLabel.TabIndex = 12;
            this.copyrightLabel.Text = "Copyright © mullak99 - 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileAES_Installer.Properties.Resources.Icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(7, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LegacyInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 497);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.installOptionsBox);
            this.Controls.Add(this.failAccept);
            this.Controls.Add(this.passAccept);
            this.Controls.Add(this.tosTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LegacyInstaller";
            this.Text = "FileAES: Installer";
            this.installOptionsBox.ResumeLayout(false);
            this.installOptionsBox.PerformLayout();
            this.devInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox installDir;
        private System.Windows.Forms.Button browseInstallDir;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.TextBox tosTextbox;
        private System.Windows.Forms.RadioButton passAccept;
        private System.Windows.Forms.RadioButton failAccept;
        private System.Windows.Forms.GroupBox installOptionsBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox addToStartMenu;
        private System.Windows.Forms.CheckBox fileAssociation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox defaultToolComboBox;
        private System.Windows.Forms.CheckBox toolInstallFileAESCLI;
        private System.Windows.Forms.CheckBox toolInstallFileAESLegacy;
        private System.Windows.Forms.CheckBox toolInstallFileAES;
        private System.Windows.Forms.CheckBox addToContext;
        private System.Windows.Forms.GroupBox devInfo;
        private System.Windows.Forms.RichTextBox devInfoTextBox;
    }
}


