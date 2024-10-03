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
        public ActionResult<List<Usuario>> GetUsuarios([FromQuery(Name = "filtro")] string? filtro)
        {
            if(filtro == null)
            {
                return _usuariosService.GetUsuarios();
            }
            return _usuariosService.GetUsuariosBy(filtro);
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetUsuario([FromRoute(Name = "id")] int id)
        {
            _logger.LogInformation("Consultando por el producto con id {id}", id);
            var usuario = _usuariosService.GetOneUsuario(id);
            if (usuario is null)
            {
                return NotFound();
            }
            return usuario;
        }

        [HttpPost]
        public ActionResult<Usuario> CrearUsuario([FromBody] Usuario usuario) {
            var usuarioCreado = _usuariosService.InsertUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = usuarioCreado.Id }, usuario);
        }

        [HttpPut("{id}")]
        public ActionResult ModificarUsuario([FromRoute(Name = "id")] int id, [FromBody] Usuario usuario) { 
            _usuariosService.UpdateUsuario(id, usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUsuario([FromRoute(Name = "id")] int id)
        {
            _usuariosService.DeleteUsuario(id);
            return NoContent();
        }
    }
}
