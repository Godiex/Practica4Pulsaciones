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
    public partial class BuscarGui : Form
    {
        PersonaServicio personaServicio = new PersonaServicio();
        Limpiar limpiar = new Limpiar();
        public BuscarGui()
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
                RespuestaBusqueda respuestaBusqueda = personaServicio.Buscar(cedula);
                LlenarDatosPersona(respuestaBusqueda);
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
        public void LlenarDatosPersona(RespuestaBusqueda respuestaBusqueda)
        {
            if (respuestaBusqueda.Persona != null)
            {
                TbNombre.Text = respuestaBusqueda.Persona.Nombre;
                TbEdad.Text = respuestaBusqueda.Persona.Edad.ToString();
                TbSexo.Text = respuestaBusqueda.Persona.Sexo;
                TbPulsaciones.Text = respuestaBusqueda.Persona.Pulsaciones.ToString();
            }
            else
            {
                string mensaje = respuestaBusqueda.Mensaje;
                MostrarMensajeDeAdvertencia(mensaje);
            }
        }

        private void BtnVaciarCampos_Click(object sender, EventArgs e)
        {
            limpiar.VaciarCampos(this);
        }
    }
}
