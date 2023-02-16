using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IHmoRepository
    {
        public Task<List<Hmo>> GetAllAsync();
        public Task<Hmo> GetByIdAsync(int id);
        public Task<Hmo> AddAsync(string description,string name);
        public Task<Hmo> UpdateAsync(Hmo obj);
        public Task DeletAsync(int id);
    }
}
