﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ArcadeEntitie : DbContext
    {
        public ArcadeEntitie()
            : base("name=ArcadeEntitie")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Basis> Bases { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<InPut> InPuts { get; set; }
        public DbSet<OutPut> OutPuts { get; set; }
        public DbSet<EstateType> EstateTypes { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<MaritalStatu> MaritalStatus { get; set; }
        public DbSet<MilitaryStatu> MilitaryStatus { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<USER> USERs { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<Constraction> Constractions { get; set; }
        public DbSet<CoordinatingCouncil> CoordinatingCouncils { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<LandLord> LandLords { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<PersonalInfo> PersonalInfoes { get; set; }
        public DbSet<PurchaseLetter> PurchaseLetters { get; set; }
        public DbSet<RentPayment> RentPayments { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
