using KaloriHesaplamaProjesi.Core.Interfaces;
using KaloriHesaplamaProjesi.DAL;
using KaloriHesaplamaProjesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.BLL
{
    public class BesinRepository : IRepository<Besin>
    {
        KaloriHesaplamaProjesiContext db = new();
        public void Add(Besin item)
        {
            db.Besinler.Add(item);
            db.SaveChanges();
           
        }

        public List<Besin> GetAll()
        {
            return db.Besinler.ToList();
        }

        public Besin GetByID(int ID)
        {
            return db.Besinler.Find(ID);
        }

        public void Remove(Besin item)
        {
            db.Besinler.Remove(item);
            db.SaveChanges();
        }

        public void Update(Besin item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
