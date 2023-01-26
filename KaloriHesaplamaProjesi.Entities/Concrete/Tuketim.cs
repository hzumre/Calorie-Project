using KaloriHesaplamaProjesi.Core.Interfaces;
using KaloriHesaplamaProjesi.Entities.Abstract;
using KaloriHesaplamaProjesi.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Entities.Concrete
{
    public class Tuketim: BaseEntity,IEntity<int>
    {
        public Tuketim()
        {
            _tuketimTarihi = DateTime.Now;
        }
        public int ID { get; set; }
        public int KullaniciID { get; set; }

        private DateTime _tuketimTarihi;
        public DateTime TuketimTarihi { get { return _tuketimTarihi ; } set { _tuketimTarihi=value; } }
        public int Adet { get; set; }
        public int BesinPorsiyonID { get; set; }
        public Kullanici Kullanici { get; set; }
        public BesinPorsiyonu BesinPorsiyonu { get; set; }
        public Ogun Ogun { get; set; }

    }
}
