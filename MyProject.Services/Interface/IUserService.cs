using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interface
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(int id);

        Task<UserDTO> AddAsync(string family, string identity, DateTime birthDate, bool isMale, int hmoId,string name);

        Task<UserDTO> UpdateAsync(UserDTO hmo);

        Task DeleteAsync(int id);
    }
}
