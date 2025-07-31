using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Result;
using cvProject.Business.Abstract;
using cvProject.Business.Constans;
using cvProject.DataAccess.Abstract;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.About;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AboutManager(IAboutRepository aboutRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _aboutRepository = aboutRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<AboutResponseDto>> AddAsync(AboutCreateRequestDto dto)
        {
            try
            {
                var about = _mapper.Map<About>(dto);
                await _aboutRepository.AddAsync(about);

                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<AboutResponseDto>(about);
                return new SuccessDataResult<AboutResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<AboutResponseDto>(e.Message);

            }
        }

        public async Task<IDataResult<IEnumerable<AboutResponseDto>>> GetAllAsync()
        {
            try
            {
                var abouts = await _aboutRepository.GetAll(a => !a.IsDeleted).ToListAsync();
                if (abouts is null)
                {
                    return new ErrorDataResult<IEnumerable<AboutResponseDto>>("about list not found");
                }
                var dtos = _mapper.Map<IEnumerable<AboutResponseDto>>(abouts);
                return new SuccessDataResult<IEnumerable<AboutResponseDto>>(dtos, "about get list successfully");
            }
            catch (Exception e)
            {

                return new ErrorDataResult<IEnumerable<AboutResponseDto>>(e.Message);
            }
        }

        public async Task<IDataResult<AboutResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var about = await _aboutRepository.GetAsync(a => a.Id == id);
                if (about is null)
                {
                    return new ErrorDataResult<AboutResponseDto>("about not found");
                }
                var response = _mapper.Map<AboutResponseDto>(about);
                return new SuccessDataResult<AboutResponseDto>(response, "about get successfully");

            }
            catch (Exception e)
            {

                return new ErrorDataResult<AboutResponseDto>(e.Message);
            }
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var about = await _aboutRepository.GetAsync(a => a.Id == id);
                if (about is null)
                {
                    return new ErrorResult("About not found");
                }
                about.UpdateAt = DateTime.Now;
                about.IsDeleted = true;
                about.IsActive = false;
                _aboutRepository.Update(about);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.ErrorGet);
            }   
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(AboutUpdateRequestDto dto)
        {
            try
            {
                var about = _mapper.Map<About>(dto);
                about.UpdateAt = DateTime.Now;
                _aboutRepository.Update(about);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessAboutUpdated);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
