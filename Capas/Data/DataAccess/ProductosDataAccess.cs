using System;
using Data.Context;
using Entities;

namespace Data.DataAccess;

public class ProductosDataAccess
{
private readonly CoderhouseContext _context;

    public ProductosDataAccess(CoderhouseContext context)
    {
        _context = context;
    }

    public List<Producto> GetProductos()
    {
        return _context.Productos.ToList();
    }

    public List<Producto> GetProductosBy(string filtro)
    {
        return _context.Productos.Where(p => p.Categoria.Contains(filtro)).ToList();
    }

    public Producto? GetOneProducto(int id)
    {
        return _context.Productos.FirstOrDefault(p => p.Id == id);
    }

    public Producto InsertProducto(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
        return producto;
    }

    public void UpdateProducto(int id, Producto producto)
    {
        var productoToUpdate = GetOneProducto(id);
        if (productoToUpdate != null)
        {
            productoToUpdate.Descripcion = producto.Descripcion;
            productoToUpdate.Categoria = producto.Categoria;
            productoToUpdate.Stock = producto.Stock;
            productoToUpdate.PrecioCompra = producto.PrecioCompra;
            productoToUpdate.PrecioVenta = producto.PrecioVenta;
            productoToUpdate.TotalProducto = producto.TotalProducto;
            _context.SaveChanges();
        }
    }

    public void DeleteProducto(int id)
    {
        var productoToDelete = GetOneProducto(id);
        if (productoToDelete != null)
        {
            _context.Productos.Remove(productoToDelete);
            _context.SaveChanges();
        }
    }
}
