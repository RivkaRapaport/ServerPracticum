using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interface
{
    public interface IChildService
    {
        public Task<List<ChildDTO>> GetAllAsync();
        public Task<ChildDTO> GetByIdAsync(int id);
        public Task<ChildDTO> AddAsync(string name, DateTime birthDate, string identity, int parentId);
        public Task<ChildDTO> UpdateAsync(ChildDTO obj);
        public Task DeleteAsync(int id);
    }
}
