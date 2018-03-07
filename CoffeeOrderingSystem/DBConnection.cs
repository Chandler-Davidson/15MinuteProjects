using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CoffeeOrderingSystem
{
    public class DBConnection
    {
        private static readonly DBConnection _instance = new DBConnection();
        public static DBConnection Instance { get { return _instance; } }
        private static MySqlConnection sqlConnection;
        private string databaseName = string.Empty;

        DBConnection()
        {
            try
            {
                string connDetails = string.Format("Server=localhost; database={0}; UID=UserName; password=your password", databaseName);
                sqlConnection = new MySqlConnection(connDetails);
                sqlConnection.Open();
            }
            catch(MySqlException e)
            {
                Console.WriteLine("{0}: Error establishing connection.", e);
            }
		}

        public void Open() => sqlConnection.Open();
        public void Close() => sqlConnection.Close();

        public void AddOrder()
        {
            
        }
    }
}
