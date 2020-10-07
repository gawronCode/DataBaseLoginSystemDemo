using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBaseLoginSystemDemo
{
    class DataBaseClient
    {
        private readonly SqlConnection _sqlConnection = new SqlConnection();
        private readonly SqlCommand _sqlCommand = new SqlCommand();
        private readonly String _connectionString =
            "Data Source=LAPTOP-FM0P9J9A;Initial Catalog=LoginSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool AddAccount(String firstName, String lastName, String email, String nick, String userPassword, out String message)
        {
            string queryString = "INSERT INTO Person (firstName, lastName, email, nick, userPassword) VALUES ('" + firstName + "', '" + lastName + "', '" + email.ToLower() + "', '" + nick + "', '" + userPassword + "');";
            const string emailIsTaken = "Entered Email is not unique";
            const string nickIsTaken = "Entered Nick is not unique";
            const string emailAndNickIsTaken = "Entered Email and Nick are not unique";
            const string defaultMessage = "Account created successfully";
            const string errorMessages = "Error, unable to create account";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                bool emailTaken = false;
                bool nickTaken = false;
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    message = defaultMessage;
                    return true;
                }
                catch (SqlException exception)
                {
                    GetErrorMessage(exception);
                    emailTaken = Exist("Email",email.ToLower());
                    nickTaken = Exist("Nick" ,nick);
                }

                if (emailTaken && nickTaken) {message = emailAndNickIsTaken; return false;}
                if (emailTaken) {message = emailIsTaken; return false;}
                if (nickTaken) {message = nickIsTaken; return false;}

                message = errorMessages;
                return false;
            }
        }
        
        public bool LogIn(String nick, String userPassword, out String message)
        {
            string queryString = "SELECT userPassword From Person WHERE nick = '" + nick + "';";
            const string userNotFound = "User not found";
            const string wrongPassword = "Wrong password";
            const string defaultMessage = "Logged in successfully";
            const string errorMessage = "Ups, something went wrong";

            if (!Exist("Nick", nick))
            {
                message = userNotFound;
                return false;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader[0].ToString().Equals(userPassword))
                        {
                            message = defaultMessage;
                            reader.Close();
                            return true;
                        }
                        else
                        {
                            message = wrongPassword;
                            reader.Close();
                            return false;
                        }
                    }
                }
                catch (SqlException exception)
                {
                    GetErrorMessage(exception);
                }

                message = errorMessage;
                return false;
            }
        }

        private bool Exist(String fieldName, String fieldContent)
        {
            string queryString = "SELECT " + fieldName + " FROM Person WHERE " + fieldName + " = '" + fieldContent + "';";
            Console.WriteLine(queryString);
            bool taken = false;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) taken = true;
                reader.Close();
            }
            return taken;

        }

        private String GetErrorMessage(SqlException exception)
        {
            StringBuilder errorMessages = new StringBuilder();
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                errorMessages.Append("Index #" + i + "\n" +
                                     "Message: " + exception.Errors[i].Message + "\n" +
                                     "LineNumber: " + exception.Errors[i].LineNumber + "\n" +
                                     "Source: " + exception.Errors[i].Source + "\n" +
                                     "Procedure: " + exception.Errors[i].Procedure + "\n");
            }
            Console.WriteLine(errorMessages.ToString());
            return errorMessages.ToString();
        }

    }
}
