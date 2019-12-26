using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class EczaneBilgiContext:DbContext
    {
        public EczaneBilgiContext() : base("cstr")
        {

        }
        public DbSet<HastaIlac> HastaIlaclar { get; set; }
        public DbSet<IlacBilgi> Ilaclar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Entity<HastaIlac>().ToTable("tblHastaIlac");

            modelBuilder.Entity<HastaIlac>().Property(o =>o.verilis).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<HastaIlac>().Property(o => o.bitis).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<HastaIlac>().Property(o => o.sonkullanım).HasMaxLength(10).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<HastaIlac>().Property(o => o.kullanımsekli).HasMaxLength(50).IsRequired().HasColumnType("varchar");


        }
    }
   

}

