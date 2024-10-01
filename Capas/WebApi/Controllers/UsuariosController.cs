using Bussiness.Services;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ILogger<UsuariosController> _logger;
        private readonly UsuariosService _usuariosService;

        public UsuariosController(ILogger<UsuariosController> logger, UsuariosService usuariosService)
        {
            _logger = logger;
            _usuariosService = usuariosService;
        }

        [HttpGet(Name = "Get Usuarios")]
        public ActionResult<List<Usuario>> GetUsuarios()
        {

            return _usuariosService.GetUsuarios();
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetUsuario(int id)
        {
            _logger.LogInformation("Consultando por el producto con id {id}", id);
            var usuario = _usuariosService.GetOneUsuario(id);
            if (usuario is null)
            {
                return NotFound();
            }
            return usuario;
        }
    }
}
