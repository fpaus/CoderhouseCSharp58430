using Clase12.Context;
using Clase12.Models;

namespace Clase12.Database;

public class UsuariosDataAccess
{
    private CoderhouseDbContext _context;

    public UsuariosDataAccess(CoderhouseDbContext context)
    {
        _context = context;
    }

    public List<Usuario> GetUsuarios()
    {
        return _context.Usuarios.ToList();
    }

    public List<Usuario> GetUsuariosBy(string filtro)
    {
        return _context.Usuarios
            .Where(Usuario => Usuario.NombreUsuario.Contains(filtro))
            .ToList();
    }

    public Usuario? GetOneUsuario(int id)
    {
        return _context.Usuarios.FirstOrDefault(Usuario => Usuario.Id == id);
    }

    public void UpdateUsuario(int id, Usuario Usuario)
    {
        Usuario? usuarioAEditar = GetOneUsuario(id);
        if (usuarioAEditar != null)
        {
            usuarioAEditar.Nombre = Usuario.Nombre ;
            usuarioAEditar.Apellido = Usuario.Apellido ;
            usuarioAEditar.NombreUsuario = Usuario.NombreUsuario ;
            usuarioAEditar.Contraseña = Usuario.Contraseña ;
            usuarioAEditar.Email = Usuario.Email;

            _context.SaveChanges();
        }
    }

    public void InsertUsuario(Usuario Usuario)
    {
        _context.Usuarios.Add(Usuario);
        _context.SaveChanges();
    }

    public void DeleteUsuario(int id)
    {
        Usuario? usuarioAEliminar = GetOneUsuario(id);
        if (usuarioAEliminar != null)
        {
            _context.Usuarios.Remove(usuarioAEliminar);
            _context.SaveChanges();
        }
    }
}
