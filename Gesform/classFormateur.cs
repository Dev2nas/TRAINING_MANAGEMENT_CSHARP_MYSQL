using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Gesform
{
    class classFormateur
    {
        DB_connect connect = new DB_connect();
        //create a function to add a new formateur to the database

        public bool addFormateur(string nom, string prenom, string tel, string email)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO formateur(nomF,prenomF,emailF,telF) VALUES(@nom, @prenom, @tel, @email)", connect.getconnection);

            //@nom, @prenom, @tel, @email
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

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
        // to get formateur table
        public DataTable getFormateurlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create a function edit for formateur
        public bool updateFormateur(int id, string nom, string prenom, string tel, string email)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `formateur` SET `nomF`=@nom,`prenomF`=@prenom,`telF`=@tel,`emailF`=@email WHERE  `idFormateur`= @id", connect.getconnection);

            //@id ,@nom, @prenom, @tel, @email
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
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
        public bool deleteFormateur(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `formateur` WHERE `idFormateur`=@id", connect.getconnection);

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
