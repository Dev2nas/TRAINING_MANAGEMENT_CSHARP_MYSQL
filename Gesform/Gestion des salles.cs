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
    public partial class Gestion_des_salles : Form
    {
        DB_connect conn = new DB_connect();
        classSalle Salle = new classSalle();
        public Gestion_des_salles()
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
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
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

        private void Btn_delete_salle_Click(object sender, EventArgs e)
        {
            //remove the selected Student
            int id = Convert.ToInt32(input_id.Text);
            if (input_id.Text == null)
            {
                MessageBox.Show("le champs est vide");
            }
            //Show a confirmation message before delete the student
            if (MessageBox.Show("Vous étes sûr de vouloir cette module", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    if (Salle.deleteSalle(id))
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

        private void Btn_vider_Click(object sender, EventArgs e)
        {
            input_id.Clear();
            input_salle.Clear();
        }

        private void Btn_update_salle_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(input_id.Text);
            string salle = input_salle.Text;
            int formateur = Convert.ToInt32(input_formateur.SelectedValue.ToString());


            if (verify())
            {
                try
                {
                    if (Salle.updateSalle(id, salle, formateur))
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

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            input_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            input_salle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            input_formateur.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
