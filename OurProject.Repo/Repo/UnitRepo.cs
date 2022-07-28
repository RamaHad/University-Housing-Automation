using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.UnitDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class UnitRepo : UnitIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public UnitRepo(IMapper mapper)
        {
            _mapper = mapper;

        }
        public bool AddUnit(AddUnitDto dto)
        {
            var result = _mapper.Map<UnitEntity>(dto);

            try
            {
                _context.units.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllUnitDto> GetAllUnit()
        {
            var allAccessory = _context.units.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllUnitDto>>(allAccessory);
            return result;
        }
    }
}
