using OurProject.Dto.UnitStoreDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface UnitStoreIRepo
    {
        public bool AddUnitStore(AddUnitStoreDto dto);
        public List<GetAllUnitStoreDto> GetAllUnitStore();

    }
}
