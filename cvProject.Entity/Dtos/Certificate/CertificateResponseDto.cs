using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Entity.Dtos.Certificate
{
    public sealed record CertificateResponseDto(
        Guid Id,
        string Title,
        string Organization,
        string Description,
        string Degree,
        DateTime DateAt
        ) : IResponseDto;
}
