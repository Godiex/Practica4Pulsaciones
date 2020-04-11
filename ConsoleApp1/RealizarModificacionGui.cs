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
using System.Runtime.InteropServices;
namespace ConsoleApp1
{
    public partial class RealizarModificacionGui : Form
    {
        PersonaServicio personaServicio = new PersonaServicio();
        private Limpiar limpiar = new Limpiar();
        public RealizarModificacionGui()
        {
            InitializeComponent();
        }
        private void PbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public Persona CrearPersonaModificada()
        {
            string nombre = TbNombre.Text;
            string identificacion = LbMostrarCedula.Text;
            string sexo = CbSexo.Text;
            int edad = int.Parse(TbEdad.Text);
            Persona persona = new Persona(nombre,identificacion,sexo,edad);
            persona.CalcularPulsaciones();
            return persona;
        }
        public void RealizarModificacion()
        {
            Persona persona = CrearPersonaModificada();
            if (persona != null)
            {
                personaServicio.Modificar(persona);
                EscribirMensaje(persona);
            }
            else
            {
                EscribirMensaje(persona);
            }
        }
        private void BntGuardarModificacion_Click(object sender, EventArgs e)
        {
            if (!limpiar.EsCampoVacio(this))
            {
                RealizarModificacion();
            }
            else
            {
                string mensaje = "Error : Llene todos los campos";
                MessageBox.Show(mensaje, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void EscribirMensaje(Persona persona)
        {
            string mensaje;
            if (persona != null)
            {
                mensaje = "Datos modificados con exito !!!";
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

        private void BtnCalcularPulsacion_Click_1(object sender, EventArgs e)
        {
            if (!limpiar.EsCampoVacio(this))
            {
                Persona persona = CrearPersonaModificada();
                this.LbNumeroDePulsaciones.Text = $"# {persona.Pulsaciones.ToString()}";

            }
            else
            {
                string mensaje = "Error : Llene todos los campos";
                MessageBox.Show(mensaje, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
