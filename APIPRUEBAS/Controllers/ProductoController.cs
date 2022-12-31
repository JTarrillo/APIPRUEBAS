using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using APIPRUEBAS.Models;
using Microsoft.AspNetCore.Http;



namespace APIPRUEBAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public readonly DBAPIContext _dbcontext;

        public ProductoController(DBAPIContext _context)
        {
            _dbcontext = _context;
        }


        [HttpGet]
        [Route("Lista")]

        public IActionResult Lista()
        {

            List<Producto> lista = new List<Producto>();

            try
            {
                lista = _dbcontext.Productos.ToList();


                return StatusCode(StatusCodes.Status200OK, new {mensaje = "ok", response = lista});
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
                throw;
            }
        }

    }
}
