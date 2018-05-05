using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class Employee: BaseModel
    {
        public virtual Person Person { get; set; }
        public virtual decimal Salary { get; set; }
    }
}
