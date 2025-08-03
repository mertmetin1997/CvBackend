using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Result;
using cvProject.Business.Abstract;
using cvProject.Business.Constans;
using cvProject.DataAccess.Abstract;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.Interest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Concrete
{
    public class InterestManager : IInsterestService
    {
        private readonly IInterestRepository _interestRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InterestManager(IInterestRepository interestRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _interestRepository = interestRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<InterestResponseDto>> AddAsync(InterestCreateRequestDto dto)
        {
            try
            {
                var interest = _mapper.Map<Interest>(dto);
                await _interestRepository.AddAsync(interest);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<InterestResponseDto>(interest);
                return new SuccessDataResult<InterestResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<InterestResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<InterestResponseDto>>> GetAllAsync()
        {
            try
            {
                var interests = await _interestRepository.GetAll(i => !i.IsDeleted).OrderBy(i => i.Order).ToListAsync();
                if (interests == null)
                {
                    return new ErrorDataResult<IEnumerable<InterestResponseDto>>(ResultMessages.ErrorListed);
                }
                var dtos = _mapper.Map<IEnumerable<InterestResponseDto>>(interests);
                return new SuccessDataResult<IEnumerable<InterestResponseDto>>(dtos, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                   return new ErrorDataResult<IEnumerable<InterestResponseDto>>(e.Message);
            }
        }

        public async Task<IDataResult<InterestResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var interest = await _interestRepository.GetAsync(i => i.Id == id);
                if (interest is null)
                {
                    return new ErrorDataResult<InterestResponseDto>(ResultMessages.ErrorGet);
                }
                var response = _mapper.Map<InterestResponseDto>(interest);
                return new SuccessDataResult<InterestResponseDto>(response, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                  return new ErrorDataResult<InterestResponseDto>(e.Message);
            }
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var interest = await _interestRepository.GetAsync(i => i.Id == id);
                if (interest is null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);
                }
                interest.UpdateAt = DateTime.Now;
                interest.IsDeleted = true;
                interest.IsActive = false;
                _interestRepository.Update(interest);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception e)
            {

                return new ErrorResult(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(InterestUpdateRequestDto dto)
        {
            try
            {
                var interest = _mapper.Map<Interest>(dto);
                interest.UpdateAt = DateTime.Now;
                _interestRepository.Update(interest);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessUpdated);
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
