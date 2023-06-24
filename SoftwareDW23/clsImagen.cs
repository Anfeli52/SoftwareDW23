using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace SoftwareDW23
{
    class clsImagen
    {
        //Convierte Byte a Imagen
        public static MemoryStream ByteToImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream((byte[])array);
            return ms;
        }

        //Convierte Imagen a Byte
        public static byte[] ImageToByte(Image imagenIn)
        {
            MemoryStream ms = new MemoryStream();
            imagenIn.Save(ms, ImageFormat.Jpeg);

            return ms.ToArray();
        }
    }
}
