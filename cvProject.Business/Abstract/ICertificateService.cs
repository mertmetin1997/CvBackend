using Core.Business;
using Core.Utilities.Result;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.Certificate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface ICertificateService : IGenericService<Certificate,CertificateResponseDto,CertificateCreateRequestDto,CertificateUpdateRequestDto,CertificateDetailResponseDto>
    {
        Task<IDataResult<IEnumerable<CertificateResponseDto>>> GetCertificatesByOrganisationAsync();
    }
}
