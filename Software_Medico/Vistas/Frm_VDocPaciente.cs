using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Medico.Vistas
{
    public partial class Frm_VDocPaciente : Form
    {
        public Frm_VDocPaciente()
        {
            InitializeComponent();
            Btn_Paciente.Enabled = true;
        }
        //Funcionalidad basica
        private void Ptb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Ptb_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Ptb_Max.Visible = false;
            Ptb_Resize.Visible = true;
        }

        private void Ptb_Resize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Ptb_Resize.Visible = false;
            Ptb_Max.Visible = true;
        }

        private void Ptb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        //funcionalidad de la barra de botones
        private void Btn_Enfermedades_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Enfermedades frm_Enfermedades = new Frm_Enfermedades();
            frm_Enfermedades.Show();
        }

        private void Btn_Doctores_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Doctores frm_Doctores = new Frm_Doctores();
            frm_Doctores.Show();
        }

        private void Btn_Examenes_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Examenes frm_Examenes = new Frm_Examenes();
            frm_Examenes.Show();
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Inventario frm_Inventario = new Frm_Inventario();
            frm_Inventario.Show();
        }

        private void Btn_Facturacion_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Facturacion frm_Facturacion = new Frm_Facturacion();
            frm_Facturacion.Show();
        }

        private void Btn_Cita_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Cita frm_Cita = new Frm_Cita();
            frm_Cita.Show();
        }

        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_LogOut frm_LogOut = new Frm_LogOut();
            frm_LogOut.Show();
        }

        //Movilidad de la ventana
        int m, mx, my;
        private void Pnl_Barra_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Pnl_Barra_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Pnl_Barra_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
