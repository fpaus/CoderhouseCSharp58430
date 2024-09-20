using System.Data;
using Clase11.Contexts;
using Clase11.Models;
using Microsoft.Data.SqlClient;
namespace Clase11.Database;

public class ProductosDataAccess
{
    private CoderhouseDbContext _context;

    public ProductosDataAccess(CoderhouseDbContext context)
    {
        _context = context;
    }
    public void UpdateProducto(int id, Producto producto)
    {
        throw new NotImplementedException();
    }
    public List<Producto> GetProductos()
    {
        return _context.Productos.ToList();
    }

    public List<Producto> GetProductosBy(string filtro)
    {
        return _context.Productos
            .Where(producto => producto.Categoria.Contains(filtro))
            .ToList();
    }

    public Producto? GetOneProducto(int id)
    {
        throw new NotImplementedException();
    }

    public int InsertProducto(Producto producto) {
        throw new NotImplementedException();
    }

    public void DeleteProducto(int id) {
        throw new NotImplementedException();
    }
}
