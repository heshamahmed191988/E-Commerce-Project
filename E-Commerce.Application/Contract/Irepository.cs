using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contract
{
    public interface IRepository<T,Tid> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(Tid id);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        int save();
    }
}
