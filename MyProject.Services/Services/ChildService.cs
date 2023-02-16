using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ChildService: IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }

        public async Task<ChildDTO> AddAsync(string name, DateTime birthDate, string identity, int parentId)
        {
            Child role = await _childRepository.AddAsync(name,birthDate , identity, parentId);
            return _mapper.Map<ChildDTO>(role);
        }

        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeletAsync(id);
        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }

        public async Task<ChildDTO> GetByIdAsync(int id)
        {
            var child = await _childRepository.GetByIdAsync(id);
            return _mapper.Map<ChildDTO>(child);
        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            var tempR = _mapper.Map<Child>(child);
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(tempR));
        }
    }
}
