using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NightSightsCoffee.Models
{
    public partial class NightSightsDbContext : DbContext
    {
        public NightSightsDbContext()
        {
        }

        public NightSightsDbContext(DbContextOptions<NightSightsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-6JOJJRQR\\SQLEXPRESS;Database=NightSightsDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(400);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Cart__CustomerId__3B75D760");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Cart__ProductId__3C69FB99");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.FirstName).HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(40);

                entity.Property(e => e.MiddleName).HasMaxLength(40);

                entity.Property(e => e.Password).HasMaxLength(40);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Coffee).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.RoastType).HasMaxLength(120);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Product__Custome__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
