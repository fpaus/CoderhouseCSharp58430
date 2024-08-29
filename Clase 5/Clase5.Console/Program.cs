using Clase5.Clases;

namespace Clase5.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Producto miProducto = new Producto(
            //    1,
            //    "Shampoo",
            //    950.0,
            //    1300.0,
            //    "Aseo personal"
            //    );


            //if (miProducto.TienePrecioDeVentaCargado())
            //{ Console.WriteLine("Tiene precio de venta"); }
            //else
            //{ Console.WriteLine("No tiene precio de venta"); }

            //miProducto.PrecioDeVenta = 125;
            //Console.WriteLine($"El nuevo precio de compra es {miProducto.PrecioDeVenta}");

            //Console.WriteLine(miProducto);


            Usuario usuario = new Usuario(
                "Fabrizio",
                "Pauselli",
                123456,
                "fabriziopauselli@gmail.com",
                32,
                "CABA"
                );
            Console.WriteLine($"Mi nombre completo es {usuario.NombreCompleto()}");
            Console.WriteLine($"Soy mayor de edad? {usuario.EsMayorDeEdad()}");
        }
    }
}
