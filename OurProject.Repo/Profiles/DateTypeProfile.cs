using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.DateTypeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles

{
    public class DateTypeProfile : Profile
    {
        public DateTypeProfile()
        {
            //src              //dest
            CreateMap<AddDateTypeDto, DateTypeEntity>();  // add
            CreateMap<DateTypeEntity, GetAllDateTypeDto>();  //getall
        }
    }
}
