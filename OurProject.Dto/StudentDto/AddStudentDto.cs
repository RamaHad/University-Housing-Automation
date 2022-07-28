using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Dto.StudentDto
{
  public  class AddStudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string UniversityId { get; set; }
        public string Image { get; set; }
        public bool Gender { get; set; }
        public bool Recorded { get; set; }


        public int UnitRoomFk { get; set; }

       

        public int StudyBranchId { get; set; }

     
        public int CityId { get; set; }
    }
}
