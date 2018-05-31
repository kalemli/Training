using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class PersonDetail: BaseModel
    {
        public virtual Person Person { get; set; }
        public virtual string Phone1 { get; set; }
        public virtual string Phone2 { get; set; }
        public virtual string Email { get; set; }
        public virtual string Web { get; set; }
    }
}
