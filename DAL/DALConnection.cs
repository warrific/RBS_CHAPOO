using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class DALConnection
    {
        public SqlConnection OpenConnectieDB()
        {
            string host = "194.171.20.101";
            string db = "RBS1617S_db06";
            string user = "RBS1617S_grp06";
            string password = "NwawwcGBA7";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = host;
            builder.UserID = user;
            builder.Password = password;
            builder.InitialCatalog = db;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();
            return connection;
        }

        public void sluitConnectieDB(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
