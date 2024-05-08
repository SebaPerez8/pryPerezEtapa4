using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryPerezEtapa4
{

    public class clsVehiculo
    {
        public string nombre;
        public string tipo;
        public Bitmap imagen;


        public void crearVehiculo(PictureBox pictureBox, Bitmap imagen)
        {
            
            Bitmap imagenRedimensionada = new Bitmap(imagen, 200, 100);

            // Asignar la imagen redimensionada al PictureBox
            pictureBox.Image = imagenRedimensionada;

         


        }
    }
}

