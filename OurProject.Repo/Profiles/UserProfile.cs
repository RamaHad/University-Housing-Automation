using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            //src             //dest
            CreateMap<AddUserDto, UserEntity>();  // add
            //CreateMap<UserEntity, GetAllUserDto>();  //getall
        }
    }
}
