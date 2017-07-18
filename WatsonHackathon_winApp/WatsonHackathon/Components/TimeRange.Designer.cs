namespace WatsonHackathon.Components
{
    partial class TimeRange
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
            this.sentimentLabel = new System.Windows.Forms.Label();
            this.PersonnalityPanel = new System.Windows.Forms.Label();
            this.PerseptionPanel = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sentimentLabel
            // 
            this.sentimentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sentimentLabel.BackColor = System.Drawing.Color.Red;
            this.sentimentLabel.ForeColor = System.Drawing.Color.Black;
            this.sentimentLabel.Location = new System.Drawing.Point(0, 0);
            this.sentimentLabel.Name = "sentimentLabel";
            this.sentimentLabel.Size = new System.Drawing.Size(73, 75);
            this.sentimentLabel.TabIndex = 0;
            this.sentimentLabel.Text = "Sentiment";
            this.sentimentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonnalityPanel
            // 
            this.PersonnalityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonnalityPanel.BackColor = System.Drawing.Color.Yellow;
            this.PersonnalityPanel.ForeColor = System.Drawing.Color.Black;
            this.PersonnalityPanel.Location = new System.Drawing.Point(81, 0);
            this.PersonnalityPanel.Name = "PersonnalityPanel";
            this.PersonnalityPanel.Size = new System.Drawing.Size(73, 75);
            this.PersonnalityPanel.TabIndex = 1;
            this.PersonnalityPanel.Text = "Personnality";
            this.PersonnalityPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerseptionPanel
            // 
            this.PerseptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerseptionPanel.BackColor = System.Drawing.Color.Green;
            this.PerseptionPanel.ForeColor = System.Drawing.Color.Black;
            this.PerseptionPanel.Location = new System.Drawing.Point(162, 0);
            this.PerseptionPanel.Name = "PerseptionPanel";
            this.PerseptionPanel.Size = new System.Drawing.Size(73, 75);
            this.PerseptionPanel.TabIndex = 2;
            this.PerseptionPanel.Text = "Perseption";
            this.PerseptionPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.BackColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(4, 79);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(229, 23);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "30";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.PerseptionPanel);
            this.Controls.Add(this.PersonnalityPanel);
            this.Controls.Add(this.sentimentLabel);
            this.Name = "TimeRange";
            this.Size = new System.Drawing.Size(236, 106);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sentimentLabel;
        private System.Windows.Forms.Label PersonnalityPanel;
        private System.Windows.Forms.Label PerseptionPanel;
        private System.Windows.Forms.Label labelInfo;
    }
}
