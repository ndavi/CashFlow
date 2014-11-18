namespace AppCashFlow.Presentation
{
    partial class Index
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_tauxActualisation = new System.Windows.Forms.TextBox();
            this.tbx_valeurResiduelle = new System.Windows.Forms.TextBox();
            this.tbx_nbrAnnees = new System.Windows.Forms.TextBox();
            this.tbx_montantInvestissement = new System.Windows.Forms.TextBox();
            this.tbx_montantInvestissementProjet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_infoAnnee = new System.Windows.Forms.GroupBox();
            this.cbx_memeValeurs = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_ChargesFixes = new System.Windows.Forms.TextBox();
            this.tbx_chargesVariables = new System.Windows.Forms.TextBox();
            this.tbx_chifreAffaire = new System.Windows.Forms.TextBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_infoAnnee.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_tauxActualisation);
            this.groupBox1.Controls.Add(this.tbx_valeurResiduelle);
            this.groupBox1.Controls.Add(this.tbx_nbrAnnees);
            this.groupBox1.Controls.Add(this.tbx_montantInvestissement);
            this.groupBox1.Controls.Add(this.tbx_montantInvestissementProjet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Montants";
            // 
            // tbx_tauxActualisation
            // 
            this.tbx_tauxActualisation.Location = new System.Drawing.Point(256, 192);
            this.tbx_tauxActualisation.Name = "tbx_tauxActualisation";
            this.tbx_tauxActualisation.Size = new System.Drawing.Size(100, 20);
            this.tbx_tauxActualisation.TabIndex = 9;
            this.tbx_tauxActualisation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_tauxActualisation_KeyPress);
            // 
            // tbx_valeurResiduelle
            // 
            this.tbx_valeurResiduelle.Location = new System.Drawing.Point(256, 238);
            this.tbx_valeurResiduelle.Name = "tbx_valeurResiduelle";
            this.tbx_valeurResiduelle.Size = new System.Drawing.Size(100, 20);
            this.tbx_valeurResiduelle.TabIndex = 8;
            this.tbx_valeurResiduelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_valeurResiduelle_KeyPress);
            // 
            // tbx_nbrAnnees
            // 
            this.tbx_nbrAnnees.Location = new System.Drawing.Point(256, 148);
            this.tbx_nbrAnnees.Name = "tbx_nbrAnnees";
            this.tbx_nbrAnnees.Size = new System.Drawing.Size(100, 20);
            this.tbx_nbrAnnees.TabIndex = 7;
            this.tbx_nbrAnnees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_nbrAnnees_KeyPress);
            // 
            // tbx_montantInvestissement
            // 
            this.tbx_montantInvestissement.Location = new System.Drawing.Point(256, 106);
            this.tbx_montantInvestissement.Name = "tbx_montantInvestissement";
            this.tbx_montantInvestissement.Size = new System.Drawing.Size(100, 20);
            this.tbx_montantInvestissement.TabIndex = 6;
            this.tbx_montantInvestissement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_montantInvestissement_KeyPress);
            // 
            // tbx_montantInvestissementProjet
            // 
            this.tbx_montantInvestissementProjet.Location = new System.Drawing.Point(256, 67);
            this.tbx_montantInvestissementProjet.Name = "tbx_montantInvestissementProjet";
            this.tbx_montantInvestissementProjet.Size = new System.Drawing.Size(100, 20);
            this.tbx_montantInvestissementProjet.TabIndex = 5;
            this.tbx_montantInvestissementProjet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_montantInvestissementProjet_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(81, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valeur résiduelle : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(81, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taux d\'actualisation : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(96, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre d\'années : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Montant investissement : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant d\'investissement projet : ";
            // 
            // gb_infoAnnee
            // 
            this.gb_infoAnnee.Controls.Add(this.cbx_memeValeurs);
            this.gb_infoAnnee.Controls.Add(this.label6);
            this.gb_infoAnnee.Controls.Add(this.label7);
            this.gb_infoAnnee.Controls.Add(this.label8);
            this.gb_infoAnnee.Controls.Add(this.tbx_ChargesFixes);
            this.gb_infoAnnee.Controls.Add(this.tbx_chargesVariables);
            this.gb_infoAnnee.Controls.Add(this.tbx_chifreAffaire);
            this.gb_infoAnnee.Location = new System.Drawing.Point(380, 13);
            this.gb_infoAnnee.Name = "gb_infoAnnee";
            this.gb_infoAnnee.Size = new System.Drawing.Size(290, 309);
            this.gb_infoAnnee.TabIndex = 1;
            this.gb_infoAnnee.TabStop = false;
            this.gb_infoAnnee.Text = "Information pour l\'année n°";
            // 
            // cbx_memeValeurs
            // 
            this.cbx_memeValeurs.AutoSize = true;
            this.cbx_memeValeurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_memeValeurs.Location = new System.Drawing.Point(25, 191);
            this.cbx_memeValeurs.Name = "cbx_memeValeurs";
            this.cbx_memeValeurs.Size = new System.Drawing.Size(262, 17);
            this.cbx_memeValeurs.TabIndex = 13;
            this.cbx_memeValeurs.Text = "Mêmes valeurs pour les années suivantes";
            this.cbx_memeValeurs.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chiffre d\'affaires : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Charges Variables : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(37, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Charges Fixes : ";
            // 
            // tbx_ChargesFixes
            // 
            this.tbx_ChargesFixes.Location = new System.Drawing.Point(165, 133);
            this.tbx_ChargesFixes.Name = "tbx_ChargesFixes";
            this.tbx_ChargesFixes.Size = new System.Drawing.Size(100, 20);
            this.tbx_ChargesFixes.TabIndex = 11;
            this.tbx_ChargesFixes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_ChargesFixes_KeyPress);
            // 
            // tbx_chargesVariables
            // 
            this.tbx_chargesVariables.Location = new System.Drawing.Point(165, 98);
            this.tbx_chargesVariables.Name = "tbx_chargesVariables";
            this.tbx_chargesVariables.Size = new System.Drawing.Size(100, 20);
            this.tbx_chargesVariables.TabIndex = 12;
            this.tbx_chargesVariables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_chargesVariables_KeyPress);
            // 
            // tbx_chifreAffaire
            // 
            this.tbx_chifreAffaire.Location = new System.Drawing.Point(165, 66);
            this.tbx_chifreAffaire.Name = "tbx_chifreAffaire";
            this.tbx_chifreAffaire.Size = new System.Drawing.Size(100, 20);
            this.tbx_chifreAffaire.TabIndex = 10;
            this.tbx_chifreAffaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_chifreAffaire_KeyPress);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.Location = new System.Drawing.Point(406, 357);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(86, 29);
            this.btn_suivant.TabIndex = 2;
            this.btn_suivant.Text = "Suivant";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(557, 357);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(88, 29);
            this.btn_annuler.TabIndex = 3;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(682, 454);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.gb_infoAnnee);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.LightSlateGray;
            this.Name = "Index";
            this.Text = "Index";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_infoAnnee.ResumeLayout(false);
            this.gb_infoAnnee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_tauxActualisation;
        private System.Windows.Forms.TextBox tbx_valeurResiduelle;
        private System.Windows.Forms.TextBox tbx_nbrAnnees;
        private System.Windows.Forms.TextBox tbx_montantInvestissement;
        private System.Windows.Forms.TextBox tbx_montantInvestissementProjet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_infoAnnee;
        private System.Windows.Forms.CheckBox cbx_memeValeurs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_ChargesFixes;
        private System.Windows.Forms.TextBox tbx_chargesVariables;
        private System.Windows.Forms.TextBox tbx_chifreAffaire;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_annuler;
    }
}

