using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Dto.UnitStoreDto
{
    public class GetAllUnitStoreDto
    {
        public int Id { get; set; }
        public String Name { get; set; }


        public int UserFk { get; set; }
    }
}
