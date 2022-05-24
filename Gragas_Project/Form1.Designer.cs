namespace Gragas_Project
{
    partial class fWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.h1 = new System.Windows.Forms.Label();
            this.h2 = new System.Windows.Forms.Label();
            this.h3 = new System.Windows.Forms.Label();
            this.pBLoadingStart = new System.Windows.Forms.ProgressBar();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            this.lblTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.BackColor = System.Drawing.Color.Transparent;
            this.h1.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.h1.Location = new System.Drawing.Point(317, 41);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(295, 82);
            this.h1.TabIndex = 0;
            this.h1.Text = "Welcome";
            this.h1.Click += new System.EventHandler(this.h1_Click);
            // 
            // h2
            // 
            this.h2.AutoSize = true;
            this.h2.BackColor = System.Drawing.Color.Transparent;
            this.h2.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.h2.Location = new System.Drawing.Point(411, 123);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(89, 82);
            this.h2.TabIndex = 1;
            this.h2.Text = "to";
            // 
            // h3
            // 
            this.h3.AutoSize = true;
            this.h3.BackColor = System.Drawing.Color.Transparent;
            this.h3.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.h3.Location = new System.Drawing.Point(339, 205);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(231, 82);
            this.h3.TabIndex = 2;
            this.h3.Text = "Gragas";
            // 
            // pBLoadingStart
            // 
            this.pBLoadingStart.Location = new System.Drawing.Point(170, 355);
            this.pBLoadingStart.Name = "pBLoadingStart";
            this.pBLoadingStart.Size = new System.Drawing.Size(580, 23);
            this.pBLoadingStart.TabIndex = 4;
            // 
            // tProgress
            // 
            this.tProgress.Interval = 50;
            this.tProgress.Tick += new System.EventHandler(this.tProgress_Tick);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Location = new System.Drawing.Point(12, 501);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(148, 15);
            this.lblTC.TabIndex = 5;
            this.lblTC.Text = "Software by Azelon Pty Ltd";
            // 
            // fWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Gragas_Project.Properties.Resources._2632224_stars_4k_full_hd_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.pBLoadingStart);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.h1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "fWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label h1;
        private Label h2;
        private Label h3;
        private ProgressBar pBLoadingStart;
        private System.Windows.Forms.Timer tProgress;
        private Label lblTC;
    }
}