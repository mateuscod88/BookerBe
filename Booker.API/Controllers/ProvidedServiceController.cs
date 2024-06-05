using Booker.Domain.Models.ProvidedService;
using Microsoft.AspNetCore.Mvc;

namespace Booker.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProvidedServiceController : Controller
{
    // GET
    [HttpGet]
    public  async Task<IActionResult> GetAll()
    {
        return Ok(Enumerable.Range(0, 10).Select(
            (value) =>
                new { Type = (ProvidedServiceType)(value % 3) }));
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(id);
    }
}