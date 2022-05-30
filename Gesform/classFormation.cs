using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gesform
{
    class classFormation
    {
        //public MySqlConnection connect = DB_connect.GetConnection();
        DB_connect connect = new DB_connect();
        //create a function to add a new Module to the database

        public bool addFormation(string theme,string niveau,string lieu,int nbPlace,int prix,DateTime dateDebut,DateTime dateFin, int module,int salle, int formateur)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO formation(theme,niveau,lieu,Nb_place,prix,dateDebut,dateFin,idModule,idSalle,idFormateur) VALUES(@theme, @niveau, @lieu,@nbPlace,@prix,@dateDebut,@dateFin,@module,@salle,@formateur)", connect.getconnection);


            command.Parameters.Add("@theme", MySqlDbType.VarChar).Value = theme;
            command.Parameters.Add("@niveau", MySqlDbType.VarChar).Value = niveau;
            command.Parameters.Add("@lieu", MySqlDbType.VarChar).Value = lieu;
            command.Parameters.Add("@nbPlace", MySqlDbType.Int32).Value = nbPlace;
            command.Parameters.Add("@prix", MySqlDbType.Int32).Value = prix;
            command.Parameters.Add("@dateDebut", MySqlDbType.DateTime).Value = dateDebut;
            command.Parameters.Add("@dateFin", MySqlDbType.DateTime).Value = dateFin;
            command.Parameters.Add("@module", MySqlDbType.Int32).Value = module;
            command.Parameters.Add("@salle", MySqlDbType.Int32).Value = salle;
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
        public bool updateFormation(int id, string theme, string niveau, string lieu, int nbPlace, int prix, DateTime dateDebut, DateTime dateFin, int module, int salle, int formateur)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `formation` SET `theme`=@theme,`niveau`=@niveau,`lieu`=@lieu,`Nb_place`=@nbPlace,`prix`=@prix,`dateDebut`=@dateDebut,`dateFin`=@dateFin,`idModule`=@module,`idSalle`=@,`idFormateur`=@formateur WHERE  `idFormation`= @id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@theme", MySqlDbType.VarChar).Value = theme;
            command.Parameters.Add("@niveau", MySqlDbType.VarChar).Value = niveau;
            command.Parameters.Add("@lieu", MySqlDbType.VarChar).Value = lieu;
            command.Parameters.Add("@nbPlace", MySqlDbType.Int32).Value = nbPlace;
            command.Parameters.Add("@prix", MySqlDbType.Int32).Value = prix;
            command.Parameters.Add("@dateDebut", MySqlDbType.DateTime).Value = dateDebut;
            command.Parameters.Add("@dateFin", MySqlDbType.DateTime).Value = dateFin;
            command.Parameters.Add("@module", MySqlDbType.Int32).Value = module;
            command.Parameters.Add("@salle", MySqlDbType.Int32).Value = salle;
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
        public bool deleteFormation(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `formation` WHERE `idFormation`=@id", connect.getconnection);

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

            public DataTable getFormationlist(MySqlCommand command)
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
        public DataTable ListModule()
        {
            string selectQuery = "SELECT * FROM `module`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
            public DataTable ListSalle()
            {
                string selectQuery = "SELECT * FROM `salles`";
                MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                return table;
            }
        }
    }
