using OurProject.Dto.DateTypeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface DateTypeIRepo
    {
        public bool AddDateType(AddDateTypeDto dto);
        public List<GetAllDateTypeDto> GetAllDateType();

    }
}
