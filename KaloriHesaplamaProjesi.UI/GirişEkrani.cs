using KaloriHesaplamaProjesi.BLL;
using KaloriHesaplamaProjesi.DAL;
using KaloriHesaplamaProjesi.Entities.Concrete;

namespace KaloriHesaplamaProjesi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        KullaniciRepository kullaniciRepository = new();
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool validUser = false;

            foreach(Kullanici item in kullaniciRepository.GetAll() )
            {
                if (txtKullaniciAdi.Text == item.Mail && txtSifre.Text == item.Sifre)
                {
                    
                    OgunEkrani ogunEkrani = new(item);
                    ogunEkrani.ShowDialog();                    
                    validUser = true;
                    this.Close();
                    break;
                }
            }

            if (validUser == false)
            {
                MessageBox.Show("Kullan�c� Ad�n�z� veya �ifrenizi Yanl�� Girdiniz.L�tfen tekrar giriniz... ");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitEkrani kayitEkrani = new();
            kayitEkrani.ShowDialog();
        }
    }
}