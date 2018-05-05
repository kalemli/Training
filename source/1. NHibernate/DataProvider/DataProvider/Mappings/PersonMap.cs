using DataProvider.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Mappings
{
    public class PersonMap: BaseClassMap<Person>
    {
        public PersonMap()
        {
            Table("Person");
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Lastname);
        }
    }
}
