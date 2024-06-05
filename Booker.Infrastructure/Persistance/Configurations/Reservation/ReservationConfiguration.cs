using Booker.Domain.Models.ProvidedService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Booker.Domain.Models.Reservation;

namespace Booker.Infrastructure.Persistance.Configurations.Reservation;

public class ReservationConfiguration : IEntityTypeConfiguration<Domain.Models.Reservation.Reservation>
{
    public void Configure(EntityTypeBuilder<Booker.Domain.Models.Reservation.Reservation> builder)
    {
        builder.HasData(
            new Booker.Domain.Models.Reservation.Reservation
            {
                StartDateUtc = DateTime.Now.AddDays(4),
                EndDateUtc = DateTime.Now.AddDays(4).AddMinutes(60),
                ProvidedService = new Domain.Models.ProvidedService.ProvidedService{Type = ProvidedServiceType.Makeup}
            },
            new Booker.Domain.Models.Reservation.Reservation
            {
                StartDateUtc = DateTime.Now.AddDays(5),
                EndDateUtc = DateTime.Now.AddDays(5).AddMinutes(60),
                ProvidedService = new Domain.Models.ProvidedService.ProvidedService{Type = ProvidedServiceType.Makeup}
            },
            new Booker.Domain.Models.Reservation.Reservation
            {
                StartDateUtc = DateTime.Now.AddDays(6),
                EndDateUtc = DateTime.Now.AddDays(6).AddMinutes(60),
                ProvidedService = new Domain.Models.ProvidedService.ProvidedService{Type = ProvidedServiceType.Makeup}
            });
    }
}