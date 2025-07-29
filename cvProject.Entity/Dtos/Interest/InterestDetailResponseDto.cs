using Core.Entities;

namespace cvProject.Entity.Dtos.Interest
{
    public sealed record InterestDetailResponseDto(
        Guid Id,
        string Description,
        byte Order,
        bool IsActive,
        bool IsDeleted
        ) : IDetailDto;


}
