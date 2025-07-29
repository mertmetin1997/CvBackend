using Core.Entities;

namespace cvProject.Entity.Dtos.About
{
    public sealed record AboutDetailResponseDto(
        Guid Id,
        string Description,
        byte Order,
        bool IsActive,
        bool IsDeleted  
        ) : IDetailDto;
}
