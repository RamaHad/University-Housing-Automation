using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.UnitDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class UnitProfile : Profile
    {
        public UnitProfile()
        {
            //src             //dest
            CreateMap<AddUnitDto, UnitEntity>();  // add
            CreateMap<UnitEntity, GetAllUnitDto>();  //getall
        }
    }
}
