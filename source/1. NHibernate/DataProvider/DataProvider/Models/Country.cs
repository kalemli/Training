﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class Country: BaseModel
    {
        public virtual string Name { get; set; }
        public virtual string State { get; set; }
    }
}
