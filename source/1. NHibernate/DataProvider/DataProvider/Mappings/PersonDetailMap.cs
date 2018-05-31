using DataProvider.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Mappings
{
    public class PersonDetailMap: BaseClassMap<PersonDetail>
    {
        public PersonDetailMap()
        {
            Table("PersonDetail");
            References(x => x.Person, "PersonId").Unique();
            Map(x => x.Phone1);
            Map(x => x.Phone2);
            Map(x => x.Email);
            Map(x => x.Web);
        }
    }
}
