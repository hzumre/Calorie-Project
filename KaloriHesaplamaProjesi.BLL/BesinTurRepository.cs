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
    public class BesinTurRepository : IRepository<BesinTur>
    {
        KaloriHesaplamaProjesiContext db = new();
        public void Add(BesinTur item)
        {
            db.BesinTurleri.Add(item);
            db.SaveChanges();

        }

        public List<BesinTur> GetAll()
        {
            return db.BesinTurleri.ToList();
        }

        public BesinTur GetByID(int ID)
        {
            return db.BesinTurleri.Find(ID);
        }

        public void Remove(BesinTur item)
        {
            db.BesinTurleri.Remove(item);
            db.SaveChanges();
        }

        public void Update(BesinTur item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

        }
    }
}
