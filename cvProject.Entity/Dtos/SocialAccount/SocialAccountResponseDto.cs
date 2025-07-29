using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Dtos.SocialAccount
{
    public sealed record SocialAccountResponseDto(
        Guid Id,
        string Name,
        string WebUrl,
        string UserName,
        string Icon
        ) : IResponseDto;


}
