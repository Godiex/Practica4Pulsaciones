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
    public partial class EliminarGui : Form
    {
        OperacionesCampos operacionesCampos = new OperacionesCampos();
        PersonaServicio personaServicio = new PersonaServicio();
        VentanaEmergente ventanaEmergente = new VentanaEmergente();
        public EliminarGui()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!CedulaEsCampoVacio())
            {
                Persona persona = RealizarBusqueda();
                if (persona != null)
                {
                    LlenarDatosPersona(persona);
                }
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio("error llene el campo cedula");
            }
        }
        public void EscribirMensaje(Persona persona)
        {
            if (persona != null)
            {
                LbRespuesta.ForeColor = System.Drawing.Color.Lime;
                LbRespuesta.Text = "Datos encontrados con exito !!!";
            }
            else
            {
                LbRespuesta.ForeColor = System.Drawing.Color.Red;
                LbRespuesta.Text = "Error, la persona con la cedula digitada no se encuentra registrada";
            }
        }
        public bool CedulaEsCampoVacio()
        {
            if (TbCedula.Text.Length.Equals(0))
            {
                return true;
            }
            return false;
        }
        public void LlenarDatosPersona(Persona persona)
        {
            TbNombre.Text = persona.Nombre;
            TbEdad.Text = persona.Edad.ToString();
            TbSexo.Text = persona.Sexo;
            TbPulsaciones.Text = persona.Pulsaciones.ToString();
            EscribirMensaje(persona);
        }        
        public Persona RealizarBusqueda()
        {
            string cedula = TbCedula.Text;
            RespuestaBusqueda respuestaBusqueda = personaServicio.Buscar(cedula);
            if (respuestaBusqueda.Persona != null)
            {
                return respuestaBusqueda.Persona;
            }
            else
            {
                EscribirMensaje(respuestaBusqueda.Persona);
                return null;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string cedula = TbCedula.Text;
            RespuestaBusqueda respuestaBusqueda= personaServicio.Buscar(cedula);
            if (!CedulaEsCampoVacio())
            {
                AbrirFormularioEliminacionConfirmar(respuestaBusqueda.Persona);
            }
            else
            {
                ventanaEmergente.MensajeErrorCampoVacio("error llene el campo cedula");
            }
        }
        private void AbrirFormularioEliminacionConfirmar(Persona persona)
        {
            if (persona != null)
            {
                EliminacioConfirmarGui formulario = new EliminacioConfirmarGui();
                formulario.LBNumeroDeCedula.Text = TbCedula.Text;
                formulario.Show();

            }
            else
            {
                EscribirMensaje(persona);
            }
        }

        private void BtnVaciarCampos_Click(object sender, EventArgs e)
        {
            operacionesCampos.VaciarCampos(this);
            LbRespuesta.Text = "";
        }
    }
}
