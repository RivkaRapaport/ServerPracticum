using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class HmoRepository : IHmoRepository
    {
        private readonly IContex _contex;
        public HmoRepository(IContex con)
        {
            _contex = con;
        }
        public async Task<Hmo> AddAsync(string description, string name)
        {
            var nHmo=new Hmo { DescriptionDTO = description, Name = name };
       

         
            var newHmo = _contex.Hmos.Add(nHmo);
            await _contex.SaveChangesAsync();
            return newHmo.Entity;
        }

        public async Task DeletAsync(int id)
        {
            var per = await _contex.Hmos.FindAsync(id);
            _contex.Hmos.Remove(per);
            await _contex.SaveChangesAsync();
        }

        public async Task<List<Hmo>> GetAllAsync()
        {
            return await _contex.Hmos.ToListAsync();
        }

        public async Task<Hmo> GetByIdAsync(int id)
        {
            return await _contex.Hmos.FindAsync(id);
        }

        public async Task<Hmo> UpdateAsync(Hmo obj)
        {
            var hmo=_contex.Hmos.Update(obj);
            await _contex.SaveChangesAsync();
            return hmo.Entity;    
        }
    }
}
