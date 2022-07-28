using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.StudentDateDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class StudentDateRepo : StudentDateIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public StudentDateRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool AddStudentDate(AddStudentDateDto dto)
        {
            var result = _mapper.Map<StudentDateEntity>(dto);

            try
            {
                _context.studentDates.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllStudentDateDto> GetAllStudentDate()
        {
            var allAccessory = _context.studentDates.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllStudentDateDto>>(allAccessory);
            return result;
        }
    }
}
