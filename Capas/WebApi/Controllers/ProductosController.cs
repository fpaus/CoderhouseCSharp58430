using Bussiness.Services;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly ProductosService _productosService;

        public ProductosController( ILogger<ProductosController> logger, ProductosService productosService) {
            _logger = logger;
            _productosService = productosService;
        }

        [HttpGet(Name = "Get Productos")]
        public ActionResult<List<Producto>> GetProductos()
        {

            return _productosService.GetProductos();
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> GetProducto(int id)
        {
            _logger.LogInformation("Consultando por el producto con id {id}", id);
            var producto = _productosService.GetOneProducto(id);
            if(producto is null)
            {
                return NotFound();
            }
            return producto;
        }
    }
}
