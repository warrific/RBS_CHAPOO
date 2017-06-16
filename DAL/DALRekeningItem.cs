using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class DALRekeningItem
    {
        protected SqlConnection dbConnection;

        public DALRekeningItem()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            dbConnection = new SqlConnection(connString);
        }
        //dal properties db connection enzo

        public List<RekeningItem> GetRekening(int order_id)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT b.aantal, m.shortname, m.prijs, c.btw_tarief FROM Menuitem AS m INNER JOIN Bestelling_item AS b ON m.item_id = b.item_id INNER JOIN Menucategory as c ON m.category = c.id WHERE b.order_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", order_id);
            SqlDataReader reader = command.ExecuteReader();

            List<RekeningItem> rekening = new List<RekeningItem>();

            while (reader.Read())
            {
                rekening.Add(ReadItem(reader));
            }

            reader.Close();
            dbConnection.Close();

            return rekening;
        }

        private RekeningItem ReadItem(SqlDataReader reader)
        {
            return new RekeningItem((int)reader["aantal"], (string)reader["shortname"], (double)reader["prijs"] * (int)reader["aantal"], (double)reader["btw_tarief"]);
        }
    }
}