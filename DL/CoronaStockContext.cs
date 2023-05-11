using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Project.Models;

#nullable disable

namespace DL
{
    public partial class CoronaStockContext : DbContext
    {
        public CoronaStockContext()
        {
        }

        public CoronaStockContext(DbContextOptions<CoronaStockContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientVaccine> ClientVaccines { get; set; }
        public virtual DbSet<CoronaTest> CoronaTests { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9VRR8B9;Database=CoronaStock;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientVaccine>(entity =>
            {
                entity.ToTable("client_vaccine");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("date")
                    .HasColumnName("date_received");

                entity.Property(e => e.VaccineId).HasColumnName("vaccine_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ClientVaccines)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__client_va__custo__2B3F6F97");

                entity.HasOne(d => d.Vaccine)
                    .WithMany(p => p.ClientVaccines)
                    .HasForeignKey(d => d.VaccineId)
                    .HasConstraintName("FK__client_va__vacci__2C3393D0");
            });

            modelBuilder.Entity<CoronaTest>(entity =>
            {
                entity.ToTable("corona_tests");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.TestAnswer).HasColumnName("test_answer");

                entity.Property(e => e.TestDate)
                    .HasColumnType("date")
                    .HasColumnName("test_date");

              entity.Property(e => e.VaccineId).HasColumnName("vaccine_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CoronaTests)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__corona_te__custo__2F10007B");

                entity.HasOne(d => d.Vaccine)
                    .WithMany(p => p.CoronaTests)
                    .HasForeignKey(d => d.VaccineId)
                    .HasConstraintName("FK__corona_te__vacci__300424B4");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.HouseNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("house_number");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.ToTable("vaccines");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("manufacturer_name");

                entity.Property(e => e.ProductionDate)
                    .HasColumnType("date")
                    .HasColumnName("production_date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
