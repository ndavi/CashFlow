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
            foreach (Annee uneAnnee in cashFlow.ListeAnnee)
            {
                cashFlow.calculAnnee(uneAnnee);
                this.dgv.Rows.Add(uneAnnee.ChiffreAffaire,uneAnnee.ChargesVariables,
                    uneAnnee.ChargesFixes, cashFlow.Amortissement, cashFlow.ChargesAnnuelle,
                    cashFlow.CaAvantIS,cashFlow.MontantIS);
            }
        }
    }
}
