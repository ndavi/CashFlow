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
    public partial class Resultat : Form
    {
        private CashFlow cashFlow;
        public Resultat(CashFlow cashFlow)
        {
            InitializeComponent();
            this.cashFlow = cashFlow;
            this.calculCashFlow();
        }


        public void calculCashFlow()
        {
            this.dgv.Rows.Clear();
            string valResiduelle = null;
            foreach (Annee uneAnnee in cashFlow.ListeAnnee)
            {
                cashFlow.calculAnnee(uneAnnee);
                if (uneAnnee.IdAnnee == cashFlow.ListeAnnee.Count +1)
                    valResiduelle = Convert.ToString(cashFlow.ValeurResiduelle);
                this.dgv.Rows.Add(uneAnnee.ChiffreAffaire,uneAnnee.ChargesVariables,
                    uneAnnee.ChargesFixes, uneAnnee.Amortissement, uneAnnee.ChargesAnnuelle,
                    uneAnnee.CaAvantIS, uneAnnee.MontantIS, valResiduelle, uneAnnee.CashFlowCalcule);
                this.dgv_actualise.Rows.Add(uneAnnee.CashFlowCalcule, cashFlow.TauxActualisation,uneAnnee.CfActualise,cashFlow.Van);
            }
        }
    }
}
