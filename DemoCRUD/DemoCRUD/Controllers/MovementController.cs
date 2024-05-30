using DemoCRUD.Data;
using DemoCRUD.Shared;
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

        [HttpPost("AddMovement")]
        public async Task<ActionResult<string>> AddMovement(Movement movement)
        {
            try
            {
                _context.Movimientos.Add(movement);
                await _context.SaveChangesAsync();
                return "¡Movimiento agregado con exito!";
            }
            catch (Exception ex)
            {
                return "Ha habido un error en la aplicación";
            }
        }

        [HttpGet("GetMovements")]
        public async Task<ActionResult<List<Movement>>> GetMovements()
        {
            var movements = await _context.Movimientos.Include(u=> u.Usuario).ToListAsync();
            return movements;
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<string>> DeleteMovement(int id)
        {
            try
            {
                var movement = await _context.Movimientos.FindAsync(id);
                if (movement == null)
                {
                    return "No existe el movimiento";
                }
                _context.Movimientos.Remove(movement);
                await _context.SaveChangesAsync();
                return "Movimiento eliminado";
            }
            catch (Exception ex)
            {
                return "Ha habido un error en la aplicación";
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<string>> UpdateMovement(Movement movement)
        {
            try
            {
                var DbObject = await _context.Movimientos.FindAsync(movement.Id);
                if (DbObject == null)
                {
                    return "No existe el movimiento";
                }
                DbObject.Fecha = movement.Fecha;
                DbObject.Cantidad = movement.Cantidad;
                DbObject.Tipo = movement.Tipo;
                DbObject.Descripcion = movement.Descripcion;
                DbObject.UsuarioId = movement.UsuarioId;
                await _context.SaveChangesAsync();
                return "Movimiento actualizado";
            }
            catch (Exception ex)
            {
                return "Ha habido un error en la aplicación";
            }
        }
    }


}
