using Microsoft.EntityFrameworkCore;
using Roomie_API.Entities;

namespace Roomie_API.Contexto;

public class RoomieContext : DbContext
{
    public RoomieContext(DbContextOptions<RoomieContext> options) : base(options) { }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Quarto> Quarto { get; set; }
    public DbSet<Reserva> Reserva { get; set; }
    public DbSet<Admin> Admin { get; set; }
    public DbSet<Foto> Foto { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(u =>
        {
            u.Property<string>("Nome")
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            u.Property<string>("EMail")
                .IsRequired()
                .HasColumnType("nvarchar(150)");

            u.Property<string>("Senha")
                .IsRequired()
                .HasColumnType("nvarchar(255)");

            u.Property<string>("Telefone")
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            u.Property<string>("Cidade")
                .IsRequired()
                .HasColumnType("nvarchar(75)");

            u.Property<string>("UF")
                .IsRequired()
                .HasColumnType("nvarchar(2)");

            u.Property<string>("Rua")
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            u.Property<string>("Bairro")
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            u.Property<string>("CEP")
                .IsRequired()
                .HasColumnType("nvarchar(9)");

            u.Property<int>("Numero")
                .IsRequired()
                .HasColumnType("int");

            u.Property<string>("Role")
                .IsRequired()
                .HasColumnType("nvarchar(20)");

            u.Property<string>("Universidade")
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            u.Property<string>("Curso")
                .IsRequired()
                .HasColumnType("nvarchar(50)");
        });

        modelBuilder.Entity<Quarto>(q =>
        {
            q.Property<string>("Titulo")
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            q.Property<string>("Descricao")
                .IsRequired()
                .HasColumnType("nvarchar(1000)");

            q.Property<decimal>("Decimal")
                .IsRequired()
                .HasColumnType("decimal(12,2)");

            q.Property<string>("Rua")
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            q.Property<string>("Bairro")
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            q.Property<string>("CEP")
                .IsRequired()
                .HasColumnType("nvarchar(9)");

            q.Property<int>("Numero")
                .IsRequired()
                .HasColumnType("int");

            q.Property<string>("Cidade")
                .IsRequired()
                .HasColumnType("nvarchar(75)");

            q.Property<string>("UF")
                .IsRequired()
                .HasColumnType("nvarchar(2)");

            q.Property<int>("NumeroDeQuartos")
                .IsRequired()
                .HasColumnType("int");

            q.Property<int>("NumeroDeBanheiros")
                .IsRequired()
                .HasColumnType("int");

            q.Property<string>("Disponibilidade")
                .IsRequired()
                .HasColumnType("nvarchar(20)");

            q.Property<string>("Status")
                .IsRequired()
                .HasColumnType("nvarchar(20)");
        });

        modelBuilder.Entity<Reserva>(r =>
        {
            r.Property<DateTime>("DataInicio")
                .IsRequired()
                .HasColumnType("date");

            r.Property<DateTime>("DataTermino")
                .IsRequired()
                .HasColumnType("date");
        });

        modelBuilder.Entity<Admin>(a =>
        {
            a.Property<string>("Nome")
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            a.Property<string>("EMail")
                .IsRequired()
                .HasColumnType("nvarchar(150)");

            a.Property<string>("Senha")
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            a.Property<string>("Telefone")
                .IsRequired()
                .HasColumnType("nvarchar(30)");

            a.Property<string>("Cidade")
                .IsRequired()
                .HasColumnType("nvarchar(75)");

            a.Property<string>("UF")
                .IsRequired()
                .HasColumnType("nvarchar(2)");

            a.Property<string>("Role")
                .IsRequired()
                .HasColumnType("nvarchar(25)");

            a.Property<DateTime>("DataCriacao")
                .IsRequired()
                .HasColumnType("date");

            a.Property<DateTime>("UltimaAtividade")
                .IsRequired()
                .HasColumnType("datetime2");
        });

        modelBuilder.Entity<Foto>(f =>
        {
            f.Property<DateTime>("DataHoraEnvio")
                .IsRequired()
                .HasColumnType("datetime2");

            f.Property<string>("NomeArquivo")
                .IsRequired()
                .HasColumnType("nvarchar(75)");
        });

        modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Quartos)
            .WithOne(q => q.Usuario)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Usuario>()
            .HasMany(u => u.Reservas)
            .WithOne(r => r.Usuario)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Quarto>()
            .HasOne(q => q.Reserva)
            .WithOne(r => r.Quarto)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Quarto>()
            .HasMany(q => q.Fotos)
            .WithOne(f => f.Quarto)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
    public virtual void Modify(object entity) => Entry(entity).State = EntityState.Modified;
}
