using OurProject.Dto.StudentDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface StudentIRepo
    {
        public bool AddStudent(AddStudentDto dto);
        public List<GetAllStudentDto> GetAllStudent();

    }
}
