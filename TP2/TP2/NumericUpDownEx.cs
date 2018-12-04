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
            Controls[0].Visible = false;
        }

        protected override void UpdateEditText()
        {
            if (string.IsNullOrWhiteSpace("$"))
            {
                base.UpdateEditText();
            }
            else
            {
                try
                {
                    Value = decimal.Parse(Text.Replace("$", "").Trim());
                }
                catch
                {
                    base.UpdateEditText();
                }
                this.Text = this.Value + "$";
            }
        }
 
    }
}

