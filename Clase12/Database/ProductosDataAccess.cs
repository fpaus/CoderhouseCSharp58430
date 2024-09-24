using System.Data;
using Clase12.Context;
using Clase12.Models;
using Microsoft.Data.SqlClient;
namespace Clase12.Database;

public class ProductosDataAccess
{
    private CoderhouseDbContext _context;

    public ProductosDataAccess(CoderhouseDbContext context)
    {
        _context = context;
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
        return _context.Productos.FirstOrDefault(producto => producto.Id == id);
    }

    public void UpdateProducto(int id, Producto producto)
    {
        Producto? productoAEditar = GetOneProducto(id);
        if (productoAEditar != null)
        {
            productoAEditar.Descripcion = producto.Descripcion;
            productoAEditar.Categoria = producto.Categoria;
            productoAEditar.Stock = producto.Stock;
            productoAEditar.PrecioCompra = producto.PrecioCompra;
            productoAEditar.PrecioVenta = producto.PrecioVenta;
            productoAEditar.TotalProducto = producto.TotalProducto;

            _context.SaveChanges();
        }
    }

    public void InsertProducto(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
    }

    public void DeleteProducto(int id)
    {
        Producto? productoAEliminar = GetOneProducto(id);
        if (productoAEliminar != null)
        {
            _context.Productos.Remove(productoAEliminar);
            _context.SaveChanges();
        }
    }
}
