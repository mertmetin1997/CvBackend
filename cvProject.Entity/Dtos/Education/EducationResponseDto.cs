using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Dtos.Education
{
    public sealed record EducationResponseDto(
        Guid Id,
        string School,
        string Deprtment,
        string Grade,
        decimal GPA,
        string Section,
        DateTime StartDate,
        DateTime? EndDate
        ) : IResponseDto;

}
