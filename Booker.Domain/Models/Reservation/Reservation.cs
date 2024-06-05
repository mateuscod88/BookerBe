using System.ComponentModel.DataAnnotations;

namespace Booker.Domain.Models.Reservation;

public class Reservation
{
    
    public Guid Id { get; set; }
    // [Required(ErrorMessage = "Date of reservation is required")]
    public required DateTime StartDateUtc { get; set; }
    
    public required DateTime EndDateUtc { get; set; }
    public  required ProvidedService.ProvidedService ProvidedService { get; init; }
    
}