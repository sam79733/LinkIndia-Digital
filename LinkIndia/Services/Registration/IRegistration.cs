using System;
using System.Collections.Generic;
using LinkIndia.Dtos;
using LinkIndia.Models;
using System.Threading.Tasks;

namespace LinkIndia.Services.Registration
{
    public interface IRegistration
    {
        Task<ServiceResponse<List<GetTransporterDtos>>> AddTransporter(AddTransporterDtos addTransporterDtos);

        Task<ServiceResponse<List<GetTruckOwnerDtos>>> AddTruckOwner(AddTruckOwnerDtos addTruckOwnerDtos);

        Task<ServiceResponse<List<GetLoadProviderDtos>>> AddLoadProvider(AddLoadProviderDtos addLoadProviderDtos);
    }
}
