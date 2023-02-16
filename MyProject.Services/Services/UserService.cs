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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repositoryRole,IMapper mapper)
        {
            _userRepository = repositoryRole;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(string family, string identity, DateTime birthDate, bool isMale, int hmoId, string name)
        {
            User user= await _userRepository.AddAsync(family,  identity,  birthDate,  isMale,  hmoId,name);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeletAsync(id);
        }

        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            var user=await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            var tempR = _mapper.Map<User>(user);
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(tempR));
        }
    }
}
