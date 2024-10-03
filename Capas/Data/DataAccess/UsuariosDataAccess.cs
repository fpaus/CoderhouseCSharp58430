using Data.Context;
using Entities;

namespace Data.DataAccess;

public class UsuariosDataAccess
{
    private readonly CoderhouseContext _context;

    public UsuariosDataAccess(CoderhouseContext context)
    {
        _context = context;
    }

    public List<Usuario> GetUsuarios()
    {
        return _context.Usuarios.ToList();
    }

    public List<Usuario> GetUsuariosBy(string filtro)
    {
        return _context
            .Usuarios.Where(u =>
                u.Nombre.Contains(filtro) || u.Apellido.Contains(filtro) || u.Email.Contains(filtro)
            )
            .ToList();
    }

    public Usuario? GetOneUsuario(int id)
    {
        return _context.Usuarios.FirstOrDefault(u => u.Id == id);
    }

    public Usuario InsertUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return usuario;
    }

    public void UpdateUsuario(int id, Usuario usuario)
    {
        var usuarioToUpdate = GetOneUsuario(id);
        if (usuarioToUpdate != null)
        {
            usuarioToUpdate.Nombre = usuario.Nombre;
            usuarioToUpdate.Apellido = usuario.Apellido;
            usuarioToUpdate.NombreUsuario = usuario.NombreUsuario;
            usuarioToUpdate.Email = usuario.Email;
            usuarioToUpdate.Contraseña = usuario.Contraseña;
            _context.Usuarios.Update(usuarioToUpdate);
            _context.SaveChanges();
        }
    }

    public void DeleteUsuario(int id)
    {
        var usuarioToDelete = GetOneUsuario(id);
        if (usuarioToDelete != null)
        {
            _context.Usuarios.Remove(usuarioToDelete);
            _context.SaveChanges();
        }
    }
}
