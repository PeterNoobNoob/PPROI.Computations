using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PPROI.ComputationsAPI.Repository.Models;

#nullable disable

namespace PPROI.ComputationsAPI.Repository
{
    public partial class PPROIDbContext : DbContext
    {
        public PPROIDbContext()
        {
        }

        public PPROIDbContext(DbContextOptions<PPROIDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<Result> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=PPROIDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Slovak_CI_AS");

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Results__EntityI__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
