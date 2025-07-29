using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Dtos.Language
{
    public sealed record LanguageResponseDto(
        Guid Id,
        string Name,
        byte Level
        ) : IResponseDto;


}
