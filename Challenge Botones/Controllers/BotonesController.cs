using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Challenge_Botones.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge_Botones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotonesController : ControllerBase
    {
        // Utilizamos el contexto dentro del controlador
        private readonly ChallengeBotonesContext _dbcontext;

        // Creamos el constructor
        public BotonesController(ChallengeBotonesContext context)
        {
            _dbcontext = context;
        }

        // Creamos el método GET para obtener la lista de botones de la tabla
        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Botones> lista = await _dbcontext.Botones.OrderBy(c => c.IdBoton).ToListAsync();

            return StatusCode(StatusCodes.Status200OK, lista);

        }

        // Creamos el método POST para agregar un botón a la lista de botones
        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar([FromBody] Botones request)
        {
           await _dbcontext.Botones.AddAsync(request);
           await _dbcontext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "Ok");

        }

        // Creamos el método PUT para editar el contador según las veces que se presionó el botón.
        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> Editar([FromBody] Botones request)
        {
            _dbcontext.Botones.Update(request);
            await _dbcontext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "Ok");

        }

        // Creamos el método DELETE para eliminar un botón de la lista.
        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            Botones boton = _dbcontext.Botones.Find(id);

            _dbcontext.Botones.Remove(boton);
            await _dbcontext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "Ok");

        }

    }
}
