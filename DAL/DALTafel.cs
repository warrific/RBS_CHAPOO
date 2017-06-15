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

            //  inlezen
            while (reader.Read())
            {

                Model.Tafel tafeloverzicht = new Model.Tafel();
                Model.Bestelling bestellingsoverzicht = new Model.Bestelling();
                tafeloverzicht.Id = reader.GetInt32(0);
                tafeloverzicht.Status = (TafelStatus)reader.GetInt32(1);
                //bestellingsoverzicht.id = reader.GetInt32(2);
                //bestellingsoverzicht.Status = (BestellingsStatus)Enum.Parse(typeof(BestellingsStatus),reader.GetString(3));

                restaurantoverzicht.Add(tafeloverzicht);
                //restaurantoverzicht.Add(bestellingsoverzicht);

            }

            reader.Close();
            dbConnection.Close();

            return restaurantoverzicht;
        }

        public Model.Tafel GetForID(int Id)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tafel WHERE tafel_id = @tafel_id", dbConnection);
            command.Parameters.AddWithValue("@tafel_id", Id);
            SqlDataReader reader = command.ExecuteReader();

            Model.Tafel item = null;

            if (reader.Read())
            {
                item = Readitem(reader);
            }

            reader.Close();
            dbConnection.Close();

            return item;
        }

        private Model.Tafel Readitem(SqlDataReader reader)
    {
            int tafel_id = (int)reader["tafel_id"];
            TafelStatus status = (TafelStatus)(int)reader["status"];
            return new Model.Tafel(tafel_id, status);

        }
    }
}
