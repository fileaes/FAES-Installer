
namespace FileAES_Installer.Views
{
    partial class Welcome
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
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.welcomePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Label();
            this.briefWalkthrough = new System.Windows.Forms.Label();
            this.layoutPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Controls.Add(this.infoPanel, 0, 0);
            this.layoutPanel.Controls.Add(this.welcomePanel, 1, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Size = new System.Drawing.Size(484, 291);
            this.layoutPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 1;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoPanel.Controls.Add(this.icon, 0, 0);
            this.infoPanel.Controls.Add(this.infoLabel, 0, 1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 2;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoPanel.Size = new System.Drawing.Size(160, 291);
            this.infoPanel.TabIndex = 0;
            // 
            // icon
            // 
            this.icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.icon.Image = global::FileAES_Installer.Properties.Resources.Icon;
            this.icon.InitialImage = null;
            this.icon.Location = new System.Drawing.Point(3, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(154, 139);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 11;
            this.icon.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Location = new System.Drawing.Point(8, 153);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(8);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(144, 130);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "PLACEHOLDER TEXT";
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.titlePanel);
            this.welcomePanel.Controls.Add(this.briefWalkthrough);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.Location = new System.Drawing.Point(166, 6);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(6);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(312, 279);
            this.welcomePanel.TabIndex = 1;
            // 
            // titlePanel
            // 
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(3, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(315, 54);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Text = "Welcome to the FileAES Installer!";
            // 
            // briefWalkthrough
            // 
            this.briefWalkthrough.Location = new System.Drawing.Point(3, 60);
            this.briefWalkthrough.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.briefWalkthrough.Name = "briefWalkthrough";
            this.briefWalkthrough.Size = new System.Drawing.Size(315, 219);
            this.briefWalkthrough.TabIndex = 1;
            this.briefWalkthrough.Text = "Please click \"Next\" to proceed with the installation.";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutPanel);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(484, 291);
            this.layoutPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.welcomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.FlowLayoutPanel welcomePanel;
        private System.Windows.Forms.Label titlePanel;
        private System.Windows.Forms.Label briefWalkthrough;
    }
}
