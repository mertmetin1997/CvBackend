using Core.Entities;

namespace cvProject.Entity.Dtos.Certificate
{
    public sealed record CertificateDetailResponseDto(
        Guid Id,
        string Title,
        string Organisation,
        string Description,
        string Degree,
        DateTime DateAt,
        bool IsActive,
        bool IsDeleted
        ) : IDetailDto;
}
