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
        private Limpiar limpiar = new Limpiar();
        public RegistrarPersonaGui()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtnCalcularPulsacion_Click(object sender, EventArgs e)
        {
            if (!limpiar.EsCampoVacio(this))
            {
                Persona persona = CrearPersona();
                this.LbNumeroDePulsaciones.Text = $"# {persona.Pulsaciones.ToString()}";
            }
            else
            {
                string mensaje = "Error : Llene todos los campos";
                MessageBox.Show(mensaje, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                personaServicio.Guardar(persona);
                EscribirMensaje(true);
                VaciarCampos();
            }
            else
            {
                string mensaje = "Error : Llene todos los campos";
                MessageBox.Show(mensaje, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EscribirMensaje(false);
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

        public void EscribirMensaje(bool exito)
        {
            string mensaje;
            if (exito == true)
            {
                mensaje = "Datos guardados con exito !!!";
                LbRespuesta.ForeColor = System.Drawing.Color.Lime;
                LbRespuesta.Text = mensaje;
            }
            else
            {
                mensaje = "Error, llene todos los campos";
                LbRespuesta.Font = new System.Drawing.Font("Century Gothic", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                LbRespuesta.ForeColor = System.Drawing.Color.Red;
                LbRespuesta.Text = mensaje;
            }
        }
    }
}
