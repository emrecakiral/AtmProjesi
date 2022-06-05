using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDonemProjesi
{
    public class TxtBoxIsAlphabetic
    {
         public bool TxtBoxIsAlphabetical(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return true;
            }
            else
                return false;
        }
    }
}
