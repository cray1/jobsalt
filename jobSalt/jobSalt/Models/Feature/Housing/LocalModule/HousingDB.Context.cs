﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jobSalt.Models.Feature.Housing.LocalModule
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HousingDBEntities : DbContext
    {
        public HousingDBEntities()
            : base("name=HousingDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HousingReview> HousingReviews { get; set; }
        public virtual DbSet<HousingLocation> HousingLocations { get; set; }
    }
}