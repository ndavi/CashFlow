using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace AppCashFlow.Presentation
{
    public partial class Index : Form
    {
        private static int? nbrAnnee = null;
        private static int cptAnnee;
        private static bool terminer = false;
        private static CashFlow cashFlow;
        public Index()
        {
            InitializeComponent();
            cashFlow = new CashFlow();
            cptAnnee = 1;
            gb_infoAnnee.Text += "1";

        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            if(!nbrAnnee.HasValue)
            {
                if (tbx_nbrAnnees.Text == "" || tbx_nbrAnnees.Text.Contains(","))
                {
                    MessageBox.Show("Veuillez vérifier le champ \"Nombre d'années\"",
                   "Erreur", MessageBoxButtons.OK);
                }
                else
                {
                    nbrAnnee = Convert.ToInt32(tbx_nbrAnnees.Text);
                    tbx_nbrAnnees.Enabled = false;
                }
            }
            if ((tbx_chifreAffaire.Text == "" || tbx_ChargesFixes.Text == ""
                || tbx_chargesVariables.Text == "") && nbrAnnee.HasValue && terminer == false)
                MessageBox.Show("Veuillez remplir tous les champs",
                    "Erreur lors du calcul", MessageBoxButtons.OK);
            else if (cptAnnee <= nbrAnnee)
            {
                cashFlow.ListeAnnee.Add(new Annee(cptAnnee, Convert.ToDouble(tbx_chifreAffaire.Text),
                    Convert.ToDouble(tbx_chargesVariables.Text), Convert.ToDouble(tbx_ChargesFixes.Text)));
                cptAnnee++;
                gb_infoAnnee.Text = "Information pour l'année n°" + Convert.ToString(cptAnnee);
                if (cbx_memeValeurs.Checked)
                {
                    while (cptAnnee <= 5)
                    {
                        cashFlow.ListeAnnee.Add(new Annee(cptAnnee, Convert.ToDouble(tbx_chifreAffaire.Text),
                            Convert.ToDouble(tbx_chargesVariables.Text), Convert.ToDouble(tbx_ChargesFixes.Text)));
                        cptAnnee++;
                        if (cptAnnee <= 5)
                        {
                            btn_suivant.Text = "Terminer";
                            gb_infoAnnee.Enabled = false;
                            gb_infoAnnee.Text = "Veuillez valider vos informations";
                            terminer = true;
                        }
                    }
                }
                else if (cptAnnee > nbrAnnee)
                {
                    btn_suivant.Text = "Terminer";
                    gb_infoAnnee.Text = "Veuillez valider vos informations";
                    gb_infoAnnee.Enabled = false;
                    terminer = true;
                }
                else
                {
                    tbx_chifreAffaire.Clear();
                    tbx_chargesVariables.Clear();
                    tbx_ChargesFixes.Clear();
                }


            }
            else if (cptAnnee > nbrAnnee)
            {
                if(tbx_montantInvestissementProjet.Text == "" || tbx_montantInvestissement.Text == ""
                     || tbx_tauxActualisation.Text == "" ||
                    tbx_valeurResiduelle.Text == "")
                    MessageBox.Show("Veuillez remplir tous les champs",
                   "Erreur lors du calcul", MessageBoxButtons.OK);
                else
                {
                    cashFlow.MontantInvestissementProjet = Convert.ToDouble(tbx_montantInvestissementProjet.Text);
                    cashFlow.MontantInvestissementMateriel = Convert.ToDouble(tbx_montantInvestissement.Text);
                    cashFlow.NbrAnnees = Convert.ToDouble(tbx_nbrAnnees.Text);
                    cashFlow.TauxActualisation = Convert.ToDouble(tbx_valeurResiduelle.Text);
                    cashFlow.ValeurResiduelle = Convert.ToDouble(tbx_valeurResiduelle.Text);
                    Resultat fRes = new Resultat(cashFlow);
                    fRes.Show();
                }
            }
        }

        #region verificationChamps

        private void verificationTbx(KeyPressEventArgs e,TextBox tbx)
        {
            if (((e.KeyChar == Convert.ToChar(".")) || (e.KeyChar == Convert.ToChar(","))) &&
                (tbx.Text.Contains(".") || tbx.Text.Contains(",")))
            {
                e.Handled = true;
                ToolTip tooltipTaux = new ToolTip();
                tooltipTaux.RemoveAll();
                tooltipTaux.Show("Vous avez déjà saisi une virgule", tbx);
            }
            else if (e.KeyChar == Convert.ToChar("."))
                e.KeyChar = Convert.ToChar(",");
            else if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && Convert.ToChar(",") != e.KeyChar)
            {
                e.Handled = true;
            }
        }

        private void tbx_montantInvestissementProjet_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_montantInvestissementProjet);
        }

        private void tbx_montantInvestissement_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_montantInvestissement);

        }

        private void tbx_tauxActualisation_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_tauxActualisation);

        }

        private void tbx_valeurResiduelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_valeurResiduelle);

        }

        private void tbx_chifreAffaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_chifreAffaire);

        }

        private void tbx_chargesVariables_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_chargesVariables);

        }

        private void tbx_ChargesFixes_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_ChargesFixes);

        }

        private void tbx_nbrAnnees_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.verificationTbx(e,tbx_nbrAnnees);

        }
        #endregion

    }
}
