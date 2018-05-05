using DataProvider.Utilities;
using System;
using System.Linq.Expressions;

namespace DataProvider.Models
{
    public class BaseModel
    {
        public virtual int? Id { get; set; }
        public virtual DateTime LogDate { get; set; }

        public virtual void Save()
        {
            var repos = new BaseRepository<BaseModel>();
            repos.Save(this);
        }

        public virtual void Delete()
        {
            var repos = new BaseRepository<BaseModel>();
            repos.Delete(this);
        }

        public static BaseModel Get(Expression<Func<BaseModel, bool>> expression)
        {
            var repos = new BaseRepository<BaseModel>();
            var model = repos.Get(expression);
            return model;
        }
    }
}