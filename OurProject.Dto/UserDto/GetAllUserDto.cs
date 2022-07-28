using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Dto.UserDto
{
    public class GetAllUserDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public String Password { get; set; }
        public String Image { get; set; }
        public String PhoneNumber { get; set; }
        public String RoleName { get; set; }

    }
}
