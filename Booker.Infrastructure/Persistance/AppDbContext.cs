using Booker.Domain.Models.ProvidedService;
using Booker.Domain.Models.Reservation;
using Booker.Infrastructure.Persistance.Configurations.ProvidedService;
using Booker.Infrastructure.Persistance.Configurations.Reservation;
using Microsoft.EntityFrameworkCore;

namespace Booker.Infrastructure.Persistance;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
            
    }
    private DbSet<ProvidedService> ProvidedServices => Set<ProvidedService>();
    private DbSet<Reservation> Reservations => Set<Reservation>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProvidedServiceConfiguration());
        modelBuilder.ApplyConfiguration(new ReservationConfiguration());
    }
}