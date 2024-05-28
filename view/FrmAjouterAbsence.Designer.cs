
namespace Application_de_gestion_du_personnel.view
{
    partial class FrmAjouterAbsence
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
            this.comboMotif = new System.Windows.Forms.ComboBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblverif
            // 
            this.lblverif.AutoSize = true;
            this.lblverif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverif.ForeColor = System.Drawing.Color.DarkRed;
            this.lblverif.Location = new System.Drawing.Point(216, 155);
            this.lblverif.Name = "lblverif";
            this.lblverif.Size = new System.Drawing.Size(163, 17);
            this.lblverif.TabIndex = 22;
            this.lblverif.Text = "Remplir tout les champs.";
            // 
            // comboMotif
            // 
            this.comboMotif.FormattingEnabled = true;
            this.comboMotif.Location = new System.Drawing.Point(196, 115);
            this.comboMotif.Name = "comboMotif";
            this.comboMotif.Size = new System.Drawing.Size(183, 24);
            this.comboMotif.TabIndex = 21;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(284, 191);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(93, 30);
            this.btnConfirmer.TabIndex = 20;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(176, 191);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(93, 30);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(196, 74);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(183, 22);
            this.txtFin.TabIndex = 18;
            // 
            // txtDebut
            // 
            this.txtDebut.Location = new System.Drawing.Point(196, 36);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(183, 22);
            this.txtDebut.TabIndex = 17;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(27, 113);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(46, 17);
            this.lblMotif.TabIndex = 16;
            this.lblMotif.Text = "Motif :";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(27, 74);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(85, 17);
            this.lblFin.TabIndex = 15;
            this.lblFin.Text = "Date de fin :";
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(27, 36);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(106, 17);
            this.lblDebut.TabIndex = 14;
            this.lblDebut.Text = "Date de début :";
            // 
            // FrmAjouterAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 254);
            this.Controls.Add(this.lblverif);
            this.Controls.Add(this.comboMotif);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.txtDebut);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblDebut);
            this.Name = "FrmAjouterAbsence";
            this.Text = "Ajouter une absence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblverif;
        private System.Windows.Forms.ComboBox comboMotif;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblDebut;
    }
}