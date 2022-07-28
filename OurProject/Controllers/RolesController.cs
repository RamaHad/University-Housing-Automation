using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OurProject.Dto.RoleDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleIRepo _roleIRepo;

        public RolesController(RoleIRepo roleIRepo)
        {
            this._roleIRepo = roleIRepo;
        }
        [HttpGet]
        public IActionResult GetAllRoles()
        {
           var result= _roleIRepo.GetAllRole();
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult FindById( int id)
        {
            var result = _roleIRepo.FindRoleById(id);
            if (result != null) return Ok(result);
            else return NotFound("Can't Fount");
        }
        
        [HttpGet ("FindFirstByName")]
        public IActionResult FindFirstByName([FromBody] AddRoleDto dto)
        {
            var result = _roleIRepo.SelectFirstRoleByName(dto);
            if (result != null) return Ok(result);
            else return NotFound("No Role With this Name");
                
        }
       
        [HttpPut]
        public IActionResult UpdateRole(GetAllRoleDto dto)
        {
            var result = _roleIRepo.UpdateRole(dto);
            if (result) return Ok(result);
            else return NotFound("Can't found the role that you want to update");

        }
    }
}
