using Microsoft.AspNetCore.Mvc;

namespace SecureClaim.API.Claims.Interfaces.Controllers;

[ApiController]
[Route("api/sinistro")]
public class SinistroController : ControllerBase
{
    [HttpGet]
    public IActionResult Buscar()
    {
        return Ok(new
        {
            id = 1,
            descricao = "Colisão frontal",
            status = "ABERTO"
        });
    }
}