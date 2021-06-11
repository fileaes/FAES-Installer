
namespace FileAES_Installer.Views
{
    partial class Completed
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
            this.installLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Label();
            this.installSuccessLabel = new System.Windows.Forms.Label();
            this.installLayoutPanel.SuspendLayout();
            this.headerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // installLayoutPanel
            // 
            this.installLayoutPanel.ColumnCount = 1;
            this.installLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.installLayoutPanel.Controls.Add(this.headerLayout, 0, 0);
            this.installLayoutPanel.Controls.Add(this.installSuccessLabel, 0, 1);
            this.installLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.installLayoutPanel.Name = "installLayoutPanel";
            this.installLayoutPanel.RowCount = 2;
            this.installLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.installLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.installLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.installLayoutPanel.Size = new System.Drawing.Size(484, 291);
            this.installLayoutPanel.TabIndex = 3;
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
            // titlePanel
            // 
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.Location = new System.Drawing.Point(6, 6);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(6);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(397, 38);
            this.titlePanel.TabIndex = 2;
            this.titlePanel.Text = "Installation Successful!";
            this.titlePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // installSuccessLabel
            // 
            this.installSuccessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installSuccessLabel.Location = new System.Drawing.Point(25, 75);
            this.installSuccessLabel.Margin = new System.Windows.Forms.Padding(25);
            this.installSuccessLabel.Name = "installSuccessLabel";
            this.installSuccessLabel.Size = new System.Drawing.Size(434, 191);
            this.installSuccessLabel.TabIndex = 4;
            this.installSuccessLabel.Text = "Installation has been successful!";
            // 
            // Completed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.installLayoutPanel);
            this.Name = "Completed";
            this.Size = new System.Drawing.Size(484, 291);
            this.installLayoutPanel.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel installLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titlePanel;
        private System.Windows.Forms.Label installSuccessLabel;
    }
}
