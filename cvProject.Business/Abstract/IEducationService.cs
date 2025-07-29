using Core.Business;
using Core.Utilities.Result;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface IEducationService : IGenericService<Education,EducationResponseDto,EducationCreateRequestDto,EducationUpdateRequestDto,EducationDetailResponseDto>
    {
        Task<IDataResult<EducationResponseDto>> GetEducationAsync(string grade);
        Task<IResult> AnyContinueAsync();
    }
}
