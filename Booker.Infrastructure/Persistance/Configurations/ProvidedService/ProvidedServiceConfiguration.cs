using Booker.Domain.Models.ProvidedService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booker.Infrastructure.Persistance.Configurations.ProvidedService;

public class ProvidedServiceConfiguration : IEntityTypeConfiguration<Domain.Models.ProvidedService.ProvidedService>
{
    public void Configure(EntityTypeBuilder<Domain.Models.ProvidedService.ProvidedService> builder)
    {
        
    }
}