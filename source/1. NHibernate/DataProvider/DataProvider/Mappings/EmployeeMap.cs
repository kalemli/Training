using DataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Mappings
{
    public class EmployeeMap: BaseClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("Employee");
            References(x => x.Person).Cascade.All();
            Map(x => x.Salary);
        }
    }
}
