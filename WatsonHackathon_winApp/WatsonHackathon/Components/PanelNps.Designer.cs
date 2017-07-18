namespace WatsonHackathon.Components
{
    partial class PanelNps
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
            this.labelFirst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirst
            // 
            this.labelFirst.BackColor = System.Drawing.Color.Gray;
            this.labelFirst.Location = new System.Drawing.Point(3, 0);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(102, 102);
            this.labelFirst.TabIndex = 0;
            // 
            // PanelNps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelFirst);
            this.Name = "PanelNps";
            this.Size = new System.Drawing.Size(886, 102);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFirst;
    }
}
