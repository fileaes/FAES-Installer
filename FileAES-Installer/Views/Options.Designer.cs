
namespace FileAES_Installer.Views
{
    partial class Options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.optionsUserConfigPanel = new System.Windows.Forms.TableLayoutPanel();
            this.installPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.configPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolsInstallLabel = new System.Windows.Forms.Label();
            this.toolsCheckList = new System.Windows.Forms.CheckedListBox();
            this.installPathPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.installPathLabel = new System.Windows.Forms.Label();
            this.installPath = new System.Windows.Forms.TextBox();
            this.folderFindButton = new System.Windows.Forms.Button();
            this.installOptionsLabel = new System.Windows.Forms.Label();
            this.installOptionsCheckList = new System.Windows.Forms.CheckedListBox();
            this.defaultToolLabel = new System.Windows.Forms.Label();
            this.defaultToolComboBox = new System.Windows.Forms.ComboBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.optionsLayoutPanel.SuspendLayout();
            this.headerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.optionsUserConfigPanel.SuspendLayout();
            this.installPanel.SuspendLayout();
            this.configPanel.SuspendLayout();
            this.installPathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsLayoutPanel
            // 
            this.optionsLayoutPanel.ColumnCount = 1;
            this.optionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsLayoutPanel.Controls.Add(this.headerLayout, 0, 0);
            this.optionsLayoutPanel.Controls.Add(this.optionsUserConfigPanel, 0, 2);
            this.optionsLayoutPanel.Controls.Add(this.installPathPanel, 0, 1);
            this.optionsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsLayoutPanel.Name = "optionsLayoutPanel";
            this.optionsLayoutPanel.RowCount = 3;
            this.optionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.optionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.optionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsLayoutPanel.Size = new System.Drawing.Size(484, 291);
            this.optionsLayoutPanel.TabIndex = 1;
            // 
            // headerLayout
            // 
            this.headerLayout.ColumnCount = 2;
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.headerLayout.Controls.Add(this.logo, 0, 0);
            this.headerLayout.Controls.Add(this.titlePanel, 0, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(0, 0);
            this.headerLayout.Margin = new System.Windows.Forms.Padding(0);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(484, 50);
            this.headerLayout.TabIndex = 3;
            // 
            // titlePanel
            // 
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(6, 6);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(6);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(397, 38);
            this.titlePanel.TabIndex = 2;
            this.titlePanel.Text = "Install Options";
            this.titlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.Image = global::FileAES_Installer.Properties.Resources.Icon;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(412, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(69, 44);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // optionsUserConfigPanel
            // 
            this.optionsUserConfigPanel.ColumnCount = 2;
            this.optionsUserConfigPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsUserConfigPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsUserConfigPanel.Controls.Add(this.configPanel, 1, 0);
            this.optionsUserConfigPanel.Controls.Add(this.installPanel, 0, 0);
            this.optionsUserConfigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsUserConfigPanel.Location = new System.Drawing.Point(3, 93);
            this.optionsUserConfigPanel.Name = "optionsUserConfigPanel";
            this.optionsUserConfigPanel.RowCount = 1;
            this.optionsUserConfigPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsUserConfigPanel.Size = new System.Drawing.Size(478, 195);
            this.optionsUserConfigPanel.TabIndex = 4;
            // 
            // installPanel
            // 
            this.installPanel.Controls.Add(this.toolsInstallLabel);
            this.installPanel.Controls.Add(this.toolsCheckList);
            this.installPanel.Controls.Add(this.defaultToolLabel);
            this.installPanel.Controls.Add(this.defaultToolComboBox);
            this.installPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.installPanel.Location = new System.Drawing.Point(3, 3);
            this.installPanel.Name = "installPanel";
            this.installPanel.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.installPanel.Size = new System.Drawing.Size(233, 189);
            this.installPanel.TabIndex = 0;
            // 
            // configPanel
            // 
            this.configPanel.Controls.Add(this.installOptionsLabel);
            this.configPanel.Controls.Add(this.installOptionsCheckList);
            this.configPanel.Controls.Add(this.branchLabel);
            this.configPanel.Controls.Add(this.branchComboBox);
            this.configPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.configPanel.Location = new System.Drawing.Point(242, 3);
            this.configPanel.Name = "configPanel";
            this.configPanel.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.configPanel.Size = new System.Drawing.Size(233, 189);
            this.configPanel.TabIndex = 1;
            // 
            // toolsInstallLabel
            // 
            this.toolsInstallLabel.Location = new System.Drawing.Point(6, 6);
            this.toolsInstallLabel.Name = "toolsInstallLabel";
            this.toolsInstallLabel.Size = new System.Drawing.Size(219, 13);
            this.toolsInstallLabel.TabIndex = 0;
            this.toolsInstallLabel.Text = "Tools to Install:";
            // 
            // toolsCheckList
            // 
            this.toolsCheckList.CheckOnClick = true;
            this.toolsCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsCheckList.FormattingEnabled = true;
            this.toolsCheckList.Items.AddRange(new object[] {
            "FileAES",
            "FileAES: Legacy",
            "FileAES: CLI"});
            this.toolsCheckList.Location = new System.Drawing.Point(6, 22);
            this.toolsCheckList.Name = "toolsCheckList";
            this.toolsCheckList.Size = new System.Drawing.Size(219, 96);
            this.toolsCheckList.TabIndex = 1;
            this.toolsCheckList.SelectedIndexChanged += new System.EventHandler(this.toolsCheckList_SelectedIndexChanged);
            // 
            // installPathPanel
            // 
            this.installPathPanel.Controls.Add(this.installPathLabel);
            this.installPathPanel.Controls.Add(this.installPath);
            this.installPathPanel.Controls.Add(this.folderFindButton);
            this.installPathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installPathPanel.Location = new System.Drawing.Point(3, 58);
            this.installPathPanel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.installPathPanel.Name = "installPathPanel";
            this.installPathPanel.Size = new System.Drawing.Size(478, 24);
            this.installPathPanel.TabIndex = 5;
            // 
            // installPathLabel
            // 
            this.installPathLabel.Location = new System.Drawing.Point(3, 0);
            this.installPathLabel.Name = "installPathLabel";
            this.installPathLabel.Size = new System.Drawing.Size(74, 23);
            this.installPathLabel.TabIndex = 1;
            this.installPathLabel.Text = "Install Path:";
            this.installPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // installPath
            // 
            this.installPath.Location = new System.Drawing.Point(83, 3);
            this.installPath.Name = "installPath";
            this.installPath.Size = new System.Drawing.Size(317, 20);
            this.installPath.TabIndex = 2;
            // 
            // folderFindButton
            // 
            this.folderFindButton.Location = new System.Drawing.Point(406, 3);
            this.folderFindButton.Name = "folderFindButton";
            this.folderFindButton.Size = new System.Drawing.Size(67, 20);
            this.folderFindButton.TabIndex = 3;
            this.folderFindButton.Text = "...";
            this.folderFindButton.UseVisualStyleBackColor = true;
            this.folderFindButton.Click += new System.EventHandler(this.folderFindButton_Click);
            // 
            // installOptionsLabel
            // 
            this.installOptionsLabel.Location = new System.Drawing.Point(6, 6);
            this.installOptionsLabel.Name = "installOptionsLabel";
            this.installOptionsLabel.Size = new System.Drawing.Size(219, 13);
            this.installOptionsLabel.TabIndex = 2;
            this.installOptionsLabel.Text = "Install Options:";
            // 
            // installOptionsCheckList
            // 
            this.installOptionsCheckList.CheckOnClick = true;
            this.installOptionsCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installOptionsCheckList.FormattingEnabled = true;
            this.installOptionsCheckList.Items.AddRange(new object[] {
            "File Association",
            "Start Menu Shortcuts",
            "Context Menu Shortcuts"});
            this.installOptionsCheckList.Location = new System.Drawing.Point(6, 22);
            this.installOptionsCheckList.Name = "installOptionsCheckList";
            this.installOptionsCheckList.Size = new System.Drawing.Size(219, 96);
            this.installOptionsCheckList.TabIndex = 3;
            // 
            // defaultToolLabel
            // 
            this.defaultToolLabel.Location = new System.Drawing.Point(6, 121);
            this.defaultToolLabel.Name = "defaultToolLabel";
            this.defaultToolLabel.Size = new System.Drawing.Size(219, 13);
            this.defaultToolLabel.TabIndex = 2;
            this.defaultToolLabel.Text = "Default Tool:";
            // 
            // defaultToolComboBox
            // 
            this.defaultToolComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultToolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultToolComboBox.FormattingEnabled = true;
            this.defaultToolComboBox.Location = new System.Drawing.Point(6, 137);
            this.defaultToolComboBox.Name = "defaultToolComboBox";
            this.defaultToolComboBox.Size = new System.Drawing.Size(219, 21);
            this.defaultToolComboBox.TabIndex = 3;
            // 
            // branchLabel
            // 
            this.branchLabel.Location = new System.Drawing.Point(6, 121);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(219, 13);
            this.branchLabel.TabIndex = 4;
            this.branchLabel.Text = "Branch:";
            // 
            // branchComboBox
            // 
            this.branchComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Items.AddRange(new object[] {
            "Stable",
            "Beta",
            "Developer"});
            this.branchComboBox.Location = new System.Drawing.Point(6, 137);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(219, 21);
            this.branchComboBox.TabIndex = 5;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionsLayoutPanel);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(484, 291);
            this.optionsLayoutPanel.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.optionsUserConfigPanel.ResumeLayout(false);
            this.installPanel.ResumeLayout(false);
            this.configPanel.ResumeLayout(false);
            this.installPathPanel.ResumeLayout(false);
            this.installPathPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel optionsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titlePanel;
        private System.Windows.Forms.TableLayoutPanel optionsUserConfigPanel;
        private System.Windows.Forms.FlowLayoutPanel configPanel;
        private System.Windows.Forms.FlowLayoutPanel installPanel;
        private System.Windows.Forms.Label toolsInstallLabel;
        private System.Windows.Forms.CheckedListBox toolsCheckList;
        private System.Windows.Forms.FlowLayoutPanel installPathPanel;
        private System.Windows.Forms.Label installPathLabel;
        private System.Windows.Forms.TextBox installPath;
        private System.Windows.Forms.Button folderFindButton;
        private System.Windows.Forms.Label installOptionsLabel;
        private System.Windows.Forms.CheckedListBox installOptionsCheckList;
        private System.Windows.Forms.Label defaultToolLabel;
        private System.Windows.Forms.ComboBox defaultToolComboBox;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.ComboBox branchComboBox;
    }
}
