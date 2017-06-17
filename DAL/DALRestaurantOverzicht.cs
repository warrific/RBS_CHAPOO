using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class DALRestaurantOverzicht
    {
        protected SqlConnection dbConnection;    
        
        public DALRestaurantOverzicht()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

      
        // informatie over de statussen toevoegen in database voor de eigenaar.
        public void AddAll(List<string> status_lijst)
        {
            // Connectie opzetten
            int tafel_id = 0;
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT code FROM Medewerker WHERE code = @code", dbConnection);
            command.Parameters.AddWithValue("@code", status_lijst);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
               tafel_id = (int)reader["tafel_id"];
               
            }

            reader.Close();
            dbConnection.Close();
        }
    
    }
}
