using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace SoftwareDW23
{
    public partial class registrarDatos : Form
    {
        SerialPort Port;
        SistemaSensores sensores;
        System.Windows.Forms.Timer loop;

        String datos;
        bool IsClosed = false;

        //FECHA ACTUAL//
        string fechaActual = DateTime.Today.ToString("yyy-MM-dd");

        public registrarDatos()
        {
            InitializeComponent();

            if (clsConexion.CheckConexion())
            {
                Console.WriteLine("Conexion Establecida");
                clsConexion.GetConexionClient();
            }
            else
            {
                Console.WriteLine("Ocurrrio un error al establecer la conexion");
            }

            //CÓDIGO AGUA//
            Random random = new Random();
            int numRandom = random.Next(1001, 10000);
            string codigoAgua = "R" + numRandom;
            lblCodigoAgua.Text = codigoAgua;

            //CONEXIÓN ARDUINO
            Port = new SerialPort("COM3");
            Port.BaudRate = 9600;
            Port.Parity = Parity.None;
            Port.StopBits = StopBits.One;
            Port.DataBits = 8;

            loop = new System.Windows.Forms.Timer();
            loop.Interval = 500;
            loop.Tick += Loop_Tick;
            loop.Start();

            sensores = new SistemaSensores();

            try
            {
                Port.Open();
                Port.DataReceived += Puerto_DataReceived;
            }
            catch { }

        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            datos = Port.ReadLine();
            string[] substrings = datos.Split('/');
            if (substrings.Length == 4)
            {
                if (substrings[0] == "~")
                {
                    sensores.strVolt = substrings[1];
                    sensores.strTurb = substrings[2];
                    sensores.strPh = substrings[3];
                    sensores.ObtieneValores();
                }
            }
        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            txtNivelPH.Text = sensores.strPh;
            txtTurbidad.Text = sensores.strTurb;
        }


        protected MySqlCommand comando;
        private void btnRegistrarCuerpo_Click(object sender, EventArgs e)
        {

            ////INICIALIZAR CONEXIÓN//
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=yaxja;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            //CORREO USUARIO//
            variables variables = new variables();
            string correo = variables.getCorreo();
           

            string nombre = txtNombreCuerpo.Text;
            string nivelPH = txtNivelPH.Text;
            string turbidez = txtTurbidad.Text;


            


            //INSERTAR LA INFORMACIÓN A LA BASE DE DATOS//
            String query = "INSERT INTO contaminacion(codigoAgua, nivelContaminante, nivelTurbidad, nombreAgua, cuerpoAgua, fechaMuestra, correoContaminacion, imagen) VALUES('"+ lblCodigoAgua.Text + "', '" + txtNivelPH.Text+"', '"+txtTurbidad.Text+"', '"+txtNombreCuerpo.Text+"', '"+cbCuerpoAgua.Text+"','"+ fechaActual + "' ,'"+ correo +"', '@imagen')";
            
            //CODIGO AGUA//
            Random random = new Random();
            int numRandom = random.Next(1001, 10000);
            string codigoAgua = "R" + numRandom;
            lblCodigoAgua.Text = codigoAgua;

            ///AGREGAR IMAGEN//
            databaseConnection.Open();
            Console.WriteLine(query);
            byte[] mifoto = clsImagen.ImageToByte(ptbImagen.Image);
            comando = new MySqlCommand(query, clsConexion.conexion);
            comando.Parameters.AddWithValue("@imagen", mifoto);
            comando.ExecuteNonQuery();


        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione una imagen";
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\Users\\A10\\Desktop\\Imagenes";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ptbImagen.ImageLocation = dialog.FileName;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            this.Close();
            Login.Show();
            
        }

        private void registrarDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
