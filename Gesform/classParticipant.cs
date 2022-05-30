using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gesform
{
    class classParticipant
    {
        //public MySqlConnection connect = DB_connect.GetConnection();
        DB_connect connect = new DB_connect();
        //create a function to add a new Module to the database

        public bool addParticipant(string nom,string prenom,string type_participant,string tel,string email,int idFormation, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO participant(nomP,prenomP,type_Participant,telP,emailP,dateInscire,idFormation) VALUES(@nom,@prenom,@type_participant,@tel,@email,@date,@idFormation)", connect.getconnection);
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@type_participant", MySqlDbType.VarChar).Value = type_participant;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@idFormation", MySqlDbType.Int32).Value = idFormation;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;

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

        // to get Participant table
        public DataTable getParticipantlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a function edit for Module
        public bool updateParticipant(int id, string nom, string prenom, string type_participant, string tel, string email, int idFormation, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `participant` SET `nomP`=@nom,`prenomP`=@prenom,`type_Participant`=@type_participant,`telP`=@tel,`emailP`=@email,`idFormation`=@idFormation,`dateInscire`=@date WHERE  `idParticipant`= @id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = nom;
            command.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = prenom;
            command.Parameters.Add("@type_participant", MySqlDbType.VarChar).Value = type_participant;
            command.Parameters.Add("@tel", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@idFormation", MySqlDbType.Int32).Value = idFormation;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date;
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

        public DataTable ListFormateur()
        {
            string selectQuery = "SELECT * FROM `formation`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //Create a function to delete data
        //we need only id 
        public bool deleteParticipant(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `participant` WHERE `idParticipant`=@id", connect.getconnection);

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
