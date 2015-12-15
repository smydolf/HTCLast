using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> QEntityQueryable { get; }
        T AddEntity(T entity);
        
        T DeleteEntity(T entity);

        IEnumerable<T> GetList();

        IQueryable<T> GetList(Expression<Func<T, bool>> query);

        T GetEntityById(int primarykey);
    }
}
