namespace ClientBeta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblUpdateAvailable = new System.Windows.Forms.Label();
            this.lblLatestVersion = new System.Windows.Forms.Label();
            this.btnCheckForUpdates = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Versão atual:";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Location = new System.Drawing.Point(128, 106);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentVersion.TabIndex = 1;
            this.lblCurrentVersion.Text = "0.0.0";
            // 
            // lblUpdateAvailable
            // 
            this.lblUpdateAvailable.AutoSize = true;
            this.lblUpdateAvailable.Location = new System.Drawing.Point(53, 142);
            this.lblUpdateAvailable.Name = "lblUpdateAvailable";
            this.lblUpdateAvailable.Size = new System.Drawing.Size(69, 13);
            this.lblUpdateAvailable.TabIndex = 2;
            this.lblUpdateAvailable.Text = "Versão atual:";
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.AutoSize = true;
            this.lblLatestVersion.Location = new System.Drawing.Point(53, 178);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Size = new System.Drawing.Size(69, 13);
            this.lblLatestVersion.TabIndex = 3;
            this.lblLatestVersion.Text = "Versão atual:";
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.Location = new System.Drawing.Point(307, 245);
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.Size = new System.Drawing.Size(75, 23);
            this.btnCheckForUpdates.TabIndex = 4;
            this.btnCheckForUpdates.Text = "button1";
            this.btnCheckForUpdates.UseVisualStyleBackColor = true;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(307, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "button2";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 315);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCheckForUpdates);
            this.Controls.Add(this.lblLatestVersion);
            this.Controls.Add(this.lblUpdateAvailable);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblUpdateAvailable;
        private System.Windows.Forms.Label lblLatestVersion;
        private System.Windows.Forms.Button btnCheckForUpdates;
        private System.Windows.Forms.Button btnUpdate;
    }
}

