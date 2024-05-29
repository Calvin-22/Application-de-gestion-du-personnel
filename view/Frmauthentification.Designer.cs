
namespace Application_de_gestion_du_personnel.view
{
    partial class FrmAuthentification
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
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.LblConnexion = new System.Windows.Forms.Label();
            this.lblidentifier = new System.Windows.Forms.Label();
            this.lblMotdePasse = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Location = new System.Drawing.Point(199, 155);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(140, 33);
            this.btnSeConnecter.TabIndex = 0;
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // LblConnexion
            // 
            this.LblConnexion.AutoSize = true;
            this.LblConnexion.Location = new System.Drawing.Point(20, 15);
            this.LblConnexion.Name = "LblConnexion";
            this.LblConnexion.Size = new System.Drawing.Size(157, 17);
            this.LblConnexion.TabIndex = 1;
            this.LblConnexion.Text = "Veuillez vous identifier :";
            // 
            // lblidentifier
            // 
            this.lblidentifier.AutoSize = true;
            this.lblidentifier.Location = new System.Drawing.Point(20, 52);
            this.lblidentifier.Name = "lblidentifier";
            this.lblidentifier.Size = new System.Drawing.Size(81, 17);
            this.lblidentifier.TabIndex = 2;
            this.lblidentifier.Text = "Identifiant : ";
            // 
            // lblMotdePasse
            // 
            this.lblMotdePasse.AutoSize = true;
            this.lblMotdePasse.Location = new System.Drawing.Point(20, 107);
            this.lblMotdePasse.Name = "lblMotdePasse";
            this.lblMotdePasse.Size = new System.Drawing.Size(105, 17);
            this.lblMotdePasse.TabIndex = 3;
            this.lblMotdePasse.Text = "Mot de passe : ";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(133, 49);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(186, 22);
            this.txtIdentifiant.TabIndex = 4;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(133, 104);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(186, 22);
            this.txtMDP.TabIndex = 5;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 238);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblMotdePasse);
            this.Controls.Add(this.lblidentifier);
            this.Controls.Add(this.LblConnexion);
            this.Controls.Add(this.btnSeConnecter);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Label LblConnexion;
        private System.Windows.Forms.Label lblidentifier;
        private System.Windows.Forms.Label lblMotdePasse;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMDP;
    }
}