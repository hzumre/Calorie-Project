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
    public partial class OgunEkrani : Form
    {
        public OgunEkrani()
        {
            InitializeComponent();
        }

        KaloriHesaplamaProjesiContext db = new();
        TuketimRepository tr = new();
        Tuketim tuketim = new();
        Kullanici _kullanici = new();
        public OgunEkrani(Kullanici item)
        {        
            _kullanici = item;
            InitializeComponent();
        }

        private void pcbKahvalti_Click(object sender, EventArgs e)
        {
            tuketim.Ogun = Ogun.Kahvalti;
            BesinlereGit();
        }

        private void pcbOgle_Click(object sender, EventArgs e)
        {
            tuketim.Ogun = Ogun.Ogle;
            BesinlereGit();
        }

        private void pcbAksam_Click(object sender, EventArgs e)
        {
            tuketim.Ogun = Ogun.Aksam;
            BesinlereGit();
        }

        private void pcbAtistirmalik_Click(object sender, EventArgs e)
        {
            tuketim.Ogun = Ogun.AraOgun;
            BesinlereGit();
        }

        void BesinlereGit()
        {
            Besinler besinler = new(_kullanici,tuketim,this);
            besinler.ShowDialog();
        }

        private void OgunEkrani_Load(object sender, EventArgs e)
        {

            GunlukKaloriHesapla();

        }
        
        private void btnGunluk_Click(object sender, EventArgs e)
        {
            
        }

        public void GunlukKaloriHesapla()
        {
            double toplamKaloriKahvaltı = 0;
            double toplamKaloriOgle = 0;
            double toplamKaloriAksam = 0;
            double toplamKaloriAraogun = 0;

            foreach (Tuketim item in tr.GetAll().Where(x=>x.KullaniciID==_kullanici.ID))
            {

                BesinPorsiyonu besinPorsiyonu = db.BesinPorsiyonlari.Where(x => x.ID == item.BesinPorsiyonID).First();

                if (item.Ogun == Ogun.Kahvalti && item.TuketimTarihi.Day == DateTime.Now.Day)
                {
                    toplamKaloriKahvaltı += item.Adet * besinPorsiyonu.Kalori;
                    toplamKaloriKahvaltı = Math.Round(toplamKaloriKahvaltı, 2);
                    lblKahvalti.Text = $"{toplamKaloriKahvaltı} kcal";
                }

                else if (item.Ogun == Ogun.Ogle && item.TuketimTarihi.Day == DateTime.Now.Day)
                {
                    toplamKaloriOgle += item.Adet * besinPorsiyonu.Kalori;
                    toplamKaloriOgle = Math.Round(toplamKaloriOgle, 2);
                    lblOgle.Text = $"{toplamKaloriOgle} kcal";
                }
                else if (item.Ogun == Ogun.Aksam && item.TuketimTarihi.Day == DateTime.Now.Day)
                {
                    toplamKaloriAksam += item.Adet * besinPorsiyonu.Kalori;
                    toplamKaloriAksam = Math.Round(toplamKaloriAksam, 2);
                    lblAksam.Text = $"{toplamKaloriAksam} kcal";
                }
                else if (item.Ogun == Ogun.AraOgun && item.TuketimTarihi.Day == DateTime.Now.Day)
                {
                    toplamKaloriAraogun += item.Adet * besinPorsiyonu.Kalori;
                    toplamKaloriAraogun = Math.Round(toplamKaloriAraogun, 2);
                    lblAtistirmalik.Text = $"{toplamKaloriAraogun} kcal";
                }
            }
        }

        private void btnGunluk_Click_1(object sender, EventArgs e)
        {
            GunlukRaporEkrani raporEkrani = new(_kullanici);
            raporEkrani.ShowDialog();
        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            HaftalikRaporEkrani raporEkrani = new(_kullanici);
            raporEkrani.ShowDialog();
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            AylikRaporEkrani raporEkrani = new(_kullanici);
            raporEkrani.ShowDialog();
        }


    }

        
 }
