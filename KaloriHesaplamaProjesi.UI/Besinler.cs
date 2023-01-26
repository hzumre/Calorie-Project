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
    public partial class Besinler : Form
    {
        KaloriHesaplamaProjesiContext db = new();
        BesinRepository besinlerRepository = new();
        TuketimRepository tr = new();
        public Besinler()
        {
            InitializeComponent();
        }

        Tuketim tuketim = new();
        Kullanici _kullanici=new();
        OgunEkrani _ogunEkrani;
        public Besinler(Kullanici item,Tuketim ogun, OgunEkrani ogunEkrani)
        {
            _ogunEkrani = ogunEkrani;
            tuketim = ogun; 
            _kullanici = item;
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Besinler_Load(object sender, EventArgs e)
        {
            BesinlerTablosu();

            TuketimTablosu();
        }


        
    void BesinlerTablosu()
        {
            dgvBesinler.DataSource = db.BesinPorsiyonlari.Include("Besin").Include("Porsiyon").Select(x => new
            {
                BesinPorsiyonuId=x.ID,
                BesinAd=x.Besin.BesinAd,
                PorsiyonAd=x.Porsiyon.PorsiyonAd,
                Kalori=x.Kalori,
                Yag=x.Yag,
                Protein=x.Protein,
                Karbonhidrat=x.Karbonhidrat
            }).ToList();


            //dgvBesinler.DataSource = db.Besinler.Join(db.BesinPorsiyonlari, b => b.ID, bp => bp.BesinID, (b, bp) => new { b, bp })
            //                                    .Join(db.Porsiyonlar, bpi => bpi.bp.PorsiyonID, p => p.ID, (bpi, p) => new { bpi, p })
            //                                    .Select(m => new
            //                                    {
            //                                        m.bpi.b.BesinAd,
            //                                        m.p.PorsiyonAd,
            //                                        m.bpi.bp.Kalori,
            //                                        m.bpi.bp.Yag,
            //                                        m.bpi.bp.Protein,
            //                                        m.bpi.bp.Karbonhidrat
            //                                    }).ToList();
        }


        void TuketimTablosu()
        {
            dgvTuketim.DataSource = db.Tuketimler.Where(x=>x.TuketimTarihi.Day==DateTime.Now.Day && x.KullaniciID == _kullanici.ID).Select(x => new {x.ID ,x.BesinPorsiyonu.Besin.BesinAd,x.BesinPorsiyonu.Porsiyon.PorsiyonAd,x.Adet }).ToList();
        }


        BesinPorsiyonu secili = null;
        Tuketim seciliTuketim = null;
        int besinPorsiyonId ;
        int tuketimId;
        private void dgvBesinler_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBesinler.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Önce Bir Satır Seçiniz.");
                return;
            }


            DataGridViewRow selectedRow = dgvBesinler.SelectedRows[0];

            secili = db.BesinPorsiyonlari.Find(Convert.ToInt32(selectedRow.Index+1));
            besinPorsiyonId = secili.ID;
                      
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           
            _ogunEkrani.GunlukKaloriHesapla();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tuketim == null)
            {
                MessageBox.Show("Önce Bir Satır Seçiniz.");
                return;
            }

            tuketim.BesinPorsiyonID = besinPorsiyonId;
            tuketim.KullaniciID = _kullanici.ID;
            tuketim.Adet = Convert.ToInt32(numericUpDown1.Value);
            tr.Add(tuketim);
            TuketimTablosu();
        }     

        private void dgvTuketim_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTuketim.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Önce Bir Satır Seçiniz.");
                return;
            }

            DataGridViewRow selectedRow = dgvTuketim.SelectedRows[0];
            int tuketimId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string besinad = selectedRow.Cells[1].Value.ToString();
            string porsiyonad = selectedRow.Cells[2].Value.ToString();
            int adet = Convert.ToInt32(selectedRow.Cells[3].Value);

            seciliTuketim = db.Tuketimler.Include("BesinPorsiyonu").Where(x=>x.BesinPorsiyonu.Besin.BesinAd==besinad && x.BesinPorsiyonu.Porsiyon.PorsiyonAd==porsiyonad && x.ID==tuketimId && x.Adet==adet).FirstOrDefault();
            
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (seciliTuketim == null)
            {
                MessageBox.Show("Önce Bir Satır Seçiniz.");
                return;
            }

            tr.Remove(seciliTuketim);
            TuketimTablosu();
        }

       
    }
}
