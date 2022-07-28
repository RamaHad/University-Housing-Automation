using OurProject.Dto.StudyBranchDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface StudyBranchIRepo
    {
        public bool AddStudyBranch(AddStudyBranchDto dto);
        public List<GetAllStudyBranchDto> GetAllStudyBranch();

    }
}
