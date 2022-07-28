using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.StoreDetailDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class StoreDetailProfile : Profile
    {
        public StoreDetailProfile()
        {
            //src        //dest
            CreateMap<AddStoreDetailDto, StoreDetailEntity>();  // add
            CreateMap<StoreDetailEntity, GetAllStoreDetailDto>();  //getall
        }
    }
}
