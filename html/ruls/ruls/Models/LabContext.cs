using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ruls.Models;

public partial class LabContext : DbContext
{
    public LabContext()
    {
    }

    public LabContext(DbContextOptions<LabContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Maintab> Maintabs { get; set; }

    public virtual DbSet<Myname> Mynames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.1.70;Database=lab;Trusted_Connection=True;TrustServerCertificate=true;User ID=lab;Password=a123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Maintab>(entity =>
        {
            entity.HasKey(e => new { e.Email, e.Name });

            entity.ToTable("maintab");

            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(18)
                .HasColumnName("name");
            entity.Property(e => e.Bd)
                .HasColumnType("date")
                .HasColumnName("bd");
            entity.Property(e => e.Cnumber)
                .HasMaxLength(18)
                .HasColumnName("cnumber");
            entity.Property(e => e.Nickname)
                .HasMaxLength(18)
                .HasColumnName("nickname");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("remark");
            entity.Property(e => e.Sexul)
                .HasMaxLength(18)
                .HasColumnName("sexul");
            entity.Property(e => e.Unmber)
                .HasMaxLength(18)
                .HasColumnName("unmber");

            entity.HasOne(d => d.NameNavigation).WithMany(p => p.Maintabs)
                .HasForeignKey(d => d.Name)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_maintab_myname");
        });

        modelBuilder.Entity<Myname>(entity =>
        {
            entity.HasKey(e => e.Name);

            entity.ToTable("myname");

            entity.Property(e => e.Name)
                .HasMaxLength(18)
                .HasColumnName("name");
            entity.Property(e => e.State)
                .HasMaxLength(18)
                .HasColumnName("state");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
