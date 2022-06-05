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
    public partial class BilgiGuncelle : Form
    {
        public Musteri musteri = new Musteri();
        public AtmProjesiContext dbContext = new AtmProjesiContext();
        public BilgiGuncelle()
        {
            InitializeComponent();
            musteri = MusteriAtama();
            lblKayitTarihi.Text = musteri.DateTime.ToString("dd/mm/yyyy");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            musteri = MusteriAtama();
            Guncelle();

            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Bilgileriniz güncellendi.", "Başarılı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Girdiğiniz bilgilerde hata var, bilgileri düzeltip tekrar deneyiniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Doldur();
        }
        private void txtIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblIsimUyari.Visible = TxtBoxIsAlphabetical(e);
        }

        private void txtSoyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSoyisimUyari.Visible = TxtBoxIsAlphabetical(e);
        }

        private void txtKayitPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTelefonUyari.Visible = ITxtBoxIsNumber(e);
        }

        private void txtKayitSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSifreUyari.Visible = ITxtBoxIsNumber(e);
        }
        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = BtnGuncelleOpen();
        }

        private void txtSoyisim_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = BtnGuncelleOpen();
        }

        private void txtKayitPhone_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = BtnGuncelleOpen();
        }

        private void txtKayitSifre_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = BtnGuncelleOpen();
        }
        private void txtKayitSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                btnGuncelle.PerformClick();
        }
        private void BilgiGuncelle_Load(object sender, EventArgs e)
        {
            musteri = MusteriAtama();
            Doldur();
        }
        private void Geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        private void BilgiGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        #region Metotlar
        Musteri MusteriAtama()
        {
            return dbContext.Musteris.FirstOrDefault(c => c.Phone == GirisYap.SMusteri.Phone);
        }

        void Guncelle()
        {
            musteri.Name = txtIsim.Text;
            musteri.Surname = txtSoyisim.Text;
            musteri.Password = txtKayitSifre.Text;
            musteri.Phone = txtKayitPhone.Text;
        }

        private bool ITxtBoxIsNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return true;
            }
            else
                return false;
        }

        public bool BtnGuncelleOpen()
        {
            if (txtIsim.Text.Length > 1 && txtSoyisim.Text.Length > 1 && txtKayitPhone.Text.Length == 11 && txtKayitSifre.Text.Length == 6 && txtKayitPhone.Text[0] == '0' && txtKayitPhone.Text[1] == '5')
                return true;
            else
                return false;
        }

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

        void TxtClear()
        {
            txtIsim.Clear();
            txtSoyisim.Clear();
            txtKayitPhone.Clear();
            txtKayitSifre.Clear();
            txtIsim.Focus();
        }

        void Doldur()
        {
            txtIsim.Text = musteri.Name;
            txtSoyisim.Text = musteri.Surname;
            txtKayitPhone.Text = musteri.Phone;
        }

        #endregion

    }
}
