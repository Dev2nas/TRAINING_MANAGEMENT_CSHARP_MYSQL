using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Gesform
{
    public partial class Form_modules : Form
    {
     //public MySqlConnection conn = DB_connect.GetConnection();
        DB_connect conn = new DB_connect();
        classModule Module = new classModule();
        public Form_modules()
        {
            InitializeComponent();
            showTable();
            Formateur_Load();
            //showFormateur();
            getFormateurList();
        }

        //create a function to verify
        bool verify()
        {
            if ((input_module.Text == "") || (input_horaire.Text == "") ||
                (input_formateur.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void formModule_Load(object sender, EventArgs e)
        {
            showTable();
            showFormateur();
        }
        public void showTable()
        {
            dataGridView1.DataSource = Module.getModulelist(new MySqlCommand("SELECT * FROM `module`"));
        }

        public void showFormateur()
        {
            try
            {
                MySqlConnection connect = DB_connect.GetComboxConnexion();
                //DB_connect connect = new DB_connect();
                //string Query = "select distinct nomF  FROM `formateur` f,`module` m WHERE f.idFormateur=m.idFormateur ";
                // Query1 = "select distinct idFormateur  FROM `formateur`";
                string Query = "select distinct nomF  FROM `formateur` , `module` WHERE formateur.idFormateur=module.idFormateur";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connect);
               // MySqlCommand MyCommand2 = new MySqlCommand(Query1, connect);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                    string name = MyReader2.GetString(0);
                    this.input_formateur.Items.Add(name);
                }
                MyReader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        /*public void showFormateur()
        {
           // input_formateur.DataSource = Module.getFormateurlist(new MySqlCommand("SELECT nomF,prenomF FROM `formateur` f,`module` m WHERE f.idFormateur=m.idFormateur"));
            input_formateur.DataSource = Module.getFormateurlist(new MySqlCommand("SELECT nomF,prenomF FROM `formateur`"));
            //input_formateur.DataSource = Module.getFormateurlist(new MySqlCommand("SELECT * FROM `module`"));
        }*/

        private void Btn_updateModule_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form_Modules());
            Gestion_modules Module = new Gestion_modules();
            Module.Show();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            input_module.Clear();
            input_horaire.Clear();
        }

        private void Formateur_Load()
        {
            input_formateur.DataSource = Module.ListFormateur();
            input_formateur.DisplayMember = "nomF";
            input_formateur.ValueMember = "idFormateur";

            //me permet de voir la liste des formateur
            getFormateurList();

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }


        private void getFormateurList()
        {
            dataGridView1.DataSource = Module.ListFormateur();
        }

        private void AddModule_Click(object sender, EventArgs e)
        {
            // add new formateur
            string module = input_module.Text;
            int horaire = Convert.ToInt32(input_horaire.Text);
            int formateur = Convert.ToInt32(input_formateur.SelectedValue.ToString());
            // int formateur = Convert.ToInt32(input_formateur.Text);

            if (verify())
            {
                try
                {

                    if (Module.addModule(module, horaire, formateur))
                    {
                        getFormateurList();
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Gestion_module_Click(object sender, EventArgs e)
        {
            Gestion_modules gestion_module = new Gestion_modules();
            gestion_module.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
