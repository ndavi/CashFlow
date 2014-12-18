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
using Excel = Microsoft.Office.Interop.Excel;


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

        /// <summary>
        /// Récupère les valeurs de l'objet cashflow et les insère dans les dgv, et le dernier onglet
        /// </summary>
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
                this.dgv_actualise.Rows.Add(uneAnnee.CashFlowCalcule, cashFlow.TauxActualisation,uneAnnee.CfActualise);
                this.van_txt.Text = Convert.ToString(cashFlow.Van);
                if (cashFlow.Van < 0)
                    txt_conclusion.Text = "Projet non rentable";
                else
                    txt_conclusion.Text = "Projet rentable";
            }
        }
        /// <summary>
        /// Génèreune feuille axcel basée sur le dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i <= dgv.RowCount - 2; i++)
            {
                for (j = 0; j <= dgv.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = dgv[j, i].Value.ToString();
                }
            }

            xlWorkBook.SaveAs(@"c:\csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
        /// <summary>
        /// Supprime l'objet de la mémoire
        /// </summary>
        /// <param name="obj">L'objet à supprimer</param>
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dgv_actualise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
