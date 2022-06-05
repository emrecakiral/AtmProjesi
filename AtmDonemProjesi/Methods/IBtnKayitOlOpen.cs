using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDonemProjesi
{
    public interface IBtnKayitOlOpen
    {
        public bool BtnKayitOlOpen(TextBox phone, TextBox pass, TextBox name, TextBox surname)
        {
            if (name.Text.Length > 1 && surname.Text.Length > 1 && phone.Text.Length == 11 && pass.Text.Length == 6)
                return true;
            else
                return false;
        }
    }
}
