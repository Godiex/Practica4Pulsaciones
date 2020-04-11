using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ConsoleApp1
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea salir ?";
            string titulo = "Avertencia !!!";
            var resultado = MessageBox.Show(mensaje,titulo,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PbPantallaCompleta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PbPatallaTamañoNormal.Visible = true;
            PbPantallaCompleta.Visible = false;
        }

        private void PbPatallaTamañoNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PbPatallaTamañoNormal.Visible = false;
            PbPantallaCompleta.Visible = true;
        }
        private void AbrirFormEnElContenedorDeForms(object FormHijo)
        {
            if (this.ContendorDeForms.Controls.Count > 0)
            {
                this.ContendorDeForms.Controls.RemoveAt(0);
            }
            Form Fh = FormHijo as Form;
            Fh.TopLevel = false;
            Fh.Dock = DockStyle.Fill;
            this.ContendorDeForms.Controls.Add(Fh);
            this.ContendorDeForms.Tag = Fh;
            Fh.Show();
        }

        private void BntRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormEnElContenedorDeForms(new RegistrarPersonaGui());
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormEnElContenedorDeForms(new ConsultaGui());
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormEnElContenedorDeForms(new ModificarGui());
        }

        private void FechaYHora_Tick(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.ToShortTimeString();
            LbFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            AbrirFormEnElContenedorDeForms(new EliminarGui());
        }

        private void LbHora_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnElContenedorDeForms(new InicioGui());
        }

        private void ContenedorBarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContenedorBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
    }
}
