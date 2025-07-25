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
    public interface ISocialAccountService : IGenericService<SocialAccount>
    {
        Task<IDataResult<SocialAccount>> GetSocialAccountByNameAsync();
        Task<IDataResult<IEnumerable<SocialAccount>>> GetSocialAccountByUserNameAsync(); 
    }
}
