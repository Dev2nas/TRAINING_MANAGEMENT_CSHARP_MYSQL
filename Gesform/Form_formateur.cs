using System;
using System.Collections;
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
    public partial class Form_formateur : Form
    {
        DB_connect conn = new DB_connect();
        classFormateur formateur = new classFormateur();
        public Form_formateur()
        {
            InitializeComponent();
            showTable();
        }

        //create a function to verify
        bool verify()
        {
            if ((input_nom.Text == "") || (input_tel.Text == "") ||
                (input_prenom.Text == "") || (input_email.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void formFormateur_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            dataGridView1.DataSource = formateur.getFormateurlist(new MySqlCommand("SELECT * FROM `formateur`"));
        }

        private void AddFormateur_Click(object sender, EventArgs e)
        {
            // add new formateur
            string nom = input_nom.Text;
            string prenom = input_prenom.Text;
            string email = input_email.Text;
            string tel = input_tel.Text;

            if (verify())
            {
                try
                {

                    if (formateur.addFormateur(nom, prenom, email, tel))
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

        private void Btn_updateFormateur_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form_formateurs());
            Form_formateurs formateur = new Form_formateurs();
            formateur.Show();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            input_nom.Clear();
            input_prenom.Clear();
            input_email.Clear();
            input_tel.Clear();
        }
    }
}
