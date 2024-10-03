using System;
using Data.DataAccess;
using Entities;

namespace Bussiness.Services;

public class ProductosService
{
    private ProductosDataAccess _productosDataAccess;

    public ProductosService(ProductosDataAccess productosDataAccess)
    {
        _productosDataAccess = productosDataAccess;
    }

    public List<Producto> GetProductos()
    {
        return _productosDataAccess.GetProductos();
    }

    public List<Producto> GetProductosBy(string filtro)
    {
        return _productosDataAccess.GetProductosBy(filtro);
    }

    public Producto? GetOneProducto(int id)
    {
        return _productosDataAccess.GetOneProducto(id);
    }

    public Producto InsertProducto(Producto producto)
    {
        return _productosDataAccess.InsertProducto(producto);
    }

    public void UpdateProducto(int id, Producto producto)
    {
        _productosDataAccess.UpdateProducto(id, producto);
    }

    public void DeleteProducto(int id)
    {
        _productosDataAccess.DeleteProducto(id);
    }


    public void UpdateTotalProducto(int id)
    {
        var producto = GetOneProducto(id);
        if(producto != null)
        {
            producto.TotalProducto = producto.Stock * producto.PrecioVenta;
            _productosDataAccess.UpdateProducto(id, producto);
        }
    }

    public void UpdateTotalProductos()
    {
        var productos = GetProductos();
        foreach(var producto in productos)
        {
            producto.TotalProducto = producto.Stock * producto.PrecioVenta;
            _productosDataAccess.UpdateProducto(producto.Id, producto);
        }
    }

}
