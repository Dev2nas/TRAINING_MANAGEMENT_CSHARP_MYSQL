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
    public partial class Formation : Form
    {
        DB_connect conn = new DB_connect();
        classFormation formation = new classFormation();
        public Formation()
        {
            InitializeComponent();
            Module_Load();
            Salle_Load();
            Formateur_Load();
            showTable();
        }

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
            if ((input_salle.Text == "") || (input_formateur.Text == "")||(input_module.Text=="")|| (input_lieu.Text == "") || (input_prix.Text == "") || (input_place.Text == "") || (input_dateDebut.Text == "") || (input_dateFin.Text == "") || (input_theme.Text == "") || (input_niveau.Text == "") || (input_theme.Text == ""))
            {
                return false;
            }
            else
                return true;
        }

        private void Btn_AddFormation_Click(object sender, EventArgs e)
        {
            // add new formation
            string theme = input_theme.Text;
            string niveau = input_niveau.Text;
            string lieu = input_lieu.Text;
            int prix = Convert.ToInt32(input_prix.Text);
            int NbPlace = Convert.ToInt32(input_place.Text);
            DateTime dateDebut = input_dateDebut.Value;
            DateTime dateFin = input_dateFin.Value;
            int module = Convert.ToInt32(input_formateur.SelectedValue.ToString());
            int salle = Convert.ToInt32(input_formateur.SelectedValue.ToString());
            int formateur = Convert.ToInt32(input_formateur.SelectedValue.ToString());

            if (verify())
            {
                try
                {

                    if (formation.addFormation(theme, niveau,lieu,NbPlace,prix,dateDebut,dateFin,module,salle,formateur))
                    {
                        showTable();
                        MessageBox.Show("Un nouveau formation à été ajouter", "Nouveau formation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Les champs son vide", "Nouveau formation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_gestionF_Click(object sender, EventArgs e)
        {
            Gestion_des_formations gestion_Des_Formations = new Gestion_des_formations();
            gestion_Des_Formations.Show();
        }
    }
}
