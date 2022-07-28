using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.UnitRoomDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class UnitRoomProfile : Profile
    {
        public UnitRoomProfile()
        {
            //src             //dest
            CreateMap<AddUnitRoomDto, UnitRoomEntity>();  // add
            CreateMap<UnitRoomEntity, GetAllUnitRoomDto>();  //getall
        }
    }
}
