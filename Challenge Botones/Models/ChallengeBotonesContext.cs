using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Challenge_Botones.Models;

public partial class ChallengeBotonesContext : DbContext
{
    public ChallengeBotonesContext()
    {
    }

    public ChallengeBotonesContext(DbContextOptions<ChallengeBotonesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Botones> Botones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ChallengeBotones;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Botones>(entity =>
        {
            entity.HasKey(e => e.IdBoton).HasName("PK__Botones__9F291FF8A27C319A");

            entity.Property(e => e.IdBoton).HasColumnName("idBoton");
            entity.Property(e => e.Contador).HasColumnName("contador");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
