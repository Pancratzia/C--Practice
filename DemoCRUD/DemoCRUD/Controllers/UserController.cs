using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("Test")]
        public async Task<ActionResult<string>> GetEjemplo()
        {
            return "¡Servidor conectado con Éxito!";
        }

    }
}
