using System;
using LinkIndia.Dtos;
using LinkIndia.Models;
using AutoMapper;
namespace LinkIndia
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TransporterReg, GetTransporterDtos>();
            CreateMap<AddTransporterDtos, TransporterReg>();
            CreateMap<TruckOwnerReg, GetTruckOwnerDtos>();
            CreateMap<AddTruckOwnerDtos, TruckOwnerReg>();
            CreateMap<Client_LoadReg, GetLoadProviderDtos>();
            CreateMap<AddLoadProviderDtos, Client_LoadReg>();
            CreateMap<PostLoad, GetPostLoadDtos>();
            CreateMap<AddPostLoadDtos, PostLoad>();
            CreateMap<AddPostTruckDtos, PostTruck>();
            CreateMap<PostTruck, GetPostTruckDtos>();
            CreateMap<TruckType, GetTruckTypesDtos>();
            CreateMap<MaterialType, GetMaterialTypeDtos>();

        }
    }
}
