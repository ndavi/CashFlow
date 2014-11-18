using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Annee
    {
        private int idAnnee;
        private String chiffreAffaire;
        private String chargesFixes;
        private String chargesVariables;

        public int IdAnnee
        {
            get { return idAnnee; }
            set { idAnnee = value; }
        }
        public String ChiffreAffaire
        {
            get { return chiffreAffaire; }
            set { chiffreAffaire = value; }
        }

        public String ChargesVariables
        {
            get { return chargesVariables; }
            set { chargesVariables = value; }
        }

        public String ChargesFixes
        {
            get { return chargesFixes; }
            set { chargesFixes = value; }
        }

        public Annee(int idAnnee,String chiffreAffaire,String chargesVariables,String chargesFixes)
        {
            this.idAnnee = idAnnee;
            this.chiffreAffaire = chiffreAffaire;
            this.chargesVariables = chargesVariables;
            this.chargesFixes = chargesFixes;
        }
    }
}
