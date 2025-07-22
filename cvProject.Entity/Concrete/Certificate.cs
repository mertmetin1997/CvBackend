﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Concrete
{
    public sealed class Certificate : BaseEntity
    {
        public string Title { get; set; }
        public DateTime DateAt { get; set; }
        public string Degree { get; set; }
        public string Organisation { get; set; }
        public string Description { get; set; }
    }
}
