using Core.Entities;

namespace cvProject.Entity.Dtos.Education
{
    public sealed record EducationCreateRequestDto(
        string School,
        string Department,
        string Grade,
        decimal GPA,
        string Section,
        DateTime StartDate,
        DateTime? EndDate
        ) : ICreateDto;

}
