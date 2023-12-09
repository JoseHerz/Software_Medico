using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Software_Medico.Frm_Menu;

namespace Software_Medico.Vistas
{
    public partial class Frm_LogOut : Form
    {
        public Frm_LogOut()
        {
            InitializeComponent();

            Btn_Usuario.Enabled = false;
        }
        //Funcionalidad de la ventana
        private void Ptb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void Ptb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funcionalidad de los botones

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

        private void Btn_Paciente_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Paciente frm_Paciente = new Frm_Paciente();
            frm_Paciente.Show();
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

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();  
        }
    }
}
