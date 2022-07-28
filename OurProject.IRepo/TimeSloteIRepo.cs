using OurProject.Dto.TimeSloteDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface TimeSloteIRepo
    {
        public bool AddTimeSlote(AddTimeSloteDto dto);
        public List<GetAllTimeSloteDto> GetAllTimeSlote();

    }
}
