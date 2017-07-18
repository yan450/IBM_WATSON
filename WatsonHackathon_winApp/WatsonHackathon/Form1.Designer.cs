namespace WatsonHackathon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.progressBarFiles = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerSeconde = new System.Windows.Forms.Timer(this.components);
            this.labelBottom = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelMiddle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNps = new WatsonHackathon.Components.PanelNps();
            this.offreTitanium = new WatsonHackathon.Components.OffreTitanium();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(688, 20);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(130, 39);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // progressBarFiles
            // 
            this.progressBarFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarFiles.Location = new System.Drawing.Point(69, 160);
            this.progressBarFiles.Maximum = 30;
            this.progressBarFiles.Name = "progressBarFiles";
            this.progressBarFiles.Size = new System.Drawing.Size(886, 23);
            this.progressBarFiles.Step = 1;
            this.progressBarFiles.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarFiles.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerSeconde
            // 
            this.timerSeconde.Interval = 1000;
            this.timerSeconde.Tick += new System.EventHandler(this.timerSeconde_Tick);
            // 
            // labelBottom
            // 
            this.labelBottom.Image = global::WatsonHackathon.Properties.Resources.belronbottom;
            this.labelBottom.Location = new System.Drawing.Point(0, 752);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(1008, 408);
            this.labelBottom.TabIndex = 5;
            // 
            // labelTop
            // 
            this.labelTop.Image = global::WatsonHackathon.Properties.Resources.belrontop;
            this.labelTop.Location = new System.Drawing.Point(0, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(1008, 176);
            this.labelTop.TabIndex = 3;
            // 
            // labelMiddle
            // 
            this.labelMiddle.Image = global::WatsonHackathon.Properties.Resources.belronmiddleLarge;
            this.labelMiddle.Location = new System.Drawing.Point(0, 164);
            this.labelMiddle.Name = "labelMiddle";
            this.labelMiddle.Size = new System.Drawing.Size(1008, 338);
            this.labelMiddle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Image = global::WatsonHackathon.Properties.Resources.belronmiddleLarge;
            this.label1.Location = new System.Drawing.Point(0, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 323);
            this.label1.TabIndex = 7;
            // 
            // panelNps
            // 
            this.panelNps.BackColor = System.Drawing.Color.Transparent;
            this.panelNps.Location = new System.Drawing.Point(69, 189);
            this.panelNps.Name = "panelNps";
            this.panelNps.Size = new System.Drawing.Size(886, 102);
            this.panelNps.TabIndex = 8;
            // 
            // offreTitanium
            // 
            this.offreTitanium.BackColor = System.Drawing.Color.White;
            this.offreTitanium.Location = new System.Drawing.Point(82, 315);
            this.offreTitanium.Name = "offreTitanium";
            this.offreTitanium.Size = new System.Drawing.Size(873, 537);
            this.offreTitanium.TabIndex = 6;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(833, 20);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(130, 39);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 1062);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.panelNps);
            this.Controls.Add(this.offreTitanium);
            this.Controls.Add(this.labelBottom);
            this.Controls.Add(this.progressBarFiles);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.labelMiddle);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1022, 1100);
            this.MinimumSize = new System.Drawing.Size(1022, 1038);
            this.Name = "Form1";
            this.Text = "IBM Hackathon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ProgressBar progressBarFiles;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerSeconde;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelMiddle;
        private System.Windows.Forms.Label labelBottom;
        private Components.OffreTitanium offreTitanium;
        private System.Windows.Forms.Label label1;
        private Components.PanelNps panelNps;
        private System.Windows.Forms.Button buttonStop;
    }
}

