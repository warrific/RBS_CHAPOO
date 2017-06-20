﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class Login_DAO
    {
        protected SqlConnection dbConnection;    
        
        public Login_DAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);

        }

        public int GetPassword(string invoer_wachtwoord)
        {
            //Connectie opzetten;
             int code = 0;
             dbConnection.Open();
             SqlCommand command = new SqlCommand("SELECT code FROM Medewerker WHERE code = @code", dbConnection);
             command.Parameters.AddWithValue("@code", invoer_wachtwoord);
             SqlDataReader reader = command.ExecuteReader();
             if (reader.Read())
             {
                code = (int)reader["code"];
              }

              reader.Close();
              dbConnection.Close();

              return code;
        }


    }
}