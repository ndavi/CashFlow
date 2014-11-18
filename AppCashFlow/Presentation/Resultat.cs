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
        private static CashFlow cashFlow;
        public Resultat(CashFlow cashFlowI)
        {
            InitializeComponent();
            cashFlow = cashFlowI;
        }

    }
}
