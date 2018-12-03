using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class nomCompletIDAbonne
    {
        public string idAbonnement { get; private set; }
        public string idEtNomComplet { get; private set; }
        public nomCompletIDAbonne(string idAbonnement, string idEtNomComplet)
        {
            this.idAbonnement = idAbonnement;
            this.idEtNomComplet = idEtNomComplet;
        }
    }
}
