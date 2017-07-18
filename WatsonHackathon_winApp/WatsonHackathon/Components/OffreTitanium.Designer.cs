namespace WatsonHackathon.Components
{
    partial class OffreTitanium
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
            this.labelThumbPlatinium = new System.Windows.Forms.Label();
            this.labelOffers = new System.Windows.Forms.Label();
            this.labelThumbGold = new System.Windows.Forms.Label();
            this.labelThumbSilver = new System.Windows.Forms.Label();
            this.labelThumbBronze = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelThumbPlatinium
            // 
            this.labelThumbPlatinium.Image = global::WatsonHackathon.Properties.Resources.thumb;
            this.labelThumbPlatinium.Location = new System.Drawing.Point(51, 453);
            this.labelThumbPlatinium.Name = "labelThumbPlatinium";
            this.labelThumbPlatinium.Size = new System.Drawing.Size(120, 78);
            this.labelThumbPlatinium.TabIndex = 1;
            // 
            // labelOffers
            // 
            this.labelOffers.Image = global::WatsonHackathon.Properties.Resources.offers;
            this.labelOffers.Location = new System.Drawing.Point(3, 0);
            this.labelOffers.Name = "labelOffers";
            this.labelOffers.Size = new System.Drawing.Size(870, 453);
            this.labelOffers.TabIndex = 0;
            // 
            // labelThumbGold
            // 
            this.labelThumbGold.Image = global::WatsonHackathon.Properties.Resources.thumb;
            this.labelThumbGold.Location = new System.Drawing.Point(266, 453);
            this.labelThumbGold.Name = "labelThumbGold";
            this.labelThumbGold.Size = new System.Drawing.Size(120, 78);
            this.labelThumbGold.TabIndex = 2;
            // 
            // labelThumbSilver
            // 
            this.labelThumbSilver.Image = global::WatsonHackathon.Properties.Resources.thumb;
            this.labelThumbSilver.Location = new System.Drawing.Point(484, 453);
            this.labelThumbSilver.Name = "labelThumbSilver";
            this.labelThumbSilver.Size = new System.Drawing.Size(120, 78);
            this.labelThumbSilver.TabIndex = 3;
            // 
            // labelThumbBronze
            // 
            this.labelThumbBronze.Image = global::WatsonHackathon.Properties.Resources.thumb;
            this.labelThumbBronze.Location = new System.Drawing.Point(702, 453);
            this.labelThumbBronze.Name = "labelThumbBronze";
            this.labelThumbBronze.Size = new System.Drawing.Size(120, 78);
            this.labelThumbBronze.TabIndex = 4;
            // 
            // OffreTitanium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelThumbBronze);
            this.Controls.Add(this.labelThumbSilver);
            this.Controls.Add(this.labelThumbGold);
            this.Controls.Add(this.labelThumbPlatinium);
            this.Controls.Add(this.labelOffers);
            this.Name = "OffreTitanium";
            this.Size = new System.Drawing.Size(873, 537);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOffers;
        private System.Windows.Forms.Label labelThumbPlatinium;
        private System.Windows.Forms.Label labelThumbGold;
        private System.Windows.Forms.Label labelThumbSilver;
        private System.Windows.Forms.Label labelThumbBronze;
    }
}
