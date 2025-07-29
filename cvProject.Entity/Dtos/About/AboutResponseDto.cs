using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Dtos.About
{
    public sealed record AboutResponseDto(
        Guid Id,
        string Description,
        byte Order
        ) :IResponseDto ;
}
