using KaloriHesaplamaProjesi.Core.Interfaces;
using KaloriHesaplamaProjesi.DAL;
using KaloriHesaplamaProjesi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.BLL
{

    public class TuketimRepository : IRepository<Tuketim>
    {
        KaloriHesaplamaProjesiContext db = new();
        public void Add(Tuketim item)
        {
            db.Tuketimler.Add(item);
            db.SaveChanges();

        }

        public List<Tuketim> GetAll()
        {
            return db.Tuketimler.ToList();
        }

        public Tuketim GetByID(int ID)
        {
            return db.Tuketimler.Find(ID);
        }

        public void Remove(Tuketim item)
        {
            db.Tuketimler.Remove(item);
            db.SaveChanges();
        }

        public void Update(Tuketim item)
        {
            db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

       
    }
}
