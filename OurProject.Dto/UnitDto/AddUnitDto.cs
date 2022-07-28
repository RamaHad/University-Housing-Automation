using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Dto.UnitDto
{
    public class AddUnitDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public bool Gender { get; set; }

        public int UserFk { get; set; }

        public int UnitStoreFk { get; set; }

        public int StudyBranchEntityId { get; set; }
    }
}
