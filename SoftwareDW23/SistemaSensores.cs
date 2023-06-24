using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDW23
{
    public class SistemaSensores
    {
        public double volt { get; set; }
        public double turb { get; set; }
        public double pH { get; set; }

        public string strVolt { get; set; }
        public string strTurb { get; set; }
        public string strPh { get; set; }

        public void ObtieneValores()
        {
            try
            {
                this.volt = Convert.ToDouble(strVolt);
                this.turb = Convert.ToDouble(strTurb);
                this.pH = Convert.ToDouble(strPh);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("No se pudo convertir un String de las variables");
            }
        }
    }
}
