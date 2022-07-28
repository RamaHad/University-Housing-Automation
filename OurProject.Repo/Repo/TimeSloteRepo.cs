using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.TimeSloteDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class TimeSloteRepo : TimeSloteIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public TimeSloteRepo(IMapper mapper)
        {
            _mapper = mapper;

        }
        public bool AddTimeSlote(AddTimeSloteDto dto)
        {
            var result = _mapper.Map<TimeSloteEntity>(dto);

            try
            {
                _context.timeSlotes.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllTimeSloteDto> GetAllTimeSlote()
        {
            var allAccessory = _context.timeSlotes.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllTimeSloteDto>>(allAccessory);
            return result;
        }
    }
}
