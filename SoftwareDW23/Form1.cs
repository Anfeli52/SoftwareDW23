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

namespace SoftwareDW23
{
    public partial class Form1 : Form
    {

        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=yaxja;";
        public Form1()
        {
            InitializeComponent();
        }


        public void login()
        {
            String query = "SELECT * FROM usuario WHERE correo = '" + txtEmail.Text + "' AND password= '" + txtPassword.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        registrarDatos registrarDatos = new registrarDatos();
                        registrarDatos.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("¡¡Usuario o Contraseña Incorrectos!!");
                }
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String correo = txtEmail.Text;
            variables variables = new variables();
            variables.setCorreo(correo);
            login();
        }
    }
}
