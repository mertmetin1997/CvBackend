using Core.Business;
using Core.Utilities.Result;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface IExperienceService : IGenericService<Experience,ExperienceResponseDto,ExperienceCreateRequestDto,ExperienceUpdateRequestDto,ExperienceDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<ExperienceResponseDto>>> GetExpreiencesByCompanyAsync(string company);
    }
}
