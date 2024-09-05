using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7.Hybrid.Entidades;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Categoria { get; set; }

    public Producto(int id, string nombre, double precio, string categoria)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }

    public Producto()
    {
        Id = 0;
        Nombre = string.Empty;
        Precio = 0;
        Categoria = string.Empty;
    }
}
