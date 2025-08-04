using Core.Entities;

namespace cvProject.Entity.Dtos.Certificate
{
    public sealed record CertificateCreateRequestDto(
        
        string Title,
        string Organisation,
        string Description,
        string Degree,
        DateTime DateAt
        ) : ICreateDto;
}
