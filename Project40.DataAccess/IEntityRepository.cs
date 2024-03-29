using Project40.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project40.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        void Add(T entity);
        List<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
    }
}
