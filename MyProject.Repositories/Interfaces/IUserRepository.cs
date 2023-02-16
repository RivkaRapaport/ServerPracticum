using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllAsync();
        public Task<User> GetByIdAsync(int id);
        public Task<User> AddAsync(string family, string identity, DateTime birthDate, bool isMale, int hmoId,string name);
        public Task<User> UpdateAsync(User obj);
        public Task DeletAsync(int id);
    }
}
