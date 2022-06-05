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
    public partial class Home : Form
    {
        public AtmProjesiContext dbContext = new AtmProjesiContext();
        public Musteri musteri = new Musteri();
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            musteri = MusteriAtama();
            lblBakiye.Text = musteri.Balance.ToString();
        }

        private void HizliCekim_Click(object sender, EventArgs e)
        {
            musteri = MusteriAtama();
            Button tutarButton = (Button)sender;
            CekimIslemi(musteri.Balance, Convert.ToInt32(tutarButton.Text));
            lblBakiye.Text = musteri.Balance.ToString();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            BilgiGuncelle bilgiGuncelle = new BilgiGuncelle();
            bilgiGuncelle.Show();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParaCekme paraCekme = new ParaCekme();
            paraCekme.Show();
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParaYatir paraYatir = new ParaYatir();
            paraYatir.Show();

        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Havale havale = new Havale();
            havale.Show();
        }


        private void btnFatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaturaOde faturaOde = new FaturaOde();
            faturaOde.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cik = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(cik == DialogResult.Yes)
                Environment.Exit(0);
            else
            {
                e.Cancel = true;
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }

        #region Metotlar
        Musteri MusteriAtama()
        {
            return dbContext.Musteris.FirstOrDefault(c => c.Phone == GirisYap.SMusteri.Phone);
        }

        void CekimIslemi(int bakiye, int tutar)
        {
            if (bakiye > tutar)
            {
                musteri.Balance = musteri.Balance - tutar;
                dbContext.SaveChanges();
                MessageBox.Show($"İşleminiz tamamlanmıştır. Kalan bakiye: {musteri.Balance}", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
                MessageBox.Show("Lütfen bakiyenizi kontrol edin. Para yatırdıktan sonra işlemi tekrar yapmayı deneyin.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
