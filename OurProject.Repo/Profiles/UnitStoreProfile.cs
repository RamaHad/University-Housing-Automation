using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.UnitStoreDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class UnitStoreProfile : Profile
    {
        public UnitStoreProfile()
        {
            //src             //dest
            CreateMap<AddUnitStoreDto, UnitStoreEntity>();  // add
            CreateMap<UnitStoreEntity, GetAllUnitStoreDto>();  //getall
        }
    }
}
