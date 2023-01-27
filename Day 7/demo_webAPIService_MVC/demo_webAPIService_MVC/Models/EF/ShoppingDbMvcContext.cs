using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace demo_webAPIService_MVC.Models.EF;

public partial class ShoppingDbMvcContext : DbContext
{
    public ShoppingDbMvcContext()
    {
    }

    public ShoppingDbMvcContext(DbContextOptions<ShoppingDbMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<ProductDetail> ProductDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=shoppingDB_MVC;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__Customer__D830D47780D658D3");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("cId");
            entity.Property(e => e.CCity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cCity");
            entity.Property(e => e.CName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cName");
            entity.Property(e => e.CProfileIsActive).HasColumnName("cProfileIsActive");
            entity.Property(e => e.CWalletBalance).HasColumnName("cWalletBalance");
        });

        modelBuilder.Entity<ProductDetail>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__productD__DD36D562AF9031DF");

            entity.ToTable("productDetails");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PManufacturer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pManufacturer");
            entity.Property(e => e.PName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
