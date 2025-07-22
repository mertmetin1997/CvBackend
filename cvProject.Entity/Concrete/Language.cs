﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Concrete
{
    public sealed class Language : BaseEntity
    {
        public string Name { get; set; }
        public byte Level { get; set; }
    }
}
