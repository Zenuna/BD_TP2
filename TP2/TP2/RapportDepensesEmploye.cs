using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class RapportDepensesEmploye
    {
        public string nomCompletEmploye { get; set; }
        public string typeService { get; set; }
        public decimal montant { get; set; }
        public DateTime dateDepense { get; set; }
        public string nomCompletAbPrincipal { get; set; }
    }
}
