﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitirmePro.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class uniDegerlendirmeEntities1 : DbContext
    {
        public uniDegerlendirmeEntities1()
            : base("name=uniDegerlendirmeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<hakkimizda> hakkimizda { get; set; }
        public virtual DbSet<iletisim> iletisim { get; set; }
        public virtual DbSet<kategori> kategori { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tur> tur { get; set; }
        public virtual DbSet<uni> uni { get; set; }
        public virtual DbSet<yorumIicerik> yorumIicerik { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<bolum> bolum { get; set; }
    }
}
