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
    public partial class Gestion_des_formations : Form
    {
        DB_connect conn = new DB_connect();
        classFormation formation = new classFormation();
        public Gestion_des_formations()
        {
            InitializeComponent();
            showTable();
            Formateur_Load();
            Module_Load();
            Salle_Load();
        }
        //chargement liste deroulante formateur
        private void Formateur_Load()
        {
            input_formateur.DataSource = formation.ListFormateur();
            input_formateur.DisplayMember = "nomF";
            input_formateur.ValueMember = "idFormateur";
        }
        private void Module_Load()
        {
            input_module.DataSource = formation.ListModule();
            input_module.DisplayMember = "libelle";
            input_module.ValueMember = "idModule";
        }
        private void Salle_Load()
        {
            input_salle.DataSource = formation.ListSalle();
            input_salle.DisplayMember = "libelle";
            input_salle.ValueMember = "idSalle";
        }
        //liste des salles
        public void showTable()
        {
            dataGridView1.DataSource = formation.getFormationlist(new MySqlCommand("SELECT * FROM `formation`"));
        }

        //create a function to verify
        bool verify()
        {
            if ((input_salle.Text == "") || (input_formateur.Text == "") || (input_module.Text == "") || (input_lieu.Text == "") || (input_prix.Text == "") || (input_place.Text == "") || (input_dateDebut.Text == "") || (input_dateFin.Text == "") || (input_theme.Text == "") || (input_niveau.Text == "") || (input_theme.Text == ""))
            {
                return false;
            }
            else
                return true;
        }     

        private void Btn_deleteFormateur_Click_1(object sender, EventArgs e)
        {
            //remove the selected Student
            int id = Convert.ToInt32(input_id.Text);
            //Show a confirmation message before delete the student
            if (MessageBox.Show("Vous étes sûr de vouloir cette module", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    if (formation.deleteFormation(id))
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

        private void DataGridView1_Click_1(object sender, EventArgs e)
        {
            input_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            input_theme.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            input_niveau.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            input_lieu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            input_place.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            input_prix.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            input_dateDebut.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            input_dateFin.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            input_formateur.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            input_module.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            input_salle.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            // update module record
            int id = Convert.ToInt32(input_id.Text);
            string theme = input_theme.Text;
            string niveau = input_niveau.Text;
            string lieu = input_lieu.Text;
            int prix = Convert.ToInt32(input_prix.Text);
            int NbPlace = Convert.ToInt32(input_place.Text);
            DateTime dateDebut = input_dateDebut.Value;
            DateTime dateFin = input_dateFin.Value;
            int module = Convert.ToInt32(input_module.SelectedValue.ToString());
            int salle = Convert.ToInt32(input_salle.SelectedValue.ToString());
            int formateur = Convert.ToInt32(input_formateur.SelectedValue.ToString());


            if (verify())
            {
                try
                {
                    if (formation.updateFormation(id, theme, niveau, lieu, NbPlace, prix, dateDebut, dateFin, module, salle, formateur))
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

        private void Vider_Click(object sender, EventArgs e)
        {
            input_id.Clear();
            input_theme.Clear();
            input_lieu.Clear();
            input_place.Clear();
            input_prix.Clear();
        }
    }
}
