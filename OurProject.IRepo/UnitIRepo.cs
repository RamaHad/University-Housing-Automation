using OurProject.Dto.UnitDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface UnitIRepo
    {
        public bool AddUnit(AddUnitDto dto);
        public List<GetAllUnitDto> GetAllUnit();

    }
}
