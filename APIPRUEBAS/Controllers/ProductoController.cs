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
    }
}
