namespace VV_Wifi_Manager
{
    partial class RequestsList
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
            this.itemsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usersData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aggiornaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsMenu
            // 
            this.itemsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiornaToolStripMenuItem});
            this.itemsMenu.Name = "itemsMenu";
            this.itemsMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // usersData
            // 
            this.usersData.AllowUserToAddRows = false;
            this.usersData.AllowUserToDeleteRows = false;
            this.usersData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.usersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserId,
            this.Nome,
            this.Classe,
            this.Status});
            this.usersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersData.Location = new System.Drawing.Point(0, 0);
            this.usersData.Name = "usersData";
            this.usersData.ReadOnly = true;
            this.usersData.Size = new System.Drawing.Size(814, 530);
            this.usersData.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID Richiesta";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 90;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserId.HeaderText = "ID Studente";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 89;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Classe
            // 
            this.Classe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            this.Classe.Width = 63;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Stato";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 57;
            // 
            // aggiornaToolStripMenuItem
            // 
            this.aggiornaToolStripMenuItem.Name = "aggiornaToolStripMenuItem";
            this.aggiornaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aggiornaToolStripMenuItem.Text = "Aggiorna";
            this.aggiornaToolStripMenuItem.Click += new System.EventHandler(this.aggiornaToolStripMenuItem_Click);
            // 
            // RequestsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 530);
            this.Controls.Add(this.usersData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RequestsList";
            this.Text = "Elenco Richieste di Attivazione";
            this.Load += new System.EventHandler(this.RequestsList_Load);
            this.itemsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.ContextMenuStrip itemsMenu;
        private System.Windows.Forms.DataGridView usersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripMenuItem aggiornaToolStripMenuItem;
    }
}