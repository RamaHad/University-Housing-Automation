using OurProject.Dto.UnitRoomDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface UnitRoomIRepo
    {
        public bool AddUnitRoom(AddUnitRoomDto dto);
        public List<GetAllUnitRoomDto> GetAllUnitRoom();

    }
}
