using pryPerezEtapa4;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryPerezEtapa4
{
    public partial class frmEtapa4 : Form
    {

        clsVehiculo objVehiculo = new clsVehiculo();
        List<clsVehiculo> listVehiculos = new List<clsVehiculo>();

        public frmEtapa4()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            foreach (clsVehiculo vehiculos in listVehiculos)
            {
                lstListado.Items.Add("nombre: "+vehiculos.nombre + "    " + " tipo: "+ vehiculos.tipo);
            }


            listVehiculos.Clear();

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            objVehiculo.crearVehiculo(picImagen, Properties.Resources.auto);

            objVehiculo.nombre = "Cybertruck";
            objVehiculo.tipo = "auto";

            listVehiculos.Add(objVehiculo);

        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            objVehiculo.crearVehiculo(picImagen, Properties.Resources.avion);

            objVehiculo.nombre = "Boeing-797";
            objVehiculo.tipo = "avion";

            listVehiculos.Add(objVehiculo);

        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objVehiculo.crearVehiculo(picImagen, Properties.Resources.barco);

            objVehiculo.nombre = "Barco pirata";
            objVehiculo.tipo = "barco";

            listVehiculos.Add(objVehiculo);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listVehiculos.Clear();
            lstListado.Items.Clear();
            picImagen.Image = null;

        }
    }
}
