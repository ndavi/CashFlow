using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class CashFlow
    {
        #region Propriété + Accesseurs
        private double montantInvestissementProjet,
            montantInvestissementMateriel,
            nbrAnnees,
            tauxActualisation,
            valeurResiduelle;
        private List<Annee> listeAnnee = new List<Annee>();
        private double van;

        public double Van
        {
            get { return van; }
            set { van = value; }
        }
        
        public List<Annee> ListeAnnee
        {
            get { return listeAnnee; }
            set { listeAnnee = value; }
        }

        public double ValeurResiduelle
        {
            get { return valeurResiduelle; }
            set { valeurResiduelle = value; }
        }

        public double TauxActualisation
        {
            get { return tauxActualisation; }
            set { tauxActualisation = value; }
        }

        public double NbrAnnees
        {
            get { return nbrAnnees; }
            set { nbrAnnees = value; }
        }

        public double MontantInvestissementMateriel
        {
            get { return montantInvestissementMateriel; }
            set { montantInvestissementMateriel = value; }
        }

        public double MontantInvestissementProjet
        {
            get { return montantInvestissementProjet; }
            set { montantInvestissementProjet = value; }
        }
        #endregion

        public CashFlow()
        {
            
        }
        /// <summary>
        /// Effectue les différents calculs pour obtenir le cashflow
        /// </summary>
        /// <param name="uneAnnee">L'année à calculer</param>
        public void calculAnnee(Annee uneAnnee)
        {
            Double amortissement = (montantInvestissementMateriel) - valeurResiduelle;
            uneAnnee.Amortissement = amortissement / listeAnnee.Count;
            uneAnnee.ChargesAnnuelle = uneAnnee.ChargesFixes + uneAnnee.ChargesVariables;
            uneAnnee.CaAvantIS = uneAnnee.ChiffreAffaire - uneAnnee.ChargesAnnuelle - uneAnnee.Amortissement;
            uneAnnee.MontantIS = uneAnnee.CaAvantIS * 0.3333;
            if (uneAnnee.IdAnnee == listeAnnee.Count + 1)
                uneAnnee.CashFlowCalcule = (uneAnnee.Amortissement + (uneAnnee.CaAvantIS - uneAnnee.MontantIS)) + this.valeurResiduelle;        
            else
                uneAnnee.CashFlowCalcule = uneAnnee.Amortissement + (uneAnnee.CaAvantIS - uneAnnee.MontantIS);
            uneAnnee.CfActualise = uneAnnee.CashFlowCalcule * ((Math.Pow((1 + (this.tauxActualisation / 100)), -uneAnnee.IdAnnee)));
            double tmp = 0;
            foreach (Annee annee in this.listeAnnee)
            {
                tmp += annee.CfActualise;
            }
            this.van = tmp - this.montantInvestissementProjet;
        }
    }
}
