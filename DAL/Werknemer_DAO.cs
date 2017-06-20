using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class Werknemer_DAO
    {
        //void GetId() { }
        //void getFunctie() { }
        //void GetNaam() { }
        //void GetWachtwoord() { }
        //public void GetAllWerknemers() { }

        protected SqlConnection dbConnection;
        public Werknemer_DAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Model.Werknemer> GetAll()
        {
            dbConnection.Open();
            SqlCommand command =
            new SqlCommand("SELECT * FROM Medewerker", dbConnection);
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

        public List<Model.Werknemer> GetAllBediening()
        {
            dbConnection.Open();
            SqlCommand command =
            new SqlCommand("SELECT * FROM Medewerker WHERE  functie=Bediening ", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<Werknemer> bediening = new  List<Werknemer>();

            while (reader.Read())
            {
                Werknemer werknemer = ReadWerknemer(reader);
                bediening.Add(werknemer);
            }

            reader.Close();
            dbConnection.Close();
            return bediening;
        }

        public Model.Werknemer GetWerknemer(int code)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Medewerker WHERE code = @code", dbConnection);
            command.Parameters.AddWithValue("@code", code);
            SqlDataReader reader = command.ExecuteReader();

            Werknemer werknemer = null;

            if (reader.Read())
            {
                werknemer = ReadWerknemer(reader);
            }

            reader.Close();
            dbConnection.Close();
            return werknemer;
        }

        public Werknemer GetForID(int Id)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Medewerker WHERE persoon_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", Id);
            SqlDataReader reader = command.ExecuteReader();

            Werknemer werknemer = null;

            if (reader.Read())
            {
                werknemer = ReadWerknemer(reader);
            }

            reader.Close();
            dbConnection.Close();
            return werknemer;
        }

        public int GetLastId()
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("SELECT MAX(persoon_id) FROM Medewerker", dbConnection);

            int id = 0;

            id = (int)command.ExecuteScalar();

            dbConnection.Close();

            return id;
        }

        public void ToevoegenWerknemer(int id, string naam, string functie, int code)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Medewerker VALUES (@Id, @Naam, @Functie, @Code)", dbConnection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Naam", naam);
            command.Parameters.AddWithValue("@Functie", functie);
            command.Parameters.AddWithValue("@Code", code);
            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public void WijzigenWerknemer(int id, string naam, string functie)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE Medewerker SET naam = @Naam, functie = @Functie WHERE persoon_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Naam", naam);
            command.Parameters.AddWithValue("@Functie", functie);
            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public void VerwijderenWerknemer(int id)
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Medewerker WHERE persoon_id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = command.ExecuteReader();

            reader.Close();
            dbConnection.Close();
        }

        public List<int> GetCodes()
        {
            dbConnection.Open();

            List<int> codes = new List<int>();

            SqlCommand command = new SqlCommand("SELECT code FROM Medewerker", dbConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int code = ((int)reader["code"]);
                codes.Add(code);
            }

            reader.Close();
            dbConnection.Close();

            return codes;
        }

        private Werknemer ReadWerknemer(SqlDataReader reader)
        {
            // haal gegevens van alle velden op
            int id = (int)reader["persoon_id"];
            Functie functie = (Functie)Enum.Parse(typeof(Functie), (string)reader["functie"]);
            string naam = (string)reader["naam"];
            string wachtwoord = ((int)reader["code"]).ToString();

            // return nieuw Werknemer-object
            return new Werknemer(id, functie, naam, wachtwoord);
        } 
    }
}
