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
    public partial class ModificarGui : Form
    {
        private PersonaServicio personaServicio = new PersonaServicio();
        private Limpiar limpiar = new Limpiar();

        public ModificarGui()
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
        public void EscribirMensaje(Persona persona )
        {
            string mensaje;
            if (persona != null)
            {
                mensaje = "Datos encontrados con exito !!!";
                LbRespuesta.ForeColor = System.Drawing.Color.Lime;
                LbRespuesta.Text = mensaje;
            }
            else
            {
                mensaje = "Error, la persona con la cedula digitada no se encuentra registrada";
                LbRespuesta.Font = new System.Drawing.Font("Century Gothic", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LbRespuesta.ForeColor = System.Drawing.Color.Red;
                LbRespuesta.Text = mensaje;
            }
        }
        public void LlenarDatosPersona(Persona persona)
        {
             TbNombre.Text = persona.Nombre;
             TbEdad.Text = persona.Edad.ToString();
             TbSexo.Text = persona.Sexo;
             TbPulsaciones.Text = persona.Pulsaciones.ToString();
             EscribirMensaje(persona);
        }

        private void BtnVaciarCampos_Click_1(object sender, EventArgs e)
        {
            limpiar.VaciarCampos(this);
            this.LbRespuesta.Text = " ";
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!CedulaEsCampoVacio())
            {
                string cedula = TbCedula.Text;
                Persona persona = RealizarBusqueda();
                if (persona!=null)
                {
                    LlenarDatosPersona(persona);
                }
            }
            else
            {
                MostrarMensajeDeCedulaEsCampoVacio();
            }
        }
        public void MostrarMensajeDeCedulaEsCampoVacio()
        {
            string mensaje = "Error : Llene el campo cedula";
            string Titulo = "Advertencia";
            MessageBox.Show(mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Persona RealizarBusqueda()
        {
            string cedula = TbCedula.Text;
            RespuestaBusqueda respuestaBusqueda = personaServicio.Buscar(cedula);
            if (respuestaBusqueda.Persona != null)
            {
                EscribirMensaje(respuestaBusqueda.Persona);
                return respuestaBusqueda.Persona;
            }
            else
            {
                EscribirMensaje(respuestaBusqueda.Persona);
                return respuestaBusqueda.Persona;
            }
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string cedula = TbCedula.Text;
            RespuestaBusqueda respuestaBusqueda = personaServicio.Buscar(cedula);
            if (!CedulaEsCampoVacio())
            {
                AbrirFormularioRealizarModificacion(respuestaBusqueda.Persona);
            }
            else
            {
                MostrarMensajeDeCedulaEsCampoVacio();
            }
            
        }
        private void AbrirFormularioRealizarModificacion(Persona persona)
        {
            if (persona != null)
            {
                RealizarModificacionGui formulario = new RealizarModificacionGui();
                formulario.LbMostrarCedula.Text = TbCedula.Text;
                formulario.Show();
            }
            else
            {
                EscribirMensaje(persona);
            }
        }
    }
}
