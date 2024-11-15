﻿
namespace MasterPoll.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MasterPolEntities : DbContext
    {
        public static MasterPolEntities _context;
        public static MasterPolEntities GetContext()
        {
            if (_context == null)
            {
                _context = new MasterPolEntities();
            }
            return _context;
        }
        public MasterPolEntities()
            : base("name=MasterPolEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Addres> Addres { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<PartnerName> PartnerName { get; set; }
        public virtual DbSet<PartnerProducts> PartnerProducts { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnerType> PartnerType { get; set; }
        public virtual DbSet<ProductName> ProductName { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<ProductTypeName> ProductTypeName { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Street> Street { get; set; }
    }
}
