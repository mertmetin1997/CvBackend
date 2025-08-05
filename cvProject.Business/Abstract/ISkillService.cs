using Core.Business;
using Core.Utilities.Result;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface ISkillService : IGenericService<Skill,SkillResponseDto,SkillCreateRequestDto,SkillUpdateRequestDto,SkillDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsProgramLanguagesAsync();
        Task<IDataResult<IEnumerable<SkillResponseDto>>> GetWorkflowsAsync();
    }
}
