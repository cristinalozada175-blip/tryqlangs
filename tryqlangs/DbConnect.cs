using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryqlangs
{
    internal class DbConnect
    {
        public class DBConnect
        {
            private MySqlConnection connection = new MySqlConnection(
                "server=sql12.freesqldatabase.com;user=sql12825429;database=sql12825429;port=3306;password=LG8bLlXZXg;"
            );

            public MySqlConnection Connection => connection;
            
            public void Open()
            {
                try { if (connection.State != System.Data.ConnectionState.Open) connection.Open(); }
                catch (System.Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
            }

            public void Close()
            {
                try { if (connection.State != System.Data.ConnectionState.Closed) connection.Close(); }
                catch (System.Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
            }
        }
    }
}
