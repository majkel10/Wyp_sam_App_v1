﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1_MI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Wyp_sam_lok_v1Entities : DbContext
    {
        public Wyp_sam_lok_v1Entities()
            : base("name=Wyp_sam_lok_v1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KLIENCI> KLIENCI { get; set; }
        public virtual DbSet<PRACOWNICY> PRACOWNICY { get; set; }
        public virtual DbSet<SAMOCHODY> SAMOCHODY { get; set; }
        public virtual DbSet<SIEDZIBY> SIEDZIBY { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<WYPOZYCZENIA> WYPOZYCZENIA { get; set; }
    }
}
