using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.TimeSloteDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class TimeSloteProfile : Profile
    {
        public TimeSloteProfile()
        {
            //src             //dest
            CreateMap<AddTimeSloteDto, TimeSloteEntity>();  // add
            CreateMap<TimeSloteEntity, GetAllTimeSloteDto>();  //getall
        }
    }
}
