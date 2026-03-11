using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFdoga_FR_12B.models
{
    public partial class KonyvtardbContext : DbContext
    {
        public KonyvtardbContext()
        {
        }

        public KonyvtardbContext(DbContextOptions<KonyvtardbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=konyvtar;user=root;password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<books>(entity =>
            {
                entity.HasKey(e => e.id)
                    .HasName("PRIMARY");

                entity.ToTable("books");

                entity.Property(e => e.id)
                    .HasColumnName("id")
                    .HasColumnType("int");

                entity.Property(e => e.title)
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'NULL'");
                
                entity.Property(e => e.author)
                    .HasColumnName("author")
                    .HasMaxLength(150)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.price)
                    .HasColumnName("price")
                    .HasColumnType("int")
                    .HasDefaultValueSql("'NULL'");
            });

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
