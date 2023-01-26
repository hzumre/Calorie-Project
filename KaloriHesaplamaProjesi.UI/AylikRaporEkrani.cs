using KaloriHesaplamaProjesi.BLL;
using KaloriHesaplamaProjesi.DAL;
using KaloriHesaplamaProjesi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
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
    public partial class AylikRaporEkrani : Form
    {
        public AylikRaporEkrani()
        {
            InitializeComponent();
        }

        Kullanici _kullanici = new();
        public AylikRaporEkrani(Kullanici item)
        {
            _kullanici = item;
            InitializeComponent();
        }
        KaloriHesaplamaProjesiContext db = new();
        TuketimRepository tr = new();

        private void AylikRaporEkrani_Load(object sender, EventArgs e)
        {
            int toplamAdet = 0;
            double toplamKalori = 0;
            double toplamYag = 0;
            double toplamProtein = 0;
            double toplamKarbonhidrat = 0;


            foreach (Tuketim item in tr.GetAll().Where(x => x.TuketimTarihi.Month == DateTime.Now.Month && x.KullaniciID == _kullanici.ID))
            {

                BesinPorsiyonu besinPorsiyonu = db.BesinPorsiyonlari.Where(x => x.ID == item.BesinPorsiyonID).First();

                toplamKalori += item.Adet * besinPorsiyonu.Kalori;
                toplamYag += besinPorsiyonu.Yag * item.Adet;
                toplamProtein += besinPorsiyonu.Protein * item.Adet;
                toplamKarbonhidrat += besinPorsiyonu.Karbonhidrat * item.Adet;
               
            }
        
           
                var favbesin = from besinporsiyonu in db.BesinPorsiyonlari
                               join tuketim in db.Tuketimler on besinporsiyonu.ID equals tuketim.BesinPorsiyonID
                               join besin in db.Besinler on besinporsiyonu.BesinID equals besin.ID
                               where tuketim.TuketimTarihi.Month== DateTime.Now.Month & tuketim.KullaniciID== _kullanici.ID
                               group tuketim by besin.BesinAd into grup //ürünler tablosundaki urunadina  göre grupla
                               select (new
                               {
                                   UrunAdi = grup.Key, //grupladığımız alan adını key ifade eder
                                   ToplamTuketim = grup.Sum(x => x.Adet)
                               });

                dataGridView1.DataSource = favbesin.OrderByDescending(x=>x.ToplamTuketim).ToList();
                  



            toplamKalori = Math.Round(toplamKalori, 2);
            toplamYag = Math.Round(toplamYag, 2);
            toplamKarbonhidrat = Math.Round(toplamKarbonhidrat, 2);
            toplamProtein = Math.Round(toplamProtein, 2);
            lblToplamKalori.Text = $"{toplamKalori} kcal";
            lblKarbonhidrat.Text = $"{toplamKarbonhidrat} kcal";
            lblYag.Text = $"{toplamYag} kcal";
            lblProtein.Text = $"{toplamProtein} kcal";

            
        }
    }
}
