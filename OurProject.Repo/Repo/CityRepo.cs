using AutoMapper;
using DataBase;
using DataBase.Entities;
using OurProject.Dto.CityDto;
using OurProject.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurProject.Repo
{
    public class CityRepo : CityIRepo
    {
        private readonly IMapper _mapper;
        private ApplicationDbContext _context = new ApplicationDbContext();
        public CityRepo(IMapper mapper)
        {
            _mapper = mapper;
        }
        public bool AddCity(AddCityDto dto)
        {
            var result = _mapper.Map<CityEntity>(dto);

            try
            {
                _context.cities.Add(result);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GetAllCityDto> GetAllCity()
        {
            var allAccessory = _context.cities.ToList();
            //dest                 //src
            var result = _mapper.Map<List<GetAllCityDto>>(allAccessory);
            return result;
        }
    }
}
