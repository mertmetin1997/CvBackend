using Core.Business;
using Core.Utilities.Result;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.SocialAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface ISocialAccountService : IGenericService<SocialAccount,SocialAccountResponseDto,SocialAccountCreateRequestDto,SocialAccountUpdateRequestDto,SocialAccountDetailResponseDto>
    {
        Task<IDataResult<SocialAccountResponseDto>> GetSocialAccountByNameAsync(string platform);
        Task<IDataResult<IEnumerable<SocialAccountResponseDto>>> GetSocialAccountByUserNameAsync(string username); 
    }
}
