using OurProject.Dto.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface UserIRepo
    {
        public bool AddUser(AddUserDto dto);
        public IQueryable<GetAllUserDto> GetAllUser();
        public AddUserDto LogIn(LoginDto dto);
    }
}
