using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interface;
using MyProject.WebAPI.Models;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HmoController : ControllerBase
    {
        private readonly IHmoService _hmoService;
        public HmoController(IHmoService hmoService)
        {
            _hmoService = hmoService;
        }
        [HttpGet]
        public async Task<List<HmoDTO>> Get()
        {
            return await _hmoService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<HmoDTO> GetById(int id)
        {
            return await _hmoService.GetByIdAsync(id);
        }
        [HttpPut("{id}")]
        public async Task Put(int id , [FromBody] HmoModel hmo)
        {
            await _hmoService.UpdateAsync(new HmoDTO { Id=id, Name= hmo.Name, DescriptionDTO= hmo.Descripsion});
        }
        [HttpPost]
        public async Task Post([FromBody] HmoModel hmo)
        {
            await _hmoService.AddAsync(hmo.Name, hmo.Descripsion);
        }
        [HttpDelete]
        public async Task Delete(int id)
        {
            await _hmoService.DeleteAsync(id);
        }
    }
}
