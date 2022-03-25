using System;
using System.Collections.Generic;
using LinkIndia.Dtos;
using LinkIndia.Models;
using System.Threading.Tasks;

namespace LinkIndia.Services.Post
{
    public interface IPostService
    {
        Task<ServiceResponse<List<GetPostLoadDtos>>> AddPostLoad(AddPostLoadDtos addPostLoadDtos);

        Task<ServiceResponse<List<GetPostTruckDtos>>> AddPostTruck(AddPostTruckDtos addPostTruckDtos);

        Task<ServiceResponse<List<GetPostLoadDtos>>> FindLoad(string fromLocation, string toLocation);
    }
}
