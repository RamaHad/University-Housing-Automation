using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Dto.StudentDateDto
{
    public class AddStudentDateDto
    {
        public int Id { get; set; }
        public float Price { get; set; }


 
        public int StudentId { get; set; }

   
        public int TimeSloteId { get; set; }

       
        public int DateTypeId { get; set; }
    }
}
