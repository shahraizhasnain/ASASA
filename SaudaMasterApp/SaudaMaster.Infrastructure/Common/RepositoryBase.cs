using SaudaMaster.Data;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SaudaMaster.Infrastructure.Common
{
    public abstract class RepositoryBase<T> where T : class
    {
        //declaring a new variable of datatype database 

        private saudadbEntities dataContext;
        
        //n IDbSet<TEntity> represents the collection
        //of all entities in the context, or that can 
        //be queried from the database, of a given type. 
        //DbSet<TEntity> is a concrete implementation of IDbSet.

        private readonly IDbSet<T> dbset;

        //getting data from databse
        protected saudadbEntities DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }


        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        public virtual void Add(T entity)
        {
            dbset.Add(entity); //msdn.microsoft.com/en-us/library/gg679233(v=vs.113).aspx
        }

        public virtual void Update(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T,bool>>where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }

        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }

        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T,bool>> where)
        {
            return dbset.Where(where).ToList();
        }

        public T Get(Expression<Func<T,bool>> where)
        {
            return dbset.Where(where).FirstOrDefault();
        }


        
    }
}
