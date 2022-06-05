using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmDonemProjesi
{
    public interface IGirisYapBtnOpen
    {
        public bool GirisYapBtnControl(EventArgs e, TextBox lblphone, TextBox lblPass)
        {
            if (lblPass.Text.Length == 6 && lblphone.Text.Length == 11)
                return true;
            else
                return false;
        }

    }
}
