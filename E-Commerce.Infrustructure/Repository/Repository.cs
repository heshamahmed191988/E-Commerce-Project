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
            var entry = _Entity.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Detached;
            }
            return _Entity.Add(entity).Entity;
        }

        public void Delete(T entity)
        {
            var entry = _Entity.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Detached;
            }
            _Entity.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {

            return _Entity.AsNoTracking();
        }

        public T GetByID(Tid id)
        {
            var entity = _Entity.Find(id);

            if (entity != null)
            {
                _Entity.Entry(entity).State = EntityState.Detached;
            }

            return entity;
        }
    

        public T Update(T entity)
        {
            var entry = _Entity.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Detached;
                
            }
            return _Entity.Update(entity).Entity;
        }
        public int save()
        {

            try
            {
                int result = _context.SaveChanges();

                // Detach all entities from the context
                foreach (var entry in _context.ChangeTracker.Entries())
                {
                    entry.State = EntityState.Detached;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    } 
}
