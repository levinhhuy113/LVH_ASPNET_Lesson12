﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lvh_Aspnet_Lesson12.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeVinhHuy_2210900106Entities : DbContext
    {
        public LeVinhHuy_2210900106Entities()
            : base("name=LeVinhHuy_2210900106Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Lvh_SACH> Lvh_SACH { get; set; }
        public virtual DbSet<Lvh_TACGIA> Lvh_TACGIA { get; set; }
    }
}
