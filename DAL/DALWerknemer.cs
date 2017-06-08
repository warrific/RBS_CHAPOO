using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class DALWerknemer
    {
        //void GetId() { }
        //void getFunctie() { }
        //void GetNaam() { }
        //void GetWachtwoord() { }
        //public void GetAllWerknemers() { }

        protected SqlConnection dbConnection;
        public DALWerknemer()
        {
            string connString = ConfigurationManager
            .ConnectionStrings["DBConnectionString"]
            .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Werknemer> GetAll()
        {
            dbConnection.Open();
            SqlCommand command =
            new SqlCommand("SELECT * FROM Werknemers", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Werknemer> werknemers = new List<Werknemer>();
            while (reader.Read())
            {
                Werknemer werknemer = ReadWerknemer(reader);
                werknemers.Add(werknemer);
            }
            reader.Close();
            dbConnection.Close();
            return werknemers;
        }

        public Werknemer GetForId(int Id)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
            "SELECT * FROM Werknemers WHERE Id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", Id);
            SqlDataReader reader = command.ExecuteReader();
            Werknemer werknemer = null;
            if (reader.Read())
                werknemer = ReadWerknemer(reader);
            reader.Close();
            dbConnection.Close();
            return werknemer;
        }

        private Werknemer ReadWerknemer(SqlDataReader reader)
        {
            // haal gegevens van alle velden op
            int id = (int)reader["id"];
            Functie functie = (Functie)reader["functie"];
            string naam = (string)reader["naam"];
            string wachtwoord = (string)reader["code"];

            // return nieuw Werknemer-object
            return new Werknemer(id, functie, naam, wachtwoord);
        } 
    }
}
