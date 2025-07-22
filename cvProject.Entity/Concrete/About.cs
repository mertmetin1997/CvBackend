﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Concrete
{
    public sealed class About : BaseEntity
    {
        public string Description { get; set; }
        public byte Order { get; set; }
    }
}   
