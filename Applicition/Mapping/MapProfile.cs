using AutoMapper;
using Domains.DTO;
using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<Student, StudentCreateDTO>().ReverseMap();
            CreateMap<Student, StudentUpdateDTO>().ReverseMap();
            CreateMap<Student, StudentDeleteDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Class, ClassCreateDTO>().ReverseMap();
            CreateMap<Class, ClassCreateDTO>().ReverseMap(); 
            CreateMap<Class, ClassUpdateDTO>().ReverseMap(); 
            CreateMap<Class, ClassDeleteDTO>().ReverseMap();

        }
    }
}
