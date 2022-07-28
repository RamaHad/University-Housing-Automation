using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.StudyBranchDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class StudyBranchProfile : Profile
    {
        public StudyBranchProfile()
        {
            //src             //dest
            CreateMap<AddStudyBranchDto, StudyBranchEntity>();  // add
            CreateMap<StudyBranchEntity, GetAllStudyBranchDto>();  //getall
        }
    }
}
