using KaloriHesaplamaProjesi.Core.Interfaces;
using KaloriHesaplamaProjesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Entities.Concrete
{
    public class Porsiyon: BaseEntity,IEntity<int>
    {
        public int ID { get; set; }
        public string PorsiyonAd { get; set; }
        public virtual List<BesinPorsiyonu> BesinPorsiyonlari { get; set; }
    }
}
