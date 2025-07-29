using Core.Entities;

namespace cvProject.Entity.Dtos.Education
{
    public sealed record EducationUpdateRequestDto(
        Guid Id,
        string School,
        string Deprtment,
        string Grade,
        decimal GPA,
        string Section,
        DateTime StartDate,
        DateTime? EndDate,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;

}
