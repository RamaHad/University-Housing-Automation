using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.AccessoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class AccessoryProfile: Profile
    {
        public AccessoryProfile()
        {            //src              //dest
            CreateMap<AddAccessoryDto, AccessoryEntity>();  // add
            CreateMap<AccessoryEntity, GetAllAccessoryDto>();  //getall

        }

    }
}
