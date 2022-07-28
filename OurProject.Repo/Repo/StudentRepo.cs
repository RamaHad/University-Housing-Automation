using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.StudentDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class StudentRepo : StudentIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public StudentRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool AddStudent(AddStudentDto dto)
        {
            var result = _mapper.Map<StudentEntity>(dto);

            try
            {
                _context.students.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllStudentDto> GetAllStudent()
        {
            var allAccessory = _context.students.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllStudentDto>>(allAccessory);
            return result;
        }
    }
}
