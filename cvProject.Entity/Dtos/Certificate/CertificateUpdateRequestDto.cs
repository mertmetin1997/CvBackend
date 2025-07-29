using Core.Entities;

namespace cvProject.Entity.Dtos.Certificate
{
    public sealed record CertificateUpdateRequestDto(
        Guid Id,
        string Title,
        string Organization,
        string Description,
        string Degree,
        DateTime DateAt,
        bool IsActive,
        bool IsDeleted
        ) : IUpdateDto;
}
