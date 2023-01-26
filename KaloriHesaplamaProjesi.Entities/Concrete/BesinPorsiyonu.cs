using KaloriHesaplamaProjesi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Entities.Concrete
{
    public class BesinPorsiyonu: BaseEntity
    {
        public int ID { get; set; }
        public int BesinID { get; set; }
        public int PorsiyonID { get; set; }
        public double Kalori { get; set; }
        public double Karbonhidrat { get; set; }
        public double Yag { get; set; }
        public double Protein { get; set; }

        public virtual Besin Besin { get; set; }
        public virtual Porsiyon Porsiyon { get; set; }

        public virtual List<Tuketim> Tuketimler { get; set; }

    }
}
