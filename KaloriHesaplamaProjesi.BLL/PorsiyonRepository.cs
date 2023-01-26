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
    public class PorsiyonRepository : IRepository<Porsiyon>
    {
        KaloriHesaplamaProjesiContext db = new();
        public void Add(Porsiyon item)
        {
            db.Porsiyonlar.Add(item);
            db.SaveChanges();
        }

        public List<Porsiyon> GetAll()
        {
            return db.Porsiyonlar.ToList();
        }

        public Porsiyon GetByID(int ID)
        {
            return db.Porsiyonlar.Find(ID);
        }

        public void Remove(Porsiyon item)
        {
            db.Porsiyonlar.Remove(item);
            db.SaveChanges();
        }

        public void Update(Porsiyon item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
