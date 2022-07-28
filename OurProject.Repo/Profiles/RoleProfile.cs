using AutoMapper;
using DataBase.Entities;
using OurProject.Dto.RoleDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
                      //src        //dest
            CreateMap<AddRoleDto,RoleEntity>();  // add
            CreateMap<RoleEntity, GetAllRoleDto>();  //getall
            CreateMap<RoleEntity, FindRoleByIdDto>(); //find by id
            CreateMap<RoleEntity, SelectTheFirstRoleDto>(); //Select the first row in the table
            CreateMap<RoleEntity, SelectFirstRoleByNameDto>(); // select the first row where name = dto.name

        }
    }
}
