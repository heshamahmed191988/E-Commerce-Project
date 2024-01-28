using E_Commerce.Application.Contract;
using E_Commerce.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrustructure.Repository
{
    public class Repository<T, Tid> : Irepository<T, Tid> where T : class
    {
        E_CommerceContext _context;
        DbSet<T> _Entity;
        public Repository(E_CommerceContext context)
        {
            _context = context;
            _Entity = _context.Set<T>();
        }
        public T Add(T entity)
        {
            return _Entity.Add(entity).Entity;
        }

        public void Delete(T entity)
        {
            _Entity.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {

            return _Entity.AsNoTracking(); 
        }

        public T GetByID(Tid id)
        {
            return _Entity.Find(id);
           
        }

        public T Update(T entity)
        {
            return _Entity.Update(entity).Entity;
        }
        public int save()
        {

            return _context.SaveChanges();
        }
    } 
}
