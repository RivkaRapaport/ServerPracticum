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
    public class HmoService : IHmoService
    {
        private readonly IHmoRepository _hmoRepository;
        private readonly IMapper _mapper;
        public HmoService(IHmoRepository hmoRepository,IMapper mapper)
        {
            _hmoRepository = hmoRepository;
            _mapper = mapper;
        }

        public async Task<HmoDTO> AddAsync( string description,string name)
        {
            return _mapper.Map<HmoDTO>(await _hmoRepository.AddAsync(description,name));
        }

        public async Task DeleteAsync(int id)
        {
            await _hmoRepository.DeletAsync(id);
        }

        public async Task<List<HmoDTO>> GetAllAsync()
        {
            return _mapper.Map<List<HmoDTO>>(await _hmoRepository.GetAllAsync());
        }

        public async Task<HmoDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<HmoDTO>(await _hmoRepository.GetByIdAsync(id));
        }

        public async Task<HmoDTO> UpdateAsync(HmoDTO hmo)
        {
            Hmo hmoTemp = _mapper.Map<Hmo>(hmo);
            return _mapper.Map<HmoDTO>(await _hmoRepository.UpdateAsync(hmoTemp));
        }
    }
}
