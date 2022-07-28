using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.RoleDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class RoleRepo : RoleIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context;
        public RoleRepo(IMapper mapper)
        {
            _mapper = mapper;
            _context = new ApplicationDbContext();
        }
        public bool AddRole(AddRoleDto dto)
        {
            var result = _mapper.Map<RoleEntity>(dto);

            try
            {
                _context.role.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public FindRoleByIdDto FindRoleById(int id)
        {
            var result = _context.role.Find(id);
            var resultDto = _mapper.Map<FindRoleByIdDto>(result);
            return resultDto;
        }

        public List<GetAllRoleDto> GetAllRole()
        {

            try
            {
                var result = _context.role.ToList();
                //dest                 //src
                var resultDto = _mapper.Map<List<GetAllRoleDto>>(result);

                return resultDto;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public IQueryable<SelectAllRoleNameDto> SelectAllRoleName()
        {

            try
            {
                var result = _context.role.Select(m => new SelectAllRoleNameDto { Name = m.Name }); // return IQueryable<SelectAllRoleNameDto> so we don't need to map it
                return result;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public SelectFirstRoleByNameDto SelectFirstRoleByName(AddRoleDto dto)
        {

            try
            {
                var result = _context.role.First(m => m.Name.Equals(dto.Name));  // if table is empty or if it can't find row with this condetion there will be error
                var resultDto = _mapper.Map<SelectFirstRoleByNameDto>(result);
                return resultDto;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SelectTheFirstRoleDto SelectTheFirstRole()
        {

            try
            {
                var result = _context.role.First();  // if table is empty there will be error
                var resultDto = _mapper.Map<SelectTheFirstRoleDto>(result);
                return resultDto;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool UpdateRole(GetAllRoleDto dto)
        {

            var result = _context.role.Find(dto.Id);
            if (result != null)
            {
                result.Name = dto.Name;
                _context.role.Update(result);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
