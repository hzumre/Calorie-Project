using KaloriHesaplamaProjesi.Core.Interfaces;
using KaloriHesaplamaProjesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Entities.Concrete
{
    public class Besin :BaseEntity,IEntity<int>
    {
        public int ID { get; set; }
        public string BesinAd { get; set; }
        
        public int BesinTurID { get; set; }
        public BesinTur BesinTur { get; set; }
        
        public virtual List<BesinPorsiyonu> BesinPorsiyonlari { get; set; }



    }
}
