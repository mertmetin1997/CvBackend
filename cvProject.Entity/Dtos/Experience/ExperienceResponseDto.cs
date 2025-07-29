using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Dtos.Experience
{
    public sealed record ExperienceResponseDto(
        Guid Id,
        string Title,
        string Company,
        string Description,
        DateTime StartDate,
        DateTime? EndDate
        ) : IResponseDto;


}
