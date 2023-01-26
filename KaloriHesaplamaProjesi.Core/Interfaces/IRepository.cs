using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriHesaplamaProjesi.Core.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        T GetByID(int ID);
        List<T> GetAll();
    }
}
