using Software_Medico.Controlador;
using Software_Medico.Modelo;
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
    public partial class Aux_AgendarCita : Form
    {
        CitasControl cc = new CitasControl();
        public Aux_AgendarCita()
        {
            InitializeComponent();

          
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CitasControl citasControl = new CitasControl();
            CitasModel citasModel = new CitasModel();


            Txt_Paciente.Text = citasControl.buscarNombre(Txt_IDPaciente.Text);



        }
        private void Aux_AgendarCita_Load(object sender, EventArgs e)
        {
           
           
            Cmb_Clinica.DataSource = cc.CargarClinicaCMB();
            Cmb_Clinica.DisplayMember = "NOMBRE_CLINICA";
            Cmb_Clinica.ValueMember = "ID_CLINICA";


            Cmb_Doctor.DataSource = cc.CargarDoctorCMB();
            Cmb_Doctor.DisplayMember = "NOMBRE_MEDICO";
            Cmb_Doctor.ValueMember = "ID_MEDICO";


        }


        private void btn_clin_Click(object sender, EventArgs e)
        {
            Cmb_Consultorio.DataSource = cc.CargarConsultorioCMB(int.Parse(Cmb_Clinica.ValueMember));
            Cmb_Consultorio.DisplayMember = "NOMBRE_CONSULTORIO";
            Cmb_Consultorio.ValueMember = "ID_CONSULTORIO";
        }


















        //funcionaliodad de la ventana
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

        //movilidad de la ventana
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
