using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.StudentDateDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class StudentDateProfile : Profile
    {
        public StudentDateProfile()
        {
                      //src             //dest
            CreateMap<AddStudentDateDto, StudentDateEntity>();  // add
            CreateMap<StudentDateEntity, GetAllStudentDateDto>();  //getall
        }
    }
}
