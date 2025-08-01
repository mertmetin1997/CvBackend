using AutoMapper;
using Core.UnitOfWorks;
using Core.Utilities.Result;
using cvProject.Business.Abstract;
using cvProject.Business.Constans;
using cvProject.DataAccess.Abstract;
using cvProject.Entity.Concrete;
using cvProject.Entity.Dtos.Skill;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvProject.Business.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly ISkillRepository _skillRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public SkillManager(ISkillRepository skillRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _skillRepository = skillRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IDataResult<SkillResponseDto>> AddAsync(SkillCreateRequestDto dto)
        {
            try
            {
                var skill = _mapper.Map<Skill>(dto);
                await _skillRepository.AddAsync(skill);
                await _unitOfWork.CommitAsync();
                var response = _mapper.Map<SkillResponseDto>(skill);    
                return new SuccessDataResult<SkillResponseDto>(response, ResultMessages.SuccessCreated);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<SkillResponseDto>(e.Message);
            }
        }

        public async Task<IDataResult<IEnumerable<SkillResponseDto>>> GetAllAsync() // burası yazılacak.
        {
            try
            {
                var skills = await _skillRepository.GetAll(s => !s.IsDeleted).ToListAsync();
                if (skills == null)
                {
                    return new ErrorDataResult<IEnumerable<SkillResponseDto>>(ResultMessages.ErrorListed);
                }

                var response = _mapper.Map<IEnumerable<SkillResponseDto>>(skills);
                return new SuccessDataResult<IEnumerable<SkillResponseDto>>(response, ResultMessages.SuccessListed);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<IEnumerable<SkillResponseDto>>(e.Message);
            }
        }

        public async Task<IDataResult<SkillResponseDto>> GetByIdAsync(Guid id)
        {
            try
            {
                var skill = await _skillRepository.GetAsync(s => s.Id == id);
                if (skill is null)
                {
                    return new ErrorDataResult<SkillResponseDto>(ResultMessages.ErrorGet);   
                }
                var response = _mapper.Map<SkillResponseDto>(skill);
                return new SuccessDataResult<SkillResponseDto>(response, ResultMessages.SuccessGet);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<SkillResponseDto>(e.Message);
            }
        }

        public Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsProgramLanguagesAsync(bool program)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsProgramLanguagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsToolsAsync(bool tools)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IEnumerable<SkillResponseDto>>> GetSkillsToolsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(Guid id)
        {
            try
            {
                var skill = await _skillRepository.GetAsync(s => s.Id == id);
                if (skill == null)
                {
                    return new ErrorResult(ResultMessages.ErrorGet);
                }
                skill.UpdateAt = DateTime.Now;
                skill.IsDeleted = true;
                skill.IsActive = false;
                _skillRepository.Update(skill);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(ResultMessages.SuccessDeleted);
            }
            catch (Exception e)
            {

                return new ErrorResult(e.Message);
            }
        }

        public async Task<IResult> UpdateAsync(SkillUpdateRequestDto dto)
        {
            try
            {
                var skill = _mapper.Map<Skill>(dto);
                skill.UpdateAt = DateTime.Now;
                _skillRepository.Update(skill);
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
