using Clase9.Maui.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9.Maui.Database;

public class Database
{
    private readonly string _connectionString;

    public Database(string connectionString)
    {
        _connectionString = connectionString; 
    }

    public List<Producto> GetProductos() 
    {
        DataSet dataSet = new DataSet();
        List<Producto> productos = new List<Producto>();
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Productos";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dataSet, "Productos");

            connection.Close();
        }
        foreach (DataRow row in dataSet.Tables["Productos"].Rows)
        {
            productos.Add(new Producto
            {
                Id = (int)row["Id"],
                Descripcion = (string)row["Descripcion"],
                Costo = (decimal)row["Costo"],
                PrecioVenta = (decimal)row["PrecioVenta"],
                Categoria = (string)row["Categoria"]
            });
        }
        return productos;
    }
}
