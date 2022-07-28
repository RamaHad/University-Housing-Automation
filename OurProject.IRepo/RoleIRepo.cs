using OurProject.Dto.RoleDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface RoleIRepo
    {
        public bool AddRole(AddRoleDto dto);
        public List<GetAllRoleDto> GetAllRole();
        public FindRoleByIdDto FindRoleById(int id);
        public SelectTheFirstRoleDto SelectTheFirstRole();
        public SelectFirstRoleByNameDto SelectFirstRoleByName(AddRoleDto dto); // the Name that we need to find it is as dto object
        public IQueryable<SelectAllRoleNameDto> SelectAllRoleName(); //select just role name using select method
        public bool UpdateRole(GetAllRoleDto dto);
    }
}
