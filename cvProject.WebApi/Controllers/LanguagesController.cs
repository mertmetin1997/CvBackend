using cvProject.Business.Abstract;
using cvProject.Entity.Dtos.Language;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cvProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(LanguageCreateRequestDto dto)
        {
            if (dto == null )
            {
                return BadRequest("geçersiz veri");
            }
            var result = await _languageService.AddAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);

        }

        [HttpPut]

        public async Task<IActionResult> Update(LanguageUpdateRequestDto dto)
        {
            if (dto == null)
            {
                return BadRequest("geçersiz veri");
            }
            var result = await _languageService.UpdateAsync(dto);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        { 
            var result = await _languageService.RemoveAsync(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var result = await _languageService.GetAllAsync();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }


        // kontrol edilmeli!
        [HttpGet("[action]/{level}")]
        public async Task<IActionResult> GetByLevel(byte level)
        {
            var result = await _languageService.GetLanguagesGraterLevelAsync(level);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

    }
}
