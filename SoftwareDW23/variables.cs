using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDW23
{
    public class variables
    {
        public static String getCorreo()
        {
            return correo;
        }
        public static void setCorreo(String aCorreo)
        {
            correo = aCorreo;
        }

        private static String correo = "";
    }
}
