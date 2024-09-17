// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;

string connectionString = "Data Source=10.0.2.2;Initial Catalog=Coderhouse;User ID=sa;Password=Str0ngPassword;TrustServerCertificate=True";

Console.WriteLine("Conectado");
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    Console.WriteLine("Que id queres buscar?");
    int id = int.Parse(Console.ReadLine());
    using (SqlCommand command = new SqlCommand( "SELECT * FROM Personas where id = @id", connection ))
    {
        SqlParameter parameter = new SqlParameter();
        parameter.ParameterName = "@id";
        parameter.SqlDbType = SqlDbType.Int;
        parameter.Value = id;
        
        command.ExecuteNonQuery();

        using (SqlDataReader reader = command.ExecuteReader()) 
        {
            while (reader.Read()) 
            {
                Console.WriteLine($"Nombre: {reader["Nombre"]} Password: {reader["Password"]}");
            }
        }
    }
    connection.Close();
}


Console.WriteLine("Desconectado");

DataSet dataSet = new DataSet();
using (SqlConnection connection = new SqlConnection(connectionString))
{
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Personas", connection);
    //adapter.SelectCommand.Parameters.Add();
    connection.Open();

    adapter.Fill(dataSet, "Personas");

    connection.Close();


}
foreach (DataRow row in dataSet.Tables["Personas"].Rows)
{
    Console.WriteLine($"Id: {row["Id"]}, nombre: {row["Nombre"]}");
}