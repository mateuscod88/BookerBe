using Microsoft.AspNetCore.Mvc;

namespace Booker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : Controller
{
    // GET
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok("reservation");
    }

    [HttpGet("{reservationId}/providedservices")]
    public async Task<IActionResult> GetReserationProvidedServices(int reservationId)
    {
        return Ok($"reservation provided services {reservationId}");
    }
    
}