using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.UnitRoomDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class UnitRoomRepo : UnitRoomIRepo
    {
        private readonly IMapper _mapper;
        public UnitRoomRepo(IMapper mapper)
        {
            _mapper = mapper;

        }
        private ApplicationDbContext _context = new ApplicationDbContext();
        public bool AddUnitRoom(AddUnitRoomDto dto)
        {
            var result = _mapper.Map<UnitRoomEntity>(dto);

            try
            {
                _context.unitRooms.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllUnitRoomDto> GetAllUnitRoom()
        {
            var allAccessory = _context.unitRooms.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllUnitRoomDto>>(allAccessory);
            return result;
        }
    }
}
