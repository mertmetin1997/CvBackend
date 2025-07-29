using Core.Business;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.PersonalInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface IPersonalInfoService : IGenericService<PersonalInfo,PersonalInfoResponseDto,PersonalInfoCreateRequestDto,PersonalInfoUpdateRequestDto,PersonalInfoDetailResponseDto>
    {
       
    }
}
