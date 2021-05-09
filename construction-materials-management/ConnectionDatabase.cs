using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace construction_materials_management
{
    class ConnectionDatabase
    {
        static MySqlConnection dataConnection;
        static MySqlCommand commandDatabase;
        static MySqlDataReader myReader;

        private static string server = "127.0.0.1";
        private static string port = "3306";
        private static string username = "root";
        private static string database = "material";
        private static string mySQLConnectionString = "datasource=" + server + ";port=" + port + ";username=" + username + ";password=;database=" + database;

        public static bool HasConnectingToDb()
        {
            try
            {
                if (dataConnection == null)
                {
                    dataConnection = new MySqlConnection(mySQLConnectionString);

                }
                dataConnection.Open();

                return true;
            }
            catch(Exception ex)
            {

                MessageBox.Show("Kết nối Database thất bại !!! ");
                return false;
            }
        }

        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            if (HasConnectingToDb())
            {
                try
                {

                    commandDatabase = new MySqlCommand(query, dataConnection);
                    commandDatabase.CommandTimeout = 60;

                    myReader = commandDatabase.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        dt.Load(myReader);
                    }

                    myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataConnection.Close();

            }

            return dt;
        }

        public static bool QueryData(string query)
        {
            bool result = true;
            if (HasConnectingToDb())
            {
                try
                {

                    commandDatabase = new MySqlCommand(query, dataConnection);
                    commandDatabase.CommandTimeout = 60;

                    myReader = commandDatabase.ExecuteReader();

                    myReader.Close();
                }
                catch (Exception ex)
                {
                    result = false;
                    MessageBox.Show(ex.Message);
                }

                dataConnection.Close();

            }

            return result;
        }
    }
}
