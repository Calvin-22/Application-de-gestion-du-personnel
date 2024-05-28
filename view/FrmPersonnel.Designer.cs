
namespace Application_de_gestion_du_personnel.view
{
    partial class FrmPersonnel
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
            this.listPersonnel = new System.Windows.Forms.ListBox();
            this.grboxPersonnel = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lbllogo = new System.Windows.Forms.Label();
            this.grboxPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPersonnel
            // 
            this.listPersonnel.FormattingEnabled = true;
            this.listPersonnel.ItemHeight = 16;
            this.listPersonnel.Location = new System.Drawing.Point(6, 21);
            this.listPersonnel.Name = "listPersonnel";
            this.listPersonnel.Size = new System.Drawing.Size(242, 420);
            this.listPersonnel.TabIndex = 0;
            // 
            // grboxPersonnel
            // 
            this.grboxPersonnel.Controls.Add(this.vScrollBar1);
            this.grboxPersonnel.Controls.Add(this.listPersonnel);
            this.grboxPersonnel.Location = new System.Drawing.Point(29, 38);
            this.grboxPersonnel.Name = "grboxPersonnel";
            this.grboxPersonnel.Size = new System.Drawing.Size(254, 457);
            this.grboxPersonnel.TabIndex = 2;
            this.grboxPersonnel.TabStop = false;
            this.grboxPersonnel.Text = "Personnel";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(224, 21);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 420);
            this.vScrollBar1.TabIndex = 1;
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(319, 322);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(111, 32);
            this.btnAbsence.TabIndex = 3;
            this.btnAbsence.Text = "Absence";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(319, 462);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(111, 32);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(319, 424);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 32);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(319, 386);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 32);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Location = new System.Drawing.Point(360, 120);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(35, 17);
            this.lbllogo.TabIndex = 7;
            this.lbllogo.Text = "logo";
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 527);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.grboxPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "Gestion du personnel";
            this.grboxPersonnel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPersonnel;
        private System.Windows.Forms.GroupBox grboxPersonnel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lbllogo;
    }
}