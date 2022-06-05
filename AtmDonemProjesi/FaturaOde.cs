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
    public partial class FaturaOde : Form
    {
        int faturaTutari;
        string tarih;
        int kurumIndex = -2;
        List<int> odenmisFatura = new List<int>();
        public FaturaOde()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnFaturaOde_Click(object sender, EventArgs e)
        {
            musteri = MusteriAtama();
            FaturaOdeme(musteri.Balance, faturaTutari);
        }

        private void cBoxKurum_SelectedValueChanged(object sender, EventArgs e)
        {
            int temp = cBoxKurum.SelectedIndex;
            if (temp == kurumIndex)
                return;
            kurumIndex = cBoxKurum.SelectedIndex;
            FaturaOlustur();
        }

        private void FaturaOde_FormClosing(object sender, FormClosingEventArgs e)
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
        void FaturaOlustur()
        {
            if (odenmisFatura.IndexOf(kurumIndex) == -1)
            {
                btnFaturaOde.Enabled = true;
                Random r = new Random();
                tarih = $"{r.Next(1, Convert.ToInt32(DateTime.Now.ToString("dd")))}" + $"/{DateTime.Now.ToString("MM")}";
                if (kurumIndex == 1)
                    faturaTutari = r.Next(50, 80);
                else if (kurumIndex > 3)
                    faturaTutari = r.Next(50, 150);
                else if (kurumIndex == 0)
                    faturaTutari = r.Next(220, 350);
                else if (kurumIndex < 3)
                    faturaTutari = r.Next(80, 150);

                lblFaturaBilgi.Text = $"{tarih} tarihli {faturaTutari} TL tutarında faturanız bulunmuştur.";
            }
            else
            {
                lblFaturaBilgi.Text = "Ödenmemiş faturanız bulunmamaktadır.";
                btnFaturaOde.Enabled = false;
            }
        }

        void FaturaOdeme(int bakiye, int tutar)
        {
            if (bakiye > faturaTutari)
            {
                musteri.Balance = musteri.Balance - faturaTutari;
                dbContext.SaveChanges();
                odenmisFatura.Add(kurumIndex);
                btnFaturaOde.Enabled = false;
                MessageBox.Show($"İşleminiz tamamlanmıştır. Kalan bakiye: {musteri.Balance}", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
                lblFaturaBilgi.Text = "Faturanız başarıyle ödendi.";
            }
            else
                MessageBox.Show("Lütfen bakiyenizi kontrol edin, para yatırdıktan sonra işlemi tekrar yapmayı deneyin.", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Musteri MusteriAtama()
        {
            return dbContext.Musteris.FirstOrDefault(c => c.Phone == GirisYap.SMusteri.Phone);
        }

        public AtmProjesiContext dbContext = new AtmProjesiContext();
        public Musteri musteri = new Musteri();
        #endregion
    }
}
