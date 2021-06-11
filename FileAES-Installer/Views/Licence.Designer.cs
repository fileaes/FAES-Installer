
namespace FileAES_Installer.Views
{
    partial class Licence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licence));
            this.licenceLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.licencePanel = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.acceptTerms = new System.Windows.Forms.RadioButton();
            this.denyTerms = new System.Windows.Forms.RadioButton();
            this.licenceAgreement = new System.Windows.Forms.RichTextBox();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.titlePanel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.licenceLayoutPanel.SuspendLayout();
            this.licencePanel.SuspendLayout();
            this.radioButtonPanel.SuspendLayout();
            this.headerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // licenceLayoutPanel
            // 
            this.licenceLayoutPanel.ColumnCount = 1;
            this.licenceLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.licenceLayoutPanel.Controls.Add(this.licencePanel, 0, 1);
            this.licenceLayoutPanel.Controls.Add(this.headerLayout, 0, 0);
            this.licenceLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenceLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.licenceLayoutPanel.Name = "licenceLayoutPanel";
            this.licenceLayoutPanel.RowCount = 2;
            this.licenceLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.licenceLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.licenceLayoutPanel.Size = new System.Drawing.Size(484, 291);
            this.licenceLayoutPanel.TabIndex = 0;
            // 
            // licencePanel
            // 
            this.licencePanel.ColumnCount = 1;
            this.licencePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.licencePanel.Controls.Add(this.radioButtonPanel, 0, 1);
            this.licencePanel.Controls.Add(this.licenceAgreement, 0, 0);
            this.licencePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licencePanel.Location = new System.Drawing.Point(3, 53);
            this.licencePanel.Name = "licencePanel";
            this.licencePanel.RowCount = 2;
            this.licencePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.licencePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.licencePanel.Size = new System.Drawing.Size(478, 235);
            this.licencePanel.TabIndex = 2;
            // 
            // radioButtonPanel
            // 
            this.radioButtonPanel.Controls.Add(this.acceptTerms);
            this.radioButtonPanel.Controls.Add(this.denyTerms);
            this.radioButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.radioButtonPanel.Location = new System.Drawing.Point(10, 170);
            this.radioButtonPanel.Margin = new System.Windows.Forms.Padding(10);
            this.radioButtonPanel.Name = "radioButtonPanel";
            this.radioButtonPanel.Size = new System.Drawing.Size(458, 55);
            this.radioButtonPanel.TabIndex = 0;
            // 
            // acceptTerms
            // 
            this.acceptTerms.AutoSize = true;
            this.acceptTerms.Location = new System.Drawing.Point(3, 3);
            this.acceptTerms.Name = "acceptTerms";
            this.acceptTerms.Size = new System.Drawing.Size(135, 17);
            this.acceptTerms.TabIndex = 0;
            this.acceptTerms.Text = "I accept the agreement";
            this.acceptTerms.UseVisualStyleBackColor = true;
            this.acceptTerms.CheckedChanged += new System.EventHandler(this.acceptTerms_CheckedChanged);
            // 
            // denyTerms
            // 
            this.denyTerms.AutoSize = true;
            this.denyTerms.Checked = true;
            this.denyTerms.Location = new System.Drawing.Point(3, 26);
            this.denyTerms.Name = "denyTerms";
            this.denyTerms.Size = new System.Drawing.Size(168, 17);
            this.denyTerms.TabIndex = 1;
            this.denyTerms.TabStop = true;
            this.denyTerms.Text = "I do not accept the agreement";
            this.denyTerms.UseVisualStyleBackColor = true;
            this.denyTerms.CheckedChanged += new System.EventHandler(this.denyTerms_CheckedChanged);
            // 
            // licenceAgreement
            // 
            this.licenceAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenceAgreement.Location = new System.Drawing.Point(3, 3);
            this.licenceAgreement.Name = "licenceAgreement";
            this.licenceAgreement.ReadOnly = true;
            this.licenceAgreement.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.licenceAgreement.Size = new System.Drawing.Size(472, 154);
            this.licenceAgreement.TabIndex = 1;
            this.licenceAgreement.Text = resources.GetString("licenceAgreement.Text");
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
            this.titlePanel.Text = "Licence";
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
            // Licence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.licenceLayoutPanel);
            this.Name = "Licence";
            this.Size = new System.Drawing.Size(484, 291);
            this.licenceLayoutPanel.ResumeLayout(false);
            this.licencePanel.ResumeLayout(false);
            this.radioButtonPanel.ResumeLayout(false);
            this.radioButtonPanel.PerformLayout();
            this.headerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel licenceLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel licencePanel;
        private System.Windows.Forms.FlowLayoutPanel radioButtonPanel;
        private System.Windows.Forms.RadioButton acceptTerms;
        private System.Windows.Forms.RadioButton denyTerms;
        private System.Windows.Forms.RichTextBox licenceAgreement;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.Label titlePanel;
        private System.Windows.Forms.PictureBox logo;
    }
}
