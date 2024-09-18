namespace Clase8.Models;

public class Cliente
{
    public long Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public short Edad { get; set; }


    public Cliente(long id, string nombre, string direccion, short edad)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Edad = edad;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Cliente cliente)
        {
            return Id.Equals(cliente.Id);
        }
        return false;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Nombre}, Dirección: {Direccion}, Edad: {Edad}";
    }
}
