using Core.Business;
using Core.Utilities.Result;
using cvProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface ISkillService : IGenericService<Skill>
    {
        Task<IDataResult<IEnumerable<Skill>>> GetSkillsProgramLanguagesAsync(bool program);
        Task<IDataResult<IEnumerable<Skill>>> GetSkillsToolsAsync(bool tools);
    }
}
