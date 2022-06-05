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
    public partial class Havale : Form
    {

        public AtmProjesiContext dbContext = new AtmProjesiContext();
        public Musteri musteri = new Musteri();
        Musteri aliciMusteri = new Musteri();

        public Havale()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            musteri = MusteriAtama();
            aliciMusteri = AliciMusteriAtama();
            ParaGondermeIslemi(musteri.Balance, Convert.ToInt32(txtTutar.Text));
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnGonder.Enabled = GonderOpen();
        }

        private void txtKayitPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTelefonUyari.Visible = TxtBoxIsNumber(e);
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTutarUyari.Visible = TxtBoxIsNumber(e);
        }

        private void txtTutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                btnGonder.PerformClick();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        private void Havale_FormClosing(object sender, FormClosingEventArgs e)
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


        void TxtClear()
        {
            txtKayitPhone.Clear();
            txtTutar.Clear();
        }


        public bool GonderOpen()
        {
            try
            {
                if (txtKayitPhone.Text[0] == '0' && txtKayitPhone.Text[1] == '5' && txtTutar.Text.Length > 0)
                    return true;
                else
                    return false;
            }
            catch { return false; }

        }

        private bool TxtBoxIsNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return true;
            }
            else
                return false;
        }

        Musteri MusteriAtama()
        {
            return dbContext.Musteris.FirstOrDefault(c => c.Phone == GirisYap.SMusteri.Phone);
        }

        Musteri AliciMusteriAtama()
        {
            return dbContext.Musteris.FirstOrDefault(c => c.Phone == txtKayitPhone.Text);
        }

        void ParaGondermeIslemi(int bakiye, int tutar)
        {
            if (bakiye > tutar)
            {
                musteri.Balance -= tutar;
                aliciMusteri.Balance += tutar;
                dbContext.SaveChanges();
                MessageBox.Show($"İşleminiz tamamlanmıştır. Gönderilen tutar: {txtTutar.Text} Kalan bakiye: {musteri.Balance}", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
                TxtClear();
            }
            else
            {
                MessageBox.Show("Lütfen bakiyenizi kontrol edin, para yatırdıktan sonra işlemi tekrar yapmayı deneyin.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTutar.Clear();
            }

        }



        #endregion
    }
}
