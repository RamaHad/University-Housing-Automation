using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.StudentAccessoriesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class StudentAccessoriesProfile : Profile
    {
        public StudentAccessoriesProfile()
        {
            //src        //dest
            CreateMap<AddStudentAccessoriesDto, StudentAccessoriesEntity>();  // add
            CreateMap<StudentAccessoriesEntity, GetAllStudentAccessoriesDto>();  //getall
        }
    }
}
