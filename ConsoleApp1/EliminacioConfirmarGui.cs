using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaLogica;


namespace ConsoleApp1
{
    public partial class EliminacioConfirmarGui : Form
    {
        PersonaServicio personaServicio = new PersonaServicio();
        public EliminacioConfirmarGui()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntEliminar_Click(object sender, EventArgs e)
        {
            string cedula = LBNumeroDeCedula.Text;
            personaServicio.Eliminar(cedula);
            LbRespuesta.Text = "Datos eliminados con exito !!!";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
