using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gesform
{
    public partial class Form_formateurs : Form
    {
        DB_connect con = new DB_connect();
        classFormateur formateurs = new classFormateur();
        public Form_formateurs()
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
            dataGridView1.DataSource = formateurs.getFormateurlist(new MySqlCommand("SELECT * FROM `formateur`"));
        }

        private void AddFormateur_Click(object sender, EventArgs e)
        {
            Form_formateur form_formateur = new Form_formateur();
            form_formateur.Show();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            input_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            input_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            input_prenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            input_tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            input_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void Btn_updateFormateur_Click(object sender, EventArgs e)
        {
            // update formateur record
            int id = Convert.ToInt32(input_id.Text);
            string nom = input_nom.Text;
            string prenom = input_prenom.Text;
            string email = input_email.Text;
            string tel = input_tel.Text;


            if(verify())
            {
                try
                {
                    if (formateurs.updateFormateur(id, nom, prenom, tel, email))
                    {
                        showTable();
                        MessageBox.Show("Le formateur à été modifier", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Les champs son vide", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_deleteFormateur_Click(object sender, EventArgs e)
        {
            //remove the selected Student
            int id = Convert.ToInt32(input_id.Text);
            //Show a confirmation message before delete the student
            if (MessageBox.Show("Vous étes sûr de vouloir cette formateur", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
            {
                    if (formateurs.deleteFormateur(id))
                    {
                        showTable();
                        MessageBox.Show("Supprimer éffectué avec succés", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {

            
            input_id.Clear();
            input_nom.Clear();
            input_prenom.Clear();
            input_email.Clear();
            input_tel.Clear();
        }

        private void Form_formateurs_Load(object sender, EventArgs e)
        {

        }
    }
}
