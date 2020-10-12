using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp19
{
    public class MyDbContext : DbContext
    {
        public virtual DbSet<ARTICLE> ARTICLE { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite($"Filename=testDb.db");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.QteUnite)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,7)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.PoidsBrut)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.PoidsNet)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.Longueur)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.Largeur)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.Hauteur)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.Epaisseur)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.Cubage)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.PxAchatHT)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<ARTICLE>()
                .Property(e => e.PxAchatPour)
                .HasConversion<double>();
            //    .HasColumnType("decimal(18,7)");

    
        }
    }
}
