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
        protected SqlConnection dbConnection;

        public DALTafel()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public List<Tafel> GetAll()
        {
            // List
            List<Tafel> bestellingen = new List<Tafel>();

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            // Items inlezen
            while (reader.Read())
            {
                Tafel item = Readitem(reader);
                bestellingen.Add(item);
            }

            reader.Close();
            dbConnection.Close();

            return bestellingen;
        }

        public Tafel GetForID(int tafelId)
        {
            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tafel WHERE tafel_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", tafelId);
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

        private Tafel Readitem(SqlDataReader reader)
        {
            int tafel_id = (int)reader["tafel_id"];
            string status = (string)reader["status"];

            return new Tafel(tafel_id, status);

        }
    }
}
