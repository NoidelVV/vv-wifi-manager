namespace VV_Wifi_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.welcomeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.copyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaElencoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utentiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richiesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeLabel,
            this.copyLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 550);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(931, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(83, 17);
            this.welcomeLabel.Text = "welcomeLabel";
            // 
            // copyLabel
            // 
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(833, 17);
            this.copyLabel.Spring = true;
            this.copyLabel.Text = "© 2016 Vittorio Grasso";
            this.copyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utentiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chiudiToolStripMenuItem.Text = "&Esci";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // utentiToolStripMenuItem
            // 
            this.utentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaElencoToolStripMenuItem,
            this.aggiungiToolStripMenuItem});
            this.utentiToolStripMenuItem.Name = "utentiToolStripMenuItem";
            this.utentiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.utentiToolStripMenuItem.Text = "&Studenti";
            this.utentiToolStripMenuItem.Click += new System.EventHandler(this.utentiToolStripMenuItem_Click);
            // 
            // visualizzaElencoToolStripMenuItem
            // 
            this.visualizzaElencoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utentiToolStripMenuItem1,
            this.richiesteToolStripMenuItem});
            this.visualizzaElencoToolStripMenuItem.Name = "visualizzaElencoToolStripMenuItem";
            this.visualizzaElencoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visualizzaElencoToolStripMenuItem.Text = "Visualizza";
            this.visualizzaElencoToolStripMenuItem.Click += new System.EventHandler(this.visualizzaElencoToolStripMenuItem_Click);
            // 
            // utentiToolStripMenuItem1
            // 
            this.utentiToolStripMenuItem1.Name = "utentiToolStripMenuItem1";
            this.utentiToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.utentiToolStripMenuItem1.Text = "Utenti Attivi";
            this.utentiToolStripMenuItem1.Click += new System.EventHandler(this.utentiToolStripMenuItem1_Click);
            // 
            // richiesteToolStripMenuItem
            // 
            this.richiesteToolStripMenuItem.Name = "richiesteToolStripMenuItem";
            this.richiesteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.richiesteToolStripMenuItem.Text = "Richieste";
            this.richiesteToolStripMenuItem.Click += new System.EventHandler(this.richiesteToolStripMenuItem_Click);
            // 
            // aggiungiToolStripMenuItem
            // 
            this.aggiungiToolStripMenuItem.Name = "aggiungiToolStripMenuItem";
            this.aggiungiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aggiungiToolStripMenuItem.Text = "Autorizza...";
            this.aggiungiToolStripMenuItem.Click += new System.EventHandler(this.aggiungiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 572);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "VV Wifi Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel welcomeLabel;
        private System.Windows.Forms.ToolStripStatusLabel copyLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaElencoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utentiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem richiesteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}