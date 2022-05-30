using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Gesform
{
    class DB_connect
    {
        //to create connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=gesform");

        public static MySqlConnection GetComboxConnexion()
        {

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=gesform;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            // MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=gesform");
            try
            {
                cnn.Open();

                return cnn;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MySqlConnection GetConnection()
        {
            return connect;
        }
        //to get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to Open conncetion
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //Create a fuction to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}