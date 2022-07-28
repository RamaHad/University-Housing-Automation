using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Dto.StudentAccessoriesDto
{
    public class AddStudentAccessoriesDto
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public bool Returned { get; set; }

        public int StudentId { get; set; }

        public int StoreDetailId { get; set; }
    }
}
