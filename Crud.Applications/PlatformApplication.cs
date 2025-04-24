using Microsoft.EntityFrameworkCore;
using System.Data;

using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Crud.Applications;
using Crud.Applications.Models;
using Crud.Applications.Notifications;


public sealed class PlatformApplication : DbContext, IPlatformApplication
{

    public DbSet<Deliverer> Deliverers { get; }
    public DbSet<Motorcycle> Motorcycles { get; }

    public PlatformApplication()
    {
        this.Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("User ID=postgres;Password=12345678;Host=localhost;Port=5432;Database=postgress;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;");
        base.OnConfiguring(optionsBuilder);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EventPlatform>().ToTable("Messages");
        modelBuilder.Entity<EventPlatform>(p => p.HasKey(k => k.Id));
        modelBuilder.Entity<EventPlatform>(p => p.Property(pp => pp.Id));
        modelBuilder.Entity<EventPlatform>(p => p.Property(pp => pp.Message));


        modelBuilder.Entity<Motorcycle>().ToTable("Motorcycles");
        modelBuilder.Entity<Motorcycle>(p => p.HasKey(k => k.Identifier));
        modelBuilder.Entity<Motorcycle>(p => p.Property(pp => pp.Identifier));
        modelBuilder.Entity<Motorcycle>(p => p.Property(pp => pp.Model).HasConversion(new ModelMotorcycleConverter()));
        modelBuilder.Entity<Motorcycle>(p => p.Property(pp => pp.Plate).HasConversion(new PlateMotorcycleConverter()));
        modelBuilder.Entity<Motorcycle>(p => p.Property(pp => pp.Year).HasConversion(new YearMotorcycleConverter()));


        modelBuilder.Entity<Deliverer>().ToTable("Delivers");
        modelBuilder.Entity<Deliverer>(p => p.HasKey(k => k.Identifier));
        modelBuilder.Entity<Deliverer>(p => p.Property(pp => pp.Identifier));
        modelBuilder.Entity<Deliverer>(p => p.Property(pp => pp.Name));
        modelBuilder.Entity<Deliverer>(p => p.Property(pp => pp.DocumentCnpj).HasConversion(new CnpjConverter()));
        modelBuilder.Entity<Deliverer>(p => p.Property(pp => pp.DateOfBirth).HasConversion(new DateOfBirthConverter()));
        modelBuilder.Entity<Deliverer>(p => p.Property(pp => pp.Cnh).HasConversion(new CnhConverter()));
        modelBuilder.Entity<Deliverer>(p => p.Property(pp => pp.TypeOfCnh).HasConversion(new TypesOfCnhConverter()));
        modelBuilder.Entity<Deliverer>(p => p.Property(pp => pp.CnhPhotoDriverer).HasConversion(new CnhPhotoDrivererConverter()));

    }

    public void RegisterMotorcycle(Motorcycle motor)
    {
        throw new NotImplementedException();
    }

    public void RegisterNewEvent(INotificationEvent notificationEvent)
    {
        throw new NotImplementedException();
    }
}