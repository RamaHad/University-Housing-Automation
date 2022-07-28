using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.StudentAccessoriesDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class StudentAccessoriesRepo : StudentAccessoriesIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public StudentAccessoriesRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool AddStudentAccessories(AddStudentAccessoriesDto dto)
        {
            var result = _mapper.Map<StudentAccessoriesEntity>(dto);

            try
            {
                _context.studentAccessories.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllStudentAccessoriesDto> GetAllStudentAccessories()
        {
            var allAccessory = _context.studentAccessories.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllStudentAccessoriesDto>>(allAccessory);
            return result;
        }
    }
}
