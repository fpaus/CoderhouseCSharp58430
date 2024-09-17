using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Models;

public class Producto
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public decimal Costo { get; set; }
    public decimal PrecioVenta { get; set; }
    public string Categoria { get; set; }
}
