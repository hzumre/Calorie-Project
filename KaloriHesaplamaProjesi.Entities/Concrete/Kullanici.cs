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
    public class Kullanici:BaseEntity,IEntity<int>
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public int Yas { get; set; }
        public int Kilo { get; set; }
        public int Boy { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public virtual List<Tuketim> Tuketimler { get; set; }

       
    }
}
