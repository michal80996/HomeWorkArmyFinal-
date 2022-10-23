using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoronaManagementSystemDAL.Models
{
    public partial class CoronaManagementSystemContext : DbContext
    {
        public CoronaManagementSystemContext()
        {
        }

        public CoronaManagementSystemContext(DbContextOptions<CoronaManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoronaDetails> CoronaDetails { get; set; }
        public virtual DbSet<UserName> UserName { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-E29QNMH;Database=CoronaManagementSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoronaDetails>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK__CoronaDe__AA2FFBE53A2CD901");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CoronaManufacturer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoronaManufacturer2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoronaManufacturer3)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoronaManufacturer4)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoronaVaccine).HasColumnType("date");

                entity.Property(e => e.CoronaVaccine2).HasColumnType("date");

                entity.Property(e => e.CoronaVaccine3).HasColumnType("date");

                entity.Property(e => e.CoronaVaccine4).HasColumnType("date");

                entity.Property(e => e.PositiveForCorona).HasColumnType("date");

                entity.Property(e => e.RecoveringFromCorona).HasColumnType("date");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.CoronaDetails)
                    .HasForeignKey<CoronaDetails>(d => d.PersonId)
                    .HasConstraintName("FK__CoronaDet__Perso__30F848ED");
            });

            modelBuilder.Entity<UserName>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK__UserName__AA2FFBE5599F706B");

                entity.Property(e => e.PersonId)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
