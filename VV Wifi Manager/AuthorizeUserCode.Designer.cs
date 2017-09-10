namespace VV_Wifi_Manager
{
    partial class AuthorizeUserCode
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
            this.codeTB = new System.Windows.Forms.TextBox();
            this.checkBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice Richiesta";
            // 
            // codeTB
            // 
            this.codeTB.Location = new System.Drawing.Point(105, 6);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(167, 20);
            this.codeTB.TabIndex = 1;
            // 
            // checkBT
            // 
            this.checkBT.Location = new System.Drawing.Point(278, 6);
            this.checkBT.Name = "checkBT";
            this.checkBT.Size = new System.Drawing.Size(74, 20);
            this.checkBT.TabIndex = 2;
            this.checkBT.Text = "Controlla";
            this.checkBT.UseVisualStyleBackColor = true;
            this.checkBT.Click += new System.EventHandler(this.checkBT_Click);
            // 
            // AuthorizeUserCode
            // 
            this.AcceptButton = this.checkBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 34);
            this.Controls.Add(this.checkBT);
            this.Controls.Add(this.codeTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 73);
            this.MinimumSize = new System.Drawing.Size(381, 73);
            this.Name = "AuthorizeUserCode";
            this.Text = "Autorizza Utente";
            this.Load += new System.EventHandler(this.AuthorizeUserCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTB;
        private System.Windows.Forms.Button checkBT;
    }
}