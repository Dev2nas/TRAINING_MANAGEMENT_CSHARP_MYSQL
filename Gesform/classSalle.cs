using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Gesform
{
    class classSalle
    {
        //public MySqlConnection connect = DB_connect.GetConnection();
       DB_connect connect = new DB_connect();
        //create a function to add a new Module to the database

        public bool addSalle(string salle, int formateur)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO salles(libelle,idFormateur) VALUES(@salle, @formateur)", connect.getconnection);

           
            command.Parameters.Add("@salle", MySqlDbType.VarChar).Value = salle;
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

        // to get salle table
        public DataTable getSallelist(MySqlCommand command)
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
            //string selectQuery = "SELECT * FROM `formateur` , `salles` WHERE salles.idFormateur=formateur.idFormateur";
            string selectQuery = "SELECT * FROM `formateur`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //create a function edit for Module
        public bool updateSalle(int id, string salle, int formateur)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `salles` SET `libelle`=@salle,`idFormateur`=@formateur WHERE  `idSalle`= @id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@salle", MySqlDbType.VarChar).Value = salle;
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
        public bool deleteSalle(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `salles` WHERE `idSalle`=@id", connect.getconnection);

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
