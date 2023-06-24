using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDW23
{
    class clsUsuario
    {
        protected MySqlCommand comando;
        public Boolean Insert(string Nombre, string nivelPH, string turbidez, PictureBox fotico, string fecha, string codigoA)
        {
            try
            {

                string cadena = "INSERT INTO contaminacion SET codigoAgua='"+ codigoA +"', nombreCuerpo='" + Nombre + "', nivelContaminante='" + nivelPH + "', nivelTurbidad ='" + turbidez + "', imagen=@imagen, fechaMuestra='" + fecha + "'";
                Console.WriteLine(cadena);
                byte[] mifoto = clsImagen.ImageToByte(fotico.Image);
                comando = new MySqlCommand(cadena, clsConexion.conexion);
                comando.Parameters.AddWithValue("@imagen", mifoto);
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
