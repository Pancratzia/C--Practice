using DemoCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovementController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public MovementController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("TestMovements")]
        public async Task<ActionResult<string>> GetMovementsConection()
        {
            try
            {
                var response = await _context.Movimientos.ToListAsync();
                return "¡Conexión Exitosa a la BD de Movimientos!";
            }
            catch (Exception ex)
            {
                return "Ha habido un error en la conexión";
            }
        }
    }


}
