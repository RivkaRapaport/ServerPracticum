﻿using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ForMember(dest => dest.Children, opt => opt.MapFrom(src => src.Children)) .ReverseMap();            
            CreateMap<Hmo, HmoDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
    
        }
    }
}
