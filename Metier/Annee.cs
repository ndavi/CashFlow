﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Annee
    {
        private int idAnnee;
        private Double chiffreAffaire;
        private Double chargesFixes;
        private Double chargesVariables;

        public int IdAnnee
        {
            get { return idAnnee; }
            set { idAnnee = value; }
        }
        public Double ChiffreAffaire
        {
            get { return chiffreAffaire; }
            set { chiffreAffaire = value; }
        }

        public Double ChargesVariables
        {
            get { return chargesVariables; }
            set { chargesVariables = value; }
        }

        public Double ChargesFixes
        {
            get { return chargesFixes; }
            set { chargesFixes = value; }
        }

        public Annee(int idAnnee,Double chiffreAffaire,Double chargesVariables,Double chargesFixes)
        {
            this.idAnnee = idAnnee;
            this.chiffreAffaire = chiffreAffaire;
            this.chargesVariables = chargesVariables;
            this.chargesFixes = chargesFixes;
        }
    }
}
