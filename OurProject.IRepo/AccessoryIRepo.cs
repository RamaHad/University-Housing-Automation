using OurProject.Dto.AccessoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
   public interface AccessoryIRepo
    {
        public bool AddAccessory(AddAccessoryDto dto);
        public List<GetAllAccessoryDto> GetAllAccessory();

    }
}
