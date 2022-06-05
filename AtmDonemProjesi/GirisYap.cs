using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtmDonemProjesi.Models;

namespace AtmDonemProjesi
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }


        public static Musteri SMusteri;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            AtmProjesiContext dbContext = new AtmProjesiContext();
            Musteri musteri = dbContext.Musteris.FirstOrDefault(c => c.Phone == txtGirisYapPhone.Text);
            if (musteri.Password == txtGirisYapPass.Text)
            {
                Home home = new Home();
                SMusteri = musteri;
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Telefon Numarası veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtClear();
            }
        }

        private void txtGirisYapPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTelefonUyariGiris.Visible = isNum.TxtBoxIsNumber(e);
        }

        private void txtGirisYapPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSifreUyariGiris.Visible = isNum.TxtBoxIsNumber(e);
        }

        private void txtGirisYapPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap.PerformClick();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnGirisYap.Enabled = GirisYapBtnControl();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }

        private void GirisYap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region Metotlar
        private bool GirisYapBtnControl()
        {
            if (txtGirisYapPass.Text.Length == 6 && txtGirisYapPhone.Text.Length == 11 && txtGirisYapPhone.Text[0] == '0' && txtGirisYapPhone.Text[1] == '5')
                return true;
            else
                return false;
        }

        void TxtClear()
        {
            txtGirisYapPass.Clear();
            txtGirisYapPhone.Clear();
            txtGirisYapPhone.Focus();
        }

        TxtBoxIsNum isNum = new TxtBoxIsNum();
        #endregion
    }
}
