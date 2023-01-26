using KaloriHesaplamaProjesi.BLL;
using KaloriHesaplamaProjesi.Core.Enum;
using KaloriHesaplamaProjesi.DAL;
using KaloriHesaplamaProjesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriHesaplamaProjesi.UI
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }
       
        KullaniciRepository kullaniciRepository = new();
        private void btnKayıtOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                kullaniciRepository.Add(KullaniciOlustur());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public Kullanici KullaniciOlustur()
        {
            Kullanici yeniKullanici = new();

            if(txtAd.Text==null)
            {
                throw new Exception("Lütfen adınızı giriniz!");
            }
            else
            {
                yeniKullanici.AdSoyad = txtAd.Text;
            }
            


            foreach (Kullanici item in kullaniciRepository.GetAll())
            {
                if (item.Mail == txtMail.Text)
                {
                    throw new Exception("Bu mail kullanılmıştır.Lütfen başka bir mail ile giriş yapmayı deneyiniz.");
                }
                
                else
                {
                    yeniKullanici.Mail = txtMail.Text;
                }

            }

            bool harfMi = false;
            bool sayiMi = false;
            const string _rakamlar = "0123456789";

            for (int i = 0; i < txtSifre.Text.Length; i++)
            {
                if (_rakamlar.Contains(txtSifre.Text[i]))
                {
                    sayiMi = true;
                }
                else if (char.IsLetter(txtSifre.Text[i]))
                {
                    harfMi = true;
                }
            }

            if (txtSifre.Text.Length > 8 && harfMi && sayiMi)
            {
                yeniKullanici.Sifre = txtSifre.Text;
            }             
            else
            {
                throw new Exception("Lütfen şifrenizin uzunluğu sekiz karakterden büyük,içinde harf ve sayı olsun.");
            }



            if (txtYas.Text == null)
            {
                throw new Exception("Lütfen yaşınızı giriniz!");
            }
            else
            {
                yeniKullanici.Yas = Convert.ToInt32(txtYas.Text);
            }


            if (txtKilo.Text == null)
            {
                throw new Exception("Lütfen kilonuzu giriniz!");
            }
            else
            {
                yeniKullanici.Kilo = Convert.ToInt32(txtKilo.Text);
            }

            if (txtBoy.Text == null)
            {
                throw new Exception("Lütfen boyunuzu giriniz!");
            }
            else
            {
                yeniKullanici.Boy = Convert.ToInt32(txtBoy.Text);
            }

            if (rdbErkek == null && rdbKadin == null)
            {
                throw new Exception("Lütfen cinsiyetinizi giriniz!");
            }
            else
            {
                yeniKullanici.Cinsiyet = rdbErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadin;
            }

            
            return yeniKullanici;
        }



    }
}
