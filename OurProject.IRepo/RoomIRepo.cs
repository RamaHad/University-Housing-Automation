using OurProject.Dto.RoomDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.IRepo
{
    public interface RoomIRepo
    {
        public bool AddRoom(AddRoomDto dto);
        public List<GetAllRoomDto> GetAllRoom();

    }
}
