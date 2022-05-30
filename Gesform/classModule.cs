using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Gesform
{
    class classModule
    {
        //public MySqlConnection connect = DB_connect.GetConnection();
       DB_connect connect = new DB_connect();
        //create a function to add a new Module to the database

        public bool addModule(string module, int horaire, int formateur)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO module(libelle,horaire,idFormateur) VALUES(@module, @horaire, @formateur)", connect.getconnection);

           
            command.Parameters.Add("@module", MySqlDbType.VarChar).Value = module;
            command.Parameters.Add("@horaire", MySqlDbType.Int32).Value = horaire;
            command.Parameters.Add("@formateur", MySqlDbType.Int32).Value = formateur;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }

        internal object ListFormateur(string v)
        {
            throw new NotImplementedException();
        }

        // to get Module table
        public DataTable getModulelist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // to get Module table
        public DataTable getFormateurlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable ListFormateur()
        {
            string selectQuery = "SELECT * FROM `formateur`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //create a function edit for Module
        public bool updateModule(int id, string module, int horaire, int formateur)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `module` SET `libelle`=@module,`horaire`=@horaire,`idFormateur`=@formateur WHERE  `idModule`= @id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@module", MySqlDbType.VarChar).Value = module;
            command.Parameters.Add("@horaire", MySqlDbType.Int32).Value = horaire;
            command.Parameters.Add("@formateur", MySqlDbType.Int32).Value = formateur;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }

        //Create a function to delete data
        //we need only id 
        public bool deleteModule(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `module` WHERE `idModule`=@id", connect.getconnection);

            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }

     

    }
}
