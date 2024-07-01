using AutoMapper;
using Clean.Core.DTOs;
using Clean.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core
{
    internal class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<clients, clientsDTO>().ReverseMap();
            CreateMap<doctors, doctorsDTO>().ReverseMap(); 
        }
    }
}
