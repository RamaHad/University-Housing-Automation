using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.StudentDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            //src             //dest
            CreateMap<AddStudentDto, StudentEntity>();  // add
            CreateMap<StudentEntity, GetAllStudentDto>();  //getall
        }
    }
}
