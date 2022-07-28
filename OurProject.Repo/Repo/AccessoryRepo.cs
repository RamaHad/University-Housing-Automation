
using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.AccessoryDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class AccessoryRepo : AccessoryIRepo

    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public AccessoryRepo(IMapper mapper)
        {
            _mapper = mapper;

        }
        public bool AddAccessory(AddAccessoryDto dto)
        {
                                  //dest           //src
           var result= _mapper.Map<AccessoryEntity>(dto);

            try
            {
                _context.accessories.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
            
        }

        public List<GetAllAccessoryDto> GetAllAccessory()
        {
           
                var allAccessory = _context.accessories.ToList();
                                        //dest                 //src
                var result = _mapper.Map<List<GetAllAccessoryDto>>(allAccessory);
                return result;
            
          
        }
    }
}
