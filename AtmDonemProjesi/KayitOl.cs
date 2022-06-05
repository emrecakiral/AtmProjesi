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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            AtmProjesiContext dbContext = new AtmProjesiContext();
            Musteri musteri = new Musteri();
            musteri.Name = txtIsim.Text;
            musteri.Surname = txtSoyisim.Text;
            musteri.Password = txtKayitSifre.Text;
            musteri.Phone = txtKayitPhone.Text;
            musteri.Balance = Convert.ToInt32(txtBakiye.Text);

            try
            {
                dbContext.Musteris.Add(musteri);
                dbContext.SaveChanges();
                MessageBox.Show("Bilgileriniz sistemimize kaydedilmiştir.", "Başarılı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Girilen telefon numarası zaten kayıtlı! Lütfen başka bir numara deneyiniz!{ ex.Message}", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TxtClear();

        }

        private void txtIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblIsimUyari.Visible = isAlfabetik.TxtBoxIsAlphabetical(e);
        }

        private void txtSoyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSoyisimUyari.Visible = isAlfabetik.TxtBoxIsAlphabetical(e);
        }

        private void txtKayitPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTelefonUyari.Visible = isNum.TxtBoxIsNumber(e);
        }

        private void txtBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblBakiyeUyari.Visible = isNum.TxtBoxIsNumber(e);
        }

        private void txtKayitSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSifreUyari.Visible = isNum.TxtBoxIsNumber(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnKayitOl.Enabled = BtnKayitOlOpen();
        }

        private void txtKayitSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                btnKayitOl.PerformClick();
        }

        private void KayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisYap girisyap = new GirisYap();
            girisyap.Show();
            this.Hide();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
        }

        #region Metotlar
        bool BtnKayitOlOpen()
        {
            if (txtIsim.Text.Length > 1 && txtSoyisim.Text.Length > 1 && txtKayitPhone.Text.Length == 11 && txtKayitSifre.Text.Length == 6 && txtKayitPhone.Text[0] == '0' && txtKayitPhone.Text[1] == '5' && txtBakiye.Text.Length > 0)
                return true;
            else
                return false;
        }

        void TxtClear()
        {
            txtIsim.Clear();
            txtSoyisim.Clear();
            txtKayitPhone.Clear();
            txtKayitSifre.Clear();
            txtBakiye.Clear();
            txtIsim.Focus();
        }

        TxtBoxIsAlphabetic isAlfabetik = new TxtBoxIsAlphabetic();
        TxtBoxIsNum isNum = new TxtBoxIsNum();
        #endregion
    }
}
