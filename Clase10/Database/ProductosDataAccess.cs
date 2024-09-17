using System.Data;
using Clase10.Models;
using Microsoft.Data.SqlClient;
namespace Clase10.Database;

public class ProductosDataAccess
{
    private readonly string _connectionString;

    public ProductosDataAccess(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Producto> GetProductos()
    {
        DataSet dataSet = new DataSet();
        List<Producto> productos = new List<Producto>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
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

    public Producto? GetOneProducto(int id)
    {
        DataSet dataSet = new DataSet();
        string query = "SELECT * FROM dbo.Productos WHERE Id = @Id";
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            adapter.SelectCommand.Parameters.AddWithValue("@Id", id);
            connection.Open();
            
            adapter.Fill(dataSet, "Productos");
            connection.Close ();
        }
        if (dataSet.Tables["Productos"].Rows.Count == 0)
        {
            return null;
        }
        DataRow row = dataSet.Tables["Productos"].Rows[0];
        Producto producto = new Producto
        {
            Id = (int)row["Id"],
            Descripcion = (string)row["Descripcion"],
            Costo = (decimal)row["Costo"],
            PrecioVenta = (decimal)row["PrecioVenta"],
            Categoria = (string)row["Categoria"]
        };
        return producto;
    }

    public int InsertProducto(Producto producto) {
        string insertQuery = @"INSERT INTO Productos
                               (Descripcion, Costo, PrecioVenta, Categoria)
                               VALUES
                               (@Descripcion, @Costo, @PrecioVenta, @Categoria); SELECT @@IDENTITY";
        int id;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        { 
            
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            command.Parameters.AddWithValue("@Costo", producto.Costo);
            command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
            command.Parameters.AddWithValue("@Categoria", producto.Categoria);

            connection.Open();
            id = command.ExecuteNonQuery();
            connection.Close();
        }
        return id;
    }

    public void UpdateProducto(int id, Producto producto) {
        string updateQuery = @"UPDATE Productos
            SET Descripcion = @Descripcion,
            Costo = @Costo,
            PrecioVenta = @PrecioVenta,
            Categoria = @Categoria
            WHERE Id = @Id";
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            SqlCommand command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            command.Parameters.AddWithValue("@Costo", producto.Costo);
            command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
            command.Parameters.AddWithValue("@Categoria", producto.Categoria);
            
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void DeleteProducto(int id) {
        string deleteQuery = @"DELETE FROM Productos
            WHERE Id = @Id";
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
