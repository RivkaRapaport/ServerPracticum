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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<ICollection<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> GetById(int id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpPut("{id}")]
        public async Task Put(int id,[FromBody] UserModel user)  // update
        { 
            await _userService.UpdateAsync(new UserDTO {Id=id, Family=user.Family,Identity=user.Identity,BirthDate=user.BirthDate,IsMale=user.IsMale,HmoId=user.UserHmoId,Name=user.Name,Children=user.Children });
        }
        [HttpPost]
        public async Task Post([FromBody] UserModel user) //הכנסה
        {
            await _userService.AddAsync(user.Family, user.Identity,user.BirthDate,user.IsMale,user.UserHmoId,user.Name,user.Children);
        }
        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
