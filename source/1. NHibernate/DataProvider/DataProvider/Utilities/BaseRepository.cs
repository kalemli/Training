using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataProvider.Utilities
{
    public class BaseRepository<T> where T : class
    {
        public IList<T> FindAll()
        {
            ISession session = DbSessionProvider.CurrentSession;
            IList<T> list = session.QueryOver<T>().List();
            return list;
        }

        public IList<T> Find(Expression<Func<T, bool>> expression)
        {
            ISession session = DbSessionProvider.CurrentSession;
            var list = session.QueryOver<T>().Where(expression).List();
            return list;
        }

        public IQueryOver<T, T> CreateCriteria(Expression<Func<T, bool>> expression)
        {
            ISession session = DbSessionProvider.CurrentSession;
            return session.QueryOver<T>().Where(expression);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            ISession session = DbSessionProvider.CurrentSession;
            IList<T> list = session.QueryOver<T>().Where(expression).List();
            return list.Count > 0 ? list[0] : null;
        }

        public void Save(T entity)
        {
            ISession session = DbSessionProvider.CurrentSession;
            session.SaveOrUpdate(entity);
            session.Flush();
        }

        public void Delete(T entity)
        {
            ISession session = DbSessionProvider.CurrentSession;
            session.Delete(entity);
            session.Flush();
        }
    }
}