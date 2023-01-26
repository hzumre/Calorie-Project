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
    public partial class GunlukRaporEkrani : Form
    {
        public GunlukRaporEkrani()
        {
            InitializeComponent();
        }

        KaloriHesaplamaProjesiContext db = new();
        TuketimRepository tr = new();
        Kullanici _kullanici=new();

        public GunlukRaporEkrani(Kullanici item)
        {
            _kullanici = item;
            InitializeComponent();
        }
        

        double gerekliKalori;
        private void GunlukRaporEkrani_Load(object sender, EventArgs e)
        {

            if (_kullanici.Cinsiyet==Cinsiyet.Erkek)
            {
                gerekliKalori = 66.5 + (13.75 * _kullanici.Kilo) + (5 * _kullanici.Boy) - (6.77 * _kullanici.Yas);
                gerekliKalori = Math.Round(gerekliKalori, 2);
                lblGerekliKalori.Text = $"{gerekliKalori} kcal";
            }
           else if(_kullanici.Cinsiyet == Cinsiyet.Kadin)
            {
                gerekliKalori = 655 + (9.56 * _kullanici.Kilo) + (1.85 * _kullanici.Boy) - (4.67 * _kullanici.Yas);
                gerekliKalori = Math.Round(gerekliKalori, 2);
                lblGerekliKalori.Text = $"{gerekliKalori} kcal" ;
            }


            double toplamKalori = 0;
            double toplamYag = 0;
            double toplamProtein = 0;
            double toplamKarbonhidrat = 0;
            foreach (Tuketim item in tr.GetAll().Where(x=>x.TuketimTarihi.Day==DateTime.Now.Day && x.KullaniciID == _kullanici.ID))
            {

                BesinPorsiyonu besinPorsiyonu = db.BesinPorsiyonlari.Where(x => x.ID == item.BesinPorsiyonID).First();

                toplamKalori += item.Adet * besinPorsiyonu.Kalori;
                toplamYag += besinPorsiyonu.Yag * item.Adet;
                toplamProtein += besinPorsiyonu.Protein * item.Adet;
                toplamKarbonhidrat += besinPorsiyonu.Karbonhidrat * item.Adet;
            }


            toplamKalori = Math.Round(toplamKalori, 2);
            toplamYag = Math.Round(toplamYag, 2);
            toplamKarbonhidrat = Math.Round(toplamKarbonhidrat, 2);
            toplamProtein = Math.Round(toplamProtein, 2);
            lblToplamKalori.Text = $"{toplamKalori} kcal";
            lblKarbonhidrat.Text = $"{toplamKarbonhidrat} kcal";
            lblYag.Text = $"{toplamYag} kcal";
            lblProtein.Text = $"{toplamProtein} kcal"; ;




            pbKalori.Maximum= Convert.ToInt32(gerekliKalori);
            pbKalori.Value = Convert.ToInt32(toplamKalori);

            if(pbKalori.Value>pbKalori.Maximum)
            {
                MessageBox.Show("Günlük almanız gereken kalori miktarını aştınız!!!");
            }


        }
    }
}
