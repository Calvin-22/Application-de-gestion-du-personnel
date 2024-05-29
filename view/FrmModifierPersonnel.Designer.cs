
namespace Application_de_gestion_du_personnel.view
{
    partial class FrmModifierPersonnel
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
            this.lblverif = new System.Windows.Forms.Label();
            this.cboPersonnel = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblverif
            // 
            this.lblverif.AutoSize = true;
            this.lblverif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverif.ForeColor = System.Drawing.Color.DarkRed;
            this.lblverif.Location = new System.Drawing.Point(216, 227);
            this.lblverif.Name = "lblverif";
            this.lblverif.Size = new System.Drawing.Size(163, 17);
            this.lblverif.TabIndex = 26;
            this.lblverif.Text = "Remplir tout les champs.";
            // 
            // cboPersonnel
            // 
            this.cboPersonnel.FormattingEnabled = true;
            this.cboPersonnel.Location = new System.Drawing.Point(196, 187);
            this.cboPersonnel.Name = "cboPersonnel";
            this.cboPersonnel.Size = new System.Drawing.Size(183, 24);
            this.cboPersonnel.TabIndex = 25;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(284, 263);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(93, 30);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(176, 263);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(93, 30);
            this.btnAnnuler.TabIndex = 23;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(196, 146);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(183, 22);
            this.txtMail.TabIndex = 22;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(196, 108);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(183, 22);
            this.txtTel.TabIndex = 21;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(196, 70);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(183, 22);
            this.txtPrenom.TabIndex = 20;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(196, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(183, 22);
            this.txtNom.TabIndex = 19;
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Location = new System.Drawing.Point(27, 185);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(83, 17);
            this.lblAffectation.TabIndex = 18;
            this.lblAffectation.Text = "Affectation :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(27, 146);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(110, 17);
            this.lblMail.TabIndex = 17;
            this.lblMail.Text = "Adresse e-mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(27, 108);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(84, 17);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(27, 70);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 15;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 17);
            this.lblNom.TabIndex = 14;
            this.lblNom.Text = "Nom : ";
            // 
            // FrmModifierPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 327);
            this.Controls.Add(this.lblverif);
            this.Controls.Add(this.cboPersonnel);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblAffectation);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmModifierPersonnel";
            this.Text = "Modifier un personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblverif;
        private System.Windows.Forms.ComboBox cboPersonnel;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
    }
}