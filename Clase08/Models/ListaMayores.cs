namespace Clase8.Models;

public class ListaMayores
{
    private List<Cliente> _clientesMayores;

    public ListaMayores() {
        _clientesMayores = [];
    }

    public List<Cliente> GetLista()
    {
        return _clientesMayores;
    }

    public void InsertarEnLista(Cliente[] clientes)
    {
        foreach (Cliente cliente in clientes)
        {
            //Si es mayor de edad
            if (cliente.Edad >= 18) { 
                _clientesMayores.Add(cliente);
            }
        }
    }

    public bool BorrarCliente(Cliente cliente)
    {
        if (!_clientesMayores.Contains(cliente))
        {
            return false;
        }
        return _clientesMayores.Remove(cliente);
    }

    public int Buscar(Cliente cliente)
    {
        return _clientesMayores.IndexOf(cliente);
    }

    public bool Modificar(Cliente actual, Cliente modificado)
    {
        int indice = Buscar(actual);
        if (indice < 0) { 
            return false;
        }
        _clientesMayores[indice] = modificado;
        return true;
    }

    public void limpiarLista()
    {
        _clientesMayores.Clear();
    }

    public void OrdenarLista()
    {
        _clientesMayores.Sort(CompararClientes);
    }

    private int CompararClientes(Cliente a, Cliente b)
    {
        return a.Id.CompareTo(b.Id);
    }
}
