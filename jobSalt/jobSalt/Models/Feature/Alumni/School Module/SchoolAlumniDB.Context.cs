﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jobSalt.Models.Feature.Alumni.School_Module
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolAlumniDBContext : DbContext
    {
        public SchoolAlumniDBContext()
            : base("name=SchoolAlumniDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GradPlacement> GradPlacements { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
