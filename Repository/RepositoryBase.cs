using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> where T : class
    {
        private readonly BankAccountTypeContext _Context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase()
        {
            _Context = new BankAccountTypeContext();
            _dbSet = _Context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public bool Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Remove(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(T entity)
        {
            try
            {
                var tracker = _Context.Attach(entity);
                tracker.State = EntityState.Modified;
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
