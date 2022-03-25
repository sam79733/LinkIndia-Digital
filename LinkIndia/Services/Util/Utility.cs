using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinkIndia.Data;
using LinkIndia.Dtos;
using LinkIndia.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkIndia.Services.Util
{
    public class Utility : IUtility
    {


        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public async Task<ServiceResponse<List<GetTruckTypesDtos>>> GetTruckTypes()
        {
            _context.Database.EnsureCreated();

            var serviceResponse = new ServiceResponse<List<GetTruckTypesDtos>>();


          

            serviceResponse.Data = await _context.truckTypes.Include(c => c.TruckSubTypes)
                                                 .Select(c => _mapper.Map<GetTruckTypesDtos>(c))
                                                 .ToListAsync();

            serviceResponse.Success = true;
            serviceResponse.Message = "successfull";
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetMaterialTypeDtos>>> GetMaterialTypes()
        {
            _context.Database.EnsureCreated();

            var serviceResponse = new ServiceResponse<List<GetMaterialTypeDtos>>();




            serviceResponse.Data = await _context.materialTypes
                                                 .Select(c => _mapper.Map<GetMaterialTypeDtos>(c))
                                                 .ToListAsync();

            serviceResponse.Success = true;
            serviceResponse.Message = "Successfull";
            return serviceResponse;
        }

        public Utility(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _context = dataContext;
        }
    }
}
