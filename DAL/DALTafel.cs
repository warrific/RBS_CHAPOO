using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class DALTafel
    {
       // void GetId() { }
       // void GetStatus() { }
       // public void GetAllTafels() { }


        protected SqlConnection dbConnection;

        public DALTafel()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Tafel> GetAll()
        {
            // List
            List<Tafel> restaurantoverzicht = new List<Tafel>();
          
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT Tafel.tafel_id, Tafel.status AS tafelstatus, Bestelling.status AS bestellingstatus FROM Tafel JOIN Bestelling on Tafel.tafel_id = Bestelling.tafel_id", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            Tafel tafel = null;

            //  inlezen
            while (reader.Read())
            {
                tafel = Readitem(reader);
                restaurantoverzicht.Add(tafel);
            }

            reader.Close();
            dbConnection.Close();

            return restaurantoverzicht;
        }

        public Tafel GetForID(int Id)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tafel WHERE tafel_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", Id);
            SqlDataReader reader = command.ExecuteReader();
            Tafel item = null;
            if (reader.Read())
            {
          //      item =(Tafel)Read("Id");
            }
            reader.Close();
            dbConnection.Close();

            return item;
        }


        public int GetID(int Id)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tafel WHERE tafel_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", Id);
            SqlDataReader reader = command.ExecuteReader();
            int item = 0;
            if (reader.Read())
            {
                item = (int)reader["tafel_id"];
            }
            reader.Close();
            dbConnection.Close();

            return item;
        }

        private Tafel Readitem(SqlDataReader reader)
    {
            int tafel_id = (int)reader["tafel_id"];
            Status_tafel status = (Status_tafel)(int)reader["status"];
            return new Tafel(tafel_id, status);

        }
    }
}
