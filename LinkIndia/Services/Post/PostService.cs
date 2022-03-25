using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LinkIndia.Data;
using AutoMapper;
using LinkIndia.Dtos;
using LinkIndia.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LinkIndia.Services.Post
{
    public class PostService : IPostService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public async Task<ServiceResponse<List<GetPostTruckDtos>>> AddPostTruck(AddPostTruckDtos addPostTruckDtos)
        {
            var serviceResponse = new ServiceResponse<List<GetPostTruckDtos>>();

            PostTruck postTruck = _mapper.Map<PostTruck>(addPostTruckDtos);

            _context.postTrucks.Add(postTruck);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.postTrucks
                                                 .Select(c => _mapper.Map<GetPostTruckDtos>(c))
                                                 .ToListAsync();


            serviceResponse.Success = true;
            serviceResponse.Message = "Successfully saved";

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPostLoadDtos>>> AddPostLoad(AddPostLoadDtos addPostLoadDtos)
        {
            var serviceResponse = new ServiceResponse<List<GetPostLoadDtos>>();

            PostLoad postLoad = _mapper.Map<PostLoad>(addPostLoadDtos);

            _context.postLoads.Add(postLoad);
            await _context.SaveChangesAsync();

            serviceResponse.Data = await _context.postLoads
                                                 .Select(c => _mapper.Map<GetPostLoadDtos>(c))
                                                 .ToListAsync();


            serviceResponse.Success = true;
            serviceResponse.Message = "Successfully saved";

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPostLoadDtos>>> FindLoad(string fromLocation, string tolocation)
        { 
            var serviceResponse = new ServiceResponse<List<GetPostLoadDtos>>();

            if(!string.IsNullOrEmpty(tolocation))
            {
                serviceResponse.Data = await _context.postLoads
                                                  .Join(_context.truckTypes, post=>post.TruckType, tr=> tr.Id, (post, tr) => new { post, tr })
                                                  .Where(x => x.post.LoadFrom.ToLower() == fromLocation.ToLower()  && x.post.LoadTo.ToLower() == tolocation.ToLower())
                                                  .Select(load => new GetPostLoadDtos {
                                                      Id = load.post.Id,
                                                      TruckCapacity = load.post.TruckCapacity,
                                                      LoadFrom = load.post.LoadFrom,
                                                      LoadTo = load.post.LoadTo,
                                                      TruckType = load.tr.Type,
                                                      MaterialType = load.post.MaterialType,
                                                      NumberOfTrucks = load.post.NumberOfTrucks,
                                                      Weight = load.post.Weight,
                                                      Date = load.post.Date,
                                                      Mobile = load.post.Mobile

                                                  })
                                                  .ToListAsync();
            }
            else
            {
                serviceResponse.Data = await _context.postLoads
                                                    .Join(_context.truckTypes, post => post.TruckType, tr => tr.Id, (post, tr) => new { post, tr })
                                                    .Where(x => x.post.LoadFrom.ToLower() == fromLocation.ToLower())
                                                    .Select(load => new GetPostLoadDtos
                                                    {
                                                        Id = load.post.Id,
                                                        TruckCapacity = load.post.TruckCapacity,
                                                        LoadFrom = load.post.LoadFrom,
                                                        LoadTo = load.post.LoadTo,
                                                        TruckType = load.tr.Type,
                                                        MaterialType = load.post.MaterialType,
                                                        NumberOfTrucks = load.post.NumberOfTrucks,
                                                        Weight = load.post.Weight,
                                                        Date = load.post.Date,
                                                        Mobile = load.post.Mobile

                                                    })
                                                    .ToListAsync();
            }



        serviceResponse.Success = true;
            serviceResponse.Message = "Successfully saved";

            return serviceResponse;
        }

        public PostService(DataContext dataContext, IMapper mapper)
        {
            _context = dataContext;
            _mapper = mapper;
        }
    }
}
