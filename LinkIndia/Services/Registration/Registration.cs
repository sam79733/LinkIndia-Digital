using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LinkIndia.Data;
using AutoMapper;
using LinkIndia.Dtos;
using LinkIndia.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LinkIndia.Services.Registration
{
    public class Registration : IRegistration
    {


        //mapper
        private readonly IMapper _mapper;
        private readonly DataContext _context;


        public async Task<ServiceResponse<List<GetTransporterDtos>>> AddTransporter(AddTransporterDtos addTransporterDtos)
        {
            _context.Database.EnsureCreated();

            var serviceResponse = new ServiceResponse<List<GetTransporterDtos>>();

            TransporterReg transporter = _mapper.Map<TransporterReg>(addTransporterDtos);
            _context.transporterRegs.Add(transporter);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.transporterRegs
                                                 .Select(c => _mapper.Map<GetTransporterDtos>(c))
                                                 .ToListAsync();

            serviceResponse.Success = true;
            serviceResponse.Message = "Transporter has been added successfully";
            return serviceResponse;

        }


        public async Task<ServiceResponse<List<GetTruckOwnerDtos>>> AddTruckOwner(AddTruckOwnerDtos addTruckOwnerDtos)
        {
            _context.Database.EnsureCreated();

            var serviceResponse = new ServiceResponse<List<GetTruckOwnerDtos>>();

            TruckOwnerReg transporter = _mapper.Map<TruckOwnerReg>(addTruckOwnerDtos);
            _context.truckOwnerRegs.Add(transporter);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.truckOwnerRegs
                                                 .Select(c => _mapper.Map<GetTruckOwnerDtos>(c))
                                                 .ToListAsync();

            serviceResponse.Success = true;
            serviceResponse.Message = "Transporter has been added successfully";
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetLoadProviderDtos>>> AddLoadProvider(AddLoadProviderDtos addLoadProviderDtos)
        {
            _context.Database.EnsureCreated();

            var serviceResponse = new ServiceResponse<List<GetLoadProviderDtos>>();

            Client_LoadReg loadProvider = _mapper.Map<Client_LoadReg>(addLoadProviderDtos);
            _context.client_LoadRegs.Add(loadProvider);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.client_LoadRegs
                                                 .Select(c => _mapper.Map<GetLoadProviderDtos>(c))
                                                 .ToListAsync();

            serviceResponse.Success = true;
            serviceResponse.Message = "Transporter has been added successfully";
            return serviceResponse;
        }

        public Registration(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _context = dataContext;
        }
    }
}
