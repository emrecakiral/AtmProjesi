using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDonemProjesi
{
    public class TxtBoxIsNum
    {
        public bool TxtBoxIsNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return true;
            }
            else
                return false;
        }
    }
}
