using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
namespace ConsoleApp1
{
    public partial class ConsultarGui : Form
    {
        PersonaServicio personaServicio = new PersonaServicio();
        public ConsultarGui()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DgvPersonas.DataSource = null;
            RespuestaConsulta respuestaConsulta =  personaServicio.Consultar();
            if (CbTipoDeConsulta.Text.Equals("Todos"))
            {
                DgvPersonas.DataSource = respuestaConsulta.Personas;
            }
            else
            {
                if (CbTipoDeConsulta.Text.Equals("Hombres"))
                {
                    DgvPersonas.DataSource = personaServicio.ConsultaPorSexo("M");
                }
                else
                {
                    DgvPersonas.DataSource = personaServicio.ConsultaPorSexo("F");
                } 
            }
            
        }

    }
}
