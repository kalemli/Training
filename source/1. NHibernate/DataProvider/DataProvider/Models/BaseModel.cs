using DataProvider.Utilities;
using System;

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
    }
}