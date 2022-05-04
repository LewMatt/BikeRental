﻿using System.Data.Entity;
using BikeRental.Data.Entities;

namespace ContractorMng.Data
{
    public class BikeRentalContext : DbContext
    {
        public DbSet<Bikes> Bikes { get; set; }
        public DbSet<Rents> Rents { get; set; }
        public DbSet<RepairOrders> RepairOrders { get; set; }
        public DbSet<Repairs> Repairs { get; set; }
        public DbSet<Users> Users { get; set; }

        public BikeRentalContext() : base("name=BikeRentalDb")
        {
            //Database.SetInitializer<ContractorContext>(new DropCreateDatabaseAlways<ContractorContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
