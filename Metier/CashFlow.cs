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

        public void CashFlow()
        {

        }
    }
}
