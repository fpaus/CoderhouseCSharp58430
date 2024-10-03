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
        public ActionResult<List<Producto>> GetProductos([FromQuery(Name = "filtro")] string? filtro)
        {
            if(filtro == null)
            {
                return _productosService.GetProductos();
            }
            return _productosService.GetProductosBy(filtro);
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

        [HttpPost]
        public ActionResult<Producto> CrearProducto([FromBody] Producto producto)
        {
            var productoCreado = _productosService.InsertProducto(producto);
            return CreatedAtAction(nameof(GetProducto), new { id = productoCreado.Id }, producto);
        }

        [HttpPut("{id}")]
        public ActionResult ModificarProducto([FromRoute(Name = "id")] int id, [FromBody] Producto producto)
        {
            _productosService.UpdateProducto(id, producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProducto([FromRoute(Name = "id")] int id)
        {
            _productosService.DeleteProducto(id);
            return NoContent();
        }

        [HttpPut("fix-total")]
        public ActionResult FixTotalProductos()
        {
            _productosService.UpdateTotalProductos();
            return NoContent();
        }

    }
}
