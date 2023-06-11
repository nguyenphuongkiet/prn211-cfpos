using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class RepositoryBase<T> where T : class
    {
        POSContext posContext;
        DbSet<T> _dbSet;

        public RepositoryBase()
        {
            posContext = new POSContext();
            _dbSet = posContext.Set<T>();
        }

        public List<T> getAll()
        {
            return _dbSet.ToList();
        }

        public void create(T entity)
        {
            _dbSet.Add(entity);
            posContext.SaveChanges();
        }

        public void update(T entity)
        {
            var tracker = posContext.Attach(entity);
            tracker.State = EntityState.Modified;
            posContext.SaveChanges();
        }

        public bool delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                posContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
