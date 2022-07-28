using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.StoreDetailDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class StoreDetailRepo : StoreDetailIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public StoreDetailRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool AddStoreDetail(AddStoreDetailDto dto)
        {
            var result = _mapper.Map<StoreDetailEntity>(dto);

            try
            {
                _context.storeDetails.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllStoreDetailDto> GetAllStoreDetail()
        {
            var allAccessory = _context.storeDetails.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllStoreDetailDto>>(allAccessory);
            return result;
        }
    }
}
