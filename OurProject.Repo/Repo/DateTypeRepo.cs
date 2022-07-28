using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.DateTypeDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class DateTypeRepo : DateTypeIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public DateTypeRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool AddDateType(AddDateTypeDto dto)
        {
            var result = _mapper.Map<DateTypeEntity>(dto);

            try
            {
                _context.dateTypes.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllDateTypeDto> GetAllDateType()
        {
            var allAccessory = _context.dateTypes.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllDateTypeDto>>(allAccessory);
            return result;
        }
    }
}
