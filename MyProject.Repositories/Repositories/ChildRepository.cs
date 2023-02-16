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
    public class ChildRepository: IChildRepository
    {
        private readonly IContex _contex;
        public ChildRepository(IContex con)
        {
            _contex = con;
        }
        public async Task<Child> AddAsync(string name, DateTime birthDate, string identity, int parentId)
        {
            var nChild = new Child { BirthDate=birthDate,Identity=identity,ParentId=parentId, Name = name };



            var newChild = _contex.Childs.Add(nChild);
            await _contex.SaveChangesAsync();
            return newChild.Entity;
        }

        public async Task DeletAsync(int id)
        {
            var per = await _contex.Childs.FindAsync(id);
            _contex.Childs.Remove(per);
            await _contex.SaveChangesAsync();
        }


        public async Task<List<Child>> GetAllAsync()
        {
            return await _contex.Childs.ToListAsync();
        }
        public async Task<Child> GetByIdAsync(int id)
        {
            return await _contex.Childs.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child obj)
        {
            var child = _contex.Childs.Update(obj);
            await _contex.SaveChangesAsync();
            return child.Entity;
        }
    }
}
