using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp1
{
    public class VentanaEmergente
    {
        public void  MensajeErrorCampoVacio()
        {
            string mensaje = "Error : Llene todos los campos";
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void MensajeErrorCampoVacio(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
