using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Dto.StoreDetailDto
{
    public class GetAllStoreDetailDto
    {
        public int Id { get; set; }
        public int Amount { get; set; }


        public int AccessoryId { get; set; }


        public int UnitStoreId { get; set; }
    }
}
