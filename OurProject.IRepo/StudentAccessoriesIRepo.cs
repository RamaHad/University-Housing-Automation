using OurProject.Dto.StudentAccessoriesDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface StudentAccessoriesIRepo
    {
        public bool AddStudentAccessories(AddStudentAccessoriesDto dto);
        public List<GetAllStudentAccessoriesDto> GetAllStudentAccessories();

    }
}
