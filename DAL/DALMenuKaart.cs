using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using System.Data;
using System.Data.SqlTypes;

namespace DAL
{
    public class DALMenuKaart
    {
        protected SqlConnection dbConnection;

        public DALMenuKaart()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }

        public int GetTypeForID(int menuId)
        {
            int categorie_id = 0;

            // Connectie opzetten
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM MenuKaart WHERE menu_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", menuId);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                categorie_id = (int)reader["subcategorie"];
            }

            reader.Close();
            dbConnection.Close();

            return categorie_id;
        }
    }
}
