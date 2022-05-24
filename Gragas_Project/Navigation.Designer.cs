namespace Gragas_Project
{
    partial class fNavigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNavigation));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProductPrice = new System.Windows.Forms.Button();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.BackColor = System.Drawing.Color.DimGray;
            this.btnExport.FlatAppearance.BorderSize = 5;
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProductPrice
            // 
            resources.ApplyResources(this.btnProductPrice, "btnProductPrice");
            this.btnProductPrice.BackColor = System.Drawing.Color.DimGray;
            this.btnProductPrice.FlatAppearance.BorderSize = 5;
            this.btnProductPrice.Name = "btnProductPrice";
            this.btnProductPrice.UseVisualStyleBackColor = false;
            this.btnProductPrice.Click += new System.EventHandler(this.btnProductPrice_Click);
            // 
            // btnIngredients
            // 
            resources.ApplyResources(this.btnIngredients, "btnIngredients");
            this.btnIngredients.BackColor = System.Drawing.Color.DimGray;
            this.btnIngredients.FlatAppearance.BorderSize = 5;
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.UseVisualStyleBackColor = false;
            this.btnIngredients.Click += new System.EventHandler(this.btnIngredients_Click);
            // 
            // lblHeading
            // 
            resources.ApplyResources(this.lblHeading, "lblHeading");
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Name = "lblHeading";
            // 
            // lblTC
            // 
            resources.ApplyResources(this.lblTC, "lblTC");
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Name = "lblTC";
            // 
            // fNavigation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Gragas_Project.Properties.Resources._2632224_stars_4k_full_hd_wallpaper;
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnIngredients);
            this.Controls.Add(this.btnProductPrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fNavigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Button btnExport;
        private Button btnExit;
        private Button btnProductPrice;
        private Button btnIngredients;
        private Label lblHeading;
        private Label lblTC;
    }
}