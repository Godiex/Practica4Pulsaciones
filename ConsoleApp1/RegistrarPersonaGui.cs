using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace ConsoleApp1
{
    public partial class RegistrarPersonaGui : Form
    {
        private PersonaServicio personaServicio = new PersonaServicio();
        private OperacionesCampos limpiar = new OperacionesCampos();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        public RegistrarPersonaGui()
        {
            InitializeComponent();
        }


        private void BtnCalcularPulsacion_Click(object sender, EventArgs e)
        {
            if (!limpiar.EsCampoVacio(this))
            {
                Persona persona = CrearPersona();
                this.LbNumeroDePulsaciones.Text = $"# {persona.Pulsaciones}";
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio();
                string mensaje = "No ha llenado todos los campos ";
                EscribirMensaje("Red", mensaje);
            }
        }
        public void VaciarCampos()
        {
            limpiar.VaciarCampos(this);
            LbNumeroDePulsaciones.Text = "";
        }
        private void BntRegistrar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }
        public void GuardarPersona()
        {
            if (!limpiar.EsCampoVacio(this))
            {
                Persona persona = CrearPersona();
                string respuesta =  personaServicio.Guardar(persona);
                EscribirMensaje("Lime", respuesta);
                VaciarCampos();
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio();
                string mensaje = "No ha llenado todos los campos ";
                EscribirMensaje("Red", mensaje);
            }
            
        }
        public Persona CrearPersona()
        {
            string identificacion = TbCedula.Text;
            string nombre = this.TbNombre.Text;
            int edad = int.Parse(this.TbEdad.Text);
            string sexo = this.CbSexo.Text;
            Persona persona = new Persona(nombre, identificacion, sexo, edad);
            persona.CalcularPulsaciones();
            return persona;
        }

        public void EscribirMensaje(string color ,string respuesta)
        {
            if (color == "Lime")
            {
                LbRespuesta.ForeColor = System.Drawing.Color.Lime;
                LbRespuesta.Text = respuesta;
            }
            else
            {
                LbRespuesta.ForeColor = System.Drawing.Color.Red;
                LbRespuesta.Text = respuesta;
            }
        }
    }
}
