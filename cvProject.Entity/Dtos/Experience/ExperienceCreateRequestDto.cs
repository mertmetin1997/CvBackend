using Core.Entities;

namespace cvProject.Entity.Dtos.Experience
{
    public sealed record ExperienceCreateRequestDto(
        
        string Title,
        string Company,
        string Description,
        DateTime StartDate,
        DateTime? EndDate
        ) : ICreateDto;


}
