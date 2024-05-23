using Npgsql;
using SneakerWebApp3BHWII.Models;

namespace SneakerWebApp3BHWII.Repositories;

public class SchuhRepository
{

    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=Sneakerverkauf;User Id=dbuser;Password=lorenz;";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        
        connection.Open();
        return connection;
    }
    public List<Schuh> GetAllSchuhe()
    {
        NpgsqlConnection myconnection = ConnectToDB();
        
        using NpgsqlCommand cmd = new NpgsqlCommand("Select * from Schuh", myconnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();

        List<Schuh> schuh = new List<Schuh>();
        while (reader.Read())
        {
            Schuh newSchuh = new Schuh();
            newSchuh.sku = (string)reader["Sku"];
            newSchuh.bezeichnung = (string)reader["Bezeichnung"];
            newSchuh.groesse = (string)reader["Groesse"];
            newSchuh.preis = (double)reader["Preis"];
            newSchuh.modell_id = (int)reader["Modell_ID"];
            
            schuh.Add(newSchuh);
        }
        
        
        myconnection.Close();
        return schuh;

    }

    public void CreateSchuh(Schuh schuh)
    {
        
    }

    public void DeleteSchuh(string sku)
    {
        
        
    }

    public void UpdateSchuh(Schuh schuh)
    {
        
    }
    
    
    
    
    
    
}