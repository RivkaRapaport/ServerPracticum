﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContex _contex;
        private readonly IMapper _mapper;

        public UserRepository(IContex c, IMapper mapper)
        {
            _contex = c;
            _mapper = mapper;
        }
        public async Task<User> AddAsync(string family, string identity, DateTime birthDate, bool isMale, int hmoId, string name, ICollection<Child> children)
        {
            var nUser = new User
            {
                Family = family,
                Identity = identity,
                BirthDate = birthDate,
                IsMale = isMale,
                HmoId = hmoId,
                Name = name,
                Children = children

            };
            var newUser = _contex.Users.Add(nUser);
            await _contex.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task DeletAsync(int id)
        {
            var user = await _contex.Users.FindAsync(id);
            _contex.Users.Remove(user);
            await _contex.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _contex.Users.Include(u => u.Children).ToListAsync();
        }     

        public async Task<User> GetByIdAsync(int id)
        {
            return await _contex.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var users = _contex.Users.Update(user);    
            await _contex.SaveChangesAsync();
            return users.Entity;    
        }
    }
}
