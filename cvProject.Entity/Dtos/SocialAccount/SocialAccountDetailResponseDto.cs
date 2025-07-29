using Core.Entities;

namespace cvProject.Entity.Dtos.SocialAccount
{
    public sealed record SocialAccountDetailResponseDto(
        Guid Id,
        string Name,
        string WebUrl,
        string UserName,
        string Icon,
        bool IsActive,
        bool IsDeleted
        ) : IDetailDto;


}
