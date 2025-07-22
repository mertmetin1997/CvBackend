using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Concrete
{
    public sealed class Skill : BaseEntity
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public bool IsProgramLanguageAndTool { get; set; }
    }
}
