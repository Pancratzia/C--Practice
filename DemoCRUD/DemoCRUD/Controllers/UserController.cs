using DemoCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Test")]
        public async Task<ActionResult<string>> GetEjemplo()
        {
            return "¡Servidor conectado con Éxito!";
        }

        [HttpGet("TestUsers")]
        public async Task<ActionResult<string>> GetUsersConection()
        {
            try
            {
                var response = await _context.Usuarios.ToListAsync();
                return "¡Conexión Exitosa a la BD de Usuarios!";
            } catch (Exception ex)
            {
                return "Ha habido un error en la conexión";
            }
        }
    }
}
