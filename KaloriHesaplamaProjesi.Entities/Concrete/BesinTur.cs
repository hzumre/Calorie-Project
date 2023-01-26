using KaloriHesaplamaProjesi.Core.Interfaces;
using KaloriHesaplamaProjesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Entities.Concrete
{
    public class BesinTur: BaseEntity,IEntity<int>
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        public virtual List<Besin> Besinler { get; set; }
    }
}
