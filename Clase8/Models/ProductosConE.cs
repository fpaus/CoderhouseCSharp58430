namespace Clase8.Models;

public class ProductosConE
{
    private List<Producto> _productos;

    public ProductosConE() { 
        _productos = [];
    }

    public void InsertarEnLista(Producto[] productos)
    {
        foreach (Producto producto in productos)
        {
            // Si la descripcion contiene una E
            if (producto.Descripcion.Contains('E', StringComparison.CurrentCultureIgnoreCase))
            {
                _productos.Add(producto);
            }
        }
    }

    public List<Producto> GetLista()
    {
        return _productos; 
    }

    public void LimpiarLista()
    {
        _productos.Clear();
    }
}
