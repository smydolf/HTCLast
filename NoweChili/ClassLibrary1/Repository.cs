using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ClassLibrary1.Interface;

namespace ClassLibrary1
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public HtcAplicationContext Context { get; set; }
        protected DbSet DbSet { get; set; }

        protected Repository(HtcAplicationContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public IEnumerable<T> QEntityQueryable
        {
            get { return Context.Set<T>(); }
        }

        public T AddEntity(T entity)
        {
            return DbSet.Add(entity) as T;

        }
      
        public T DeleteEntity(T entity)
        {

            return (T)DbSet.Remove(entity);
        }
        public IEnumerable<T> GetList()
        {
            IEnumerable<T> query = Context.Set<T>();
            return query;
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>> query)
        {
            throw new NotImplementedException();//TODO
        }

        public T GetEntityById(int primaryKey)
        {
            return (T)DbSet.Find(primaryKey);
        }

        public void SaveChange()
        {
            Context.SaveChanges();
        }
    }
}
