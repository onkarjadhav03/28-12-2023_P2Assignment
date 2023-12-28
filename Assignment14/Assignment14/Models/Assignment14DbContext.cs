using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assignment14.Models
{
    public partial class Assignment14DbContext : DbContext
    {
        public Assignment14DbContext()
        {
        }

        public Assignment14DbContext(DbContextOptions<Assignment14DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Cource> Cources { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-VDRMSHO;database=Assignment14Db;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.CourceCategory, "UQ__Category__FBBDC41E15093DA1")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourceCategory).HasMaxLength(50);
            });

            modelBuilder.Entity<Cource>(entity =>
            {
                entity.ToTable("Cource");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDate");

                entity.HasOne(d => d.CourceCategoryNavigation)
                    .WithMany(p => p.Cources)
                    .HasForeignKey(d => d.CourceCategory)
                    .HasConstraintName("FK__Cource__CourceCa__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
