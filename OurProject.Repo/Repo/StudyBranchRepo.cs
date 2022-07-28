using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.StudyBranchDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class StudyBranchRepo : StudyBranchIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public StudyBranchRepo(IMapper mapper)
        {
            _mapper = mapper;

        }
        public bool AddStudyBranch(AddStudyBranchDto dto)
        {
            var result = _mapper.Map<StudyBranchEntity>(dto);

            try
            {
                _context.studyBranches.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllStudyBranchDto> GetAllStudyBranch()
        {
            var allAccessory = _context.studyBranches.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllStudyBranchDto>>(allAccessory);
            return result;
        }
    }
}
