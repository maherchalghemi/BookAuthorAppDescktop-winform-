using DAL.Context;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected BookContext Db = new BookContext();

        public bool Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
                return false;
        }

     



        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

      
       

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
