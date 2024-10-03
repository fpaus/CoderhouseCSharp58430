using Data.DataAccess;
using Entities;

namespace Bussiness.Services;

public class UsuariosService
{
    private UsuariosDataAccess _usuariosDataAccess;

    public UsuariosService(UsuariosDataAccess usuariosDataAccess)
    {
        _usuariosDataAccess = usuariosDataAccess;
    }

    public List<Usuario> GetUsuarios()
    {
        return _usuariosDataAccess.GetUsuarios();
    }

    public Usuario? GetOneUsuario(int id)
    {
        return _usuariosDataAccess.GetOneUsuario(id);
    }

    public Usuario InsertUsuario(Usuario usuario)
    {
        return _usuariosDataAccess.InsertUsuario(usuario);
    }

    public void UpdateUsuario(int id, Usuario usuario)
    {
        _usuariosDataAccess.UpdateUsuario(id, usuario);
    }

    public void DeleteUsuario(int id)
    {
        _usuariosDataAccess.DeleteUsuario(id);
    }

    public List<Usuario> GetUsuariosBy(string filtro)
    {
        return _usuariosDataAccess.GetUsuariosBy(filtro);
    }
}
