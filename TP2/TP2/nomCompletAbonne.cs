using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class nomCompletAbonne
    {
        public string idAbonne { get; private set; }
        public string nomComplet { get; private set; }
        public nomCompletAbonne(string id, string nomComplet)
        {
            this.idAbonne = id;
            this.nomComplet = nomComplet;
        }
    }
}
