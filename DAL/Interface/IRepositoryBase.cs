using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        bool Add(TEntity obj);
       
        IEnumerable<TEntity> GetAll();
       
        void Dispose();
    }
}
