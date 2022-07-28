using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.RoomDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class RoomRepo : RoomIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public RoomRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool AddRoom(AddRoomDto dto)
        {
            var result = _mapper.Map<RoomEntity>(dto);

            try
            {
                _context.rooms.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllRoomDto> GetAllRoom()
        {
            var allAccessory = _context.rooms.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllRoomDto>>(allAccessory);
            return result;
        }
    }
}
