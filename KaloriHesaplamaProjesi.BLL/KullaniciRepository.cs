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
    public class KullaniciRepository : IRepository<Kullanici>
    {
        KaloriHesaplamaProjesiContext db = new();
        public void Add(Kullanici item)
        {
            db.Kullanicilar.Add(item);
            db.SaveChanges();
        }

        public List<Kullanici> GetAll()
        {
            return db.Kullanicilar.ToList();
        }

        public Kullanici GetByID(int ID)
        {
            return db.Kullanicilar.Find(ID);
        }

        public void Remove(Kullanici item)
        {
            db.Kullanicilar.Remove(item);
            db.SaveChanges();
        }

        public void Update(Kullanici item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
