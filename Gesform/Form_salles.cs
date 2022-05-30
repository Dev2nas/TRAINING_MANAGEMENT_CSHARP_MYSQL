using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gesform
{
    public partial class Form_salles : Form
    {
        DB_connect conn = new DB_connect();
        classSalle Salle = new classSalle();
        public Form_salles()
        {
            InitializeComponent();
            showTable();
            Formateur_Load();
        }

        private void Formateur_Load()
        {
            input_formateur.DataSource = Salle.ListFormateur();
            input_formateur.DisplayMember = "nomF";
            input_formateur.ValueMember = "idFormateur";
        }
        //liste des salles
        public void showTable()
        {
            dataGridView1.DataSource = Salle.getSallelist(new MySqlCommand("SELECT * FROM `salles`"));
        }

        //create a function to verify
        bool verify()
        {
            if ((input_salle.Text == "") || (input_formateur.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void Btn_addSalle_Click(object sender, EventArgs e)
        {
            // add new formateur
            string salle = input_salle.Text;
            int formateur = Convert.ToInt32(input_formateur.SelectedValue.ToString());

            if (verify())
            {
                try
                {

                    if (Salle.addSalle(salle, formateur))
                    {
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

        private void Gestion_salle_Click(object sender, EventArgs e)
        {
            Gestion_des_salles gestion_Des_Salles = new Gestion_des_salles();
            gestion_Des_Salles.Show();
        }
    }
}
