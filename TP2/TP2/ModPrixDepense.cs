using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class ModPrixDepense
    {
        public int no { get; set; }
        public string description { get;  set; }
        public decimal prix { get;  set; }
        public decimal depensesObligatoires { get;  set; }
        public ModPrixDepense(int no,  string description, decimal prix, decimal depensesObligatoires)
        {
            this.no = no;
            this.description = description;
            this.prix = prix;
            this.depensesObligatoires = depensesObligatoires;
        }
    }
}
