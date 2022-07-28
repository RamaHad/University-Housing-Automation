using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.RoomDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
                      //src        //dest
            CreateMap<AddRoomDto, RoomEntity>();  // add
            CreateMap<RoomEntity, GetAllRoomDto>();  //getall
        }
    }
}
