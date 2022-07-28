using OurProject.Dto.StoreDetailDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface StoreDetailIRepo
    {
        public bool AddStoreDetail(AddStoreDetailDto dto);
        public List<GetAllStoreDetailDto> GetAllStoreDetail();

    }
}
