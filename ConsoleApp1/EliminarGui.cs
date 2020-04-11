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
        Limpiar limpiar = new Limpiar();
        PersonaServicio personaServicio = new PersonaServicio();
        public EliminarGui()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!CedulaEsCampoVacio())
            {
                string cedula = TbCedula.Text;
                Persona persona = RealizarBusqueda();
                if (persona != null)
                {
                    LlenarDatosPersona(persona);
                }
            }
            else
            {
                MostrarMensajeDeCedulaEsCampoVacio();
            }
        }
        public void EscribirMensaje(Persona persona)
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
        public void MostrarMensajeDeCedulaEsCampoVacio()
        {
            string mensaje = "Error : Llene el campo cedula";
            string Titulo = "Advertencia";
            MessageBox.Show(mensaje, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Persona RealizarBusqueda()
        {
            string cedula = TbCedula.Text;
            Persona persona = personaServicio.Buscar(cedula);
            if (persona != null)
            {
                personaServicio.Buscar(cedula);
                return persona;
            }
            else
            {
                EscribirMensaje(persona);
                return null;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string cedula = TbCedula.Text;
            Persona persona = personaServicio.Buscar(cedula);
            if (!CedulaEsCampoVacio())
            {
                AbrirFormularioEliminacionConfirmar(persona);
            }
            else
            {
                MostrarMensajeDeCedulaEsCampoVacio();
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
            limpiar.VaciarCampos(this);
            LbRespuesta.Text = "";
        }
    }
}
