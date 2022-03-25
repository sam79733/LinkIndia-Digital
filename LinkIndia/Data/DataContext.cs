using System;
using Microsoft.EntityFrameworkCore;
using LinkIndia.Models;

namespace LinkIndia.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TransporterReg> transporterRegs { get; set; }
        public DbSet<TruckOwnerReg> truckOwnerRegs { get; set; }
        public DbSet<Client_LoadReg> client_LoadRegs { get; set; }
        public DbSet<TruckType> truckTypes { get; set; }
        public DbSet<PostLoad> postLoads { get; set; }
        public DbSet<TruckSubTypes> trucksubTypes { get; set; }
        public DbSet<PostTruck> postTrucks { get; set; }
        public DbSet<MaterialType> materialTypes { get; set; }

    }
}
