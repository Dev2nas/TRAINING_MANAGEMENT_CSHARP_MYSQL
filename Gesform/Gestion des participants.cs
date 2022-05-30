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
    public partial class Gestion_des_participants : Form
    {
        DB_connect conn = new DB_connect();
        classParticipant participant = new classParticipant();
        public Gestion_des_participants()
        {
            InitializeComponent();
            showTable();
        }


        //create a function to verify
        //create a function to verify
        bool verify()
        {
            if ((input_nom.Text == "") || (input_prenom.Text == "") || (input_telephone.Text == "") || (input_email.Text == "") || (input_typeParticipant.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        public void showTable()
        {

            dataGridView1.DataSource = participant.getParticipantlist(new MySqlCommand("SELECT * FROM `participant`"));


        }

        private void Btn_updateParticipant_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(input_id.Text);
            string nom = input_nom.Text;
            string prenom = input_prenom.Text;
            string type_participant = input_typeParticipant.Text;
            string tel = input_telephone.Text;
            int idFormation = Convert.ToInt32(input_formation.SelectedValue.ToString());
            string email = input_email.Text;
            DateTime date = input_date.Value;

            if (verify())
            {
                try
                {
                    if (participant.updateParticipant(id, nom, prenom, type_participant, tel, email,idFormation, date))
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

        private void Btn_deleteParticipant_Click(object sender, EventArgs e)
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
                    if (participant.deleteParticipant(id))
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

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            input_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            input_nom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            input_prenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            input_typeParticipant.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            input_telephone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            input_email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            input_date.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            input_formation.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

    }
}
