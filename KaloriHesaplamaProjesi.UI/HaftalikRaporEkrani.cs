using KaloriHesaplamaProjesi.BLL;
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
    public partial class HaftalikRaporEkrani : Form
    {
        public HaftalikRaporEkrani()
        {
            InitializeComponent();
        }

        Kullanici _kulanici = new();
        public HaftalikRaporEkrani(Kullanici item)
        {
            _kulanici = item;
            InitializeComponent();
        }

        KaloriHesaplamaProjesiContext db = new();
        TuketimRepository tr = new();
        
        

        private void HaftalikRaporEkrani_Load(object sender, EventArgs e)
        {

            double toplamKalori = 0;
            double toplamYag = 0;
            double toplamProtein = 0;
            double toplamKarbonhidrat = 0;

            foreach (Tuketim item in tr.GetAll().Where(x => x.TuketimTarihi.Day <= DateTime.Now.Day & x.TuketimTarihi.Day >= DateTime.Now.Day - 7 & x.KullaniciID==_kulanici.ID))
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
                           where tuketim.TuketimTarihi.Day <= DateTime.Now.Day & tuketim.TuketimTarihi.Day >= DateTime.Now.Day - 7 & tuketim.KullaniciID == _kulanici.ID
                           group tuketim by besin.BesinAd into grup //ürünler tablosundaki urunadina  göre grupla
                              select (new
                               {
                                   UrunAdi = grup.Key, //grupladığımız alan adını key ifade eder
                                   ToplamTuketim = grup.Sum(x => x.Adet)
                               });

                dataGridView1.DataSource = favbesin.OrderByDescending(x => x.ToplamTuketim).ToList();
          

            

            toplamKalori = Math.Round(toplamKalori, 2);
            toplamYag = Math.Round(toplamYag, 2);
            toplamKarbonhidrat = Math.Round(toplamKarbonhidrat, 2);
            toplamProtein = Math.Round(toplamProtein, 2);
            lblKalori.Text = $"{toplamKalori} kcal";
            lblKarbonhidrat.Text = $"{toplamKarbonhidrat} kcal";
            lblYag.Text = $"{toplamYag} kcal";
            lblProtein.Text = $"{toplamProtein} kcal"; 
        }
    }
}
