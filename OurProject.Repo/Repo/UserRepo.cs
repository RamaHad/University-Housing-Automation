using AutoMapper;
using DataBase;
using DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using OurProject.Dto.UserDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class UserRepo : UserIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public UserRepo(IMapper mapper)
        {
            _mapper = mapper;

        }
        public UserRepo()
        {
           

        }
        public bool AddUser(AddUserDto dto)
        {
            var result = _mapper.Map<UserEntity>(dto);

            try
            {
                _context.users.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<GetAllUserDto> GetAllUser()
        {
            var result = _context.users
                .Join(_context.role, 
                user=>user.Id ,
                role=>role.Id,
                (u, r)=> new GetAllUserDto {
                    UserId = u.Id,
                    Name= u.UserName,
                    Password = u.Password,
                    RoleId = u.RoleId,
                    RoleName = r.Name
                }
                );
            return result;
        }

        public AddUserDto LogIn(LoginDto dto)
        { 
       
            var result = _context.users.FromSqlRaw($"UserLogin {dto.UserName }, {dto.Password}").ToList();
            if(result.Count!=0)
            {
                var resultDto =_mapper.Map<AddUserDto>(result[0]);
                return resultDto;
            }
            else
            {
                return null;
            }
        }
    }
}
