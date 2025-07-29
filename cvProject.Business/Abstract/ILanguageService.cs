using Core.Business;
using Core.Utilities.Result;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.Language;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Abstract
{
    public interface ILanguageService : IGenericService<Language,LanguageResponseDto,LanguageCreateRequestDto,LanguageUpdateRequestDto,LanguageDetailResponseDto>
    {
        Task<IDataResult<IEnumerable>> GetLanguagesGraterLevelAsync(byte level);
    }
}
