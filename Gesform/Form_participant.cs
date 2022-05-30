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
    public partial class Form_participant : Form
    {
        DB_connect conn = new DB_connect();
        classParticipant participant = new classParticipant();
        public Form_participant()
        {
            InitializeComponent();
            showTable();
            Formation_Load();
        }

        //liste des salles
        public void showTable()
        {
            dataGridView1.DataSource = participant.getParticipantlist(new MySqlCommand("SELECT * FROM `participant`"));
        }

        //create a function to verify
        bool verify()
        {
            if ((input_nom.Text == "") || (input_prenom.Text == "")|| (input_telephone.Text == "") || (input_email.Text == "") || (input_typeParticipant.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void Formation_Load()
        {
            input_formation.DataSource = participant.ListFormateur();
            input_formation.DisplayMember = "theme";
            input_formation.ValueMember = "idFormation";
        }

        private void Btn_addParticipant_Click(object sender, EventArgs e)
        {
            // add new formateur
            string nom = input_nom.Text;
            string prenom = input_prenom.Text;
            string type_participant = input_typeParticipant.Text;
            string tel = input_telephone.Text;
            string email = input_email.Text;
            int idFormation = Convert.ToInt32(input_formation.SelectedValue.ToString());
            DateTime date = input_date.Value;
             if (verify())
            {
                try
                {

                    if (participant.addParticipant(nom, prenom, type_participant, tel, email, idFormation, date))
                    {
                        showTable();
                        MessageBox.Show("Un nouveau paricipant à été ajouter", "Ajouter un participant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Les champs sont vide !!!!", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_gestionParticipant_Click(object sender, EventArgs e)
        {
            Gestion_des_participants gestion_Des_Participants= new Gestion_des_participants();
            gestion_Des_Participants.Show();
        }
    }
}
