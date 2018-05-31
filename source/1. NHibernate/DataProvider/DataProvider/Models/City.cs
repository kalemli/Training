﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class City: BaseModel
    {
        public virtual Country Country { get; set; }
        public virtual string Name { get; set; }
    }
}
