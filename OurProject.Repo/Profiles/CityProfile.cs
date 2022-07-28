using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.CityDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class CityProfile : Profile
    {
      
         public CityProfile()
        {
                      //src              //dest
            CreateMap<AddCityDto, CityEntity>();  // add
            CreateMap<CityEntity, GetAllCityDto>();  //getall
        }
    }
}
