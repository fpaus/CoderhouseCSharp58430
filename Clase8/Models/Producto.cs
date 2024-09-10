namespace Clase8.Models;

public class Producto
{
    public int Codigo { get; set; }
    public string Descripcion { get; set; }

    public Producto(int codigo, string descripcion)
    {
        Codigo = codigo;
        Descripcion = descripcion;
    }
}
