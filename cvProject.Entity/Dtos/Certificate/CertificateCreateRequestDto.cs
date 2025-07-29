using Core.Entities;

namespace cvProject.Entity.Dtos.Certificate
{
    public sealed record CertificateCreateRequestDto(
        
        string Title,
        string Organization,
        string Description,
        string Degree,
        DateTime DateAt
        ) : ICreateDto;
}
