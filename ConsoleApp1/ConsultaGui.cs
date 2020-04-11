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
    public partial class ConsultaGui : Form
    {
        PersonaServicio personaServicio = new PersonaServicio();
        Limpiar limpiar = new Limpiar();
        public ConsultaGui()
        {
            InitializeComponent();
        }
        public bool CedulaEsCampoVacio()
        {
            if (TbCedula.Text.Length.Equals(0))
            {
                return true;
            }
            return false;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!CedulaEsCampoVacio())
            {
                string cedula = TbCedula.Text;
                Persona persona = personaServicio.Buscar(cedula);
                LlenarDatosPersona(persona);
            }
            else
            {
                string mensaje = "Error : Llene el campo cedula";
                MostrarMensajeDeAdvertencia(mensaje);
            }
        }
        public void MostrarMensajeDeAdvertencia(string mensaje)
        {
            string Titulo = "Advertencia";
            MessageBox.Show(mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LlenarDatosPersona(Persona persona)
        {
            if (persona != null)
            {
                TbNombre.Text = persona.Nombre;
                TbEdad.Text = persona.Edad.ToString();
                TbSexo.Text = persona.Sexo;
                TbPulsaciones.Text = persona.Pulsaciones.ToString();
            }
            else
            {
                string mensaje = "Error : La Cedula no se encuentra registrada";
                MostrarMensajeDeAdvertencia(mensaje);
            }
        }

        private void BtnVaciarCampos_Click(object sender, EventArgs e)
        {
            limpiar.VaciarCampos(this);
        }
    }
}
