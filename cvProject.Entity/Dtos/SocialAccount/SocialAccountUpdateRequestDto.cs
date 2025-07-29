using Core.Entities;

namespace cvProject.Entity.Dtos.SocialAccount
{
    public sealed record SocialAccountUpdateRequestDto(
        Guid Id,
        string Name,
        string WebUrl,
        string UserName,
        string Icon,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;


}
