using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    class NumericUpDownEx:NumericUpDown
    {
        public NumericUpDownEx()
        {
        }

        protected override void UpdateEditText()
        {
            this.Text = this.Value.ToString() + " $";
            //base.UpdateEditText ();
        }
    }
}

