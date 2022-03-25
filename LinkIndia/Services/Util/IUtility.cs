using System;
using System.Collections.Generic;
using LinkIndia.Dtos;
using LinkIndia.Models;
using System.Threading.Tasks;

namespace LinkIndia.Services.Util
{
    public interface IUtility
    {
        Task<ServiceResponse<List<GetTruckTypesDtos>>> GetTruckTypes();
        Task<ServiceResponse<List<GetMaterialTypeDtos>>> GetMaterialTypes();
    }
}
