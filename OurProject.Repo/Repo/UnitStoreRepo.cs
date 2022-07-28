using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.UnitStoreDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class UnitStoreRepo : UnitStoreIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public UnitStoreRepo(IMapper mapper)
        {
            _mapper = mapper;

        }
        public bool AddUnitStore(AddUnitStoreDto dto)
        {
            var result = _mapper.Map<UnitStoreEntity>(dto);

            try
            {
                _context.unitStores.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllUnitStoreDto> GetAllUnitStore()
        {
            var allAccessory = _context.unitStores.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllUnitStoreDto>>(allAccessory);
            return result;
        }
    }
}
