using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class MenuKaart_DAO
    {
        protected SqlConnection dbConnection;

        public MenuKaart_DAO()
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
