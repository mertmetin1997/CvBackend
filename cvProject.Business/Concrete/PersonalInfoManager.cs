using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Result;
using cvProject.Business.Abstract;
using cvProject.DataAccess.Abstract;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.PersonalInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cvProject.Business.Constans;

namespace cvProject.Business.Concrete
{
    public class PersonalInfoManager : IPersonalInfoService
    {
        private readonly IPersonalInfoRepository _personalInfoRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PersonalInfoManager(IPersonalInfoRepository personalInfoRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _personalInfoRepository = personalInfoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<PersonalInfoResponseDto>> AddAsync(PersonalInfoCreateRequestDto dto)
        {
            try
            {
                var personalInfo = _mapper.Map<PersonalInfo>(dto);
                await _personalInfoRepository.AddAsync(personalInfo);
                await _unitOfWork.CommitAsync();

                var response = _mapper.Map<PersonalInfoResponseDto>(personalInfo);
                return new SuccessDataResult<PersonalInfoResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<PersonalInfoResponseDto>(e.Message);
            }
        }


        public async Task<IDataResult<IEnumerable<PersonalInfoResponseDto>>> GetAllAsync()
        {
            try
            {
                var personalInfos = await _personalInfoRepository.GetAll(p => !p.IsDeleted).ToListAsync();
                if (personalInfos is null)
                {
                    return new ErrorDataResult<IEnumerable<PersonalInfoResponseDto>>("personalInfo list not found");
                }
                var personalInfoDtos = _mapper.Map<IEnumerable<PersonalInfoResponseDto>>(personalInfos);
                return new SuccessDataResult<IEnumerable<PersonalInfoResponseDto>>(personalInfoDtos, "personalInfo get list successfully");

            }
            catch (Exception e)
            {

                return new ErrorDataResult<IEnumerable<PersonalInfoResponseDto>>(e.Message);
            }
        }


        public async Task<IDataResult<PersonalInfoResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var personalInfo = await _personalInfoRepository.GetAsync(p => p.Id == id);
                if (personalInfo is null)
                {
                    return new ErrorDataResult<PersonalInfoResponseDto>("personalInfo not found");                    
                }
                var personalInfoDto = _mapper.Map<PersonalInfoResponseDto>(personalInfo);
                return new SuccessDataResult<PersonalInfoResponseDto>(personalInfoDto, "personalInfo get by id successfully");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<PersonalInfoResponseDto>(e.Message);
            }
        }


        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var personalInfo = await _personalInfoRepository.GetAsync(p => p.Id == id);
                if (personalInfo is null)
                {
                    return new ErrorResult("personalInfo not found");
                }
                personalInfo.UpdateAt = DateTime.Now;
                personalInfo.IsDeleted = true;
                personalInfo.IsActive = false;
                _personalInfoRepository.Update(personalInfo);
                await _unitOfWork.CommitAsync();
                return new SuccessResult("personalInfo deleted successfully");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }


        public async Task<IResult> UpdateAsync(PersonalInfoUpdateRequestDto dto)
        {
            try
            {
                var personalInfo = _mapper.Map<PersonalInfo>(dto);
                personalInfo.UpdateAt = DateTime.Now;
                _personalInfoRepository.Update(personalInfo);
                await _unitOfWork.CommitAsync();
                return new SuccessResult("personalInfo updated successfully");

            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
