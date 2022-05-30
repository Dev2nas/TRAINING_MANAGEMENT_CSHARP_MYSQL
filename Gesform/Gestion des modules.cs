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
    public partial class Gestion_modules : Form
    {
        DB_connect con = new DB_connect();
        classModule modules = new classModule();
        public Gestion_modules()
        {
            InitializeComponent();
            showTable();
            Formateur_Load();
        }
        //dataviews  
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            // Formateur_Load();
           

            input_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            input_module.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            input_horaire.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            input_formateur.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        //chargement liste deroulante formateur
        private void Formateur_Load()
        {
            input_formateur.DataSource = modules.ListFormateur();
            input_formateur.DisplayMember = "nomF";
            input_formateur.ValueMember = "idFormateur";
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
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
        public void showTable()
        {
            dataGridView1.DataSource = modules.getModulelist(new MySqlCommand("SELECT * FROM `module`"));
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {

            
            input_id.Clear();
            input_module.Clear();
            input_horaire.Clear();
        }

        private void Btn_updateModule_Click(object sender, EventArgs e)
        {
            // update module record
            int id = Convert.ToInt32(input_id.Text);
            string module = input_module.Text;
            int horaire = Convert.ToInt32(input_horaire.Text);
            int formateur = Convert.ToInt32(input_formateur.SelectedValue.ToString());


            if (verify())
            {
                try
                {
                    if (modules.updateModule(id, module, horaire, formateur))
                    {
                        showTable();
                        MessageBox.Show("Le module à été modifier", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show("Vous étes sûr de vouloir cette module", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    if (modules.deleteModule(id))
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
    }
}
