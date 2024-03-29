using Project20.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20.DataAccess
{
    internal interface IEntityRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
    }
}
