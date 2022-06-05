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
    public partial class ParaCekme : Form
    {

        public AtmProjesiContext dbContext = new AtmProjesiContext();
        public Musteri musteri = new Musteri();
        public ParaCekme()
        {
            InitializeComponent();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            musteri = MusteriAtama();
            try
            {
                ParaCekmeIslemi(musteri.Balance, Convert.ToInt32(txtBakiye.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen sadece sayı giriniz!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtBakiye.Clear();
        }

        private void txtBakiye_TextChanged(object sender, EventArgs e)
        {
            btnParaCek.Enabled = BtnParaCekOpen();
        }

        private void txtBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblBakiyeUyari.Visible = ITxtBoxIsNumber(e);
        }

        private void txtBakiye_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                btnParaCek.PerformClick();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        private void ParaCekme_FormClosing(object sender, FormClosingEventArgs e)
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

        public bool BtnParaCekOpen()
        {
            if (txtBakiye.Text.Length > 0)
                return true;
            else
                return false;
        }

        Musteri MusteriAtama()
        {
            return dbContext.Musteris.FirstOrDefault(c => c.Phone == GirisYap.SMusteri.Phone);
        }

        void ParaCekmeIslemi(int bakiye, int tutar)
        {
            if (bakiye > tutar)
            {
                if (tutar % 10 != 0)
                    MessageBox.Show("Sadece 10 ve katları tutarlarda çekim yapabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    musteri.Balance = musteri.Balance - tutar;
                    dbContext.SaveChanges();
                    MessageBox.Show($"İşleminiz tamamlanmıştır. Kalan bakiye: {musteri.Balance}", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else
                MessageBox.Show("Lütfen bakiyenizi kontrol edin, para yatırdıktan sonra işlemi tekrar yapmayı deneyin.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}
