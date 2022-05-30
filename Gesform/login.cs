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
using System.Data;

namespace Gesform
{
    public partial class login : Form
    {
        DB_connect connect = new DB_connect();
        login Login = new login();
        public login()
        {
            InitializeComponent();
        }

        
            if (input_username.Text == "" || input_password.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_usrname.Text;
    string pass = textBox_password.Text;
    DataTable table = Login.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + uname + "' AND `password`='" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

    }
}
