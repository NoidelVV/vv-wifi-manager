namespace VV_Wifi_Manager
{
    partial class AuthorizeUserView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.classTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.reqIDLabel = new System.Windows.Forms.Label();
            this.confirmBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Classe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(88, 6);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(219, 20);
            this.nameTB.TabIndex = 4;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(88, 32);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.ReadOnly = true;
            this.surnameTB.Size = new System.Drawing.Size(219, 20);
            this.surnameTB.TabIndex = 5;
            // 
            // classTB
            // 
            this.classTB.Location = new System.Drawing.Point(88, 58);
            this.classTB.Name = "classTB";
            this.classTB.ReadOnly = true;
            this.classTB.Size = new System.Drawing.Size(219, 20);
            this.classTB.TabIndex = 6;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(88, 84);
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            this.emailTB.Size = new System.Drawing.Size(219, 20);
            this.emailTB.TabIndex = 7;
            // 
            // reqIDLabel
            // 
            this.reqIDLabel.AutoSize = true;
            this.reqIDLabel.Location = new System.Drawing.Point(12, 129);
            this.reqIDLabel.Name = "reqIDLabel";
            this.reqIDLabel.Size = new System.Drawing.Size(33, 13);
            this.reqIDLabel.TabIndex = 8;
            this.reqIDLabel.Text = "reqID";
            // 
            // confirmBT
            // 
            this.confirmBT.Location = new System.Drawing.Point(139, 117);
            this.confirmBT.Name = "confirmBT";
            this.confirmBT.Size = new System.Drawing.Size(168, 37);
            this.confirmBT.TabIndex = 9;
            this.confirmBT.Text = "Conferma";
            this.confirmBT.UseVisualStyleBackColor = true;
            this.confirmBT.Click += new System.EventHandler(this.confirmBT_Click);
            // 
            // AuthorizeUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 164);
            this.Controls.Add(this.confirmBT);
            this.Controls.Add(this.reqIDLabel);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.classTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 203);
            this.MinimumSize = new System.Drawing.Size(342, 203);
            this.Name = "AuthorizeUserView";
            this.Text = "Informazioni Utente";
            this.Load += new System.EventHandler(this.AuthorizeUserView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox classTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label reqIDLabel;
        private System.Windows.Forms.Button confirmBT;
    }
}