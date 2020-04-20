using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp1
{
    public class TextoLabel
    {
        public void MostrarRespuestaDeBusqueda(Label Respuesta,bool exito)
        {
            if (exito == true)
            {
                Respuesta.ForeColor = System.Drawing.Color.Lime;
                Respuesta.Text = "Datos encontrados con exito !!!";
            }
            else
            {
                Respuesta.ForeColor = System.Drawing.Color.Red;
                Respuesta.Text = "Error, la persona con la cedula digitada no se encuentra registrada";
            }
           
        }

    }
}
