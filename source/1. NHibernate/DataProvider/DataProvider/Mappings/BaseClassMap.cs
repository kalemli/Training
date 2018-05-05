using FluentNHibernate.Mapping;
using DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataProvider.Mappings
{
    public class BaseClassMap<T> : ClassMap<T> where T : BaseModel
    {
        public BaseClassMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.LogDate).ReadOnly().Default("GETDATE()");
        }
    }
}